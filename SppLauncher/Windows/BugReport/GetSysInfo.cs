using System;
using System.Linq;
using System.Management;

namespace SppLauncher.Windows.BugReport
{
    class GetSysInfo
    {
        public int getmemory()
        {
            return Convert.ToInt32(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024);
        }
        
        public string GetProcessorName()
        {
            string ProcessorName = "";
            string mhz = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in mos.Get())
            {
                ProcessorName = mo["Name"].ToString().Replace("  ", "");
                mhz = mo["maxclockspeed"].ToString().Replace(" ", "");
            }

            return ProcessorName + " @" + mhz;
        }

        public string GetProcessorNameL()
        {
            string ProcessorName = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in mos.Get())
                ProcessorName = mo["Name"].ToString();

            return ProcessorName;
        }

        public string getOS()
        {
            var name =
                (from x in
                     new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>()
                 select x.GetPropertyValue("Caption")).First();
            return name != null ? name.ToString() : "Unknown";
        }
    }
}
