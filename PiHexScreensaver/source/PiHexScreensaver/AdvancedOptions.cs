using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PiHexScreensaver
{
    public partial class AdvancedOptions : Form
    {
        public AdvancedOptions()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavePiDigitsButton_Click(object sender, EventArgs e)
        {
            if (PiSaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                StreamWriter SW = File.CreateText(PiSaveFileDialog.FileName);
                
                string rawPi = PiHexSession.getPiFromSession();
                rawPi = rawPi.Substring(2, rawPi.Length - 2);

                
                SW.WriteLine("\nPiHexScreensaver created by Ben Holland. \n\n\n"+
                    "----------------------------------------------------------------------");
                SW.WriteLine("Pi Calculated to " + PiHexSession.getCurrentDigit() + " digits in hexadecimal.");
                SW.WriteLine("This file was created by the PiHexScreensaver on " + DateTime.Today.Date.ToString());
                SW.WriteLine("----------------------------------------------------------------------\n");

                SW.Write("3.\n");

                int spaces = 0;
                int returns = 0;

                foreach (char x in rawPi)
                {
                    if (spaces == 10) { SW.Write("  "); spaces=0;}
                    if (returns == 50) { SW.Write("\n"); returns = 0; }
                    SW.Write(x);

                    spaces++;
                    returns++;
                }

                SW.Close();
            }

        }

        private void CreatePiBitmapButton_Click(object sender, EventArgs e)
        {

            BasicBitmapGenerator genBMP = new BasicBitmapGenerator();
            genBMP.ShowDialog();

        }

        private void CreateCustomPiBitmapButton_Click(object sender, EventArgs e)
        {
            CustomBitmapGenerator genBMP = new CustomBitmapGenerator();
            genBMP.ShowDialog();
        }

    }
}