using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QueueApp
{
    public class Roi
    {
        public int PeopleCount { get; set;}
        public double? MaxDuelTime { get;}
        public string? RoiSysID {get;}
        public string? UseCaseID { get; set; }       
    
        public Roi(int peoplecount , [Optional]double maxdueltime, [Optional]string usecaseID)
        {
            
            PeopleCount = peoplecount;
            MaxDuelTime = maxdueltime;
            RoiSysID = Guid.NewGuid().ToString();
            UseCaseID = usecaseID;

        }

    }

}