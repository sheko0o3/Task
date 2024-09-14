
using Microsoft.VisualBasic;


namespace QueueApp;

class Program
{
    static void Main(string[] args)
    {   
        System.Console.WriteLine("***************");

        Queue queueOne = new Queue(capacity:20, usecaseID:"A");
        Queue queueTwo = new Queue(capacity:30,usecaseID:"C");
        
        Roi roi = new Roi(peoplecount:2, ID:"1", usecaseID:"A");
        Roi roiTwo = new Roi(peoplecount:10, ID:"2", usecaseID:"B");
        Roi roiThree = new Roi(peoplecount:15, ID:"3", usecaseID:"A");
    
        queueOne.AddRoiObj(roi);
        queueOne.AddRoiSysIDs(roi);

        queueOne.AddRoiObj(roiTwo);
        queueOne.AddRoiSysIDs(roiTwo);

        queueTwo.AddRoiObj(roiThree);
        queueTwo.AddRoiSysIDs(roiThree);

        
        
       
        
        
        if(Queue.OverCapacityTest(id:"1"))
        {   
            
            System.Console.WriteLine("Fire Alarm");
            
            
        }
        else
        {
            System.Console.WriteLine($" No Alarm");
                
        }
       

        // System.Console.WriteLine(queueOne.RelatedRoiSysIDs.Count);
        // System.Console.WriteLine(Queue.RelatedRoiObjs.Count);
        // System.Console.WriteLine(queueTwo.RelatedRoiSysIDs.Count);
        System.Console.WriteLine("************");
        System.Console.Read();
        

    }
}
