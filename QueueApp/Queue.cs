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
        public List<string> RelatedRois {get;}
        public List<Roi> RoisCreated {get;}
        public string QueueSysID { get;}
        public string UseCaseID { get; set; }

        public int OverCapacityThreshold { get; set; }
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

        public static List<Queue> GetQueueID(string RoiID)
        {
            List<Queue> queueIDs = new();

            foreach(var item in UseCase.queuesCreated)
            {
                if (item.RelatedRois.Contains(RoiID))
                {
                    queueIDs.Add(item);
                }
                
            }
            return queueIDs;
        }

        public static void OverCapacityTest(List<Roi> rois)
        {   
            
            foreach(var roi in rois)
            {
                List<Queue> list = GetQueueID(roi.RoiSysID);
                foreach(var x in list)
                {
                    if (roi.PeopleCount > x.OverCapacityThreshold || roi.MaxDuelTime > x.DuelTimeThreshold)
                    {
                        
                        System.Console.WriteLine($"fire alarm Queue:{x.QueueSysID}");
                    }
                }
                
                
            }
            
            
               
            
        }   

    }
}