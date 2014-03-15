namespace PiHexScreensaver
{
    partial class CustomBitmapGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomBitmapGenerator));
            this.wallpaperCheckBox = new System.Windows.Forms.CheckBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExitButton = new System.Windows.Forms.Button();
            this.colorQuestionbutton = new System.Windows.Forms.Button();
            this.colorQuestionlabel = new System.Windows.Forms.Label();
            this.colorFbutton = new System.Windows.Forms.Button();
            this.colorFlabel = new System.Windows.Forms.Label();
            this.colorEbutton = new System.Windows.Forms.Button();
            this.colorElabel = new System.Windows.Forms.Label();
            this.colorDbutton = new System.Windows.Forms.Button();
            this.colorDlabel = new System.Windows.Forms.Label();
            this.colorCbutton = new System.Windows.Forms.Button();
            this.colorClabel = new System.Windows.Forms.Label();
            this.colorBbutton = new System.Windows.Forms.Button();
            this.colorBlabel = new System.Windows.Forms.Label();
            this.colorAbutton = new System.Windows.Forms.Button();
            this.colorAlabel = new System.Windows.Forms.Label();
            this.color9button = new System.Windows.Forms.Button();
            this.color9label = new System.Windows.Forms.Label();
            this.color8button = new System.Windows.Forms.Button();
            this.color8label = new System.Windows.Forms.Label();
            this.color7button = new System.Windows.Forms.Button();
            this.color7label = new System.Windows.Forms.Label();
            this.color6button = new System.Windows.Forms.Button();
            this.color6label = new System.Windows.Forms.Label();
            this.color5button = new System.Windows.Forms.Button();
            this.color5label = new System.Windows.Forms.Label();
            this.color4button = new System.Windows.Forms.Button();
            this.color4label = new System.Windows.Forms.Label();
            this.color3button = new System.Windows.Forms.Button();
            this.color3label = new System.Windows.Forms.Label();
            this.color2button = new System.Windows.Forms.Button();
            this.color2label = new System.Windows.Forms.Label();
            this.color1button = new System.Windows.Forms.Button();
            this.color1label = new System.Windows.Forms.Label();
            this.color0button = new System.Windows.Forms.Button();
            this.GenerateBitmapButton = new System.Windows.Forms.Button();
            this.color0label = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.BasicBMPSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.wallpaperComboBox = new System.Windows.Forms.ComboBox();
            this.xPixelsLabel = new System.Windows.Forms.Label();
            this.xPixelsTextBox = new System.Windows.Forms.TextBox();
            this.yPixelsTextBox = new System.Windows.Forms.TextBox();
            this.yPixelsLabel = new System.Windows.Forms.Label();
            this.requiredDigitsLabel = new System.Windows.Forms.Label();
            this.digitsCalculatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallpaperCheckBox
            // 
            this.wallpaperCheckBox.AutoSize = true;
            this.wallpaperCheckBox.Location = new System.Drawing.Point(310, 30);
            this.wallpaperCheckBox.Name = "wallpaperCheckBox";
            this.wallpaperCheckBox.Size = new System.Drawing.Size(213, 17);
            this.wallpaperCheckBox.TabIndex = 112;
            this.wallpaperCheckBox.Text = "Set as desktop wallpaper when finished";
            this.wallpaperCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(326, 424);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(74, 13);
            this.progressLabel.TabIndex = 111;
            this.progressLabel.Text = "0% Completed";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(329, 386);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 33);
            this.progressBar1.TabIndex = 110;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(513, 454);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 38);
            this.ExitButton.TabIndex = 109;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // colorQuestionbutton
            // 
            this.colorQuestionbutton.Location = new System.Drawing.Point(329, 347);
            this.colorQuestionbutton.Name = "colorQuestionbutton";
            this.colorQuestionbutton.Size = new System.Drawing.Size(110, 23);
            this.colorQuestionbutton.TabIndex = 108;
            this.colorQuestionbutton.Text = "Select \'?\' Color";
            this.colorQuestionbutton.UseVisualStyleBackColor = true;
            this.colorQuestionbutton.Click += new System.EventHandler(this.colorQuestionbutton_Click);
            // 
            // colorQuestionlabel
            // 
            this.colorQuestionlabel.AutoSize = true;
            this.colorQuestionlabel.Location = new System.Drawing.Point(445, 352);
            this.colorQuestionlabel.Name = "colorQuestionlabel";
            this.colorQuestionlabel.Size = new System.Drawing.Size(116, 13);
            this.colorQuestionlabel.TabIndex = 107;
            this.colorQuestionlabel.Text = "Digit \'?\'  Color =  (0,0,0)";
            // 
            // colorFbutton
            // 
            this.colorFbutton.Location = new System.Drawing.Point(329, 309);
            this.colorFbutton.Name = "colorFbutton";
            this.colorFbutton.Size = new System.Drawing.Size(110, 23);
            this.colorFbutton.TabIndex = 106;
            this.colorFbutton.Text = "Select \'F\' Color";
            this.colorFbutton.UseVisualStyleBackColor = true;
            this.colorFbutton.Click += new System.EventHandler(this.colorFbutton_Click);
            // 
            // colorFlabel
            // 
            this.colorFlabel.AutoSize = true;
            this.colorFlabel.Location = new System.Drawing.Point(445, 314);
            this.colorFlabel.Name = "colorFlabel";
            this.colorFlabel.Size = new System.Drawing.Size(116, 13);
            this.colorFlabel.TabIndex = 105;
            this.colorFlabel.Text = "Digit \'F\'  Color =  (0,0,0)";
            // 
            // colorEbutton
            // 
            this.colorEbutton.Location = new System.Drawing.Point(329, 273);
            this.colorEbutton.Name = "colorEbutton";
            this.colorEbutton.Size = new System.Drawing.Size(110, 23);
            this.colorEbutton.TabIndex = 104;
            this.colorEbutton.Text = "Select \'E\' Color";
            this.colorEbutton.UseVisualStyleBackColor = true;
            this.colorEbutton.Click += new System.EventHandler(this.colorEbutton_Click);
            // 
            // colorElabel
            // 
            this.colorElabel.AutoSize = true;
            this.colorElabel.Location = new System.Drawing.Point(445, 278);
            this.colorElabel.Name = "colorElabel";
            this.colorElabel.Size = new System.Drawing.Size(117, 13);
            this.colorElabel.TabIndex = 103;
            this.colorElabel.Text = "Digit \'E\'  Color =  (0,0,0)";
            // 
            // colorDbutton
            // 
            this.colorDbutton.Location = new System.Drawing.Point(329, 236);
            this.colorDbutton.Name = "colorDbutton";
            this.colorDbutton.Size = new System.Drawing.Size(110, 23);
            this.colorDbutton.TabIndex = 102;
            this.colorDbutton.Text = "Select \'D\' Color";
            this.colorDbutton.UseVisualStyleBackColor = true;
            this.colorDbutton.Click += new System.EventHandler(this.colorDbutton_Click);
            // 
            // colorDlabel
            // 
            this.colorDlabel.AutoSize = true;
            this.colorDlabel.Location = new System.Drawing.Point(445, 241);
            this.colorDlabel.Name = "colorDlabel";
            this.colorDlabel.Size = new System.Drawing.Size(118, 13);
            this.colorDlabel.TabIndex = 101;
            this.colorDlabel.Text = "Digit \'D\'  Color =  (0,0,0)";
            // 
            // colorCbutton
            // 
            this.colorCbutton.Location = new System.Drawing.Point(329, 200);
            this.colorCbutton.Name = "colorCbutton";
            this.colorCbutton.Size = new System.Drawing.Size(110, 23);
            this.colorCbutton.TabIndex = 100;
            this.colorCbutton.Text = "Select \'C\' Color";
            this.colorCbutton.UseVisualStyleBackColor = true;
            this.colorCbutton.Click += new System.EventHandler(this.colorCbutton_Click);
            // 
            // colorClabel
            // 
            this.colorClabel.AutoSize = true;
            this.colorClabel.Location = new System.Drawing.Point(445, 205);
            this.colorClabel.Name = "colorClabel";
            this.colorClabel.Size = new System.Drawing.Size(117, 13);
            this.colorClabel.TabIndex = 99;
            this.colorClabel.Text = "Digit \'C\'  Color =  (0,0,0)";
            // 
            // colorBbutton
            // 
            this.colorBbutton.Location = new System.Drawing.Point(329, 161);
            this.colorBbutton.Name = "colorBbutton";
            this.colorBbutton.Size = new System.Drawing.Size(110, 23);
            this.colorBbutton.TabIndex = 98;
            this.colorBbutton.Text = "Select \'B\' Color";
            this.colorBbutton.UseVisualStyleBackColor = true;
            this.colorBbutton.Click += new System.EventHandler(this.colorBbutton_Click);
            // 
            // colorBlabel
            // 
            this.colorBlabel.AutoSize = true;
            this.colorBlabel.Location = new System.Drawing.Point(445, 166);
            this.colorBlabel.Name = "colorBlabel";
            this.colorBlabel.Size = new System.Drawing.Size(117, 13);
            this.colorBlabel.TabIndex = 97;
            this.colorBlabel.Text = "Digit \'B\'  Color =  (0,0,0)";
            // 
            // colorAbutton
            // 
            this.colorAbutton.Location = new System.Drawing.Point(329, 122);
            this.colorAbutton.Name = "colorAbutton";
            this.colorAbutton.Size = new System.Drawing.Size(110, 23);
            this.colorAbutton.TabIndex = 96;
            this.colorAbutton.Text = "Select \'A\' Color";
            this.colorAbutton.UseVisualStyleBackColor = true;
            this.colorAbutton.Click += new System.EventHandler(this.colorAbutton_Click);
            // 
            // colorAlabel
            // 
            this.colorAlabel.AutoSize = true;
            this.colorAlabel.Location = new System.Drawing.Point(445, 127);
            this.colorAlabel.Name = "colorAlabel";
            this.colorAlabel.Size = new System.Drawing.Size(117, 13);
            this.colorAlabel.TabIndex = 95;
            this.colorAlabel.Text = "Digit \'A\'  Color =  (0,0,0)";
            // 
            // color9button
            // 
            this.color9button.Location = new System.Drawing.Point(27, 454);
            this.color9button.Name = "color9button";
            this.color9button.Size = new System.Drawing.Size(110, 23);
            this.color9button.TabIndex = 94;
            this.color9button.Text = "Select \'9\' Color";
            this.color9button.UseVisualStyleBackColor = true;
            this.color9button.Click += new System.EventHandler(this.color9button_Click);
            // 
            // color9label
            // 
            this.color9label.AutoSize = true;
            this.color9label.Location = new System.Drawing.Point(143, 459);
            this.color9label.Name = "color9label";
            this.color9label.Size = new System.Drawing.Size(116, 13);
            this.color9label.TabIndex = 93;
            this.color9label.Text = "Digit \'9\'  Color =  (0,0,0)";
            // 
            // color8button
            // 
            this.color8button.Location = new System.Drawing.Point(27, 417);
            this.color8button.Name = "color8button";
            this.color8button.Size = new System.Drawing.Size(110, 23);
            this.color8button.TabIndex = 92;
            this.color8button.Text = "Select \'8 Color";
            this.color8button.UseVisualStyleBackColor = true;
            this.color8button.Click += new System.EventHandler(this.color8button_Click);
            // 
            // color8label
            // 
            this.color8label.AutoSize = true;
            this.color8label.Location = new System.Drawing.Point(143, 422);
            this.color8label.Name = "color8label";
            this.color8label.Size = new System.Drawing.Size(116, 13);
            this.color8label.TabIndex = 91;
            this.color8label.Text = "Digit \'8\'  Color =  (0,0,0)";
            // 
            // color7button
            // 
            this.color7button.Location = new System.Drawing.Point(27, 381);
            this.color7button.Name = "color7button";
            this.color7button.Size = new System.Drawing.Size(110, 23);
            this.color7button.TabIndex = 90;
            this.color7button.Text = "Select \'7\' Color";
            this.color7button.UseVisualStyleBackColor = true;
            this.color7button.Click += new System.EventHandler(this.color7button_Click);
            // 
            // color7label
            // 
            this.color7label.AutoSize = true;
            this.color7label.Location = new System.Drawing.Point(143, 386);
            this.color7label.Name = "color7label";
            this.color7label.Size = new System.Drawing.Size(116, 13);
            this.color7label.TabIndex = 89;
            this.color7label.Text = "Digit \'7\'  Color =  (0,0,0)";
            // 
            // color6button
            // 
            this.color6button.Location = new System.Drawing.Point(27, 342);
            this.color6button.Name = "color6button";
            this.color6button.Size = new System.Drawing.Size(110, 23);
            this.color6button.TabIndex = 88;
            this.color6button.Text = "Select \'6\' Color";
            this.color6button.UseVisualStyleBackColor = true;
            this.color6button.Click += new System.EventHandler(this.color6button_Click);
            // 
            // color6label
            // 
            this.color6label.AutoSize = true;
            this.color6label.Location = new System.Drawing.Point(143, 347);
            this.color6label.Name = "color6label";
            this.color6label.Size = new System.Drawing.Size(116, 13);
            this.color6label.TabIndex = 87;
            this.color6label.Text = "Digit \'6\'  Color =  (0,0,0)";
            // 
            // color5button
            // 
            this.color5button.Location = new System.Drawing.Point(27, 304);
            this.color5button.Name = "color5button";
            this.color5button.Size = new System.Drawing.Size(110, 23);
            this.color5button.TabIndex = 86;
            this.color5button.Text = "Select \'5\' Color";
            this.color5button.UseVisualStyleBackColor = true;
            this.color5button.Click += new System.EventHandler(this.color5button_Click);
            // 
            // color5label
            // 
            this.color5label.AutoSize = true;
            this.color5label.Location = new System.Drawing.Point(143, 309);
            this.color5label.Name = "color5label";
            this.color5label.Size = new System.Drawing.Size(116, 13);
            this.color5label.TabIndex = 85;
            this.color5label.Text = "Digit \'5\'  Color =  (0,0,0)";
            // 
            // color4button
            // 
            this.color4button.Location = new System.Drawing.Point(27, 268);
            this.color4button.Name = "color4button";
            this.color4button.Size = new System.Drawing.Size(110, 23);
            this.color4button.TabIndex = 84;
            this.color4button.Text = "Select \'4\' Color";
            this.color4button.UseVisualStyleBackColor = true;
            this.color4button.Click += new System.EventHandler(this.color4button_Click);
            // 
            // color4label
            // 
            this.color4label.AutoSize = true;
            this.color4label.Location = new System.Drawing.Point(143, 273);
            this.color4label.Name = "color4label";
            this.color4label.Size = new System.Drawing.Size(116, 13);
            this.color4label.TabIndex = 83;
            this.color4label.Text = "Digit \'4\'  Color =  (0,0,0)";
            // 
            // color3button
            // 
            this.color3button.Location = new System.Drawing.Point(27, 231);
            this.color3button.Name = "color3button";
            this.color3button.Size = new System.Drawing.Size(110, 23);
            this.color3button.TabIndex = 82;
            this.color3button.Text = "Select \'3 Color";
            this.color3button.UseVisualStyleBackColor = true;
            this.color3button.Click += new System.EventHandler(this.color3button_Click);
            // 
            // color3label
            // 
            this.color3label.AutoSize = true;
            this.color3label.Location = new System.Drawing.Point(143, 236);
            this.color3label.Name = "color3label";
            this.color3label.Size = new System.Drawing.Size(116, 13);
            this.color3label.TabIndex = 81;
            this.color3label.Text = "Digit \'3\'  Color =  (0,0,0)";
            // 
            // color2button
            // 
            this.color2button.Location = new System.Drawing.Point(27, 195);
            this.color2button.Name = "color2button";
            this.color2button.Size = new System.Drawing.Size(110, 23);
            this.color2button.TabIndex = 80;
            this.color2button.Text = "Select \'2\' Color";
            this.color2button.UseVisualStyleBackColor = true;
            this.color2button.Click += new System.EventHandler(this.color2button_Click);
            // 
            // color2label
            // 
            this.color2label.AutoSize = true;
            this.color2label.Location = new System.Drawing.Point(143, 200);
            this.color2label.Name = "color2label";
            this.color2label.Size = new System.Drawing.Size(116, 13);
            this.color2label.TabIndex = 79;
            this.color2label.Text = "Digit \'2\'  Color =  (0,0,0)";
            // 
            // color1button
            // 
            this.color1button.Location = new System.Drawing.Point(27, 156);
            this.color1button.Name = "color1button";
            this.color1button.Size = new System.Drawing.Size(110, 23);
            this.color1button.TabIndex = 78;
            this.color1button.Text = "Select \'1\' Color";
            this.color1button.UseVisualStyleBackColor = true;
            this.color1button.Click += new System.EventHandler(this.color1button_Click);
            // 
            // color1label
            // 
            this.color1label.AutoSize = true;
            this.color1label.Location = new System.Drawing.Point(143, 161);
            this.color1label.Name = "color1label";
            this.color1label.Size = new System.Drawing.Size(116, 13);
            this.color1label.TabIndex = 77;
            this.color1label.Text = "Digit \'1\'  Color =  (0,0,0)";
            // 
            // color0button
            // 
            this.color0button.Location = new System.Drawing.Point(27, 117);
            this.color0button.Name = "color0button";
            this.color0button.Size = new System.Drawing.Size(110, 23);
            this.color0button.TabIndex = 76;
            this.color0button.Text = "Select \'0\' Color";
            this.color0button.UseVisualStyleBackColor = true;
            this.color0button.Click += new System.EventHandler(this.color0button_Click);
            // 
            // GenerateBitmapButton
            // 
            this.GenerateBitmapButton.Location = new System.Drawing.Point(329, 454);
            this.GenerateBitmapButton.Name = "GenerateBitmapButton";
            this.GenerateBitmapButton.Size = new System.Drawing.Size(178, 38);
            this.GenerateBitmapButton.TabIndex = 75;
            this.GenerateBitmapButton.Text = "Generate Bitmap";
            this.GenerateBitmapButton.UseVisualStyleBackColor = true;
            this.GenerateBitmapButton.Click += new System.EventHandler(this.GenerateBitmapButton_Click);
            // 
            // color0label
            // 
            this.color0label.AutoSize = true;
            this.color0label.Location = new System.Drawing.Point(143, 122);
            this.color0label.Name = "color0label";
            this.color0label.Size = new System.Drawing.Size(116, 13);
            this.color0label.TabIndex = 74;
            this.color0label.Text = "Digit \'0\'  Color =  (0,0,0)";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // BasicBMPSaveFileDialog
            // 
            this.BasicBMPSaveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // wallpaperComboBox
            // 
            this.wallpaperComboBox.FormattingEnabled = true;
            this.wallpaperComboBox.Location = new System.Drawing.Point(310, 54);
            this.wallpaperComboBox.Name = "wallpaperComboBox";
            this.wallpaperComboBox.Size = new System.Drawing.Size(201, 21);
            this.wallpaperComboBox.TabIndex = 113;
            // 
            // xPixelsLabel
            // 
            this.xPixelsLabel.AutoSize = true;
            this.xPixelsLabel.Location = new System.Drawing.Point(24, 31);
            this.xPixelsLabel.Name = "xPixelsLabel";
            this.xPixelsLabel.Size = new System.Drawing.Size(147, 13);
            this.xPixelsLabel.TabIndex = 114;
            this.xPixelsLabel.Text = "Enter width of Bitmap in pixels";
            // 
            // xPixelsTextBox
            // 
            this.xPixelsTextBox.Location = new System.Drawing.Point(181, 28);
            this.xPixelsTextBox.Name = "xPixelsTextBox";
            this.xPixelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.xPixelsTextBox.TabIndex = 115;
            this.xPixelsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.xPixelsTextBox_KeyUp);
            // 
            // yPixelsTextBox
            // 
            this.yPixelsTextBox.Location = new System.Drawing.Point(181, 54);
            this.yPixelsTextBox.Name = "yPixelsTextBox";
            this.yPixelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yPixelsTextBox.TabIndex = 116;
            this.yPixelsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.yPixelsTextBox_KeyUp);
            // 
            // yPixelsLabel
            // 
            this.yPixelsLabel.AutoSize = true;
            this.yPixelsLabel.Location = new System.Drawing.Point(24, 58);
            this.yPixelsLabel.Name = "yPixelsLabel";
            this.yPixelsLabel.Size = new System.Drawing.Size(151, 13);
            this.yPixelsLabel.TabIndex = 117;
            this.yPixelsLabel.Text = "Enter hieght of Bitmap in pixels";
            // 
            // requiredDigitsLabel
            // 
            this.requiredDigitsLabel.AutoSize = true;
            this.requiredDigitsLabel.Location = new System.Drawing.Point(24, 84);
            this.requiredDigitsLabel.Name = "requiredDigitsLabel";
            this.requiredDigitsLabel.Size = new System.Drawing.Size(118, 13);
            this.requiredDigitsLabel.TabIndex = 118;
            this.requiredDigitsLabel.Text = "0 * 0 = 0 digits required.";
            // 
            // digitsCalculatedLabel
            // 
            this.digitsCalculatedLabel.AutoSize = true;
            this.digitsCalculatedLabel.Location = new System.Drawing.Point(24, 9);
            this.digitsCalculatedLabel.Name = "digitsCalculatedLabel";
            this.digitsCalculatedLabel.Size = new System.Drawing.Size(168, 13);
            this.digitsCalculatedLabel.TabIndex = 119;
            this.digitsCalculatedLabel.Text = "You have 0 digits of Pi calculated.";
            // 
            // CustomBitmapGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 508);
            this.Controls.Add(this.digitsCalculatedLabel);
            this.Controls.Add(this.requiredDigitsLabel);
            this.Controls.Add(this.yPixelsLabel);
            this.Controls.Add(this.yPixelsTextBox);
            this.Controls.Add(this.xPixelsTextBox);
            this.Controls.Add(this.xPixelsLabel);
            this.Controls.Add(this.wallpaperComboBox);
            this.Controls.Add(this.wallpaperCheckBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.colorQuestionbutton);
            this.Controls.Add(this.colorQuestionlabel);
            this.Controls.Add(this.colorFbutton);
            this.Controls.Add(this.colorFlabel);
            this.Controls.Add(this.colorEbutton);
            this.Controls.Add(this.colorElabel);
            this.Controls.Add(this.colorDbutton);
            this.Controls.Add(this.colorDlabel);
            this.Controls.Add(this.colorCbutton);
            this.Controls.Add(this.colorClabel);
            this.Controls.Add(this.colorBbutton);
            this.Controls.Add(this.colorBlabel);
            this.Controls.Add(this.colorAbutton);
            this.Controls.Add(this.colorAlabel);
            this.Controls.Add(this.color9button);
            this.Controls.Add(this.color9label);
            this.Controls.Add(this.color8button);
            this.Controls.Add(this.color8label);
            this.Controls.Add(this.color7button);
            this.Controls.Add(this.color7label);
            this.Controls.Add(this.color6button);
            this.Controls.Add(this.color6label);
            this.Controls.Add(this.color5button);
            this.Controls.Add(this.color5label);
            this.Controls.Add(this.color4button);
            this.Controls.Add(this.color4label);
            this.Controls.Add(this.color3button);
            this.Controls.Add(this.color3label);
            this.Controls.Add(this.color2button);
            this.Controls.Add(this.color2label);
            this.Controls.Add(this.color1button);
            this.Controls.Add(this.color1label);
            this.Controls.Add(this.color0button);
            this.Controls.Add(this.GenerateBitmapButton);
            this.Controls.Add(this.color0label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomBitmapGenerator";
            this.Text = "Custom Pi Bitmap Analysis Generator";
            this.Load += new System.EventHandler(this.CustomBitmapGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox wallpaperCheckBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button colorQuestionbutton;
        private System.Windows.Forms.Label colorQuestionlabel;
        private System.Windows.Forms.Button colorFbutton;
        private System.Windows.Forms.Label colorFlabel;
        private System.Windows.Forms.Button colorEbutton;
        private System.Windows.Forms.Label colorElabel;
        private System.Windows.Forms.Button colorDbutton;
        private System.Windows.Forms.Label colorDlabel;
        private System.Windows.Forms.Button colorCbutton;
        private System.Windows.Forms.Label colorClabel;
        private System.Windows.Forms.Button colorBbutton;
        private System.Windows.Forms.Label colorBlabel;
        private System.Windows.Forms.Button colorAbutton;
        private System.Windows.Forms.Label colorAlabel;
        private System.Windows.Forms.Button color9button;
        private System.Windows.Forms.Label color9label;
        private System.Windows.Forms.Button color8button;
        private System.Windows.Forms.Label color8label;
        private System.Windows.Forms.Button color7button;
        private System.Windows.Forms.Label color7label;
        private System.Windows.Forms.Button color6button;
        private System.Windows.Forms.Label color6label;
        private System.Windows.Forms.Button color5button;
        private System.Windows.Forms.Label color5label;
        private System.Windows.Forms.Button color4button;
        private System.Windows.Forms.Label color4label;
        private System.Windows.Forms.Button color3button;
        private System.Windows.Forms.Label color3label;
        private System.Windows.Forms.Button color2button;
        private System.Windows.Forms.Label color2label;
        private System.Windows.Forms.Button color1button;
        private System.Windows.Forms.Label color1label;
        private System.Windows.Forms.Button color0button;
        private System.Windows.Forms.Button GenerateBitmapButton;
        private System.Windows.Forms.Label color0label;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog BasicBMPSaveFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ComboBox wallpaperComboBox;
        private System.Windows.Forms.Label xPixelsLabel;
        private System.Windows.Forms.TextBox xPixelsTextBox;
        private System.Windows.Forms.TextBox yPixelsTextBox;
        private System.Windows.Forms.Label yPixelsLabel;
        private System.Windows.Forms.Label requiredDigitsLabel;
        private System.Windows.Forms.Label digitsCalculatedLabel;
    }
}