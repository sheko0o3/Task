using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueApp
{
    public class Queue
    {
        public List<string> RelatedRoiSysIDs {get;}

        public List<Roi> RelatedRoiObjs {get;}

        public string? QueueSysID {get; set;}
        public string? UseCaseID {get; set;}
        
        public int OverCapacityThreshold {get; set;}
        public double DuelTimeThreshold {get; set;}


        public Queue(int capacity)
        {   
            OverCapacityThreshold = capacity;
            RelatedRoiObjs = new List<Roi>();
            RelatedRoiSysIDs = new List<string>();
        }

        public void AddRoiSysIDs(Roi relatedRoi)
        {   
            RelatedRoiSysIDs.Add(relatedRoi.RoiSysID);
            return;
        }

        public void AddRoiObj(Roi obj)
        {
            RelatedRoiObjs.Add(obj);
            return;
        }

        
        public bool OverCapacity()
        {   
            
            int TotalCapacity = 0;

            foreach(var obj in RelatedRoiObjs)
            {
                TotalCapacity += obj.PeopleCount;
                
            }
            
            if (TotalCapacity <= OverCapacityThreshold)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        
    }
}