using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;

namespace WMI_Registry_Islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string Surucu = "C";
            ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Surucu + ":\"");
            Disk.Get();
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);
            Key.SetValue("LogicalDisk", Disk["VolumeSerialNumber"].ToString());
        }
    }
}
