using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using AppLayer;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class EmailForm : SubjectManager
    {
        private string email;
        private int update;

        public EmailForm(string emails, int update2)
        {
            email = emails;
            update = update2;
            InitializeComponent();
        }

        public override void UpdateDisplay()
        {
            foreach(Athlete athlete in subjects.Values)
            {
                if(0 == athlete.UpdateNumber%update )
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("jryangarner67@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Test Mail";
                        mail.Body = "Athlete " + athlete.BibNumber.ToString() + " " + athlete.FirstName + " " + athlete.LastName + "Location: " + athlete.Location.ToString() + " Time: " + athlete.currTime.ToString();

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("jryangarner67@gmail.com", "Slimjim670");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(emailBox.Text);
            SubjectHandler.addObserver(emailBox.Text, new EmailForm(emailBox.Text, (int)updateNumber.Value), "EMAIL");
            
            this.Hide();
        }

        public int getUpdate()
        {
            return update;
        }

        public string getEmail()
        {
            return email;
        }
    }
}
