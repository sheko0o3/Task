using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueApp
{
    public class UseCase
    {
        public string UseCaseSysID { get;}
        public int DebounceTime { get; }
        public bool SendCoolDownTime { get;}

        List<Queue>? queuesCreatedList {get;}
        
        public UseCase(string usecaseID, int debounceTime)
        {
            UseCaseSysID = usecaseID;
            DebounceTime = debounceTime;
        }

    }
}