using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AppLayer;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class ControlForm : Form
    {
        private bool running = false;
        CreateObserver createObserver = new CreateObserver();


        public ControlForm()
        {
            
            InitializeComponent();
           
            FormClosed += (s, ev) => Application.Exit();
        }

        public void setLabels(string eventName, string courseName, string startDate, string startTime)
        {
            eventLabel.Text = "Event Name: " + eventName;
            courseLabel.Text = "Course Name: " + courseName;
            dateLabel.Text = "Start Date: " + startDate;
            timeLabel.Text = "Start Time: " + startTime;
        }
        //Add Subject button
        private void button2_Click(object sender, EventArgs e)
        {
            if(observerName.Text != "Athletes being Observed")
            {
                
                    if (availableAthletes.SelectedItems.Count > 0)
                    {
                        int index = Int32.Parse(availableAthletes.SelectedItems[0].Text);

                        
                        AthleteCollection athletes = AthleteCollection.getAthleteCollection();
                        Dictionary<string, SubjectManager> temp = SubjectHandler.GetObservers();
                        temp[observerName.Text].subjects.Add(index, athletes[index]);
                        temp[observerName.Text].AvailableSubjects.Remove(index);
                        
                        updateLists(observerName.Text, temp);
                    }
      
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void removeSubject_Click(object sender, EventArgs e)
        {
            if (observerName.Text != "Athletes being Observed")
            {
               
                    if (observedAthletes.SelectedItems.Count > 0)
                    {
                        int index = Int32.Parse(observedAthletes.SelectedItems[0].Text);

                       
                        AthleteCollection athletes = AthleteCollection.getAthleteCollection();
                        Dictionary<string, SubjectManager> temp = SubjectHandler.GetObservers();
                        temp[observerName.Text].subjects.Remove(index);
                        temp[observerName.Text].AvailableSubjects.Add(index, athletes[index]);

                        updateLists(observerName.Text, temp);
                    }

                
            }
        }
        //Create Observer button
        private void button1_Click(object sender, EventArgs e)
        {
            createObserver.Show();
        }
        delegate void SetAvailableList(Dictionary<int, Athlete> athletes);
        delegate void SetAvailableObservers();

       

        private void setAvailableObservers()
        {
           
                
                observerView.Items.Clear();
                foreach(string name in SubjectHandler.GetObservers().Keys)
                {
                    observerView.Items.Add(new ListViewItem(new[] { name }));
                }
                SubjectHandler.SetNewObserver(false);
           
        }

        private void setAvailableList(Dictionary<int, Athlete> athletes)
        {
            availableAthletes.Items.Clear();

            foreach (Athlete athlete in athletes.Values)
            {
                availableAthletes.Items.Add(new ListViewItem(new[] { athlete.BibNumber.ToString(), athlete.FirstName.ToString(), athlete.LastName.ToString() }));
            }
        }

        private void subjectListener()
        {
            
            while (running)
            {
                Thread.Sleep(500);
                lock (AthleteCollection.getAthleteCollection())
                {
                     
                    foreach (KeyValuePair<int, Athlete> athlete in AthleteCollection.getAthleteCollection())
                    {
                        if (athlete.Value.justUpdated == true)
                        {
                         
                           
                                SubjectHandler.addSubject(athlete.Value);
                            
                               
                            athlete.Value.justUpdated = false;
                            if (this.availableAthletes.InvokeRequired)
                            {
                                SetAvailableList b = new SetAvailableList(setAvailableList);
                                
                                this.Invoke(b, new object[] { AthleteCollection.getAthleteCollection() });
                                
                            }
                            else
                            {
                                availableAthletes.Items.Add(athlete.Value.BibNumber.ToString(), athlete.Value.currTime.ToString(), athlete.Value.Location.ToString());
                            }
                        }
                        
                            if (SubjectHandler.ObserverAdded())
                            {
                                if (this.observerView.InvokeRequired)
                                {
                                    SetAvailableObservers o = new SetAvailableObservers(setAvailableObservers);
                                    this.Invoke(o, new object[] { });

                                }
                            }
                        
                        if (athlete.Value.updated == true)
                        {
                            
                                SubjectHandler.UpdateDisplays();
                            AthleteCollection.updateDone(athlete.Value.BibNumber);                                   
                        }
                        
                    }
                }
            }
        }

        private void StartSimulation()
        {
            Thread myThread = new Thread(new ThreadStart(subjectListener));
            SimulatorController controller = new SimulatorController();
            running = true;
            myThread.Start();
            
            controller.Run("../../../SimulationData/Short Race Simulation-01.csv");
            
            myThread.Abort();
        }

        private void beginEvent_Click(object sender, EventArgs e)
        {
            
            Thread myThread2 = new Thread(new ThreadStart(StartSimulation));
            myThread2.Start();
            beginEvent.Enabled = false;

        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            
        }

        private void updateLists(string ObserverName, Dictionary<string, SubjectManager> observers)
        {

                if (observers[ObserverName].subjects.Values != null)
                {
                    observedAthletes.Items.Clear();
                    foreach (Athlete athlete in observers[ObserverName].subjects.Values)
                    {
                        observedAthletes.Items.Add(new ListViewItem(new[] { athlete.BibNumber.ToString(), athlete.FirstName, athlete.LastName }));
                    }
                    availableAthletes.Items.Clear();
                    foreach (Athlete athlete in observers[ObserverName].AvailableSubjects.Values)
                    {
                        availableAthletes.Items.Add(new ListViewItem(new[] { athlete.BibNumber.ToString(), athlete.FirstName, athlete.LastName }));
                    }
                }
            
            
        }

        private void observerView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "";
            Dictionary<string, SubjectManager> observers = SubjectHandler.GetObservers();
            if (observerView.SelectedItems.Count > 0)
            {
                observerName.Text = observerView.SelectedItems[0].Text;
                name = observerName.Text;
                if (observerName.Text != "Athletes being Observed")
                {
                    try
                    {
                        updateLists(name, observers);
                    }
                    catch(Exception f)
                    {
                        Console.WriteLine(f);
                    }
                }
            }
            
        }
    }
}
