
namespace QueueApp;

class Program
{
    static void Main(string[] args)
    {

        Roi roi = new Roi(peoplecount:20);
        Roi roiTwo = new Roi(peoplecount:10);
    
        System.Console.WriteLine("**********");

        Queue queueOne = new Queue(capacity:20);
       
        
        queueOne.AddRoiObj(roi);
        queueOne.AddRoiObj(roiTwo);

        int intervalMilliseconds = 10000;

        Timer timer = new Timer(ExecuteFunction, null, 0, intervalMilliseconds);

        
        void ExecuteFunction(object? state)
        {
            // Put the code of the function you want to call here
            if (queueOne.OverCapacity())
            {
                
                System.Console.WriteLine("Fire Alarm");
            }
            var time = DateTime.Now;
            Console.WriteLine("Function called at: " + time);
        }

        
        
        // if (queueOne.OverCapacity())
        // {
        //     System.Console.WriteLine("Fire Alarm");
        // }


        System.Console.Read();

        

    }
}
