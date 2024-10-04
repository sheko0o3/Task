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
        public List<string> RelatedRois {get; set;}
        public List<Roi> RoisCreated {get;}
        public string QueueSysID { get;}
        public string UseCaseID { get; set; }

        public static int OverCapacityThreshold { get; set; }
        public double DuelTimeThreshold { get; set; }



        public Queue(int capacity, string usecaseID, string queueID)
        {
            OverCapacityThreshold = capacity;
            // QueueSysID = Guid.NewGuid().ToString();
            QueueSysID = queueID;
            UseCaseID = usecaseID;
            RelatedRois = new();
            RoisCreated = new();

        }

        public void AddRois(List<Roi>roi)
        {
            foreach(var item in roi)
            {
                RoisCreated.Add(item);
                RelatedRois.Add(item.RoiSysID);
            }
            return;
        }

        public void UpdateQueueRois(List<Roi>Rois)
        {
            RelatedRois.Clear();
            
            foreach(var item in Rois)
            {
                RoisCreated.Add(item);
                RelatedRois.Add(item.RoiSysID);
            }
            return;
        }

        static string GetQueueID(string RoiID)
        {
            string queueID = string.Empty;
            foreach(var item in UseCase.queuesCreated)
            {
                if (item.RelatedRois.Contains(RoiID))
                {
                    queueID = item.QueueSysID;
                    System.Console.WriteLine($"Found, {queueID}");
                    break;
                }
                
            }
            return queueID;
        }

        public static void OverCapacityTest(Roi roi)
        {
            var queueID = GetQueueID(roi.RoiSysID);
            int totalcapacity = 0;
            foreach(var item in UseCase.queuesCreated.Where(p => p.QueueSysID == queueID))
            {
                foreach(var obj in item.RoisCreated)
                {
                    totalcapacity += obj.PeopleCount;
                }
            }
            System.Console.WriteLine($"QueueID : {queueID},, TotalCapacity: {totalcapacity}");
            
            
        }


        //************************************************************************//

        
        

    }
}