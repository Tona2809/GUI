
namespace MovieTheater
{
    partial class TicketForm
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
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.btnShowShowTimeNotCreateTickets = new System.Windows.Forms.Button();
            this.btnShowAllTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnShowAllTicketsBoughtByShowTime = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnAddTicketsByShowTime = new System.Windows.Forms.Button();
            this.ticketDGV = new System.Windows.Forms.DataGridView();
            this.listAllListShowTime = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAllListShowTimes);
            this.panel1.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.panel1.Controls.Add(this.btnShowAllTicketsByShowTime);
            this.panel1.Controls.Add(this.btnShowAllTicketsBoughtByShowTime);
            this.panel1.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel1.Controls.Add(this.btnAddTicketsByShowTime);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.BackColor = System.Drawing.Color.Teal;
            this.btnAllListShowTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllListShowTimes.Location = new System.Drawing.Point(818, 4);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(154, 46);
            this.btnAllListShowTimes.TabIndex = 15;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            this.btnAllListShowTimes.UseVisualStyleBackColor = false;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click);
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.BackColor = System.Drawing.Color.Teal;
            this.btnShowShowTimeNotCreateTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(656, 4);
            this.btnShowShowTimeNotCreateTickets.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(154, 46);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 14;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = false;
            this.btnShowShowTimeNotCreateTickets.Click += new System.EventHandler(this.btnShowShowTimeNotCreateTickets_Click);
            // 
            // btnShowAllTicketsByShowTime
            // 
            this.btnShowAllTicketsByShowTime.BackColor = System.Drawing.Color.Teal;
            this.btnShowAllTicketsByShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllTicketsByShowTime.Location = new System.Drawing.Point(494, 4);
            this.btnShowAllTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            this.btnShowAllTicketsByShowTime.Size = new System.Drawing.Size(154, 46);
            this.btnShowAllTicketsByShowTime.TabIndex = 13;
            this.btnShowAllTicketsByShowTime.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnShowAllTicketsByShowTime.UseVisualStyleBackColor = false;
            this.btnShowAllTicketsByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsByShowTime_Click);
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            this.btnShowAllTicketsBoughtByShowTime.BackColor = System.Drawing.Color.Teal;
            this.btnShowAllTicketsBoughtByShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllTicketsBoughtByShowTime.Location = new System.Drawing.Point(332, 4);
            this.btnShowAllTicketsBoughtByShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            this.btnShowAllTicketsBoughtByShowTime.Size = new System.Drawing.Size(154, 46);
            this.btnShowAllTicketsBoughtByShowTime.TabIndex = 12;
            this.btnShowAllTicketsBoughtByShowTime.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnShowAllTicketsBoughtByShowTime.UseVisualStyleBackColor = false;
            this.btnShowAllTicketsBoughtByShowTime.Click += new System.EventHandler(this.btnShowAllTicketsBoughtByShowTime_Click);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteTicketsByShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(170, 4);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(154, 46);
            this.btnDeleteTicketsByShowTime.TabIndex = 11;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = false;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click);
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.BackColor = System.Drawing.Color.Teal;
            this.btnAddTicketsByShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(8, 4);
            this.btnAddTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(154, 46);
            this.btnAddTicketsByShowTime.TabIndex = 10;
            this.btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            this.btnAddTicketsByShowTime.UseVisualStyleBackColor = false;
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click);
            // 
            // ticketDGV
            // 
            this.ticketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDGV.Location = new System.Drawing.Point(4, 67);
            this.ticketDGV.Name = "ticketDGV";
            this.ticketDGV.RowHeadersWidth = 51;
            this.ticketDGV.RowTemplate.Height = 24;
            this.ticketDGV.Size = new System.Drawing.Size(581, 564);
            this.ticketDGV.TabIndex = 1;
            // 
            // listAllListShowTime
            // 
            this.listAllListShowTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listAllListShowTime.HideSelection = false;
            this.listAllListShowTime.Location = new System.Drawing.Point(592, 67);
            this.listAllListShowTime.Name = "listAllListShowTime";
            this.listAllListShowTime.Size = new System.Drawing.Size(650, 564);
            this.listAllListShowTime.TabIndex = 9;
            this.listAllListShowTime.UseCompatibleStateImageBehavior = false;
            this.listAllListShowTime.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên phòng chiếu";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phim";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.Width = 112;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.listAllListShowTime);
            this.Controls.Add(this.ticketDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.DataGridView ticketDGV;
        private System.Windows.Forms.ListView listAllListShowTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnShowAllTicketsByShowTime;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
    }
}