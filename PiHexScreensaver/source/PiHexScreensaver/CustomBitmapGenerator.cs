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
    public partial class CustomBitmapGenerator : Form
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
        private int xP = 0;
        private int yP = 0;

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;


        public CustomBitmapGenerator()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {



            Bitmap bmp = new Bitmap(xP, yP, System.Drawing.Imaging.PixelFormat.Format24bppRgb);//Manipulate image......


            string rawPi = PiHexSession.getPiFromSession();
            rawPi = rawPi.Substring(2, rawPi.Length - 2);


            int x = 0;
            int y = 0;

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

                if (x == xP)
                {
                    x = 0;
                    y++;
                    decimal rows = Math.Round((decimal)xP*yP / (decimal)xP);
                    decimal percent = Math.Round(((y) / rows) * 100);
                    backgroundWorker.ReportProgress((int)percent);
                }
                if (y == yP)
                {
                    break;
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
                errors = true;
            }
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressLabel.Text = e.ProgressPercentage + "% Completed";
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

        private void color0button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                color0 = colorDialog.Color;
                color0label.Text = "Digit '0'  Color =  (" + color0.R.ToString() + "," + color0.G.ToString() + "," + color0.B.ToString() + ")";
                color0label.ForeColor = color0;
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

        private void GenerateBitmapButton_Click(object sender, EventArgs e)
        {
            if (xP * yP == 0)
            {
                MessageBox.Show("Bitmap dimensions must be at least 1 pixel by 1 pixel.", "Invalid Bitmap Dimensions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
                        if(wallpaperComboBox.Text.Equals("Tiled")){setWallpaper(BasicBMPSaveFileDialog.FileName, Style.Tiled);}
                        if (wallpaperComboBox.Text.Equals("Centered")) { setWallpaper(BasicBMPSaveFileDialog.FileName, Style.Centered); }
                        if (wallpaperComboBox.Text.Equals("Stretched")) { setWallpaper(BasicBMPSaveFileDialog.FileName, Style.Stretched); }

                    }
                }


                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
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

        private void CustomBitmapGenerator_Load(object sender, EventArgs e)
        {
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;

            wallpaperComboBox.Text = "Tiled";
            wallpaperComboBox.Items.Add("Tiled");
            wallpaperComboBox.Items.Add("Centered");
            wallpaperComboBox.Items.Add("Stretched");

            string rawPi = PiHexSession.getPiFromSession();
            rawPi = rawPi.Substring(2, rawPi.Length - 2);
            actualPiLength = rawPi.Length;

            digitsCalculatedLabel.Text = "You have "+actualPiLength+" digits of Pi calculated.";

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

        private void xPixelsTextBox_KeyUp(object sender, KeyEventArgs e)
        {
           //0 * 0 = 0 digits required
            xP = 0;
            yP = 0;
            if (yPixelsTextBox.Text.Equals("") == true) { yP = 0; }
            else
            {
                try
                {
                    yP = Convert.ToInt32(yPixelsTextBox.Text);
                }
                catch
                {
                    //not a number
                }
            }

            
            //validate new number input
            try
            {
                xP = Convert.ToInt32(xPixelsTextBox.Text);
            }
            catch
            {
                //not a number
            }


            requiredDigitsLabel.Text = xP + " * "+yP+" = "+xP*yP+" digits required.";
            
        }

        private void yPixelsTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            xP = 0;
            yP = 0;
            if (xPixelsTextBox.Text.Equals("") == true) { xP = 0; }
            else
            {
                try
                {
                    xP = Convert.ToInt32(xPixelsTextBox.Text);
                }
                catch
                {
                    //not a number
                }
            }


            //validate new number input
            try
            {
                yP = Convert.ToInt32(yPixelsTextBox.Text);
            }
            catch
            {
                //not a number
            }


            requiredDigitsLabel.Text = xP + " * " + yP + " = " + xP * yP + " digits required.";
        }
        
    }
}