﻿namespace ExpenseApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnGroup = new Guna.UI2.WinForms.Guna2Button();
            this.btnWallet = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.dashboard1 = new ExpenseApp.dashboard();
            this.wallet1 = new ExpenseApp.wallet();
            this.group1 = new ExpenseApp.group();
            this.tips1 = new ExpenseApp.profile();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(123)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Smart Spend";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblFirstname);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1292, 62);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Poppins SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(962, 7);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(174, 48);
            this.lblFirstname.TabIndex = 8;
            this.lblFirstname.Text = "Hello, User!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExpenseApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(123)))), ((int)(((byte)(47)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(123)))), ((int)(((byte)(47)))));
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.btnLogut);
            this.guna2Panel3.Controls.Add(this.btnAccount);
            this.guna2Panel3.Controls.Add(this.btnGroup);
            this.guna2Panel3.Controls.Add(this.btnWallet);
            this.guna2Panel3.Controls.Add(this.btnDashboard);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 62);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(183, 620);
            this.guna2Panel3.TabIndex = 7;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint_1);
            // 
            // btnLogut
            // 
            this.btnLogut.BorderColor = System.Drawing.Color.Empty;
            this.btnLogut.BorderRadius = 20;
            this.btnLogut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogut.FillColor = System.Drawing.SystemColors.Control;
            this.btnLogut.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogut.ForeColor = System.Drawing.Color.Black;
            this.btnLogut.Image = global::ExpenseApp.Properties.Resources.logout;
            this.btnLogut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogut.ImageOffset = new System.Drawing.Point(75, -2);
            this.btnLogut.Location = new System.Drawing.Point(-36, 563);
            this.btnLogut.Name = "btnLogut";
            this.btnLogut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogut.Size = new System.Drawing.Size(254, 45);
            this.btnLogut.TabIndex = 10;
            this.btnLogut.Text = "Logout";
            this.btnLogut.Click += new System.EventHandler(this.btnLogut_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BorderColor = System.Drawing.Color.Empty;
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.SystemColors.Control;
            this.btnAccount.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.Image = global::ExpenseApp.Properties.Resources.account;
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.ImageOffset = new System.Drawing.Point(10, -2);
            this.btnAccount.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAccount.Location = new System.Drawing.Point(14, 225);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(211, 45);
            this.btnAccount.TabIndex = 9;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BorderColor = System.Drawing.Color.Empty;
            this.btnGroup.BorderRadius = 20;
            this.btnGroup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGroup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGroup.FillColor = System.Drawing.SystemColors.Control;
            this.btnGroup.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.Black;
            this.btnGroup.Image = global::ExpenseApp.Properties.Resources.group;
            this.btnGroup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGroup.ImageOffset = new System.Drawing.Point(10, -2);
            this.btnGroup.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGroup.Location = new System.Drawing.Point(14, 158);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGroup.Size = new System.Drawing.Size(208, 45);
            this.btnGroup.TabIndex = 8;
            this.btnGroup.Text = "Group";
            this.btnGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BorderColor = System.Drawing.Color.Empty;
            this.btnWallet.BorderRadius = 20;
            this.btnWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWallet.FillColor = System.Drawing.SystemColors.Control;
            this.btnWallet.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.Black;
            this.btnWallet.Image = global::ExpenseApp.Properties.Resources.wallet1;
            this.btnWallet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWallet.ImageOffset = new System.Drawing.Point(10, -2);
            this.btnWallet.ImageSize = new System.Drawing.Size(25, 25);
            this.btnWallet.Location = new System.Drawing.Point(14, 92);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWallet.Size = new System.Drawing.Size(211, 45);
            this.btnWallet.TabIndex = 7;
            this.btnWallet.Text = "Wallet";
            this.btnWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.BorderRadius = 20;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = global::ExpenseApp.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, -2);
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(14, 27);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(211, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(183, 62);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1109, 620);
            this.homePanel.TabIndex = 8;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Green;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1292, 682);
            this.dashboard1.TabIndex = 6;
            // 
            // wallet1
            // 
            this.wallet1.BackColor = System.Drawing.Color.Violet;
            this.wallet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallet1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wallet1.Location = new System.Drawing.Point(0, 0);
            this.wallet1.Margin = new System.Windows.Forms.Padding(4);
            this.wallet1.Name = "wallet1";
            this.wallet1.Size = new System.Drawing.Size(1292, 682);
            this.wallet1.TabIndex = 5;
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.Red;
            this.group1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group1.Location = new System.Drawing.Point(0, 0);
            this.group1.Margin = new System.Windows.Forms.Padding(4);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(1292, 682);
            this.group1.TabIndex = 4;
            // 
            // tips1
            // 
            this.tips1.BackColor = System.Drawing.Color.Blue;
            this.tips1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tips1.Location = new System.Drawing.Point(0, 0);
            this.tips1.Margin = new System.Windows.Forms.Padding(4);
            this.tips1.Name = "tips1";
            this.tips1.Size = new System.Drawing.Size(1292, 682);
            this.tips1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 682);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.wallet1);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.tips1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Spend";
            this.Load += new System.EventHandler(this.Home_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private profile tips1;
        private group group1;
        private wallet wallet1;
        private dashboard dashboard1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnLogut;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnGroup;
        private Guna.UI2.WinForms.Guna2Button btnWallet;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label lblFirstname;
    }
}