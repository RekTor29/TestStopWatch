using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestStopWatch
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            stopwatch.Start();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            stopwatch.Stop();
            textBox1.Text = stopwatch.Elapsed.Minutes.ToString();
            textBox2.Text = stopwatch.Elapsed.Seconds.ToString();
            textBox3.Text = stopwatch.Elapsed.Milliseconds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            stopwatch = new Stopwatch();
        }
    }
}
