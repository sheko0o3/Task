
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
        Queue queueTwo = new Queue(capacity:10, usecaseID:"1", queueID:"B");
        Queue queueThree = new Queue(capacity:30, usecaseID:"2", queueID:"D");

        Roi roiOne = new Roi(peoplecount:30, ID:"A1");
        Roi roiTwo = new Roi(peoplecount:25, ID:"A2");
        Roi roiThree = new Roi(peoplecount:21, ID:"B3");
        Roi roiFour = new Roi(peoplecount:10, ID:"A4");
        Roi roiFive = new Roi(peoplecount:10, ID:"B5");

        UseCase.AddQueues(new(){queueOne,queueTwo});
        
        queueOne.AddRois(new(){roiOne,roiTwo,roiThree});
        queueTwo.AddRois(new(){roiThree, roiOne});

        System.Console.WriteLine("*-*-*--*-*---*");

        
        Queue.OverCapacityTest(new(){roiOne,roiTwo,roiThree});

        System.Console.WriteLine("*-*-*--*-*---*");
        

        

        

        



        
        
        

        
    }
}

        
