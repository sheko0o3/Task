using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QueueApp
{
    public class UseCase
    {
        public string UseCaseSysID { get;}
        public int DebounceTime { get; }
        public bool SendCoolDownTime { get;}
        
        public UseCase(string usecaseID, [Optional] int debounceTime)
        {
            UseCaseSysID = usecaseID;
            DebounceTime = debounceTime;
        }

    }
}