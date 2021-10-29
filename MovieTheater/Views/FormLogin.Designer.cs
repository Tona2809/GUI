
namespace MovieTheater
{
    partial class formLogin
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
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.LoginBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbsqlconnect = new System.Windows.Forms.ComboBox();
            this.forgetPassBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(358, 131);
            this.PasswordTB.Multiline = true;
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(311, 41);
            this.PasswordTB.TabIndex = 4;
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PasswordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.Location = new System.Drawing.Point(353, 103);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(106, 25);
            this.PasswordLB.TabIndex = 3;
            this.PasswordLB.Text = "Password";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(17, 131);
            this.UsernameTB.Multiline = true;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(307, 41);
            this.UsernameTB.TabIndex = 2;
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UsernameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.Location = new System.Drawing.Point(12, 103);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(110, 25);
            this.UsernameLB.TabIndex = 1;
            this.UsernameLB.Text = "Username";
            // 
            // LoginBT
            // 
            this.LoginBT.BackColor = System.Drawing.Color.Teal;
            this.LoginBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBT.Location = new System.Drawing.Point(17, 205);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(305, 50);
            this.LoginBT.TabIndex = 6;
            this.LoginBT.Text = "ĐĂNG NHẬP";
            this.LoginBT.UseVisualStyleBackColor = false;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(146, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "WELCOME TO CLE MOVIE THEATER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::MovieTheater.Properties.Resources._4221419;
            this.pictureBox1.Location = new System.Drawing.Point(106, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = global::MovieTheater.Properties.Resources._4221419;
            this.pictureBox2.Location = new System.Drawing.Point(543, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Design By: Nhóm 6- ST6- DBMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Máy chủ:";
            // 
            // cbbsqlconnect
            // 
            this.cbbsqlconnect.FormattingEnabled = true;
            this.cbbsqlconnect.Location = new System.Drawing.Point(15, 76);
            this.cbbsqlconnect.Name = "cbbsqlconnect";
            this.cbbsqlconnect.Size = new System.Drawing.Size(307, 24);
            this.cbbsqlconnect.TabIndex = 14;
            // 
            // forgetPassBT
            // 
            this.forgetPassBT.BackColor = System.Drawing.Color.Teal;
            this.forgetPassBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPassBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forgetPassBT.Location = new System.Drawing.Point(358, 205);
            this.forgetPassBT.Name = "forgetPassBT";
            this.forgetPassBT.Size = new System.Drawing.Size(305, 50);
            this.forgetPassBT.TabIndex = 15;
            this.forgetPassBT.Text = "Quên mật khẩu";
            this.forgetPassBT.UseVisualStyleBackColor = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 319);
            this.Controls.Add(this.forgetPassBT);
            this.Controls.Add(this.cbbsqlconnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.UsernameLB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginBT);
            this.Name = "formLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbsqlconnect;
        private System.Windows.Forms.Button forgetPassBT;
    }
}

