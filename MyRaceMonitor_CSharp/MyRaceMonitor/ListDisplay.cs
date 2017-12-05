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
    public partial class ListDisplay : SubjectManager
    { 
        public ListDisplay()
        {
            InitializeComponent();
            this.Show();
        }

        private int counter;

        delegate void SetListText(Athlete athlete);
        delegate void SetClearObserved();

        private void ClearObserved()
        {
            athletesObserved.Items.Clear();
        }


        public void UpdateList(Athlete athlete)
        {
            
            athletesObserved.Items.Add(new ListViewItem(new[] { athlete.BibNumber.ToString(), athlete.FirstName, athlete.LastName, athlete.currTime.ToString(), athlete.Location.ToString(), athlete.status }));
        }

        public override void UpdateDisplay()
        {
            counter++;
            if (counter > 5)
            {
                if (athletesObserved.InvokeRequired)
                {
                    SetClearObserved c = new SetClearObserved(ClearObserved);

                    Invoke(c, new object[] { });
                }
                else
                {
                    athletesObserved.Items.Clear();
                }
                athletesObserved.Items.Clear();
                if (subjects.Values.Count > 0)
                {
                    //Console.WriteLine("ype");
                }
                lock (subjects)
                {
                    try
                    {
                        foreach (Athlete athlete in subjects.Values)
                        {
                            if (athletesObserved.InvokeRequired)
                            {
                                SetListText b = new SetListText(UpdateList);

                                Invoke(b, new object[] { athlete });

                            }
                            else
                            {
                                athletesObserved.Items.Add(new ListViewItem(new[] { athlete.BibNumber.ToString(), athlete.FirstName, athlete.LastName, athlete.currTime.ToString(), athlete.Location.ToString(), athlete.status }));
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                counter = 0;
            }
        }
    }
}
