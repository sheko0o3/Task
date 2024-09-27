
using System.Diagnostics;
using Microsoft.VisualBasic;


namespace QueueApp;

class Program
{
    static void Main(string[] args)
    {  

        UseCase caseOne = new UseCase(usecaseID:"1");
        UseCase caseTwo = new UseCase(usecaseID:"2");

        Queue queueOne = new Queue(capacity:20,usecaseID:"1",queueID:"A");
        Queue queueTwo = new Queue(capacity:25, usecaseID:"1", queueID:"B");

        Queue queueThree = new Queue(capacity:30, usecaseID:"2", queueID:"D");

        Roi roiOne = new Roi(peoplecount:10, usecaseID:"1", ID:"A1");
        
        Roi roiTwo = new Roi(peoplecount:15, usecaseID:"1", ID:"A2");

        Roi roiThree = new Roi(peoplecount:12, usecaseID:"1", ID:"B3");

        Roi roiFour = new Roi(peoplecount:10, usecaseID:"1", ID:"A4");

        Roi roiFive = new Roi(peoplecount:10, usecaseID:"1", ID:"B5");

        queueOne.AddRois(new(){roiOne,roiTwo});

        queueTwo.AddRois(new(){roiThree});

        foreach(var item in queueOne.RelatedRois)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*********");
        foreach(var item in queueTwo.RelatedRois)
        {
            System.Console.WriteLine(item);
        }

        queueOne.AddRois(new(){roiFour});
        queueTwo.UpdateQueueRois(new(){roiFive});
        

        System.Console.WriteLine("/////////new/////");
        foreach(var item in queueOne.RelatedRois)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*********");
        foreach(var item in queueTwo.RelatedRois)
        {
            System.Console.WriteLine(item);
        }

        queueOne.UpdateQueueRois(new(){roiOne,roiTwo,roiThree});

        System.Console.WriteLine("/////////new new/////");
        foreach(var item in queueOne.RelatedRois)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*********");
        foreach(var item in queueTwo.RelatedRois)
        {
            System.Console.WriteLine(item);
        }



        
        
        

        
    }
}

        
