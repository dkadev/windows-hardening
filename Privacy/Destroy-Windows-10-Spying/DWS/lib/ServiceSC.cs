﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWS.lib
{
    public static class ServiceSC
    {
        public static void DisableService(string scName)
        {
            WindowsUtil.RunCmd($"/c net stop {scName}");
            WindowsUtil.ProcStartargs("powershell", $"-command \"Set-Service -Name {scName} -StartupType Disabled\"");
            Logger.Log($"Disable {scName} service");
        }

        public static void DeleteService(string scName)
        {
            WindowsUtil.RunCmd($"/c sc delete {scName}");
            Logger.Log($"Delete {scName} service");
        }
    }
}
