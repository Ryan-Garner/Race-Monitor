using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLayer
{
    public class Athlete
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public int Age;
        public int BibNumber;
        public int UpdateNumber;
        public DateTime prevRaceTime;
        public TimeSpan currTime = new TimeSpan();
        public double Location;
        public bool updated = false;
        public bool justUpdated = true;
        public string status;
        
        
        public void UpdateAthlete(double newLocation, DateTime time, string newStatus)
        {
            status = newStatus;
            updated = true;
            currTime += time.Subtract(prevRaceTime);
            prevRaceTime = time;
            UpdateNumber++;
            Location = newLocation;
        }  
    }
}
