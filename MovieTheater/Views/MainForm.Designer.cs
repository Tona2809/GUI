
namespace MovieTheater
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccountBT = new System.Windows.Forms.Button();
            this.DoanhthuBt = new System.Windows.Forms.Button();
            this.TicketBT = new System.Windows.Forms.Button();
            this.NVBT = new System.Windows.Forms.Button();
            this.DashboardBT = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.changePWBT = new System.Windows.Forms.Button();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAccountInfo);
            this.panel2.Controls.Add(this.changePWBT);
            this.panel2.Controls.Add(this.AccountBT);
            this.panel2.Controls.Add(this.DoanhthuBt);
            this.panel2.Controls.Add(this.TicketBT);
            this.panel2.Controls.Add(this.NVBT);
            this.panel2.Controls.Add(this.DashboardBT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1547, 100);
            this.panel2.TabIndex = 0;
            // 
            // AccountBT
            // 
            this.AccountBT.BackColor = System.Drawing.Color.Teal;
            this.AccountBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AccountBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBT.Location = new System.Drawing.Point(715, 11);
            this.AccountBT.Name = "AccountBT";
            this.AccountBT.Size = new System.Drawing.Size(155, 76);
            this.AccountBT.TabIndex = 3;
            this.AccountBT.Text = "Tài khoản";
            this.AccountBT.UseVisualStyleBackColor = false;
            this.AccountBT.Click += new System.EventHandler(this.AccountBT_Click);
            // 
            // DoanhthuBt
            // 
            this.DoanhthuBt.BackColor = System.Drawing.Color.Teal;
            this.DoanhthuBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoanhthuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhthuBt.Location = new System.Drawing.Point(1157, 11);
            this.DoanhthuBt.Name = "DoanhthuBt";
            this.DoanhthuBt.Size = new System.Drawing.Size(164, 76);
            this.DoanhthuBt.TabIndex = 5;
            this.DoanhthuBt.Text = "Doanh Thu";
            this.DoanhthuBt.UseVisualStyleBackColor = false;
            this.DoanhthuBt.Click += new System.EventHandler(this.DoanhthuBt_Click);
            // 
            // TicketBT
            // 
            this.TicketBT.BackColor = System.Drawing.Color.Teal;
            this.TicketBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TicketBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketBT.Location = new System.Drawing.Point(935, 11);
            this.TicketBT.Name = "TicketBT";
            this.TicketBT.Size = new System.Drawing.Size(164, 76);
            this.TicketBT.TabIndex = 4;
            this.TicketBT.Text = "Bán Vé";
            this.TicketBT.UseVisualStyleBackColor = false;
            this.TicketBT.Click += new System.EventHandler(this.TicketBT_Click);
            // 
            // NVBT
            // 
            this.NVBT.BackColor = System.Drawing.Color.Teal;
            this.NVBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NVBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVBT.Location = new System.Drawing.Point(496, 12);
            this.NVBT.Name = "NVBT";
            this.NVBT.Size = new System.Drawing.Size(155, 77);
            this.NVBT.TabIndex = 1;
            this.NVBT.Text = "Nhân viên";
            this.NVBT.UseVisualStyleBackColor = false;
            this.NVBT.Click += new System.EventHandler(this.NVBT_Click);
            // 
            // DashboardBT
            // 
            this.DashboardBT.BackColor = System.Drawing.Color.Teal;
            this.DashboardBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DashboardBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBT.Location = new System.Drawing.Point(272, 11);
            this.DashboardBT.Name = "DashboardBT";
            this.DashboardBT.Size = new System.Drawing.Size(155, 76);
            this.DashboardBT.TabIndex = 0;
            this.DashboardBT.Text = "Dashboard";
            this.DashboardBT.UseVisualStyleBackColor = false;
            this.DashboardBT.Click += new System.EventHandler(this.DashboardBT_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1547, 637);
            this.pnMain.TabIndex = 1;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // changePWBT
            // 
            this.changePWBT.BackColor = System.Drawing.Color.Teal;
            this.changePWBT.Location = new System.Drawing.Point(1448, -1);
            this.changePWBT.Name = "changePWBT";
            this.changePWBT.Size = new System.Drawing.Size(98, 33);
            this.changePWBT.TabIndex = 17;
            this.changePWBT.Text = "changePW";
            this.changePWBT.UseVisualStyleBackColor = false;
            this.changePWBT.Click += new System.EventHandler(this.changePWBT_Click);
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(3, 7);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(107, 17);
            this.lblAccountInfo.TabIndex = 18;
            this.lblAccountInfo.Text = "Tên tài khoản : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1547, 737);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DoanhthuBt;
        private System.Windows.Forms.Button TicketBT;
        private System.Windows.Forms.Button AccountBT;
        private System.Windows.Forms.Button NVBT;
        private System.Windows.Forms.Button DashboardBT;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button changePWBT;
        private System.Windows.Forms.Label lblAccountInfo;
    }
}