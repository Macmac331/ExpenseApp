﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Cloud.Firestore;

namespace ExpenseApp
{
    public partial class Login : Form
    {
        IFirebaseClient cliente;
        FirestoreDb db;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cliente = otherFunc.conn();
            db = otherFunc.FirestoreConn();
            /*checking connection*/
            if(cliente != null && db != null)
            {
                /*it can be changed*/
                /*IDEA 1: pedeng makita sa login form kung connected o hindi, gamit yung label*/
                MessageBox.Show("Connection","Connected Successfully", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Connection error","No connection", MessageBoxButtons.OK);
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void signupBTN_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = ColorTranslator.FromHtml("#4C96FF");
        }

        private void signupBTN_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = DefaultForeColor;
        }
    }
}
