﻿namespace StudentInformationSheet
{
    partial class LoginPage
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
            System.Windows.Forms.Button loginButton;
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.EchoPassword = new System.Windows.Forms.PictureBox();
            this.eyesclosedicon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EchoPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesclosedicon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            loginButton.BackColor = System.Drawing.Color.Plum;
            loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginButton.ForeColor = System.Drawing.Color.Indigo;
            loginButton.Location = new System.Drawing.Point(241, 485);
            loginButton.Margin = new System.Windows.Forms.Padding(0);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(130, 49);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTb
            // 
            this.usernameTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTb.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.ForeColor = System.Drawing.Color.Fuchsia;
            this.usernameTb.Location = new System.Drawing.Point(94, 237);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(417, 36);
            this.usernameTb.TabIndex = 2;
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.Fuchsia;
            this.passwordTb.Location = new System.Drawing.Point(94, 366);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(417, 36);
            this.passwordTb.TabIndex = 3;
            this.passwordTb.TextChanged += new System.EventHandler(this.passwordTb_TextChanged);
            // 
            // EchoPassword
            // 
            this.EchoPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EchoPassword.BackColor = System.Drawing.Color.Transparent;
            this.EchoPassword.BackgroundImage = global::StudentInformationSheet.Properties.Resources.eyeicon;
            this.EchoPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EchoPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EchoPassword.Location = new System.Drawing.Point(470, 369);
            this.EchoPassword.Name = "EchoPassword";
            this.EchoPassword.Size = new System.Drawing.Size(37, 37);
            this.EchoPassword.TabIndex = 5;
            this.EchoPassword.TabStop = false;
            this.EchoPassword.Visible = false;
            this.EchoPassword.Click += new System.EventHandler(this.EchoPassword_Click);
            // 
            // eyesclosedicon
            // 
            this.eyesclosedicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eyesclosedicon.BackColor = System.Drawing.Color.Transparent;
            this.eyesclosedicon.BackgroundImage = global::StudentInformationSheet.Properties.Resources.eyeclosedicon;
            this.eyesclosedicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyesclosedicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyesclosedicon.Location = new System.Drawing.Point(470, 368);
            this.eyesclosedicon.Name = "eyesclosedicon";
            this.eyesclosedicon.Size = new System.Drawing.Size(37, 37);
            this.eyesclosedicon.TabIndex = 6;
            this.eyesclosedicon.TabStop = false;
            this.eyesclosedicon.Click += new System.EventHandler(this.eyesclosedicon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::StudentInformationSheet.Properties.Resources.framebgfinal;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(loginButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.eyesclosedicon);
            this.groupBox1.Controls.Add(this.EchoPassword);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordTb);
            this.groupBox1.Controls.Add(this.usernameTb);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(89, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 629);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::StudentInformationSheet.Properties.Resources.linephoto;
            this.pictureBox3.Location = new System.Drawing.Point(94, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(417, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::StudentInformationSheet.Properties.Resources.linephoto;
            this.pictureBox2.Location = new System.Drawing.Point(94, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::StudentInformationSheet.Properties.Resources.loginPhotodesign;
            this.pictureBox1.Location = new System.Drawing.Point(580, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 610);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(89, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(89, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(253, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Log In";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInformationSheet.Properties.Resources.BackgroundForAll;
            this.ClientSize = new System.Drawing.Size(1255, 721);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1271, 760);
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.EchoPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyesclosedicon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.PictureBox EchoPassword;
        private System.Windows.Forms.PictureBox eyesclosedicon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

