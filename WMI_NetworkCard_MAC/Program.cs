using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WMI_NetworkCard_MAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagementClass M = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection RV = M.GetInstances();

            foreach (ManagementObject item in RV)
            {
                if ((bool)item["IPEnabled"])
                {
                    RegistryKey Key = Registry.CurrentUser.OpenSubKey("XYZProjesi", true);
                    Key.SetValue("MACAddress", item["MacAddress"].ToString());
                }
            }
        }
    }
}
