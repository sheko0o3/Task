﻿
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

        Roi roiOne = new Roi(peoplecount:10, usecaseID:"1", ID:"A1");
        
        Roi roiTwo = new Roi(peoplecount:15, usecaseID:"1", ID:"A2");

        Roi roiThree = new Roi(peoplecount:12, usecaseID:"1", ID:"B3");

        Roi roiFour = new Roi(peoplecount:10, usecaseID:"1", ID:"A4");

        Roi roiFive = new Roi(peoplecount:10, usecaseID:"1", ID:"B5");

        UseCase.addQueues(new(){queueOne,queueTwo});
        

        queueOne.AddRois(new(){roiOne,roiTwo});

        queueTwo.AddRois(new(){roiThree});


        
        System.Console.WriteLine("*-*-*--*-*---*");

        List<Roi> listOfRoi = new(){roiOne, roiTwo, roiThree, roiFour, roiFive};
        foreach(var item in listOfRoi)
        {
            Queue.OverCapacityTest(item);
            System.Console.WriteLine("***************");
        }
        

        

        

        

        



        
        
        

        
    }
}

        
