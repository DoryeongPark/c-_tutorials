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

/* Things to do: Socket Listener, Monitor event handler */
namespace Powersaver
{
    public partial class PowersaverForm : MetroForm
    {
        private Keys? shortcutForMonitorOff;
        private Keys? shortcutForShutdown;
        
        public PowersaverForm()
        {
            InitializeComponent();

            rb_monitoroff.Checked = true;
            //SetStartup("Powersaver", false);

            PowerManager.IsMonitorOnChanged += new EventHandler(MonitorOnChanged);

            //Load settings
            tb_log.Clear();
            tb_log.Text = Settings.Default.history;
            shortcutForMonitorOff = Settings.Default.scMonitorOff;
            shortcutForShutdown = Settings.Default.scShutdown;

            HandleForLastShutdown();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var executeCount = Settings.Default.executeCount;

            if (executeCount > 2)
                Hide();
        }

        private void Nircmd(string args)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "nircmd.exe";
            p.StartInfo.Arguments = args;
            p.Start();        
        }

        private void ExecuteButtonClicked(object sender, EventArgs e)
        {
            if (rb_monitoroff.Checked == true)
                MonitoroffRoutine(sender, e);
            else if (rb_standbymode.Checked == true)
                StandbyModeRoutine(sender, e);
            else if (rb_hibernate.Checked == true)
                HibernateRoutime(sender, e);
            else if (rb_shutdown.Checked == true)
                ShutdownRoutine(sender, e);
        }

        private void MonitorOnChanged(object sender, EventArgs e)
        {
            if (PowerManager.IsMonitorOn == false)
            {
                var list = ServerConnection.RequestCommand("2010112406", "read", "sleep").Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - Sleep";
                tb_log.AppendText(resultStr + "\r\n");
            }
            else
            {
                ServerConnection.RequestCommand("2010112406", "write", "wakeup");

                var list = ServerConnection.RequestCommand("2010112406", "read", "wakeup").Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - Wakeup";
                tb_log.AppendText(resultStr + "\r\n");
            }

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void OnDestroy(object sender, FormClosedEventArgs e)
        {
            ExitRoutine(sender, e);
        }

        private void HandleForLastShutdown()
        { 
            
            var strArr = tb_log.Text.Split(new string[] { "\r\n" },
                           StringSplitOptions.RemoveEmptyEntries);

            if (strArr.Length == 0)
                return;

            Stack<string> lines = new Stack<string>();
            lines.Push((string)strArr.GetValue(strArr.Length - 1));
            
            /* If last tag contains "Shutdown" */
            if(tb_log.Text != "" && lines.Peek().Contains("Shutdown"))
            {
                if (ServerConnection.RequestCommand("2010112406", "write", "wakeup") == null)
                    return;

                var list = ServerConnection.RequestCommand("2010112406", "read", "wakeup").Split('|');
                var resultStr = list.GetValue(list.Length - 1);
                resultStr = resultStr.ToString().Replace("<BR>", "") + " - Wakeup";
                tb_log.AppendText(resultStr + "\r\n");
                lines.Push((string)resultStr);

                ShowMessageBoxForLastShutdown(ref lines);
            }    
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            { 
                if (shortcutForMonitorOff.HasValue == true &&
                    keyData.Equals(shortcutForMonitorOff.Value))
                {
                    Nircmd("monitor off");
                    return true;
                }
                else if(shortcutForShutdown.HasValue == true &&
                    keyData.Equals(shortcutForShutdown.Value))
                {
                    Nircmd("exitwin poweroff");
                    return true;
                }else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void ShortcutButtonClicked(object sender, EventArgs e)
        {
            ShortcutForm sf = new ShortcutForm();
            sf.GetShortcutKeys(shortcutForMonitorOff, shortcutForShutdown);
            var result = sf.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                shortcutForMonitorOff = sf.MonitorOff;
                shortcutForShutdown = sf.Shutdown;
            }
        }

        private void ShowMessageBoxForLastShutdown(ref Stack<string> lines)
        {
            var wakeupTime = lines.Pop().Substring(0, 21);
            var shutdownTime = lines.Pop().Substring(0, 21);

            if(wakeupTime.Substring(11, 2) == "오후")
            {
                wakeupTime = wakeupTime.Remove(11, 2);
                var clock = int.Parse(wakeupTime.Substring(12, 1));
                clock += 12;
                var clockString = Convert.ToString(clock);
                wakeupTime = wakeupTime.Remove(11, 2);
                wakeupTime = wakeupTime.Insert(11, clockString);                
            }
            else
            {
                wakeupTime = wakeupTime.Remove(11, 3);
                wakeupTime = wakeupTime.Insert(11, "0");
            }

            if (shutdownTime.Substring(11, 2) == "오후")
            {
                shutdownTime = shutdownTime.Remove(11, 2);
                var clock = int.Parse(shutdownTime.Substring(12, 1));
                clock += 12;
                var clockString = Convert.ToString(clock);
                shutdownTime = shutdownTime.Remove(11, 2);
                shutdownTime = shutdownTime.Insert(11, clockString);

            }
            else
            {
                shutdownTime = shutdownTime.Remove(11, 3);
                shutdownTime = shutdownTime.Insert(11, "0");
            }

            var dtWakeup = DateTime.ParseExact(wakeupTime, 
                                                    "yyyy-MM-dd HH:mm:ss", 
                                                    CultureInfo.InvariantCulture);
            var dtShutdown = DateTime.ParseExact(shutdownTime,
                                                    "yyyy-MM-dd HH:mm:ss",
                                                    CultureInfo.InvariantCulture);
            var timeSpan = dtWakeup.Subtract(dtShutdown);
            MessageBox.Show(this, "System restarted in " + timeSpan.ToString());
        }

        private void MonitoroffRoutine(object sender, EventArgs e)
        {
            if (ServerConnection.RequestCommand("2010112406", "write", "sleep") == null)
                return;
            Nircmd("monitor off");
        }

        private void StandbyModeRoutine(object sender, EventArgs e)
        {
            if (ServerConnection.RequestCommand("2010112406", "write", "suspend") == null)
                return;
            Nircmd("standby");
        }

        private void HibernateRoutime(object sender, EventArgs e)
        {
            if (ServerConnection.RequestCommand("2010112406", "write", "hibernate") == null)
                return;
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void ShutdownRoutine(object sender, EventArgs e)
        {
            ShutdownDelayForm sdf = new ShutdownDelayForm();
            var result = sdf.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                if (sdf.Shutdown == false)
                    return;
            }

            if (ServerConnection.RequestCommand("2010112406", "write", "shutdown") == null)
                return;

            var list = ServerConnection.RequestCommand("2010112406", "read", "shutdown").Split('|');
            var resultStr = list.GetValue(list.Length - 1);
            resultStr = resultStr.ToString().Replace("<BR>", "") + " - Shutdown";
            tb_log.AppendText(resultStr + "\r\n");

            Nircmd("exitwin poweroff");

        }

        private void ExitRoutine(object sender, EventArgs e)
        {
            Settings.Default.scMonitorOff = shortcutForMonitorOff.Value;
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
            Environment.Exit(1);

        }


        private void CMenuItemShowClicked(object sender, EventArgs e)
        {
            if (Visible == false)
                Show();
        }

        private void TrayiconClicked(object sender, MouseEventArgs e)
        {
            cm_powersaver.Show(Cursor.Position.X, Cursor.Position.Y);
        }

       
        private void OnHide(object sender, EventArgs e)
        {
            if (Visible == true)
                notifyicon.Visible = false;
            else
                notifyicon.Visible = true;
        }


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

        
    }
}
