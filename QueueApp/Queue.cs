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
        public List<string>? RelatedRois {get; set;}
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

        }

        public void AddRois(List<Roi>roi)
        {
            foreach(var item in roi)
            {
                RelatedRois.Add(item.RoiSysID);
            }
            return;
        }

        public void UpdateQueueRois(List<Roi>Rois)
        {
            RelatedRois.Clear();
            
            foreach(var item in Rois)
            {
                RelatedRois.Add(item.RoiSysID);
            }
            return;
        }

        
        

        


       

        //************************************************************************//

        
        

    }
}