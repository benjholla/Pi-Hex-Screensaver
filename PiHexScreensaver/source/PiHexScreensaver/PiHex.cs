using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PiHexScreensaver
{
    class PiHex
    {
        private static double[] tp = new double[25];
        private static int tp1 = 0;
        private static bool firstCheck = false;
        private static char[] previousSequence = new char[16];
        //private static bool fileExists = false;
        //private static int currentDigit = 0;
        private static bool firstResume = true;




        
        private static string ihex(double x, int nhx, char[] chx)
        {
            //This returns, in chx, the first nhx hex digits of the fraction of x. 
            int i = 0;
            double y = 0;
            char[] hx = "0123456789ABCDEF".ToCharArray();

            y = Math.Abs(x);

            string temp = "";

            for (i = 0; i < nhx; i++)
            {
                y = 16 * (y - Math.Floor(y));
                //chx[i] = hx[(int) y];
                temp += hx[(int)y];
            }
            return temp;
        }


        private static double series(int m, int id)
        {

            //This routine evaluates the series  sum_k 16^(id-k)/(8*k+m) 
            //using the modular exponentiation technique. 

            int k = 0;
            double ak = 0;
            double eps = 0;
            double p = 0;
            double s = 0;
            double t = 0;

            //double expm(double x, double y);
            //#define eps 1e-17

            s = 0;

            //Sum the series up to id.

            for (k = 0; k < id; k++)
            {
                ak = 8 * k + m;
                p = id - k;
                t = expm(p, ak);
                s = s + t / ak;
                s = s - (int)s;
            }

            //Compute a few terms where k >= id.

            for (k = id; k <= id + 100; k++)
            {
                ak = 8 * k + m;
                t = Math.Pow(16, (double)(id - k)) / ak;
                if (t < eps) break;
                s = s + t;
                s = s - (int)s;
            }

            return s;
        }




        private static double expm(double p, double ak)
        {
            //expm = 16^p mod ak.  This routine uses the left-to-right binary 
            //exponentiation scheme.
            int i = 0;
            int j = 0;
            double p1 = 0;
            double pt = 0;
            double r = 0;

            //If this is the first call to expm, fill the power of two table tp. 

            if (tp1 == 0)
            {
                tp1 = 1;
                tp[0] = 1;

                for (i = 1; i < 25; i++) { tp[i] = 2 * tp[i - 1]; }
            }

            if (ak == 1) return 0;

            //Find the greatest power of two less than or equal to p.

            for (i = 0; i < 25; i++) if (tp[i] > p) break;

            pt = tp[i - 1];
            p1 = p;
            r = 1;

            //Perform binary exponentiation algorithm modulo ak. 

            for (j = 1; j <= i; j++)
            {
                if (p1 >= pt)
                {
                    r = 16 * r;
                    r = r - (int)(r / ak) * ak;
                    p1 = p1 - pt;
                }
                pt = 0.5 * pt;
                if (pt >= 1)
                {
                    r = r * r;
                    r = r - (int)(r / ak) * ak;
                }
            }

            return r;
        }

        public static string hexToIntegerString(char[] hexChars)
        {
            string hexStringOut = "";


            for (int i = 0; i < hexChars.Length; i++)
            {
                char hexCharTemp = hexChars[i];
                if (i == 0)
                {
                    switch (hexCharTemp)
                    {
                        case 'A':
                            hexStringOut += "10";
                            break;
                        case 'B':
                            hexStringOut += "11";
                            break;
                        case 'C':
                            hexStringOut += "12";
                            break;
                        case 'D':
                            hexStringOut += "13";
                            break;
                        case 'E':
                            hexStringOut += "14";
                            break;
                        case 'F':
                            hexStringOut += "15";
                            break;
                        default:
                            hexStringOut += hexCharTemp;
                            break;
                    }

                }
                else
                {
                    switch (hexCharTemp)
                    {
                        case 'A':
                            hexStringOut += ", 10";
                            break;
                        case 'B':
                            hexStringOut += ", 11";
                            break;
                        case 'C':
                            hexStringOut += ", 12";
                            break;
                        case 'D':
                            hexStringOut += ", 13";
                            break;
                        case 'E':
                            hexStringOut += ", 14";
                            break;
                        case 'F':
                            hexStringOut += ", 15";
                            break;
                        default:
                            hexStringOut += ", " + hexCharTemp;
                            break;
                    }
                }

            }
            return hexStringOut;
        }

        

        public static string nthHexDigitOfPi(int id)
        {

            double pid = 0;
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;

            char[] chx = new char[16];

            s1 = series(1, id);
            s2 = series(4, id);
            s3 = series(5, id);
            s4 = series(6, id);
            pid = 4 * s1 - 2 * s2 - s3 - s4;
            pid = pid - (int)pid;
            if (pid < 0.0) pid = pid + 1.0;
            string hexString = ihex(pid, 16, chx);

            if (PiHexSession.isErrorChecking() == true)
            {
                String tempHex = errorCheck(hexString.ToCharArray()).ToString();
                if (PiHexSession.isLogging()) { saveDigitToTempFile(tempHex); }
                return tempHex;
            }

            if (PiHexSession.isLogging()) { saveDigitToTempFile(hexString.Substring(0, 1)); }
            return hexString.Substring(0, 1);
        }


        private static char errorCheck(char[] hexStringCheck)
        {

            if (firstCheck == false)
            {
                char charOut = hexStringCheck[0];
                previousSequence = hexStringCheck;
                firstCheck = true;
                return charOut;
            }

            for (int i = 0; i < 4; i++)
            {
                if (!hexStringCheck[i].Equals(previousSequence[i + 1]))
                {
                    previousSequence = hexStringCheck;
                    return '?';
                }
            }

            char charOut2 = hexStringCheck[0];
            previousSequence = hexStringCheck;
            return charOut2;
        }






        private static void saveDigitToTempFile(string digit)
        {
            if (!(File.Exists(PiHexSession.localTempFile)))
            {
                StreamWriter SW = File.CreateText(PiHexSession.localTempFile);
                SW.Write(digit);
                SW.Close();
            }
            else
            {
                StreamWriter SW = File.AppendText(PiHexSession.localTempFile);
                SW.Write(digit);
                SW.Close();
            }
        }




        //private static void log(string data)
        //{
        //    if (logging == true)
        //    {
        //        if (File.Exists(logFile) == false)
        //        {
        //            StreamWriter SW4;
        //            SW4 = File.CreateText("C:\\WINDOWS\\system32\\PiHexSpacingSettings.dat");
        //            SW4.WriteLine("0");
        //            SW4.WriteLine("0");
        //            SW4.WriteLine("0");
        //            SW4.Close();

        //            StreamWriter SW;
        //            SW = File.CreateText(logFile);
        //            SW.Write("3.");
        //            SW.Close();
        //        }




        //        StreamWriter SW6;
        //        SW6 = File.AppendText(logFile);

        //        if (currentDigit == 10000000) { SW6.Write("\n\n--------------------------------------------------------------------------\nAccuracy of Pi cannot be gaureenteed past 10000000 digits on this machine.\n--------------------------------------------------------------------------\n"); spacing = 0; spacingSet = 0; }

        //        if (spacing % 5 == 0) { SW6.Write(" "); spacing = 0; }
        //        if (spacingSet % 50 == 0) { SW6.Write("\n"); spacing = 0; spacingSet = 0; }
        //        if (spacingSet % 25 == 0) { SW6.Write(" "); }
        //        SW6.Write(data);
        //        SW6.Close();
        //        spacing++;
        //        spacingSet++;

        //        StreamWriter SW2;
        //        SW2 = File.CreateText(logSettings);
        //        SW2.WriteLine(currentDigit + 1);
        //        SW2.WriteLine(spacing);
        //        SW2.WriteLine(spacingSet);
        //        SW2.Close();


        //    }
        //}














    }
}
