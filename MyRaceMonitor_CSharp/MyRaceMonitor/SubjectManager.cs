using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLayer;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class SubjectManager : Form
    {
        public SubjectManager()
        {
            InitializeComponent();
        }
        public Dictionary<int, Athlete> subjects = new Dictionary<int, Athlete>();
        public Dictionary<int, Athlete> AvailableSubjects = new Dictionary<int, Athlete>();
        

        

        public virtual void UpdateDisplay()
        {

        }

        public void UpdateSubjects(Dictionary<int, Athlete> athletes)
        {
            foreach (int key in athletes.Keys)
            {
                if (subjects.ContainsKey(key))
                {
                    subjects[key] = athletes[key];
                }
            }
        }

        public void UpdateAvailable(Athlete athlete)
        {
            AvailableSubjects.Add(athlete.BibNumber, athlete);
        }

        public void AddSubject(Athlete athlete)
        {
            lock (subjects)
            {
                subjects.Add(athlete.BibNumber, athlete);
                AvailableSubjects.Remove(athlete.BibNumber);
            }
        }
    }
}
