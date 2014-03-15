using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Screensavers;
using PiHexScreensaver;
using System.Windows.Forms;
using System.Threading;

namespace PiHexScreensaver
{
	class PiHexScreensaver : Screensaver
	{

        private static int MaxX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        private static int MaxY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        private static LinkedList<string> piScrollList = new LinkedList<string>();
        private Thread thread;
        


    public PiHexScreensaver()
    {
      Initialize += new EventHandler(PiSaver_Initialize);
      Update += new EventHandler(PiSaver_Update);
      Exit += new EventHandler(PiSaver_Exit);
    }

   void PiSaver_Initialize(object sender, EventArgs e)
   {
       PiHexSession.restoreSession();
       PiHexSession.startTime = DateTime.Now;
   }

   void PiSaver_Update(object sender, EventArgs e)
   {

       Graphics0.Clear(Color.Black);
       Font font = new Font("Verdana", 26);
       Font font2 = new Font("Verdana", 16);
       Font font3 = new Font("Verdana", 12);

       Graphics0.DrawString("Computing digit " + PiHexSession.getNextDigit().ToString() + " of Pi.", font, Brushes.Blue, (MaxX / 2) - 250, (MaxY / 2) - 30);
      
       if (PiHexSession.isScrolling() == true) {
           string piList = "";
           foreach (string s in piScrollList)
               piList += s;
           Graphics1.DrawString("Current section of Pi:  " + piList, font2, Brushes.Green, (MaxX / 2)-245, (MaxY/ 2)+20); 
       }

       if (!(PiHexSession.getTimeDisplayMode().Equals("No Display")))
       {
           Graphics2.DrawString("Total Elapsed Calculation Time", font2, Brushes.Red, 2, 2);

           if (PiHexSession.getTimeDisplayMode().Equals("Day/Hour/Min/Sec/Ms"))
           {
               Graphics2.DrawString("Days:  "+PiHexSession.getCurrentTotalCalcTimeDays().ToString(), font3, Brushes.Red, 6, 30);
               Graphics2.DrawString("Hours:  " + PiHexSession.getCurrentTotalCalcTimeHours().ToString(), font3, Brushes.Red, 6, 50);
               Graphics2.DrawString("Minutes:  " + PiHexSession.getCurrentTotalCalcTimeMinutes().ToString(), font3, Brushes.Red, 6, 70);
               Graphics2.DrawString("Seconds:  " + PiHexSession.getCurrentTotalCalcTimeSeconds().ToString(), font3, Brushes.Red, 6, 90);
               Graphics2.DrawString("Milliseconds:  " + PiHexSession.getCurrentTotalCalcTimeMilliseconds().ToString(), font3, Brushes.Red, 6, 110);
           }


           if (PiHexSession.getTimeDisplayMode().Equals("Days"))
           {
               decimal days = (decimal)PiHexSession.getCurrentTotalCalcTimeDays();
               decimal hours = (decimal)PiHexSession.getCurrentTotalCalcTimeHours();
               decimal mins = (decimal)PiHexSession.getCurrentTotalCalcTimeMinutes();
               decimal secs = (decimal)PiHexSession.getCurrentTotalCalcTimeSeconds();

               decimal totalDays = days + (hours / 24) + (mins/24/60) + (secs / 24 / 60 / 60);

               Graphics2.DrawString("Days  " + totalDays.ToString("N6"), font3, Brushes.Red, 6, 30);
           }

           if (PiHexSession.getTimeDisplayMode().Equals("Hours"))
           {
               decimal days = (decimal)PiHexSession.getCurrentTotalCalcTimeDays();
               decimal hours = (decimal)PiHexSession.getCurrentTotalCalcTimeHours();
               decimal mins = (decimal)PiHexSession.getCurrentTotalCalcTimeMinutes();
               decimal secs = (decimal)PiHexSession.getCurrentTotalCalcTimeSeconds();

               decimal totalHours = (days * 24) + hours + (mins / 60) + (secs / 60 / 60);

               Graphics2.DrawString("Hours:  " + totalHours.ToString("N4"), font3, Brushes.Red, 6, 30);
           }

           if (PiHexSession.getTimeDisplayMode().Equals("Minutes"))
           {
               decimal days = (decimal)PiHexSession.getCurrentTotalCalcTimeDays();
               decimal hours = (decimal)PiHexSession.getCurrentTotalCalcTimeHours();
               decimal mins = (decimal)PiHexSession.getCurrentTotalCalcTimeMinutes();
               decimal secs = (decimal)PiHexSession.getCurrentTotalCalcTimeSeconds();

               decimal totalMins = (days * 24 * 60) + (hours*60) + mins + (secs / 60);

               Graphics2.DrawString("Minutes  " + totalMins.ToString("N2"), font3, Brushes.Red, 6, 30);
           }

       }

       Computation compute = new Computation(PiHexSession.getNextDigit());
       ThreadStart job = new ThreadStart(compute.compute);
       thread = new Thread(job);
       thread.Start();

       while (thread.IsAlive)
       {
           try
           {
               Application.DoEvents();
               
           }
           catch
           {
           }
       }

       string digitReturned = compute.digitComputed;

       PiHexSession.incrementCurrentDigit();
       piScrollList.AddLast(digitReturned);
       if (piScrollList.Count == 17) { piScrollList.RemoveFirst(); }

    }




   void PiSaver_Exit(object sender, EventArgs e)
   {

       if (thread.IsAlive == true)
       {
           try
           {
               thread.Abort();
           }
           catch
           {
           }
       }


       PiHexSession.stopTime = DateTime.Now;
       PiHexSession.saveSession();
       if (PiHexSession.isLogging())
       {
           try
           {
               File.Delete(PiHexSession.localTempFile);
           }
           catch
           {
           }
       }



       string piTemp = PiHexSession.getPiFromSession();
       piTemp = piTemp.Substring(2, piTemp.Length - 2);
       int expectedLength = PiHexSession.getCurrentDigit();

       if (piTemp.Length > expectedLength) 
       {
           PiHexSession.saveSessionCorrected(); 
       }

   }





   [STAThread]
   static void Main()
   {
      Screensaver ss = new PiHexScreensaver();
      ss.Run();
   }
}
}
