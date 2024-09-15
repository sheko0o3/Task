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
        public List<string> RelatedRoiSysIDs { get; }

        public static List<Roi> RelatedRoiObjs { get; set; }

        public string QueueSysID { get;}
        public string UseCaseID { get; set; }

        public static int OverCapacityThreshold { get; set; }
        public double DuelTimeThreshold { get; set; }



        public Queue(int capacity, string usecaseID, string queueID)
        {
            OverCapacityThreshold = capacity;
            RelatedRoiObjs = new List<Roi>();
            RelatedRoiSysIDs = new List<string>();
            // QueueSysID = Guid.NewGuid().ToString();
            QueueSysID = queueID;
            UseCaseID = usecaseID;

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


        static string GetQueue(string ID)
        {
            string queueUseCaseID = string.Empty;
            foreach (var obj in RelatedRoiObjs)
            {
                if (obj.RoiSysID == ID)
                {

                    queueUseCaseID = obj.UseCaseID;
                    System.Console.WriteLine($"This Row in Queue: {queueUseCaseID}");

                }

            }
            return queueUseCaseID;

        }


        public static bool OverCapacity(string id)
        {
            int TotalCapacity = 0;
            string queueUseCaseID = GetQueue(ID: id);


            foreach (var obj in RelatedRoiObjs)
            {
                if (obj.UseCaseID == queueUseCaseID)
                {
                    TotalCapacity += obj.PeopleCount;
                }
            }
            System.Console.WriteLine(TotalCapacity);

            if (TotalCapacity < OverCapacityThreshold)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //************************************************************************//

        public static bool OverCapacityTest(string id)
        {
            List<string> ListOfQueuesCooldown = new List<string>();
            System.Console.WriteLine(ListOfQueuesCooldown.Count);
            
            foreach (var item in ListOfQueuesCooldown)
            {
                
                System.Console.WriteLine(item);
            }


            int TotalCapacity = 0;

            string queueUseCaseID = GetQueue(ID: id);
            ListOfQueuesCooldown.Add(id);

            var time = DateTime.Now;


            while (HelperMethods.CheckCooldown(AlarmTime: time, cooldowntime: 60) && ListOfQueuesCooldown.Contains(id))
            {
                System.Console.WriteLine("do nothing");
            }

            foreach (var obj in RelatedRoiObjs)
            {
                if (obj.UseCaseID == queueUseCaseID)
                {
                    TotalCapacity += obj.PeopleCount;
                }
            }
            System.Console.WriteLine(TotalCapacity);

            if (TotalCapacity < OverCapacityThreshold)
            {
                return false;
            }
            else
            {
                // ListOfQueuesCooldown.Add(queueUseCaseID);
                System.Console.WriteLine(ListOfQueuesCooldown.Count);
                return true;
            }

        }

    }
}