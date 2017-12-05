using System;
using System.Collections.Generic;
using System.Net.Mail;
using AppLayer;
using MyRaceMonitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RaceMonitorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAthlete()
        {
            Athlete athlete = new Athlete();
            athlete.BibNumber = 21;
            athlete.Location = 1234.04;
            DateTime testF = new DateTime(2017, 8, 10, 7, 10, 15);
            DateTime testS = new DateTime(2017, 8, 10, 5, 10, 20);
            Console.WriteLine(testF.Subtract(testS));
            athlete.prevRaceTime = testF;
            
            athlete.FirstName = "Ryan";
            athlete.status = "dumb";

            Assert.AreEqual(athlete.BibNumber, 21);
            Assert.AreEqual(athlete.Location, 1234.04);
            
            Assert.AreEqual(athlete.FirstName, "Ryan");

            athlete.UpdateAthlete(1414.22, new DateTime(2017, 8, 10, 20, 10, 20), "STUmped");

            DateTime TestA = new DateTime(2017, 8, 10, 20, 10, 20);



            Assert.AreEqual(athlete.Location, 1414.22);
            Assert.AreEqual(athlete.currTime, TestA.Subtract(testF));
            Assert.AreEqual(athlete.status, "STUmped");

        }


        [TestMethod]
        public void TestSubjectHandler()
        {
            Athlete athlete = new Athlete();
            athlete.BibNumber = 21;
            athlete.Location = 1234.04;
            DateTime testF = new DateTime(2017, 8, 10, 7, 10, 15);
            DateTime testS = new DateTime(2017, 8, 10, 5, 10, 20);
           
            athlete.prevRaceTime = testF;

            Athlete athlete2 = new Athlete();
            athlete.BibNumber = 23;
            athlete.Location = 1244.04;
            DateTime testA = new DateTime(2017, 8, 10, 5, 16, 15);
            
            Console.WriteLine(testF.Subtract(testS));
            athlete.prevRaceTime = testA;

            SubjectHandler.addSubject(athlete);
            SubjectHandler.addSubject(athlete2);
            SubjectManager TestManager = new SubjectManager();
            SubjectHandler.addObserver("Name", TestManager, "EMAIL");

            List<Athlete> athletes = new List<Athlete>();
            athletes.Add(athlete);
            athletes.Add(athlete2);

            Dictionary<string, SubjectManager> dictTest = new Dictionary<string, SubjectManager>();
            dictTest.Add("Name", new SubjectManager());
            List<Athlete> compare = SubjectHandler.getPossible();
            Dictionary<string, SubjectManager> dictTester = SubjectHandler.GetObservers();

            Assert.AreEqual(athletes[0], compare[0]);
            Assert.AreEqual(dictTester["Name"], TestManager);



        }
        [TestMethod]
        public void TestEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("jryangarner67@gmail.com");
                mail.To.Add("ryangarner67@yahoo.com");
                mail.Subject = "Test Mail";
                mail.Body = "test";

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
