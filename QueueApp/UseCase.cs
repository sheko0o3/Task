using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QueueApp
{
    public class UseCase
    {
        public static List<Queue>? queuesCreated {get; set;}
        public string UseCaseSysID { get;}
        public int DebounceTime { get; }
        public bool SendCoolDownTime { get;}
        
        public UseCase(string usecaseID, [Optional] int debounceTime)
        {
            UseCaseSysID = usecaseID;
            DebounceTime = debounceTime;
            queuesCreated = new();    
    
        }

        public static void AddQueues(List<Queue> queues)
        {   
            
            foreach(var item in queues)
            {
                queuesCreated?.Add(item);
                
            }
        }

    }
}