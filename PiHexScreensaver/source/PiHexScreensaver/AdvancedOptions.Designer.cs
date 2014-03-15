namespace PiHexScreensaver
{
    partial class AdvancedOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedOptions));
            this.CreateCustomPiBitmapButton = new System.Windows.Forms.Button();
            this.CreatePiBitmapButton = new System.Windows.Forms.Button();
            this.SavePiDigitsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PiSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // CreateCustomPiBitmapButton
            // 
            this.CreateCustomPiBitmapButton.Location = new System.Drawing.Point(12, 126);
            this.CreateCustomPiBitmapButton.Name = "CreateCustomPiBitmapButton";
            this.CreateCustomPiBitmapButton.Size = new System.Drawing.Size(401, 23);
            this.CreateCustomPiBitmapButton.TabIndex = 2;
            this.CreateCustomPiBitmapButton.Text = "Create Custom Pi Bitmap Analysis";
            this.CreateCustomPiBitmapButton.UseVisualStyleBackColor = true;
            this.CreateCustomPiBitmapButton.Click += new System.EventHandler(this.CreateCustomPiBitmapButton_Click);
            // 
            // CreatePiBitmapButton
            // 
            this.CreatePiBitmapButton.Location = new System.Drawing.Point(12, 97);
            this.CreatePiBitmapButton.Name = "CreatePiBitmapButton";
            this.CreatePiBitmapButton.Size = new System.Drawing.Size(401, 23);
            this.CreatePiBitmapButton.TabIndex = 3;
            this.CreatePiBitmapButton.Text = "Create Pi Bitmap Analysis";
            this.CreatePiBitmapButton.UseVisualStyleBackColor = true;
            this.CreatePiBitmapButton.Click += new System.EventHandler(this.CreatePiBitmapButton_Click);
            // 
            // SavePiDigitsButton
            // 
            this.SavePiDigitsButton.Location = new System.Drawing.Point(12, 44);
            this.SavePiDigitsButton.Name = "SavePiDigitsButton";
            this.SavePiDigitsButton.Size = new System.Drawing.Size(401, 23);
            this.SavePiDigitsButton.TabIndex = 5;
            this.SavePiDigitsButton.Text = "Save Calculated Pi Digits";
            this.SavePiDigitsButton.UseVisualStyleBackColor = true;
            this.SavePiDigitsButton.Click += new System.EventHandler(this.SavePiDigitsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(254, 201);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit Advanced Options";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PiSaveFileDialog
            // 
            this.PiSaveFileDialog.Filter = " Rich Text files (*.rtf)|*.rtf|All files (*.*)|*.*";
            // 
            // AdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 236);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavePiDigitsButton);
            this.Controls.Add(this.CreatePiBitmapButton);
            this.Controls.Add(this.CreateCustomPiBitmapButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomPiBitmapButton;
        private System.Windows.Forms.Button CreatePiBitmapButton;
        private System.Windows.Forms.Button SavePiDigitsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.SaveFileDialog PiSaveFileDialog;
    }
}