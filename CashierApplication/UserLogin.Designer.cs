﻿namespace CashierApplication
{
    partial class UserLogin
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(16, 49);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(218, 36);
            this.textBoxUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(16, 121);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(218, 36);
            this.textBoxPass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(16, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button button1;
    }
}