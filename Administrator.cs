﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_manegment_practice
{
    public partial class Administrator : Form
    {
        private object menuStrip1;
        private object btnDashbord;

        public Administrator()
        {   
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            //butnDash_board.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); 
            fm.Show();
            this.Hide();
        }

        private void uC_Dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
