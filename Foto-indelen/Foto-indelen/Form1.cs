﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Foto_indelen
{
    public partial class Form1 : Form
    {
        Indelen indelen = new Indelen();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] temp = Fotos.HaalFotos(indelen.LeesFolder);
            //int aantal = Fotos.AantalFotos(temp);
            indelen.jpg = jpgCheckBox.Checked;
            indelen.mp4 = mp4CheckBox.Checked;
            //Thread thread = new Thread(new ThreadStart(go));
            //thread.Start();
            indelen.go(Fotos.HaalFotos(indelen.LeesFolder), progressBar1);
            //string[] temp;
            //int numLines = 0;
            //temp = Fotos.HaalFotos(@"C:\Foto");
            //foreach(var item in temp)
            //{
            //    numLines++;
            //    Console.WriteLine(item.ToString());
            //}
            //Console.Write(numLines);
        }

        private void go ()
        {
            indelen.go(Fotos.HaalFotos(indelen.LeesFolder), progressBar1);
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            indelen.Vanaf = e.Start;
            Console.WriteLine("Vanaf:" + indelen.Vanaf);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            indelen.Tot = e.End;
            Console.WriteLine("Tot:" + indelen.Tot);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            indelen.LeesFolder = textBox1.Text; //ToString();
            Console.WriteLine("Leesfolder:" + indelen.LeesFolder);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            indelen.SchrijfFolder = textBox2.Text;
            Console.WriteLine("Schrijffolder:" + indelen.SchrijfFolder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void jpgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            indelen.jpg = jpgCheckBox.Checked;
        }

        private void mp4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            indelen.mp4 = mp4CheckBox.Checked;
        }
    }
}
