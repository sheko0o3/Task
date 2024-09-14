using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QueueApp
{
    public class HelperMethods
    {
        public static bool CheckCooldown(DateTime AlarmTime, int cooldowntime)
        {
            var currentTime = DateTime.Now;
            while (currentTime < AlarmTime.AddSeconds(cooldowntime))
            {
                return true;
            }
            return false;
        }


        

        
    }
}