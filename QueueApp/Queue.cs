using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace QueueApp
{
    public class Queue
    {

        public string QueueSysID { get;}
        public string UseCaseID { get; set; }

        public static int OverCapacityThreshold { get; set; }
        public double DuelTimeThreshold { get; set; }



        public Queue(int capacity, string usecaseID, string queueID)
        {
            OverCapacityThreshold = capacity;
            // RelatedRoiObjs = new List<Roi>();
            // RelatedRoiSysIDs = new List<string>();
            // QueueSysID = Guid.NewGuid().ToString();
            QueueSysID = queueID;
            UseCaseID = usecaseID;

        }

        string GetQueueID(string id, Dictionary<string, List<string>> Dict)
        {   string queueID = string.Empty;

            foreach( var item in Dict)
            {
                if (item.Value.Contains(id))
                {
                    queueID = item.Key;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Not Found");
                }
            }

            return queueID;
        }

       

        
        

        


       

        //************************************************************************//

        
        

    }
}