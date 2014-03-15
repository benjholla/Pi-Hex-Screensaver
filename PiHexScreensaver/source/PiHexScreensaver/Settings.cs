using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PiHexScreensaver;

namespace PiHexScreensaver
{
    public partial class Settings : Form
    {

        private bool changesApplied = true;

        public Settings()
        {
            InitializeComponent();
        }

        private void weblinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                System.Diagnostics.Process.Start("www.benjaminsbox.com"); 
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            PiHexSession.enableLogging(enableLoggingCheckbox.Checked);
            PiHexSession.enableResumeCalculation(enableResumeCheckbox.Checked);
            PiHexSession.enableErrorChecking(enableErrorCheckingCheckbox.Checked);
            PiHexSession.enableScrolling(enableScrollingCheckbox.Checked);
            PiHexSession.setTimeDisplayMode(CalcTimeComboBox.Text);

            PiHexSession.saveSession();

            this.Close();
            System.Environment.Exit(0);
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }



        private void enableResumeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
            changesApplied = false;
            if (enableLoggingCheckbox.Checked == false && enableResumeCheckbox.Checked == true) { enableResumeCheckbox.Checked = false; }
            if (enableLoggingCheckbox.Checked == false || enableResumeCheckbox.Checked == false) { AdvancedOptionsButton.Enabled = false; }
            if (enableLoggingCheckbox.Checked == true && enableResumeCheckbox.Checked == true) { AdvancedOptionsButton.Enabled = true; }
        }

        private void enableLoggingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
            changesApplied = false;
            if (enableLoggingCheckbox.Checked == true)
            {
                if (!(CalcTimeComboBox.Items.Contains("Days"))) { CalcTimeComboBox.Items.Add("Days"); }
                if (!(CalcTimeComboBox.Items.Contains("Hours"))) { CalcTimeComboBox.Items.Add("Hours"); }
                if (!(CalcTimeComboBox.Items.Contains("Minutes"))) { CalcTimeComboBox.Items.Add("Minutes"); }
                if (!(CalcTimeComboBox.Items.Contains("Day/Hour/Min/Sec/Ms"))) { CalcTimeComboBox.Items.Add("Day/Hour/Min/Sec/Ms"); }
            }
            if (enableLoggingCheckbox.Checked == false)
            {
                enableResumeCheckbox.Checked = false;
                CalcTimeComboBox.Text = "No Display";
                if (CalcTimeComboBox.Items.Contains("Days")) { CalcTimeComboBox.Items.Remove("Days"); }
                if (CalcTimeComboBox.Items.Contains("Hours")) { CalcTimeComboBox.Items.Remove("Hours"); }
                if (CalcTimeComboBox.Items.Contains("Minutes")) { CalcTimeComboBox.Items.Remove("Minutes"); }
                if (CalcTimeComboBox.Items.Contains("Day/Hour/Min/Sec/Ms")) { CalcTimeComboBox.Items.Remove("Day/Hour/Min/Sec/Ms"); }

            }

            if (enableLoggingCheckbox.Checked == false || enableResumeCheckbox.Checked==false) { AdvancedOptionsButton.Enabled = false; }
            if (enableLoggingCheckbox.Checked == true && enableResumeCheckbox.Checked == true) { AdvancedOptionsButton.Enabled = true; }
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            PiHexSession.restoreSession();

            if (enableLoggingCheckbox.Checked == true)
            {
                if (!(CalcTimeComboBox.Items.Contains("Days"))) { CalcTimeComboBox.Items.Add("Days"); }
                if (!(CalcTimeComboBox.Items.Contains("Hours"))) { CalcTimeComboBox.Items.Add("Hours"); }
                if (!(CalcTimeComboBox.Items.Contains("Minutes"))) { CalcTimeComboBox.Items.Add("Minutes"); }
                if (!(CalcTimeComboBox.Items.Contains("Day/Hour/Min/Sec/Ms"))) { CalcTimeComboBox.Items.Add("Day/Hour/Min/Sec/Ms"); }
            }
            if (enableLoggingCheckbox.Checked == false)
            {
                enableResumeCheckbox.Checked = false;
                CalcTimeComboBox.Text = "No Display";
                if (!(CalcTimeComboBox.Items.Contains("No Display"))) { CalcTimeComboBox.Items.Add("No Display"); }
                if (CalcTimeComboBox.Items.Contains("Days")) { CalcTimeComboBox.Items.Remove("Days"); }
                if (CalcTimeComboBox.Items.Contains("Hours")) { CalcTimeComboBox.Items.Remove("Hours"); }
                if (CalcTimeComboBox.Items.Contains("Minutes")) { CalcTimeComboBox.Items.Remove("Minutes"); }
                if (CalcTimeComboBox.Items.Contains("Day/Hour/Min/Sec/Ms")) { CalcTimeComboBox.Items.Remove("Day/Hour/Min/Sec/Ms"); }

            }

            refresh();
            ApplyButton.Enabled = false;
            changesApplied = true;
        }


        private void refresh()
        {
            CalcTimeComboBox.Text = PiHexSession.getTimeDisplayMode();
            enableLoggingCheckbox.Checked = PiHexSession.isLogging();
            enableResumeCheckbox.Checked = PiHexSession.isResumeCalc();
            enableErrorCheckingCheckbox.Checked = PiHexSession.isErrorChecking();
            enableScrollingCheckbox.Checked = PiHexSession.isScrolling();
        }

        private void CalcTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
            changesApplied = false;
            PiHexSession.setTimeDisplayMode(CalcTimeComboBox.Text);
        }

        private void defautButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you would like to reset all properties to default values?  All information including current Pi calculations will be lost in the process.",
                "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
            PiHexSession.createEmptyXMLSession();
            PiHexSession.restoreSession();
            CalcTimeComboBox.Text = PiHexSession.getTimeDisplayMode();
            enableLoggingCheckbox.Checked = PiHexSession.isLogging();
            enableResumeCheckbox.Checked = PiHexSession.isResumeCalc();
            enableErrorCheckingCheckbox.Checked = PiHexSession.isErrorChecking();
            enableScrollingCheckbox.Checked = PiHexSession.isScrolling();
            }
        }

        private void AdvancedOptionsButton_Click(object sender, EventArgs e)
        {
            if (changesApplied == false)
            {
                MessageBox.Show("All changes must be applied before continuing.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AdvancedOptions options = new AdvancedOptions();
                options.ShowDialog();
            }
        }

        private void ExportSessionButton_Click(object sender, EventArgs e)
        {
            if (SettingsSaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                PiHexSession.enableLogging(enableLoggingCheckbox.Checked);
                PiHexSession.enableResumeCalculation(enableResumeCheckbox.Checked);
                PiHexSession.enableErrorChecking(enableErrorCheckingCheckbox.Checked);
                PiHexSession.enableScrolling(enableScrollingCheckbox.Checked);
                PiHexSession.setTimeDisplayMode(CalcTimeComboBox.Text);
                PiHexSession.saveSession();
                PiHexSession.saveSessionCopy(SettingsSaveFileDialog.FileName);
            }
        }

        private void ImportSessionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you would like to import new session properties?  All information including current Pi calculations will be overwritten in the process.",
                "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (SettingsOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    PiHexSession.loadSession(SettingsOpenFileDialog.FileName);
                    refresh();
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            PiHexSession.enableLogging(enableLoggingCheckbox.Checked);
            PiHexSession.enableResumeCalculation(enableResumeCheckbox.Checked);
            PiHexSession.enableErrorChecking(enableErrorCheckingCheckbox.Checked);
            PiHexSession.enableScrolling(enableScrollingCheckbox.Checked);
            PiHexSession.setTimeDisplayMode(CalcTimeComboBox.Text);

            PiHexSession.saveSession();

            ApplyButton.Enabled = false;
            changesApplied = true;
        }

        private void enableErrorCheckingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
            changesApplied = false;
        }

        private void enableScrollingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
            changesApplied = false;
        }








    }
}