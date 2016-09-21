namespace Colorizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorBLabel = new System.Windows.Forms.Label();
            this.ColorNLabel = new System.Windows.Forms.Label();
            this.ColorALabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NeutralShowBox = new System.Windows.Forms.TextBox();
            this.BravoShowBox = new System.Windows.Forms.TextBox();
            this.AlphaShowBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(6, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.178.22";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(112, 17);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(142, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect to Gecko";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnButton);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPGecko Connection";
            // 
            // DisconnButton
            // 
            this.DisconnButton.Enabled = false;
            this.DisconnButton.Location = new System.Drawing.Point(260, 17);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(83, 23);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = true;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thanks to Nefarious, cFLean, Sheldon and NWPlayer for help.\r\nNote: This tool disa" +
    "bles online until restart because Nintendo can detect it.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.ColorBLabel);
            this.SettingsGroupBox.Controls.Add(this.ColorNLabel);
            this.SettingsGroupBox.Controls.Add(this.ColorALabel);
            this.SettingsGroupBox.Controls.Add(this.button5);
            this.SettingsGroupBox.Controls.Add(this.button4);
            this.SettingsGroupBox.Controls.Add(this.button3);
            this.SettingsGroupBox.Controls.Add(this.NeutralShowBox);
            this.SettingsGroupBox.Controls.Add(this.BravoShowBox);
            this.SettingsGroupBox.Controls.Add(this.AlphaShowBox);
            this.SettingsGroupBox.Controls.Add(this.button1);
            this.SettingsGroupBox.Enabled = false;
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 67);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(349, 136);
            this.SettingsGroupBox.TabIndex = 5;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ColorBLabel
            // 
            this.ColorBLabel.AutoSize = true;
            this.ColorBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorBLabel.Location = new System.Drawing.Point(163, 32);
            this.ColorBLabel.Name = "ColorBLabel";
            this.ColorBLabel.Size = new System.Drawing.Size(39, 13);
            this.ColorBLabel.TabIndex = 12;
            this.ColorBLabel.Text = "not set";
            // 
            // ColorNLabel
            // 
            this.ColorNLabel.AutoSize = true;
            this.ColorNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorNLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorNLabel.Location = new System.Drawing.Point(270, 32);
            this.ColorNLabel.Name = "ColorNLabel";
            this.ColorNLabel.Size = new System.Drawing.Size(39, 13);
            this.ColorNLabel.TabIndex = 20;
            this.ColorNLabel.Text = "not set";
            // 
            // ColorALabel
            // 
            this.ColorALabel.AutoSize = true;
            this.ColorALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorALabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorALabel.Location = new System.Drawing.Point(57, 32);
            this.ColorALabel.Name = "ColorALabel";
            this.ColorALabel.Size = new System.Drawing.Size(39, 13);
            this.ColorALabel.TabIndex = 7;
            this.ColorALabel.Text = "not set";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Set Neutral";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SetNeutralColor);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Set Bravo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetBravoColor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Set Alpha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SetAlphaColor);
            // 
            // NeutralShowBox
            // 
            this.NeutralShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NeutralShowBox.Enabled = false;
            this.NeutralShowBox.Location = new System.Drawing.Point(244, 28);
            this.NeutralShowBox.Name = "NeutralShowBox";
            this.NeutralShowBox.Size = new System.Drawing.Size(20, 20);
            this.NeutralShowBox.TabIndex = 7;
            // 
            // BravoShowBox
            // 
            this.BravoShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BravoShowBox.Enabled = false;
            this.BravoShowBox.Location = new System.Drawing.Point(137, 28);
            this.BravoShowBox.Name = "BravoShowBox";
            this.BravoShowBox.Size = new System.Drawing.Size(20, 20);
            this.BravoShowBox.TabIndex = 6;
            // 
            // AlphaShowBox
            // 
            this.AlphaShowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AlphaShowBox.Enabled = false;
            this.AlphaShowBox.Location = new System.Drawing.Point(31, 28);
            this.AlphaShowBox.Name = "AlphaShowBox";
            this.AlphaShowBox.Size = new System.Drawing.Size(20, 20);
            this.AlphaShowBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get colors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetColors);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Colorizer - Splatoon 2.12.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NeutralShowBox;
        private System.Windows.Forms.TextBox BravoShowBox;
        private System.Windows.Forms.TextBox AlphaShowBox;
        private System.Windows.Forms.Label ColorBLabel;
        private System.Windows.Forms.Label ColorNLabel;
        private System.Windows.Forms.Label ColorALabel;
    }
}

