namespace Foto_indelen
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendarVanaf = new System.Windows.Forms.MonthCalendar();
            this.Vanaf = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Tot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.jpgCheckBox = new System.Windows.Forms.CheckBox();
            this.mp4CheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "INDELEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendarVanaf
            // 
            this.monthCalendarVanaf.Location = new System.Drawing.Point(18, 198);
            this.monthCalendarVanaf.Name = "monthCalendarVanaf";
            this.monthCalendarVanaf.TabIndex = 4;
            this.monthCalendarVanaf.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Vanaf
            // 
            this.Vanaf.AutoSize = true;
            this.Vanaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Vanaf.Location = new System.Drawing.Point(95, 168);
            this.Vanaf.Name = "Vanaf";
            this.Vanaf.Size = new System.Drawing.Size(73, 29);
            this.Vanaf.TabIndex = 5;
            this.Vanaf.Text = "Vanaf";
            this.Vanaf.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(279, 198);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // Tot
            // 
            this.Tot.AutoSize = true;
            this.Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tot.Location = new System.Drawing.Point(328, 168);
            this.Tot.Name = "Tot";
            this.Tot.Size = new System.Drawing.Size(128, 29);
            this.Tot.TabIndex = 7;
            this.Tot.Text = "Tot en met";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Leesfolder";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Schrijffolder";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // jpgCheckBox
            // 
            this.jpgCheckBox.AutoSize = true;
            this.jpgCheckBox.Checked = true;
            this.jpgCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpgCheckBox.Location = new System.Drawing.Point(183, 121);
            this.jpgCheckBox.Name = "jpgCheckBox";
            this.jpgCheckBox.Size = new System.Drawing.Size(60, 24);
            this.jpgCheckBox.TabIndex = 14;
            this.jpgCheckBox.Text = ".jpg";
            this.jpgCheckBox.UseVisualStyleBackColor = true;
            this.jpgCheckBox.CheckedChanged += new System.EventHandler(this.jpgCheckBox_CheckedChanged);
            // 
            // mp4CheckBox
            // 
            this.mp4CheckBox.AutoSize = true;
            this.mp4CheckBox.Checked = true;
            this.mp4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mp4CheckBox.Location = new System.Drawing.Point(276, 121);
            this.mp4CheckBox.Name = "mp4CheckBox";
            this.mp4CheckBox.Size = new System.Drawing.Size(70, 24);
            this.mp4CheckBox.TabIndex = 15;
            this.mp4CheckBox.Text = ".mp4";
            this.mp4CheckBox.UseVisualStyleBackColor = true;
            this.mp4CheckBox.CheckedChanged += new System.EventHandler(this.mp4CheckBox_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 456);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(488, 33);
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(524, 571);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mp4CheckBox);
            this.Controls.Add(this.jpgCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tot);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Vanaf);
            this.Controls.Add(this.monthCalendarVanaf);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Foto-indelen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendarVanaf;
        private System.Windows.Forms.Label Vanaf;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Tot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckBox jpgCheckBox;
        private System.Windows.Forms.CheckBox mp4CheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

