using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer;

namespace MyRaceMonitor
{
    public class SubjectHandler
    {
        private static SubjectHandler subjectHandler = new SubjectHandler();
        static object locker = new Object();

        private Dictionary<string, SubjectManager> _observers = new Dictionary<string, SubjectManager>();
        private List<Athlete> possibleSubjects = new List<Athlete>();
        private bool newObserver = false;

        public static void addObserver(string name, SubjectManager form, string type)
        {
            Console.WriteLine(name);
            lock (locker)
            {
                if (type == "LIST")
                {
                    subjectHandler._observers.Add(name, form);
                }
                if (type == "EMAIL")
                {
                    subjectHandler._observers.Add(name, form);
                }
                if (type == "GRAPHICAL")
                {
                    subjectHandler._observers.Add(name, form);
                }
                subjectHandler.newObserver = true;
                foreach (Athlete athlete in subjectHandler.possibleSubjects)
                {
                    subjectHandler._observers[name].AvailableSubjects.Add(athlete.BibNumber, athlete);
                }
            }
            
        }

        public static void addPossible(Athlete athlete)
        {
            lock (locker)
            {
                foreach (SubjectManager obs in subjectHandler._observers.Values)
                {
                    obs.UpdateAvailable(athlete);
                }
            }
        }

        public static void addSubject(Athlete athlete)
        {
            lock (locker)
            {
                subjectHandler.possibleSubjects.Add(athlete);
                foreach (SubjectManager observer in subjectHandler._observers.Values)
                {
                    observer.AvailableSubjects.Add(athlete.BibNumber, athlete);
                    
                }
            }
        }

        public static SubjectHandler GetHandler()
        {
            lock (locker)
            {
                return subjectHandler;
            }
        }

        public static List<Athlete> getPossible()
        {
            return subjectHandler.possibleSubjects;
        }

        public static Dictionary<string, SubjectManager> GetObservers()
        {
            try
            {
                
                    return subjectHandler._observers;
                
            }
            catch(Exception f)
            {
                Console.WriteLine(f);
            }
            return new Dictionary<string, SubjectManager>();
        }

        public static void UpdateDisplays()
        {
            lock (locker)
            {
                Dictionary<int, Athlete> athletes = AthleteCollection.getAthleteCollection();
                foreach (Athlete athlete in athletes.Values)
                {
                    foreach (SubjectManager observer in subjectHandler._observers.Values)
                    {
                        if (observer.AvailableSubjects.ContainsKey(athlete.BibNumber))
                        {
                            observer.AvailableSubjects[athlete.BibNumber] = athlete;
                        }
                        if (observer.subjects.ContainsKey(athlete.BibNumber))
                        {
                            observer.subjects[athlete.BibNumber] = athlete;
                        }
                    }
                }
                
                foreach (SubjectManager observer in subjectHandler._observers.Values)
                {
                    try
                    {
                        observer.UpdateDisplay();
                    }
                    catch(Exception f)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
            
        }

        public static bool ObserverAdded()
        {
            lock (locker)
            {
                return subjectHandler.newObserver;
            }
        }

        public static void SetNewObserver(bool isNew)
        {
            lock (locker)
            {
                subjectHandler.newObserver = false;
            }
        }
    }
}
