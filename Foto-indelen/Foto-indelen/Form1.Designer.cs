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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "INDELEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendarVanaf
            // 
            this.monthCalendarVanaf.Location = new System.Drawing.Point(18, 210);
            this.monthCalendarVanaf.Name = "monthCalendarVanaf";
            this.monthCalendarVanaf.TabIndex = 4;
            this.monthCalendarVanaf.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Vanaf
            // 
            this.Vanaf.AutoSize = true;
            this.Vanaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Vanaf.Location = new System.Drawing.Point(95, 180);
            this.Vanaf.Name = "Vanaf";
            this.Vanaf.Size = new System.Drawing.Size(73, 29);
            this.Vanaf.TabIndex = 5;
            this.Vanaf.Text = "Vanaf";
            this.Vanaf.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(396, 210);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // Tot
            // 
            this.Tot.AutoSize = true;
            this.Tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tot.Location = new System.Drawing.Point(445, 180);
            this.Tot.Name = "Tot";
            this.Tot.Size = new System.Drawing.Size(128, 29);
            this.Tot.TabIndex = 7;
            this.Tot.Text = "Tot en met";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 577);
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
    }
}

