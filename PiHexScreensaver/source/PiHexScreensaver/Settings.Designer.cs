namespace PiHexScreensaver
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.enableLoggingCheckbox = new System.Windows.Forms.CheckBox();
            this.enableResumeCheckbox = new System.Windows.Forms.CheckBox();
            this.enableScrollingCheckbox = new System.Windows.Forms.CheckBox();
            this.weblinkLabel = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CalcProps = new System.Windows.Forms.Label();
            this.enableErrorCheckingCheckbox = new System.Windows.Forms.CheckBox();
            this.defautButton = new System.Windows.Forms.Button();
            this.CalcTimeComboBox = new System.Windows.Forms.ComboBox();
            this.TimeDisplayLabel = new System.Windows.Forms.Label();
            this.AdvancedOptionsButton = new System.Windows.Forms.Button();
            this.ExportSessionButton = new System.Windows.Forms.Button();
            this.ImportSessionButton = new System.Windows.Forms.Button();
            this.SessionPropertiesLabel = new System.Windows.Forms.Label();
            this.SettingsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SettingsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SettingsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AdvancedPropertiesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableLoggingCheckbox
            // 
            this.enableLoggingCheckbox.AutoSize = true;
            this.enableLoggingCheckbox.Location = new System.Drawing.Point(12, 36);
            this.enableLoggingCheckbox.Name = "enableLoggingCheckbox";
            this.enableLoggingCheckbox.Size = new System.Drawing.Size(308, 17);
            this.enableLoggingCheckbox.TabIndex = 3;
            this.enableLoggingCheckbox.Text = "Enable Logging (saves calculated Pi digits to a selected file)";
            this.enableLoggingCheckbox.UseVisualStyleBackColor = true;
            this.enableLoggingCheckbox.CheckedChanged += new System.EventHandler(this.enableLoggingCheckbox_CheckedChanged);
            // 
            // enableResumeCheckbox
            // 
            this.enableResumeCheckbox.AutoSize = true;
            this.enableResumeCheckbox.Location = new System.Drawing.Point(12, 102);
            this.enableResumeCheckbox.Name = "enableResumeCheckbox";
            this.enableResumeCheckbox.Size = new System.Drawing.Size(423, 17);
            this.enableResumeCheckbox.TabIndex = 4;
            this.enableResumeCheckbox.Text = "Enable Resume Calculation (resumes calculation of Pi from last screensaver sessio" +
                "n)";
            this.SettingsToolTip.SetToolTip(this.enableResumeCheckbox, "Resume Calculation requires Logging to be enabled  \r\nEnabling Resume Calculation " +
                    "enables the Advanced Options feature");
            this.enableResumeCheckbox.UseVisualStyleBackColor = true;
            this.enableResumeCheckbox.CheckedChanged += new System.EventHandler(this.enableResumeCheckbox_CheckedChanged);
            // 
            // enableScrollingCheckbox
            // 
            this.enableScrollingCheckbox.AutoSize = true;
            this.enableScrollingCheckbox.Location = new System.Drawing.Point(12, 189);
            this.enableScrollingCheckbox.Name = "enableScrollingCheckbox";
            this.enableScrollingCheckbox.Size = new System.Drawing.Size(412, 17);
            this.enableScrollingCheckbox.TabIndex = 5;
            this.enableScrollingCheckbox.Text = "Enable Pi Section Scrolling (displays the last 16 calculated hexidecimal digits o" +
                "f Pi)";
            this.enableScrollingCheckbox.UseVisualStyleBackColor = true;
            this.enableScrollingCheckbox.CheckedChanged += new System.EventHandler(this.enableScrollingCheckbox_CheckedChanged);
            // 
            // weblinkLabel
            // 
            this.weblinkLabel.AutoSize = true;
            this.weblinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weblinkLabel.Location = new System.Drawing.Point(9, 283);
            this.weblinkLabel.Name = "weblinkLabel";
            this.weblinkLabel.Size = new System.Drawing.Size(227, 13);
            this.weblinkLabel.TabIndex = 8;
            this.weblinkLabel.TabStop = true;
            this.weblinkLabel.Text = "View more projects at www.BenjaminsBox.com";
            this.weblinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblinkLabel_LinkClicked);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(267, 309);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logging Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Display Properties";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(343, 272);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.SettingsToolTip.SetToolTip(this.okButton, "Applies changes and exits");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(549, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CalcProps
            // 
            this.CalcProps.AutoSize = true;
            this.CalcProps.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcProps.Location = new System.Drawing.Point(7, 72);
            this.CalcProps.Name = "CalcProps";
            this.CalcProps.Size = new System.Drawing.Size(220, 27);
            this.CalcProps.TabIndex = 14;
            this.CalcProps.Text = "Calculation Properties";
            // 
            // enableErrorCheckingCheckbox
            // 
            this.enableErrorCheckingCheckbox.AutoSize = true;
            this.enableErrorCheckingCheckbox.Location = new System.Drawing.Point(12, 125);
            this.enableErrorCheckingCheckbox.Name = "enableErrorCheckingCheckbox";
            this.enableErrorCheckingCheckbox.Size = new System.Drawing.Size(351, 17);
            this.enableErrorCheckingCheckbox.TabIndex = 15;
            this.enableErrorCheckingCheckbox.Text = "Enable Error Checking (displays \'?\' for a digit that fails an error check)";
            this.enableErrorCheckingCheckbox.UseVisualStyleBackColor = true;
            this.enableErrorCheckingCheckbox.CheckedChanged += new System.EventHandler(this.enableErrorCheckingCheckbox_CheckedChanged);
            // 
            // defautButton
            // 
            this.defautButton.Location = new System.Drawing.Point(446, 189);
            this.defautButton.Name = "defautButton";
            this.defautButton.Size = new System.Drawing.Size(187, 23);
            this.defautButton.TabIndex = 16;
            this.defautButton.Text = "Restore Defaults";
            this.SettingsToolTip.SetToolTip(this.defautButton, "Resets all settings to default values");
            this.defautButton.UseVisualStyleBackColor = true;
            this.defautButton.Click += new System.EventHandler(this.defautButton_Click);
            // 
            // CalcTimeComboBox
            // 
            this.CalcTimeComboBox.FormattingEnabled = true;
            this.CalcTimeComboBox.Location = new System.Drawing.Point(12, 212);
            this.CalcTimeComboBox.Name = "CalcTimeComboBox";
            this.CalcTimeComboBox.Size = new System.Drawing.Size(192, 21);
            this.CalcTimeComboBox.TabIndex = 17;
            this.SettingsToolTip.SetToolTip(this.CalcTimeComboBox, "Calculation Time Display requires Logging to be enabled");
            this.CalcTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.CalcTimeComboBox_SelectedIndexChanged);
            // 
            // TimeDisplayLabel
            // 
            this.TimeDisplayLabel.AutoSize = true;
            this.TimeDisplayLabel.Location = new System.Drawing.Point(210, 215);
            this.TimeDisplayLabel.Name = "TimeDisplayLabel";
            this.TimeDisplayLabel.Size = new System.Drawing.Size(199, 13);
            this.TimeDisplayLabel.TabIndex = 18;
            this.TimeDisplayLabel.Text = "Total Calculation Time Display Properties";
            // 
            // AdvancedOptionsButton
            // 
            this.AdvancedOptionsButton.Location = new System.Drawing.Point(446, 218);
            this.AdvancedOptionsButton.Name = "AdvancedOptionsButton";
            this.AdvancedOptionsButton.Size = new System.Drawing.Size(187, 23);
            this.AdvancedOptionsButton.TabIndex = 19;
            this.AdvancedOptionsButton.Text = "Advanced Options";
            this.AdvancedOptionsButton.UseVisualStyleBackColor = true;
            this.AdvancedOptionsButton.Click += new System.EventHandler(this.AdvancedOptionsButton_Click);
            // 
            // ExportSessionButton
            // 
            this.ExportSessionButton.Location = new System.Drawing.Point(446, 39);
            this.ExportSessionButton.Name = "ExportSessionButton";
            this.ExportSessionButton.Size = new System.Drawing.Size(187, 23);
            this.ExportSessionButton.TabIndex = 20;
            this.ExportSessionButton.Text = "Export Session";
            this.ExportSessionButton.UseVisualStyleBackColor = true;
            this.ExportSessionButton.Click += new System.EventHandler(this.ExportSessionButton_Click);
            // 
            // ImportSessionButton
            // 
            this.ImportSessionButton.Location = new System.Drawing.Point(446, 68);
            this.ImportSessionButton.Name = "ImportSessionButton";
            this.ImportSessionButton.Size = new System.Drawing.Size(187, 23);
            this.ImportSessionButton.TabIndex = 21;
            this.ImportSessionButton.Text = "Import Session";
            this.ImportSessionButton.UseVisualStyleBackColor = true;
            this.ImportSessionButton.Click += new System.EventHandler(this.ImportSessionButton_Click);
            // 
            // SessionPropertiesLabel
            // 
            this.SessionPropertiesLabel.AutoSize = true;
            this.SessionPropertiesLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionPropertiesLabel.Location = new System.Drawing.Point(450, 9);
            this.SessionPropertiesLabel.Name = "SessionPropertiesLabel";
            this.SessionPropertiesLabel.Size = new System.Drawing.Size(183, 27);
            this.SessionPropertiesLabel.TabIndex = 22;
            this.SessionPropertiesLabel.Text = "Session Properties";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Enabled = false;
            this.ApplyButton.Location = new System.Drawing.Point(446, 272);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(97, 23);
            this.ApplyButton.TabIndex = 23;
            this.ApplyButton.Text = "Apply";
            this.SettingsToolTip.SetToolTip(this.ApplyButton, "Applies changes");
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SettingsSaveFileDialog
            // 
            this.SettingsSaveFileDialog.Filter = " XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.SettingsSaveFileDialog.Title = "Export Session";
            // 
            // SettingsOpenFileDialog
            // 
            this.SettingsOpenFileDialog.FileName = "openFileDialog1";
            this.SettingsOpenFileDialog.Filter = " XML files (*.xml)|*.xml";
            this.SettingsOpenFileDialog.Title = "Import Session";
            // 
            // AdvancedPropertiesLabel
            // 
            this.AdvancedPropertiesLabel.AutoSize = true;
            this.AdvancedPropertiesLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedPropertiesLabel.Location = new System.Drawing.Point(441, 159);
            this.AdvancedPropertiesLabel.Name = "AdvancedPropertiesLabel";
            this.AdvancedPropertiesLabel.Size = new System.Drawing.Size(206, 27);
            this.AdvancedPropertiesLabel.TabIndex = 24;
            this.AdvancedPropertiesLabel.Text = "Advanced Properties";
            // 
            // Settings
            // 
            this.AccessibleDescription = "PiSaverSettings";
            this.AccessibleName = "PiSaverSettings";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 307);
            this.Controls.Add(this.AdvancedPropertiesLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SessionPropertiesLabel);
            this.Controls.Add(this.ImportSessionButton);
            this.Controls.Add(this.ExportSessionButton);
            this.Controls.Add(this.AdvancedOptionsButton);
            this.Controls.Add(this.TimeDisplayLabel);
            this.Controls.Add(this.CalcTimeComboBox);
            this.Controls.Add(this.defautButton);
            this.Controls.Add(this.enableErrorCheckingCheckbox);
            this.Controls.Add(this.CalcProps);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.weblinkLabel);
            this.Controls.Add(this.enableScrollingCheckbox);
            this.Controls.Add(this.enableResumeCheckbox);
            this.Controls.Add(this.enableLoggingCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableLoggingCheckbox;
        private System.Windows.Forms.CheckBox enableResumeCheckbox;
        private System.Windows.Forms.CheckBox enableScrollingCheckbox;
        private System.Windows.Forms.LinkLabel weblinkLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label CalcProps;
        private System.Windows.Forms.CheckBox enableErrorCheckingCheckbox;
        private System.Windows.Forms.Button defautButton;
        private System.Windows.Forms.ComboBox CalcTimeComboBox;
        private System.Windows.Forms.Label TimeDisplayLabel;
        private System.Windows.Forms.Button AdvancedOptionsButton;
        private System.Windows.Forms.Button ExportSessionButton;
        private System.Windows.Forms.Button ImportSessionButton;
        private System.Windows.Forms.Label SessionPropertiesLabel;
        private System.Windows.Forms.ToolTip SettingsToolTip;
        private System.Windows.Forms.SaveFileDialog SettingsSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog SettingsOpenFileDialog;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label AdvancedPropertiesLabel;
    }
}