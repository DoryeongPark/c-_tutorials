using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.ApplicationServices;
using HTTPCom;
using System.Globalization;
using Microsoft.Win32;
using Assignment5.Properties;
using Assignment5;
using System.Threading;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;


/* Things to do: Socket Listener */
namespace Powersaver
{
    /*
     *  Class member
     * 
     * tcpServer                Instance containing server / client socket
     * shortcutForMonitorOff    Shortcut variable for monitor off user registered
     * shortcutForShutdown      Shortcut variable for shut down user registered
     * cmdExecuted              Enumeration of current state
     * reservation              Thread for reservation routine
     * tickCount                Reservation timer
     *
     */
    public partial class PowersaverForm : MetroForm
    {
        public enum CmdExecuted
        {
            Normal, Monitoroff, Suspend, Hibernate
        };

        private TCPServer tcpServer = null;
        private string remoteIP = null;

        private Keys? shortcutForMonitoroff;
        private Keys? shortcutForShutdown;

        private CmdExecuted cmdExecuted = CmdExecuted.Normal;

        private Thread reservation;
        private long tickCount;

        public PowersaverForm()
        {
            InitializeComponent();

            /* Initialize component states */
            reservation = new Thread(new ThreadStart(delegate () { ReservationTick(); }));

            pnl_reservation.Visible = false;
            rb_monitoroff.Checked = true;
            //SetStartup("Powersaver", false);

            PowerManager.IsMonitorOnChanged += new EventHandler(MonitorOnChanged);

            /* Load settings */
            tb_log.Clear();
            tb_log.Text = Settings.Default.history;
            shortcutForMonitoroff = Settings.Default.scMonitorOff;
            shortcutForShutdown = Settings.Default.scShutdown;

            /* Check if computer's shutdown last time by this application */
            HandleForLastShutdown();


        }

        /* Check count of execution and hide form as checked result */
        private void OnLoad(object sender, EventArgs e)
        {
            var executeCount = Settings.Default.executeCount;

            if (executeCount > 2)
                Hide();
            else
            {
                Settings.Default.executeCount = ++executeCount;
                Settings.Default.Save();
            }
        }

        /* Method of nircmd execution */
        private void Nircmd(string args)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "nircmd.exe";
            p.StartInfo.Arguments = args;
            p.Start();
        }

        /* Execute button event method */
        private void ExecuteButtonClicked(object sender, EventArgs e)
        {

            if (tcpServer == null)
            {
                if (rb_monitoroff.Checked == true)
                    MonitoroffRoutine(sender, e);
                else if (rb_standbymode.Checked == true)
                    StandbyModeRoutine(sender, e);
                else if (rb_hibernate.Checked == true)
                    HibernateRoutime(sender, e);
                else if (rb_shutdown.Checked == true)
                    ShutdownRoutine(sender, e);
            }else
            {
                if(rb_monitoroff.Checked == true)
                {
                    tcpServer.Send(remoteIP + "&cmd=SLEEP");       
                }else if(rb_shutdown.Checked == true)
                {
                    tcpServer.Send(remoteIP + "&cmd=OFF");
                }                
            }
        }

        /* Monitor event method */
        private void MonitorOnChanged(object sender, EventArgs e)
        {
            if (PowerManager.IsMonitorOn == false)
            {
                //Read previous command from server and write it
                string previousCmd = "";

                switch (cmdExecuted) {
                    case CmdExecuted.Monitoroff:
                        previousCmd = "sleep";
                        break;
                    case CmdExecuted.Suspend:
                        previousCmd = "suspend";
                        break;
                    case CmdExecuted.Hibernate:
                        previousCmd = "hibernate";
                        break;
                    default:
                        break;
                }

                var list = ServerConnection.RequestCommand("2010112406", "read", previousCmd).Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - " + previousCmd;
                tb_log.AppendText(resultStr + "\r\n");
            }
            else
            {
                //Write wake up log
                ServerConnection.RequestCommand("2010112406", "write", "wakeup");

                var list = ServerConnection.RequestCommand("2010112406", "read", "wakeup").Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - wakeup";
                tb_log.AppendText(resultStr + "\r\n");
                cmdExecuted = CmdExecuted.Normal;
            }

        }

        /* Not exit application when x button is clicked */
        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        /* Event for click of minimize button*/
        private void OnResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Close();
            }
        }

        /* Execute exit routine when application is exited */
        private void OnDestroy(object sender, FormClosedEventArgs e)
        {
            ExitRoutine(sender, e);
        }

        /* Check if previous command is "shutdown" then show message box with time span */
        private void HandleForLastShutdown()
        {
            var strArr = tb_log.Text.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries);

            if (strArr.Length == 0)
                return;

            Stack<string> lines = new Stack<string>();
            lines.Push((string)strArr.GetValue(strArr.Length - 1));

            /* If last tag contains "shutdown" */
            if (tb_log.Text != "" && lines.Peek().Contains("shutdown"))
            {
                if (ServerConnection.RequestCommand("2010112406", "write", "wakeup") == null)
                    return;

                var list = ServerConnection.RequestCommand("2010112406", "read", "wakeup").Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - wakeup";
                tb_log.AppendText(resultStr + "\r\n");
                lines.Push((string)resultStr);

                ShowMessageBoxForLastShutdown(ref lines);
            }
        }

        /* Key event method for shortcut */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (shortcutForMonitoroff.HasValue == true &&
                    keyData.Equals(shortcutForMonitoroff.Value))
                {
                    MonitoroffRoutine(new object(), new EventArgs());
                    return true;
                }
                else if (shortcutForShutdown.HasValue == true &&
                    keyData.Equals(shortcutForShutdown.Value))
                {
                    ShutdownRoutine(new object(), new EventArgs());
                    return true;
                } else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        /* Show form to register new shortcut */
        private void ShortcutButtonClicked(object sender, EventArgs e)
        {
            ShortcutForm sf = new ShortcutForm();
            sf.GetShortcutKeys(shortcutForMonitoroff, shortcutForShutdown);
            var result = sf.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                shortcutForMonitoroff = sf.MonitorOff;
                shortcutForShutdown = sf.Shutdown;
            }
        }

        /* Calculate time span between last shutdown time and current time */
        private void ShowMessageBoxForLastShutdown(ref Stack<string> lines)
        {
            var wakeupTime = lines.Pop();
            var shutdownTime = lines.Pop();

            var wkTimeCuttingPoint = wakeupTime.LastIndexOf('-');
            var sdTimeCuttingPoint = shutdownTime.LastIndexOf('-');

            wakeupTime = wakeupTime.Remove(wkTimeCuttingPoint).TrimEnd();
            shutdownTime = shutdownTime.Remove(sdTimeCuttingPoint).TrimEnd();

            if (wakeupTime.Contains("오후"))
                wakeupTime = wakeupTime.Replace("오후 ", "") + " PM";
            else
                wakeupTime = wakeupTime.Replace("오전 ", "") + " AM";

            if (shutdownTime.Contains("오후"))
                shutdownTime = shutdownTime.Replace("오후 ", "") + " PM";
            else
                shutdownTime = shutdownTime.Replace("오전 ", "") + " AM";

            var dtWakeup = DateTime.ParseExact(wakeupTime,
                                                    "yyyy-M-d h:mm:ss tt",
                                                    CultureInfo.InvariantCulture);
            var dtShutdown = DateTime.ParseExact(shutdownTime,
                                                    "yyyy-M-d h:mm:ss tt",
                                                    CultureInfo.InvariantCulture);
            var timeSpan = dtWakeup.Subtract(dtShutdown);
            MessageBox.Show(this, "System restarted in " + timeSpan.ToString());
        }

        /* Write "Sleep log" to server then turn monitor off */
        private void MonitoroffRoutine(object sender, EventArgs e)
        {
            cmdExecuted = CmdExecuted.Monitoroff;
            if (ServerConnection.RequestCommand("2010112406", "write", "sleep") == null)
            {
                MessageBox.Show("Can't connect with server");
                return;
            }
            Nircmd("monitor off");
        }

        /* Write "Standby log" to server then make computer turn into standby mode */
        private void StandbyModeRoutine(object sender, EventArgs e)
        {
            cmdExecuted = CmdExecuted.Suspend;
            if (ServerConnection.RequestCommand("2010112406", "write", "suspend") == null)
            {
                MessageBox.Show("Can't connect with server");
                return;
            }
            Nircmd("standby");
        }

        /* Write "Hibernate log" to server then make computer turn into hibernate mode */
        private void HibernateRoutime(object sender, EventArgs e)
        {
            cmdExecuted = CmdExecuted.Hibernate;
            if (ServerConnection.RequestCommand("2010112406", "write", "hibernate") == null)
            {
                MessageBox.Show("Can't connect with server");
                return;
            }
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        /* Show form with shutdown delay bar and execute shutdown command or not as result */
        private void ShutdownRoutine(object sender, EventArgs e)
        {
            ShutdownDelayForm sdf = new ShutdownDelayForm();
            var result = sdf.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                if (sdf.Shutdown == false)
                    return;
            }

            //Write and read shutdown log
            if (ServerConnection.RequestCommand("2010112406", "write", "shutdown") == null)
            {
                MessageBox.Show("Can't connect with server");
                return;
            }

            var list = ServerConnection.RequestCommand("2010112406", "read", "shutdown").Split('|');
            var resultStr = list.GetValue(list.Length - 1);
            resultStr = resultStr.ToString().Replace("<BR>", "") + " - shutdown";
            tb_log.AppendText(resultStr + "\r\n");

            Nircmd("exitwin poweroff");

        }

        /* Save all user settings and 10 logs of textbox  */
        private void ExitRoutine(object sender, EventArgs e)
        {
            Settings.Default.scMonitorOff = shortcutForMonitoroff.Value;
            Settings.Default.scShutdown = shortcutForShutdown.Value;

            var strArr = tb_log.Text.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries);
            var strList = new List<string>(strArr);
            var count = 10;
            var listCount = strList.Count;

            string resultStr = "";

            /* Only save for 10 logs */
            foreach (string s in strList.Reverse<string>())
            {
                resultStr = s + "\r\n" + resultStr;
                --count;
                --listCount;

                if (count == 0 || listCount == 0)
                    break;
            }

            Settings.Default.history = "";
            Settings.Default.history = resultStr;
            Settings.Default.Save();

            notifyicon.Visible = false;
            DeactivateSocket();

            Environment.Exit(1);

        }

        /* Show form when "show" of context menustrip is clicked */
        private void CMenuItemShowClicked(object sender, EventArgs e)
        {
            if (Visible == false)
                Show();

            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        /* Show context menustrip when tray icon is clicked */
        private void TrayiconClicked(object sender, MouseEventArgs e)
        {
            cm_powersaver.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        /* If form is hidden show tray icon, else hide tray icon */
        private void OnHide(object sender, EventArgs e)
        {
            if (Visible == true)
                notifyicon.Visible = false;
            else
                notifyicon.Visible = true;
        }

        /* Parse time of text box and runs reservation progress bar as time */
        private void ReservationTick()
        {
            CheckForIllegalCrossThreadCalls = false;

            int min, sec;

            if (!int.TryParse(tb_min.Text, out min))
                min = 0;

            if (!int.TryParse(tb_sec.Text, out sec))
                sec = 0;

            var timeSpan = new TimeSpan(0, min, sec);
            pnl_reservation.Visible = true;

            tickCount = timeSpan.Ticks / 10000000L;
            var maxValue = tickCount;

            for (;;)
            {
                pb_reservation.Value = (int)((float)tickCount / maxValue * 100.0f);

                Thread.Sleep(1000);
                tickCount--;

                lbl_reservation.Text = "Command will be executed in " + tickCount + " seconds";

                if (tickCount == 0) {
                    pnl_reservation.Visible = false;
                    ExecuteButtonClicked(new object(), new EventArgs());
                    break;
                }
            }
        }

        /* Method to start reservation thread */
        private void ReservationRoutine(object sender, EventArgs e)
        {
            if (reservation.IsAlive == true)
                reservation.Abort();

            reservation = new Thread(new ThreadStart(delegate () { ReservationTick(); }));
            reservation.Start();

        }

        /* Method to cancel reservation thread */
        private void CancelReservation(object sender, EventArgs e)
        {
            if (reservation.IsAlive == true)
            {
                reservation.Abort();
                pnl_reservation.Visible = false;
            }
        }

        /* Skip reservation delay and execute command now */
        private void ExecuteNowReservation(object sender, EventArgs e)
        {
            tickCount = 1L;
        }

        /* Create text file with logs in selected path */
        private void SaveLogAsFile(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Create log file";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK) {
                StreamWriter sw = File.CreateText(sfd.FileName);
                sw.Write(tb_log.Text);
                sw.Close();
            }
        }

        /* Show or Hide form to register id */
        private void RegisterId(object sender, EventArgs e)
        {
            RegisterIdForm rid = new RegisterIdForm();
            rid.StartPosition = FormStartPosition.CenterParent;
            rid.ShowDialog();

            if (rid.IsRegistered == true)
            {
                if (ServerConnection.RegisterId(rid.Id) != null)
                    MessageBox.Show(rid.Id + " is successfully registered");
                else
                    MessageBox.Show("Unable to register id - " + rid.Id);
            }
        }

        /* Register this application for startup */
        private void SetStartup(string appName, bool enable)
        {
            string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            RegistryKey startupKey = Registry.CurrentUser.OpenSubKey(runKey, true);

            if (enable)
            {
                if (startupKey.GetValue(appName) == null)
                    startupKey.SetValue(appName, Application.ExecutablePath.ToString());
            }
            else
            {
                startupKey.DeleteValue(appName, false);
            }

            string[] strList = startupKey.GetValueNames();
        }

        /* Routine of activating socket */
        private void ActivateSocket() {

            if (tcpServer != null)
            {
                return;
            }

            tcpServer = new TCPServer(this);

            if (tcpServer.Connect("210.94.194.100", 20151) == false)
            {
                MessageBox.Show("Fail to connect");
                return;
            }

            tcpServer.Start();
            lbl_mode.Text = "Remote Control Mode";

        }

        /* Routine of deactivating socket */
        private void DeactivateSocket()
        {
            if (tcpServer != null)
            {
                tcpServer.Disconnect();
                lbl_mode.Text = "Local Control Mode";
                remoteIP = null;
                tcpServer = null;
            }
        }

        /* Event method to activate socket */
        private void SocketOn(object sender, EventArgs e)
        {
            InsertIpForm iif = new InsertIpForm();
            
            if(iif.ShowDialog() == DialogResult.Cancel)
            {
                if (iif.IP == null)
                    return;

                remoteIP = iif.IP;
                ActivateSocket();
            }
           
        }

        /* Event method to deactivate socket */
        private void SocketOff(object sender, EventArgs e)
        {
            DeactivateSocket();
        }
    }

}
