
namespace MovieTheater
{
    partial class ResetPasswordForm
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
            this.sentBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sentBT
            // 
            this.sentBT.BackColor = System.Drawing.Color.Teal;
            this.sentBT.Location = new System.Drawing.Point(22, 85);
            this.sentBT.Name = "sentBT";
            this.sentBT.Size = new System.Drawing.Size(384, 57);
            this.sentBT.TabIndex = 9;
            this.sentBT.Text = "SENT";
            this.sentBT.UseVisualStyleBackColor = false;
            this.sentBT.Click += new System.EventHandler(this.sentBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // usernameBT
            // 
            this.usernameBT.Location = new System.Drawing.Point(159, 27);
            this.usernameBT.Multiline = true;
            this.usernameBT.Name = "usernameBT";
            this.usernameBT.Size = new System.Drawing.Size(247, 31);
            this.usernameBT.TabIndex = 7;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(425, 168);
            this.Controls.Add(this.sentBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBT);
            this.Name = "ResetPasswordForm";
            this.Text = "ResetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sentBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBT;
    }
}