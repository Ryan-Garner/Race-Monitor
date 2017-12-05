using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    public class AthleteCollection : Dictionary<int, Athlete>
    {
        private static AthleteCollection athleteCollection = new AthleteCollection();
        private Dictionary<int, Athlete> SubjectsBeingObserved = new Dictionary<int, Athlete>();
        private bool updateNeeded = false;

        public static void RegisterAthlete(AthleteUpdate message)
        {
            lock (athleteCollection)
            {
                athleteCollection.AddAthlete(message);
            }
        }



        public static bool updateRequired()
        {
            lock (athleteCollection)
            {
                return athleteCollection.updateNeeded;
            }
        }

        public static void addSubject(Athlete athlete)
        {
            lock (athleteCollection)
            {
                athleteCollection.SubjectsBeingObserved.Add(athlete.BibNumber, athlete);
            }
        }

        public static Dictionary<int, Athlete> getSubjectsBeingWatched()
        {
            lock (athleteCollection)
            {
                return athleteCollection.SubjectsBeingObserved;
            }
        }

        public static AthleteCollection getAthleteCollection()
        {

            return athleteCollection;
        }
        public static void UpdateAthlete(int ID, double Location, DateTime time, string status)
        {
            athleteCollection[ID].UpdateAthlete(Location, time, status);
        }
        public static int getCount()
        {
            return athleteCollection.Count;
        }
        public static void updateDone(int index)
        {
            athleteCollection[index].updated = false;
        }
        private void AddAthlete(AthleteUpdate message)
        {
            RegistrationUpdate registrationMessage = new RegistrationUpdate();
            registrationMessage = (RegistrationUpdate)message;
            Athlete athlete = new Athlete();
            athlete.status = registrationMessage.UpdateType.ToString();
            athlete.FirstName = registrationMessage.FirstName;
            athlete.LastName = registrationMessage.LastName;
            athlete.Gender = registrationMessage.Gender;
            athlete.Age = registrationMessage.Age;
            athlete.prevRaceTime = registrationMessage.Timestamp;
            athlete.Location = 0;
            athlete.BibNumber = message.BibNumber;
            athlete.updated = true;
            
                athleteCollection.Add(message.BibNumber, athlete);
            
        }
    }
}
