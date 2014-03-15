using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace PiHexScreensaver
{


    public partial class BasicBitmapGenerator : Form
    {
        private Color color0 = Color.FromArgb(255, 255, 0);
        private Color color1 = Color.FromArgb(128, 0, 0);
        private Color color2 = Color.FromArgb(22, 211, 233);
        private Color color3 = Color.FromArgb(255, 255, 255);
        private Color color4 = Color.FromArgb(255, 0, 128);
        private Color color5 = Color.FromArgb(0, 255, 255);
        private Color color6 = Color.FromArgb(0, 255, 64);
        private Color color7 = Color.FromArgb(64, 128, 128);
        private Color color8 = Color.FromArgb(255, 128, 0);
        private Color color9 = Color.FromArgb(255, 128, 255);
        private Color colorA = Color.FromArgb(153, 232, 159);
        private Color colorB = Color.FromArgb(255, 0, 0);
        private Color colorC = Color.FromArgb(0, 0, 255);
        private Color colorD = Color.FromArgb(233, 238, 17);
        private Color colorE = Color.FromArgb(149, 91, 164);
        private Color colorF = Color.FromArgb(53, 215, 146);
        private Color colorQuestion = Color.FromArgb(0, 0, 0);
        private decimal actualPiLength = 0;
        private bool errors = false;

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        public BasicBitmapGenerator()
        {
            InitializeComponent();
        }










        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();

            string[] resNames = assembly.GetManifestResourceNames();//Testing Purposes

            Stream imageStream = assembly.GetManifestResourceStream("PiHexScreensaver.AnalysisOriginal.bmp");



            Bitmap bmp = new Bitmap(imageStream);//Manipulate image......

            string rawPi = PiHexSession.getPiFromSession();
            rawPi = rawPi.Substring(2, rawPi.Length - 2);


            int x = 50;
            int y = 50;

            foreach (char digit in rawPi)
            {

                if (digit.Equals('0')) { bmp.SetPixel(x, y, color0); }
                if (digit.Equals('1')) { bmp.SetPixel(x, y, color1); }
                if (digit.Equals('2')) { bmp.SetPixel(x, y, color2); }
                if (digit.Equals('3')) { bmp.SetPixel(x, y, color3); }
                if (digit.Equals('4')) { bmp.SetPixel(x, y, color4); }
                if (digit.Equals('5')) { bmp.SetPixel(x, y, color5); }
                if (digit.Equals('6')) { bmp.SetPixel(x, y, color6); }
                if (digit.Equals('7')) { bmp.SetPixel(x, y, color7); }
                if (digit.Equals('8')) { bmp.SetPixel(x, y, color8); }
                if (digit.Equals('9')) { bmp.SetPixel(x, y, color9); }
                if (digit.Equals('A')) { bmp.SetPixel(x, y, colorA); }
                if (digit.Equals('B')) { bmp.SetPixel(x, y, colorB); }
                if (digit.Equals('C')) { bmp.SetPixel(x, y, colorC); }
                if (digit.Equals('D')) { bmp.SetPixel(x, y, colorD); }
                if (digit.Equals('E')) { bmp.SetPixel(x, y, colorE); }
                if (digit.Equals('F')) { bmp.SetPixel(x, y, colorF); }
                if (digit.Equals('?')) { bmp.SetPixel(x, y, colorQuestion); }

                x++;

                if (x == 1551)
                { 
                    x = 50; 
                    y++;
                    decimal rows = 0;
                    if (actualPiLength >= 1350000)
                    {
                        rows = Math.Round((decimal)1350000 / 1551);
                    }
                    else
                    {
                        rows = Math.Round(actualPiLength/ 1551);
                    }
                    decimal percent = Math.Round(((y-50) / rows)*100);
                    backgroundWorker.ReportProgress((int)Math.Round((percent*80)/100));
                }
                if (y == 951)
                {
                    break;
                }

                
            }

            backgroundWorker.ReportProgress(81);
            //color in '0' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 47; xFill < 97; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color0);
                }
            }

            backgroundWorker.ReportProgress(82);
            //color in '1' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 197; xFill < 247; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color1);
                }
            }

            backgroundWorker.ReportProgress(83);
            //color in '2' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 347; xFill < 397; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color2);
                }
            }

            backgroundWorker.ReportProgress(84);
            //color in '3' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 497; xFill < 547; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color3);
                }
            }

            backgroundWorker.ReportProgress(85);
            //color in '4' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 647; xFill < 697; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color4);
                }
            }

            backgroundWorker.ReportProgress(86);
            //color in '5' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 797; xFill < 846; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color5);
                }
            }

            backgroundWorker.ReportProgress(87);
            //color in '6' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 946; xFill < 996; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color6);
                }
            }

            backgroundWorker.ReportProgress(88);
            //color in '7' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 1096; xFill < 1146; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color7);
                }
            }

            backgroundWorker.ReportProgress(89);
            //color in '8' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 1246; xFill < 1296; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color8);
                }
            }

            backgroundWorker.ReportProgress(90);
            //color in '9' identifier with matching color
            for (int yFill = 1005; yFill < 1055; yFill++)
            {
                for (int xFill = 1396; xFill < 1446; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, color9);
                }
            }

            backgroundWorker.ReportProgress(91);
            //color in 'A' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 47; xFill < 97; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorA);
                }
            }

            backgroundWorker.ReportProgress(92);
            //color in 'B' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 197; xFill < 247; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorB);
                }
            }

            backgroundWorker.ReportProgress(93);
            //color in 'C' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 347; xFill < 397; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorC);
                }
            }

            backgroundWorker.ReportProgress(94);
            //color in 'D' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 497; xFill < 547; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorD);
                }
            }

            backgroundWorker.ReportProgress(95);
            //color in 'E' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 647; xFill < 697; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorE);
                }
            }

            backgroundWorker.ReportProgress(96);
            //color in 'F' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 797; xFill < 847; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorF);
                }
            }

            backgroundWorker.ReportProgress(97);
            //color in '?' identifier with matching color
            for (int yFill = 1100; yFill < 1150; yFill++)
            {
                for (int xFill = 947; xFill < 997; xFill++)
                {
                    bmp.SetPixel(xFill, yFill, colorQuestion);
                }
            }


            backgroundWorker.ReportProgress(98);
            if (errors == false)
            {
                //color in '?' identifier if no digits failed
                for (int yFill = 1095; yFill < 1160; yFill++)
                {
                    for (int xFill = 940; xFill < 1530; xFill++)
                    {
                        bmp.SetPixel(xFill, yFill, Color.Black);
                    }
                }
            }


            bmp.Save(BasicBMPSaveFileDialog.FileName);
            bmp.Dispose();
        }







        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }




        private void BasicBitmapGenerator_Load(object sender, EventArgs e)
        {

            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;

            string rawPi = PiHexSession.getPiFromSession();
            rawPi = rawPi.Substring(2, rawPi.Length - 2);
            actualPiLength = rawPi.Length;

            color0label.Text = "Digit '0'  Color =  (" + color0.R.ToString() + "," + color0.G.ToString() + "," + color0.B.ToString() + ")";
            color0label.ForeColor = color0;

            color1label.Text = "Digit '1'  Color =  (" + color1.R.ToString() + "," + color1.G.ToString() + "," + color1.B.ToString() + ")";
            color1label.ForeColor = color1;

            color2label.Text = "Digit '2'  Color =  (" + color2.R.ToString() + "," + color2.G.ToString() + "," + color2.B.ToString() + ")";
            color2label.ForeColor = color2;

            color3label.Text = "Digit '3'  Color =  (" + color3.R.ToString() + "," + color3.G.ToString() + "," + color3.B.ToString() + ")";
            color3label.ForeColor = color3;

            color4label.Text = "Digit '4'  Color =  (" + color4.R.ToString() + "," + color4.G.ToString() + "," + color4.B.ToString() + ")";
            color4label.ForeColor = color4;

            color5label.Text = "Digit '5'  Color =  (" + color5.R.ToString() + "," + color5.G.ToString() + "," + color5.B.ToString() + ")";
            color5label.ForeColor = color5;

            color6label.Text = "Digit '6'  Color =  (" + color6.R.ToString() + "," + color6.G.ToString() + "," + color6.B.ToString() + ")";
            color6label.ForeColor = color6;

            color7label.Text = "Digit '7'  Color =  (" + color7.R.ToString() + "," + color7.G.ToString() + "," + color7.B.ToString() + ")";
            color7label.ForeColor = color7;

            color8label.Text = "Digit '8'  Color =  (" + color8.R.ToString() + "," + color8.G.ToString() + "," + color8.B.ToString() + ")";
            color8label.ForeColor = color8;

            color9label.Text = "Digit '9'  Color =  (" + color9.R.ToString() + "," + color9.G.ToString() + "," + color9.B.ToString() + ")";
            color9label.ForeColor = color9;

            colorAlabel.Text = "Digit 'A'  Color =  (" + colorA.R.ToString() + "," + colorA.G.ToString() + "," + colorA.B.ToString() + ")";
            colorAlabel.ForeColor = colorA;

            colorBlabel.Text = "Digit 'B'  Color =  (" + colorB.R.ToString() + "," + colorB.G.ToString() + "," + colorB.B.ToString() + ")";
            colorBlabel.ForeColor = colorB;

            colorClabel.Text = "Digit 'C'  Color =  (" + colorC.R.ToString() + "," + colorC.G.ToString() + "," + colorC.B.ToString() + ")";
            colorClabel.ForeColor = colorC;

            colorDlabel.Text = "Digit 'D'  Color =  (" + colorD.R.ToString() + "," + colorD.G.ToString() + "," + colorD.B.ToString() + ")";
            colorDlabel.ForeColor = colorD;

            colorElabel.Text = "Digit 'E'  Color =  (" + colorE.R.ToString() + "," + colorE.G.ToString() + "," + colorE.B.ToString() + ")";
            colorElabel.ForeColor = colorE;

            colorFlabel.Text = "Digit 'F'  Color =  (" + colorF.R.ToString() + "," + colorF.G.ToString() + "," + colorF.B.ToString() + ")";
            colorFlabel.ForeColor = colorF;

            colorQuestionlabel.Text = "Digit '?'  Color =  (" + colorQuestion.R.ToString() + "," + colorQuestion.G.ToString() + "," + colorQuestion.B.ToString() + ")";
            colorQuestionlabel.ForeColor = colorQuestion;

            if (actualPiLength >= 1350000)
            {
                MessageBox.Show("Congrats!  You have calculated enough digits of Pi to complete the default Pi Bitmap Analysis template.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have not calculated enough digits of Pi to complete the default Pi Bitmap Analysis template.\n\nThe template will not be complete if you continue, but it is encouraged to continue and generate a template to see your current progress.\n\nYou need to calculate " + ((int)1350000 - actualPiLength) + " more digits to reach the 1,350,000 required digits.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rawPi.Contains("?") == false)
            {
                errors = false;
                colorQuestionbutton.Enabled = false;
                MessageBox.Show("Congrats!  All of your calculated digits have passed error checking!\n\n(that is assuming you had error checking enabled)", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some of your calculated digits of Pi have not passed error checking.  Those digits are represented with the '?' character", "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errors = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color0 = colorDialog.Color;
                color0label.Text = "Digit '0'  Color =  ("+color0.R.ToString()+","+color0.G.ToString()+","+color0.B.ToString()+")";
                color0label.ForeColor = color0;
            }
        }

        private void GenerateBitmapButton_Click(object sender, EventArgs e)
        {

            if (BasicBMPSaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                //cancel any process, nothing should be running at this point
                if (backgroundWorker.IsBusy == true)
                {
                    backgroundWorker.CancelAsync();
                }
                while (backgroundWorker.IsBusy == true)
                {
                    try
                    {
                        Application.DoEvents();
                    }
                    catch
                    {
                    }
                }

                GenerateBitmapButton.Enabled = false;
                backgroundWorker.RunWorkerAsync();

                //wait for event to be finished
                while (backgroundWorker.IsBusy == true)
                {
                    try
                    {
                        Application.DoEvents();
                    }
                    catch
                    {
                    }
                }

                progressBar1.Value = 100;
                progressLabel.Text = "100% Completed";
                MessageBox.Show(BasicBMPSaveFileDialog.FileName + " has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateBitmapButton.Enabled = true;

                if (wallpaperCheckBox.Checked == true)
                {
                    if (MessageBox.Show("Are you sure that you want to set " + BasicBMPSaveFileDialog.FileName + " as your new desktop wallpaper?",
                    "Set Wallpaper?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        setWallpaper(BasicBMPSaveFileDialog.FileName, Style.Stretched);
                    }
                }


                return;
            }

        }

        private void color1button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color1 = colorDialog.Color;
                color1label.Text = "Digit '1'  Color =  (" + color1.R.ToString() + "," + color1.G.ToString() + "," + color1.B.ToString() + ")";
                color1label.ForeColor = color1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == true)
            {
                if (MessageBox.Show("Are you sure that you want to cancel the Pi Bitmap Analysis process?",
                "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        backgroundWorker.CancelAsync();
                    }
                    catch
                    {
                    }
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }

        private void color2button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color2 = colorDialog.Color;
                color2label.Text = "Digit '2'  Color =  (" + color2.R.ToString() + "," + color2.G.ToString() + "," + color2.B.ToString() + ")";
                color2label.ForeColor = color2;
            }
        }

        private void color3button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color3 = colorDialog.Color;
                color3label.Text = "Digit '3'  Color =  (" + color3.R.ToString() + "," + color3.G.ToString() + "," + color3.B.ToString() + ")";
                color3label.ForeColor = color3;
            }
        }

        private void color4button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color4 = colorDialog.Color;
                color4label.Text = "Digit '4'  Color =  (" + color4.R.ToString() + "," + color4.G.ToString() + "," + color4.B.ToString() + ")";
                color4label.ForeColor = color4;
            }
        }

        private void color5button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color5 = colorDialog.Color;
                color5label.Text = "Digit '5'  Color =  (" + color5.R.ToString() + "," + color5.G.ToString() + "," + color5.B.ToString() + ")";
                color5label.ForeColor = color5;
            }
        }

        private void color6button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color6 = colorDialog.Color;
                color6label.Text = "Digit '6'  Color =  (" + color6.R.ToString() + "," + color6.G.ToString() + "," + color6.B.ToString() + ")";
                color6label.ForeColor = color6;
            }
        }

        private void color7button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color7 = colorDialog.Color;
                color7label.Text = "Digit '7'  Color =  (" + color7.R.ToString() + "," + color7.G.ToString() + "," + color7.B.ToString() + ")";
                color7label.ForeColor = color7;
            }
        }

        private void color8button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color8 = colorDialog.Color;
                color8label.Text = "Digit '8'  Color =  (" + color8.R.ToString() + "," + color8.G.ToString() + "," + color8.B.ToString() + ")";
                color8label.ForeColor = color8;
            }
        }

        private void color9button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color9 = colorDialog.Color;
                color9label.Text = "Digit '9'  Color =  (" + color9.R.ToString() + "," + color9.G.ToString() + "," + color9.B.ToString() + ")";
                color9label.ForeColor = color9;
            }
        }

        private void colorAbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorA = colorDialog.Color;
                colorAlabel.Text = "Digit 'A'  Color =  (" + colorA.R.ToString() + "," + colorA.G.ToString() + "," + colorA.B.ToString() + ")";
                colorAlabel.ForeColor = colorA;
            }
        }

        private void colorBbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorB = colorDialog.Color;
                colorBlabel.Text = "Digit 'B'  Color =  (" + colorB.R.ToString() + "," + colorB.G.ToString() + "," + colorB.B.ToString() + ")";
                colorBlabel.ForeColor = colorB;
            }
        }

        private void colorCbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorC = colorDialog.Color;
                colorClabel.Text = "Digit 'C'  Color =  (" + colorC.R.ToString() + "," + colorC.G.ToString() + "," + colorC.B.ToString() + ")";
                colorClabel.ForeColor = colorC;
            }
        }

        private void colorDbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorD = colorDialog.Color;
                colorDlabel.Text = "Digit 'D'  Color =  (" + colorD.R.ToString() + "," + colorD.G.ToString() + "," + colorD.B.ToString() + ")";
                colorDlabel.ForeColor = colorD;
            }
        }

        private void colorEbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorE = colorDialog.Color;
                colorElabel.Text = "Digit 'E'  Color =  (" + colorE.R.ToString() + "," + colorE.G.ToString() + "," + colorE.B.ToString() + ")";
                colorElabel.ForeColor = colorE;
            }
        }

        private void colorFbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorF = colorDialog.Color;
                colorFlabel.Text = "Digit 'F'  Color =  (" + colorF.R.ToString() + "," + colorF.G.ToString() + "," + colorF.B.ToString() + ")";
                colorFlabel.ForeColor = colorF;
            }
        }

        private void colorQuestionbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                colorQuestion = colorDialog.Color;
                colorQuestionlabel.Text = "Digit '?'  Color =  (" + colorQuestion.R.ToString() + "," + colorQuestion.G.ToString() + "," + colorQuestion.B.ToString() + ")";
                colorQuestionlabel.ForeColor = colorQuestion;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressLabel.Text = e.ProgressPercentage+"% Completed";
        }




        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(
            int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled, Centered, Stretched
        }

        public void setWallpaper(string path, Style style)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);

            switch (style)
            {
                case Style.Stretched:
                    key.SetValue(@"WallpaperStyle", "2");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case Style.Centered:
                    key.SetValue(@"WallpaperStyle", "1");
                    key.SetValue(@"TileWallpaper", "0");
                    break;
                case Style.Tiled:
                    key.SetValue(@"WallpaperStyle", "1");
                    key.SetValue(@"TileWallpaper", "1");
                    break;
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }


    }
}