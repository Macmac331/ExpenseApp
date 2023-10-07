namespace ExpenseApp
{
    partial class TaC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaC));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecline = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Poppins", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 337);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Terms and Conditions";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnAccept
            // 
            this.btnAccept.BorderRadius = 20;
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(123)))), ((int)(((byte)(47)))));
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(25, 410);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 45);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Accept";
            // 
            // btnDecline
            // 
            this.btnDecline.BorderRadius = 20;
            this.btnDecline.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecline.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(123)))), ((int)(((byte)(47)))));
            this.btnDecline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecline.ForeColor = System.Drawing.Color.White;
            this.btnDecline.Location = new System.Drawing.Point(208, 410);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(140, 45);
            this.btnDecline.TabIndex = 13;
            this.btnDecline.Text = "Decline";
            // 
            // TaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 467);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaC";
            this.Text = "TaC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private Guna.UI2.WinForms.Guna2Button btnDecline;
    }
}