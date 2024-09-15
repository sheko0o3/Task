using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QueueApp
{
    public class HelperMethods
    {
        public static bool CheckCooldown(Dictionary<string, DateTime> dict, int cooldowntime, string ID)
        {
            dict.TryGetValue(ID , out DateTime AlarmTime);
            
            var currentTime = DateTime.Now;

            if (AlarmTime < currentTime.AddSeconds(cooldowntime))
            {
                return true;
            }
            return false;
        }


        

        
    }
}