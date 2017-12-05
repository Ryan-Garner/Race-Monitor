using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class StartUp : Form
    {
        private  string EventName;
        private  string CourseName;
        private string startTime;
        private string startDate;
        private static StartUp sUp = new StartUp();
        public StartUp()
        {
            InitializeComponent();
        }

        private void startRaceMonitor_Click(object sender, EventArgs e)
        {
            ControlForm MainForm = new ControlForm();
            
            
            MainForm.Show();
            MainForm.setLabels(eventBox.Text, courseBox.Text, dateBox.Text, timeBox.Text);
            Hide();
            
        }
    }
}
