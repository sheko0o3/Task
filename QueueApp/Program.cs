
using Microsoft.VisualBasic;


namespace QueueApp;

class Program
{
    static void Main(string[] args)
    {   
        System.Console.WriteLine("***************");

        Queue queueOne = new Queue(capacity:20, usecaseID:"A", queueID:"OneA");
        Queue queueTwo = new Queue(capacity:30,usecaseID:"C", queueID:"TwoA");
        
        Roi roi = new Roi(peoplecount:20, ID:"1", usecaseID:"A");
        Roi roiTwo = new Roi(peoplecount:10, ID:"2", usecaseID:"C");
        Roi roiThree = new Roi(peoplecount:15, ID:"3", usecaseID:"A");
    
        queueOne.AddRoiObj(roi);
        queueOne.AddRoiSysIDs(roi);

        queueOne.AddRoiObj(roiTwo);
        queueOne.AddRoiSysIDs(roiTwo);

        queueTwo.AddRoiObj(roiThree);
        queueTwo.AddRoiSysIDs(roiThree);

        
        
       
        
        Dictionary<string, DateTime> DictOfQueuesCooldown = new Dictionary<string, DateTime>();

        List<string> list = new List<string>();
        list = ["1", "2", "3", "1", "3"];

        foreach (var item in list)
        {
             
            if (DictOfQueuesCooldown.ContainsKey(item) && HelperMethods.CheckCooldown(DictOfQueuesCooldown, 60, item))
            {
                System.Console.WriteLine("do nothing");
            }
            else
            {
                if(Queue.OverCapacityTest(id:$"{item}", cooldowntime:60))
                {
                    
                    var time = DateTime.Now;
                    DictOfQueuesCooldown.Add(item, time);
                    
                    System.Console.WriteLine($"Fire Alarm");    
                }
                else
                {
                    System.Console.WriteLine("No Alarm");
                }
                
            }       
            
        }
        // System.Console.WriteLine(queueOne.RelatedRoiSysIDs.Count);
        // System.Console.WriteLine(Queue.RelatedRoiObjs.Count);
        // System.Console.WriteLine(queueTwo.RelatedRoiSysIDs.Count);
        System.Console.WriteLine("************");
        System.Console.Read();
    

    }
}

        
