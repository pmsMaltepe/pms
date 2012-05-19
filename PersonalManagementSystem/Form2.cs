using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool closed = false;
        private void button1_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // removes red X button from right top
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://groups.google.com/group/pmsmaltepe");
        }
    }
}
