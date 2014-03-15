using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace PiHexScreensaver
{
    class PiHexSession
    {



        private static int currentDigit = 0;

        private static bool logging = true;
        private static bool resume = true;
        private static bool scrolling = true;
        private static bool errorChecking = true;

        public static double[] tp = new double[25];
        public static int tp1 = 0;
        public static bool firstCheck = false;
        public static char[] previousSequence = new char[16];

        private static string timeDisplayMode = "No Display";

        public static TimeSpan duration = new TimeSpan();
        public static DateTime startTime = DateTime.Now;
        public static DateTime stopTime = DateTime.Now;

        public static string pi = "";

        public static string localSessionFile = "C:\\WINDOWS\\system32\\PiHexScreensaverSession.xml";
        public static string localTempFile = "C:\\WINDOWS\\system32\\PiHexScreensaverTemp.dat";



        //private static bool fileExists = false;


        //SESSION FUNCTIONS
        static public void saveSession()
        {
            XmlTextWriter writer;

            writer = new XmlTextWriter(localSessionFile, System.Text.Encoding.UTF8);

            // Indent the XML document for readability
            writer.Formatting = System.Xml.Formatting.Indented;

            // Call WriteStartDocument to write XML declaration
            // should be the first call before writing elements
            writer.WriteStartDocument();

            // write a comment
            writer.WriteComment("This is a saved session from the PiHexScreensaver");

            // write root element - should at least contain a root element
            writer.WriteStartElement("Session");

            //CURRENT DIGIT
            if (isLogging())
            {
                writer.WriteElementString("current-digit", currentDigit.ToString());
            }
            else
            {
                writer.WriteElementString("current-digit", "0");
            }
            

            //CONFIG SETTINGS
            writer.WriteStartElement("config-settings");
            writer.WriteElementString("logging", logging.ToString());
            if (isLogging())
            {
                writer.WriteElementString("resume", resume.ToString());
            }
            else
            {
                writer.WriteElementString("resume", "False");
            }
            writer.WriteElementString("scrolling", scrolling.ToString());
            writer.WriteElementString("error-checking", errorChecking.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("total-calculation-time");


            if (isLogging())
            {
                TimeSpan tmp = stopTime - startTime;
                duration = duration.Add(tmp);

                writer.WriteElementString("display-mode", timeDisplayMode);
                writer.WriteElementString("days", duration.Days.ToString());
                writer.WriteElementString("hours", duration.Hours.ToString());
                writer.WriteElementString("minutes", duration.Minutes.ToString());
                writer.WriteElementString("seconds", duration.Seconds.ToString());
                writer.WriteElementString("milliseconds", duration.Milliseconds.ToString());
            }
            else
            {
                writer.WriteElementString("display-mode", "No Display");
                writer.WriteElementString("days", "0");
                writer.WriteElementString("hours", "0");
                writer.WriteElementString("minutes", "0");
                writer.WriteElementString("seconds", "0");
                writer.WriteElementString("milliseconds", "0");
            }
            writer.WriteEndElement();

            //PI data
            pi += getTempPiDigits();
            if (isLogging())
            {
                writer.WriteElementString("pi", pi);
            }
            else
            {
                writer.WriteElementString("pi", "3.");
            }

            // Write End of root element
            writer.WriteEndElement();

            // Write End of document
            writer.WriteEndDocument();

            writer.Close();
        }





        static public void saveSessionCorrected()
        {
            XmlTextWriter writer;

            writer = new XmlTextWriter(localSessionFile, System.Text.Encoding.UTF8);

            // Indent the XML document for readability
            writer.Formatting = System.Xml.Formatting.Indented;

            // Call WriteStartDocument to write XML declaration
            // should be the first call before writing elements
            writer.WriteStartDocument();

            // write a comment
            writer.WriteComment("This is a saved session from the PiHexScreensaver");

            // write root element - should at least contain a root element
            writer.WriteStartElement("Session");

            //CURRENT DIGIT
            if (isLogging())
            {
                writer.WriteElementString("current-digit", currentDigit.ToString());
            }
            else
            {
                writer.WriteElementString("current-digit", "0");
            }


            //CONFIG SETTINGS
            writer.WriteStartElement("config-settings");
            writer.WriteElementString("logging", logging.ToString());
            if (isLogging())
            {
                writer.WriteElementString("resume", resume.ToString());
            }
            else
            {
                writer.WriteElementString("resume", "False");
            }
            writer.WriteElementString("scrolling", scrolling.ToString());
            writer.WriteElementString("error-checking", errorChecking.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("total-calculation-time");


            if (isLogging())
            {
                TimeSpan tmp = stopTime - startTime;
                duration = duration.Add(tmp);

                writer.WriteElementString("display-mode", timeDisplayMode);
                writer.WriteElementString("days", duration.Days.ToString());
                writer.WriteElementString("hours", duration.Hours.ToString());
                writer.WriteElementString("minutes", duration.Minutes.ToString());
                writer.WriteElementString("seconds", duration.Seconds.ToString());
                writer.WriteElementString("milliseconds", duration.Milliseconds.ToString());
            }
            else
            {
                writer.WriteElementString("display-mode", "No Display");
                writer.WriteElementString("days", "0");
                writer.WriteElementString("hours", "0");
                writer.WriteElementString("minutes", "0");
                writer.WriteElementString("seconds", "0");
                writer.WriteElementString("milliseconds", "0");
            }
            writer.WriteEndElement();

            //PI data
            pi += getTempPiDigits();
            if (isLogging())
            {
                writer.WriteElementString("pi", pi.Substring(0,pi.Length-1));
            }
            else
            {
                writer.WriteElementString("pi", "3.");
            }

            // Write End of root element
            writer.WriteEndElement();

            // Write End of document
            writer.WriteEndDocument();

            writer.Close();
        }




        static public void createEmptyXMLSession()
        {
            XmlTextWriter writer;

            writer = new XmlTextWriter(localSessionFile, System.Text.Encoding.UTF8);

            // Indent the XML document for readability
            writer.Formatting = System.Xml.Formatting.Indented;

            // Call WriteStartDocument to write XML declaration
            // should be the first call before writing elements
            writer.WriteStartDocument();

            // write a comment
            writer.WriteComment("This is a saved session from the PiHexScreensaver");

            // write root element - should at least contain a root element
            writer.WriteStartElement("Session");

            //CURRENT DIGIT
            writer.WriteElementString("current-digit", "0");

            //CONFIG SETTINGS
            writer.WriteStartElement("config-settings");
            writer.WriteElementString("logging", "True");
            writer.WriteElementString("resume", "True");
            writer.WriteElementString("scrolling", "True");
            writer.WriteElementString("error-checking", "True");
            writer.WriteEndElement();

            writer.WriteStartElement("total-calculation-time");
            writer.WriteElementString("display-mode", "No Display");
            writer.WriteElementString("days", "0");
            writer.WriteElementString("hours", "0");
            writer.WriteElementString("minutes", "0");
            writer.WriteElementString("seconds", "0");
            writer.WriteElementString("milliseconds", "0");
            writer.WriteEndElement();

            //PI data
            pi = "3.";
            writer.WriteElementString("pi", pi);

            // Write End of root element
            writer.WriteEndElement();

            // Write End of document
            writer.WriteEndDocument();

            writer.Close();
        }







        static public void restoreSession()
        {
            if (!File.Exists(localSessionFile)) { createEmptyXMLSession(); }

            XmlTextReader textReader = new XmlTextReader(localSessionFile);

            string days = "0";
            string hours = "0";
            string minutes = "0";
            string seconds = "0";
            string milliseconds = "0";


            textReader.Read();
            // If the node has value
            while (textReader.Read())
            {

                XmlNodeType nType = textReader.NodeType;

                // if node type is an element
                if (nType == XmlNodeType.Element)
                {
                    if (textReader.Name.ToString().Equals("current-digit"))
                    {
                        currentDigit = textReader.ReadElementContentAsInt();
                    }

                    if (textReader.Name.ToString().Equals("logging"))
                    {
                        if (textReader.ReadElementContentAsString().Equals("True"))
                        {
                            logging = true;
                        }
                        else
                        {
                            logging = false;
                        }
                    }

                    if (textReader.Name.ToString().Equals("resume"))
                    {
                        if (textReader.ReadElementContentAsString().Equals("True"))
                        {
                            resume = true;
                        }
                        else
                        {
                            resume = false;
                        }
                    }

                    if (textReader.Name.ToString().Equals("scrolling"))
                    {
                        if (textReader.ReadElementContentAsString().Equals("True"))
                        {
                            scrolling = true;
                        }
                        else
                        {
                            scrolling = false;
                        }
                    }

                    if (textReader.Name.ToString().Equals("error-checking"))
                    {
                        if (textReader.ReadElementContentAsString().Equals("True"))
                        {
                            errorChecking = true;
                        }
                        else
                        {
                            errorChecking = false;
                        }
                    }

                    if (textReader.Name.ToString().Equals("display-mode"))
                    {
                        timeDisplayMode = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("days"))
                    {
                        days = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("hours"))
                    {
                        hours = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("minutes"))
                    {
                        minutes = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("seconds"))
                    {
                        seconds = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("milliseconds"))
                    {
                        milliseconds = textReader.ReadElementContentAsString();
                    }

                    if (textReader.Name.ToString().Equals("pi"))
                    {
                        pi = textReader.ReadElementContentAsString();
                        if (pi.Equals("")) { pi = "3."; }
                    }

                }
            }
            textReader.Close();
                duration = new TimeSpan(Convert.ToInt32(days), Convert.ToInt32(hours), Convert.ToInt32(minutes), Convert.ToInt32(seconds), Convert.ToInt32(milliseconds));

                if (logging == false)
                {
                    resume = false;
                }

                if (resume == false)
                {
                    duration = new TimeSpan(0, 0, 0, 0, 0);
                    currentDigit = 0;
                    pi = "3.";
                }
            
        }







        static public void saveSessionCopy(string saveSessionCopyPath)
        {
            //copy session.xml to file location
            StreamReader SR = new StreamReader(localSessionFile);

            string file = SR.ReadToEnd();

            SR.Close();

            StreamWriter SW = new StreamWriter(saveSessionCopyPath);
            SW.Write(file);
            SW.Close();
        }








        static public void loadSession(string newSessionLoadPath)
        {
            //delete current session.xml and replace it with the new file


            //copy session.xml to file location
            StreamReader SR = new StreamReader(newSessionLoadPath);

            string file = SR.ReadToEnd();

            SR.Close();

            StreamWriter SW = new StreamWriter(localSessionFile);
            SW.Write(file);
            SW.Close();

            restoreSession();
        }





        static public string getTempPiDigits()
        {
            if (PiHexSession.isLogging())
            {
                if (!(File.Exists(localTempFile)))
                {
                    return "";
                }

                string piDigits = "";

                try
                {
                    StreamReader SR = new StreamReader(localTempFile);
                    piDigits = SR.ReadToEnd();
                    SR.Close();
                }
                catch
                {
                    MessageBox.Show("Could not access temp file, data has been lost!  Session data is corrupt please reset defaults.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return piDigits;
            }
            else
            {
                return "";
            }
        }





        //EXTRA EXPORT FEATURES
        static public void exportPiBitmapAnalysis(string path)
        {
        }

        static public void exportSpecificPiBitmapAnalysis(string path)
        {
        }

        static public void exportPi(string path)
        {
        }

        static public void exportPiWave(string path)
        {
        }

        




        //GET METHODS
        static public int getCurrentDigit()
        {
            return currentDigit;
        }





        static public int getNextDigit()
        {
            return currentDigit+1;
        }





        static public void incrementCurrentDigit()
        {
            currentDigit++;
        }





        static public string getCurrentTotalCalcTime()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return "Days:  " + tmp.Days + "  Hours:  " +
                tmp.Hours + "  Minutes:  " + tmp.Minutes +
                "  Seconds:  " + tmp.Seconds +
                "  Milliseconds:  " + tmp.Milliseconds;
        }






        static public int getCurrentTotalCalcTimeDays()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return tmp.Days;
        }





        static public int getCurrentTotalCalcTimeHours()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return tmp.Hours;
        }







        static public int getCurrentTotalCalcTimeMinutes()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return tmp.Minutes;
        }







        static public int getCurrentTotalCalcTimeSeconds()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return tmp.Seconds;
        }







        static public int getCurrentTotalCalcTimeMilliseconds()
        {

            TimeSpan tmp = (DateTime.Now - startTime) + duration;


            return tmp.Milliseconds;
        }








        static public string getPiFromSession()
        {
            XmlTextReader textReader = new XmlTextReader(localSessionFile);

            textReader.Read();
            // If the node has value
            while (textReader.Read())
            {

                XmlNodeType nType = textReader.NodeType;

                // if node type is an element
                if (nType == XmlNodeType.Element)
                {

                    if (textReader.Name.ToString().Equals("pi"))
                    {
                        string piTmp = textReader.ReadElementContentAsString();
                        if (piTmp.Equals("")) { piTmp = "3."; }
                        textReader.Close();
                        return piTmp;
                    }
                }
            }
            return "3.";
        }






        //ENABLE METHODS
        static public void enableLogging(bool setLogging)
        {
            if (setLogging == true) { logging = true; }
            else { logging = false; }
        }

        static public void enableScrolling(bool setScrolling)
        {
            if (setScrolling == true) { scrolling = true; }
            else { scrolling = false; }
        }

        static public void enableResumeCalculation(bool resume)
        {
            if (resume == true) { resume = true; }
            else { resume = false; }
        }

        static public void enableErrorChecking(bool check)
        {
            if (check == true) { errorChecking = true; }
            else { errorChecking = false; }
        }

        static public string getTimeDisplayMode()
        {
            return timeDisplayMode;
        }

        static public void setTimeDisplayMode(string newTimeDisplayMode)
        {
            timeDisplayMode = newTimeDisplayMode;
        }


        //IS METHODS
        static public bool isErrorChecking()
        {
            return errorChecking;
        }

        static public bool isResumeCalc()
        {
            return resume;
        }

        static public bool isScrolling()
        {
            return scrolling;
        }

        static public bool isLogging()
        {
            return logging;
        }





    }
}
