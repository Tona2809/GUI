
namespace MovieTheater
{
    partial class DashboardFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DinhdangBT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LichchieuBt = new System.Windows.Forms.Button();
            this.phongchieuBT = new System.Windows.Forms.Button();
            this.theloaiBT = new System.Windows.Forms.Button();
            this.phimBT = new System.Windows.Forms.Button();
            this.pnmain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DinhdangBT);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.LichchieuBt);
            this.panel1.Controls.Add(this.phongchieuBT);
            this.panel1.Controls.Add(this.theloaiBT);
            this.panel1.Controls.Add(this.phimBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 637);
            this.panel1.TabIndex = 0;
            // 
            // DinhdangBT
            // 
            this.DinhdangBT.BackColor = System.Drawing.Color.Teal;
            this.DinhdangBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DinhdangBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinhdangBT.Location = new System.Drawing.Point(6, 411);
            this.DinhdangBT.Name = "DinhdangBT";
            this.DinhdangBT.Size = new System.Drawing.Size(292, 68);
            this.DinhdangBT.TabIndex = 5;
            this.DinhdangBT.Text = "Định dạng";
            this.DinhdangBT.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(292, 68);
            this.button5.TabIndex = 4;
            this.button5.Text = "Vé";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // LichchieuBt
            // 
            this.LichchieuBt.BackColor = System.Drawing.Color.Teal;
            this.LichchieuBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LichchieuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LichchieuBt.Location = new System.Drawing.Point(3, 337);
            this.LichchieuBt.Name = "LichchieuBt";
            this.LichchieuBt.Size = new System.Drawing.Size(292, 68);
            this.LichchieuBt.TabIndex = 3;
            this.LichchieuBt.Text = "Lich chiếu";
            this.LichchieuBt.UseVisualStyleBackColor = false;
            // 
            // phongchieuBT
            // 
            this.phongchieuBT.BackColor = System.Drawing.Color.Teal;
            this.phongchieuBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phongchieuBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phongchieuBT.Location = new System.Drawing.Point(3, 263);
            this.phongchieuBT.Name = "phongchieuBT";
            this.phongchieuBT.Size = new System.Drawing.Size(292, 68);
            this.phongchieuBT.TabIndex = 2;
            this.phongchieuBT.Text = "Phòng chiếu";
            this.phongchieuBT.UseVisualStyleBackColor = false;
            // 
            // theloaiBT
            // 
            this.theloaiBT.BackColor = System.Drawing.Color.Teal;
            this.theloaiBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.theloaiBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theloaiBT.Location = new System.Drawing.Point(3, 189);
            this.theloaiBT.Name = "theloaiBT";
            this.theloaiBT.Size = new System.Drawing.Size(292, 68);
            this.theloaiBT.TabIndex = 1;
            this.theloaiBT.Text = "Thể loại";
            this.theloaiBT.UseVisualStyleBackColor = false;
            this.theloaiBT.Click += new System.EventHandler(this.theloaiBT_Click);
            // 
            // phimBT
            // 
            this.phimBT.BackColor = System.Drawing.Color.Teal;
            this.phimBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phimBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phimBT.Location = new System.Drawing.Point(3, 115);
            this.phimBT.Name = "phimBT";
            this.phimBT.Size = new System.Drawing.Size(292, 68);
            this.phimBT.TabIndex = 0;
            this.phimBT.Text = "Phim";
            this.phimBT.UseVisualStyleBackColor = false;
            this.phimBT.Click += new System.EventHandler(this.phimBT_Click);
            // 
            // pnmain
            // 
            this.pnmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnmain.Location = new System.Drawing.Point(302, 0);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1246, 637);
            this.pnmain.TabIndex = 0;
            // 
            // DashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardFrm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button LichchieuBt;
        private System.Windows.Forms.Button phongchieuBT;
        private System.Windows.Forms.Button theloaiBT;
        private System.Windows.Forms.Button phimBT;
        private System.Windows.Forms.Panel pnmain;
        private System.Windows.Forms.Button DinhdangBT;
    }
}