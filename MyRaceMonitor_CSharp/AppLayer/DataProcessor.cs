using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RaceData;
using RaceData.Messages;

namespace AppLayer
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        //AthleteCollection athleteCollection = new AthleteCollection();
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
           
            // TODO: Do something to process the update message, depending on the concrete type of message
            if (updateMessage.UpdateType.ToString() == "Registered")
            {
                // AthleteCollection.UpdateAt
                lock (AthleteCollection.getAthleteCollection())
                {
                    AthleteCollection.RegisterAthlete(updateMessage);
                }
                
            }
            if(updateMessage.UpdateType.ToString() == "OnCourse")
            {
                LocationUpdate temp = (LocationUpdate)updateMessage;
                AthleteCollection.UpdateAthlete(temp.BibNumber, temp.LocationOnCourse, temp.Timestamp, temp.UpdateType.ToString());
            }
                    // TODO: Note that the console write line does below here
                    Console.WriteLine(updateMessage.ToString());
        }
    }
}
