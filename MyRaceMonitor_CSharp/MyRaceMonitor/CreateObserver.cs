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
    public partial class CreateObserver : Form
    {
        public CreateObserver()
        {
            InitializeComponent();
        }

        //private Form observer;
        public string email;
        public string name;
        EmailForm EmailForm = new EmailForm("test", 12);



        private void button1_Click(object sender, EventArgs e)
        {
            if(listRadio.Checked)
            {
               
                SubjectHandler.addObserver(textBox1.Text, new ListDisplay(), "LIST");
            }
            //Console.WriteLine(name);

            if (emailRadio.Checked)
            {
                EmailForm.Show();
            }

            if(graphicalRadio.Checked)
            {
                SubjectHandler.addObserver(textBox1.Text, new GraphicalDisplay(), "LIST");
            }

            this.Hide();
            this.textBox1.ResetText();  
        }
        
        
        public string getName()
        {
            return textBox1.Text;
        }
        public string getEmail()
        {
            return email;
        }
        public string observerType()
        {
            if(listRadio.Checked)
            {
                return "List";
            }
            if(emailRadio.Checked)
            {
                return "Email";
            }
            if(graphicalRadio.Checked)
            {
                return "Graphical";
            }
            else
            {
                return "nothing";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
            this.Hide();
        }
    }
}
