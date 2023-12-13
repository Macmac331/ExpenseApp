﻿using Google.Cloud.Firestore;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseApp
{
    public partial class Signup : Form
    {
        String fname, lname, email, username, password, repeatpass;
        bool flag = false;
        public string otp;
        public Signup()
        {
            InitializeComponent();
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            /*bool notEmptyTextBox = false;
            foreach (Control control in signupPanel.Controls){
                if (control is Guna.UI2.WinForms.Internal.PlaceholderTextBox textbox){
                    if (!string.IsNullOrEmpty(textbox.Text)){
                        notEmptyTextBox = true;
                        break;
                    }
                }
            }
            if (notEmptyTextBox) {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No){
                    return;
                }

            }*/
            this.Close();
        }
        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Cannot Enter Numerical Values and Special Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Cannot Enter Numerical Values and Special Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8){
                e.Handled = true;
                MessageBox.Show("Cannot Enter Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Username cannot contain whitespaces and special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Password cannot contain whitespaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string pass = txtPassword.Text;

            //check if the passwordTB is empty, do not show error message when empty
            if (!string.IsNullOrEmpty(txtPassword.Text)) {
                if (pass.Length > 0 && pass.Length < 8)
                {
                    errorProvider.SetError(txtPassword, "Password must be at least 8 characters long");
                }
                else if (!pass.Any(char.IsUpper) || !pass.Any(char.IsLower))
                {
                    errorProvider.SetError(txtPassword, "Password must contain upper and lower case");
                }
                else if (!pass.Any(char.IsSymbol))
                {
                    errorProvider.SetError(txtPassword, "Password must contain symbol(!@#$%^&)");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else{
                errorProvider.Clear();
            }
        }

        private void txtPassword_Paint(object sender, PaintEventArgs e)
        {
            if (txtPassword.BorderColor == System.Drawing.Color.Red){
                ControlPaint.DrawBorder(e.Graphics, txtPassword.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0])){
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text) && char.IsLower(textBox.Text[0])){
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void termsConditions_CheckedChanged(object sender, EventArgs e)
        {
            if (termsConditions.Checked){
                Terms termsForm = new Terms();
                termsForm.ShowDialog();
                if (termsForm.Accepted){
                    termsConditions.Checked = true;
                }
                else{
                    termsConditions.Checked = false;
                }
            }
        }

        private void UpdatePasswordMatchLabel()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && string.IsNullOrWhiteSpace(txtrepeatpass.Text) || string.IsNullOrEmpty(txtrepeatpass.Text))
            {
                checkPass.Text = "";
            }
            else if (txtPassword.Text == txtrepeatpass.Text)
            {
                checkPass.Text = "Password Matched";
                checkPass.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                checkPass.Text = "Password Doesn't Match";
                checkPass.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void otpTimer_Tick(object sender, EventArgs e)
        {
            txtOTP.Visible = false;
            btnVerify.Visible = false;
            otpTimer.Stop();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Tuple<string, DateTime, string> storedOTP = OTPManager.LoadOTP();
            string prevEmail = storedOTP.Item3;
            string inputOTP = txtOTP.Text.ToString();

            if (inputOTP.Equals(storedOTP.Item1))
            {
                txtOTP.Visible = false;
                btnVerify.Visible = false;
                btnSendOTP.Visible = false;
                txtEmail.Text = email;
                ptbVerified.Visible = true;
                MessageBox.Show("Email Verified", "Success", MessageBoxButtons.OK);
                flag = true;
                txtEmail.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please enter your OTP", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            Tuple<string, DateTime, string> storedOTP = OTPManager.LoadOTP();
            DateTime expireDate = storedOTP.Item2;
            DateTime currentDate = DateTime.Now;
            string prevCode = storedOTP.Item1;
            string prevEmail = storedOTP.Item3;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Enter your email", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (otherFunc.isValidEmail(txtEmail.Text.Trim()))
                {
                    string inputEmail = txtEmail.Text.Trim();
                    if(expireDate > currentDate && prevEmail.Equals(inputEmail))
                    {
                        MessageBox.Show("You still have a valid OTP. Please use the existing one.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        otherFunc.sendOTP(inputEmail, false);
                        txtOTP.Visible = true;
                        btnVerify.Visible = true;
                        email = inputEmail;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchLabel();
        }

        private void txtrepeatpass_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchLabel();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.ToString().Trim().ToLower();
            fname = txtFirstname.Text.ToString().Trim();
            lname = txtLastname.Text.ToString().Trim();
            email = txtEmail.Text.ToString().Trim();
            password = txtPassword.Text.ToString();
            repeatpass = txtrepeatpass.Text.ToString().Trim();
            CheckBox terms = termsConditions;
            bool isEmpty = otherFunc.areControlEmpty(username, fname, lname, password, repeatpass, email);
            bool hasInternet = otherFunc.internetConn();
            if (hasInternet) {
                otherFunc function = new otherFunc();
                if (!isEmpty)
                {
                    if (flag)
                    {
                        function.signingUp(username, fname, lname, email, password, repeatpass, terms, this);
                    }
                    else
                    {
                        MessageBox.Show("Email not verified!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                else
                {
                    MessageBox.Show("Something is missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("No Internet Connection!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void runErrorMsg(List<String> lst)
        {
            String Lval = string.Join(Environment.NewLine, lst);
            MessageBox.Show("Invalid: \n"+Lval, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
