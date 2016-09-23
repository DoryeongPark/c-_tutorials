using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


public static class Brightness
{
    public static int GetBrightness()
    {
        ManagementScope s = new ManagementScope("root\\WMI");
        SelectQuery q = new SelectQuery("WmiMonitorBrightness");
        ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);
        ManagementObjectCollection moc = mos.Get();

        byte curBrightness = 0;
        foreach (ManagementObject o in moc)
        {
            curBrightness = (byte)o.GetPropertyValue("CurrentBrightness");
            break; 
        }

        moc.Dispose();
        mos.Dispose();

        return (int)curBrightness;
    }

    public static void SetBrightness(byte targetBrightness)
    {
        
        ManagementScope s = new ManagementScope("root\\WMI");
        SelectQuery q = new SelectQuery("WmiMonitorBrightnessMethods");
        ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);
        ManagementObjectCollection moc = mos.Get();

        foreach (System.Management.ManagementObject o in moc)
        {
            o.InvokeMethod("WmiSetBrightness", new object[] { uint.MaxValue, targetBrightness }); 
            break; //only work on the first object
        }

        moc.Dispose();
        mos.Dispose();
    }

}

