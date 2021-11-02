
namespace MovieTheater
{
    partial class ShowTimeForm
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
            this.ShowBT = new System.Windows.Forms.Button();
            this.DelBT = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.ticketpriceTB = new System.Windows.Forms.TextBox();
            this.cbbcinemaID = new System.Windows.Forms.ComboBox();
            this.cbbformat = new System.Windows.Forms.ComboBox();
            this.manhinhTB = new System.Windows.Forms.TextBox();
            this.tenphimTB = new System.Windows.Forms.TextBox();
            this.malichchieuTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpshowtime = new System.Windows.Forms.DateTimePicker();
            this.dtpshowdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBT = new System.Windows.Forms.Button();
            this.saechTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvshowtime = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowtime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShowBT);
            this.panel1.Controls.Add(this.DelBT);
            this.panel1.Controls.Add(this.EditBt);
            this.panel1.Controls.Add(this.AddBT);
            this.panel1.Controls.Add(this.ticketpriceTB);
            this.panel1.Controls.Add(this.cbbcinemaID);
            this.panel1.Controls.Add(this.cbbformat);
            this.panel1.Controls.Add(this.manhinhTB);
            this.panel1.Controls.Add(this.tenphimTB);
            this.panel1.Controls.Add(this.malichchieuTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 562);
            this.panel1.TabIndex = 0;
            // 
            // ShowBT
            // 
            this.ShowBT.BackColor = System.Drawing.Color.Teal;
            this.ShowBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBT.Location = new System.Drawing.Point(202, 488);
            this.ShowBT.Name = "ShowBT";
            this.ShowBT.Size = new System.Drawing.Size(168, 52);
            this.ShowBT.TabIndex = 18;
            this.ShowBT.Text = "Show";
            this.ShowBT.UseVisualStyleBackColor = false;
            // 
            // DelBT
            // 
            this.DelBT.BackColor = System.Drawing.Color.Teal;
            this.DelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBT.Location = new System.Drawing.Point(14, 488);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(169, 52);
            this.DelBT.TabIndex = 17;
            this.DelBT.Text = "Xóa";
            this.DelBT.UseVisualStyleBackColor = false;
            // 
            // EditBt
            // 
            this.EditBt.BackColor = System.Drawing.Color.Teal;
            this.EditBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBt.Location = new System.Drawing.Point(202, 414);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(169, 52);
            this.EditBt.TabIndex = 16;
            this.EditBt.Text = "Sửa";
            this.EditBt.UseVisualStyleBackColor = false;
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.Teal;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBT.Location = new System.Drawing.Point(14, 414);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(169, 52);
            this.AddBT.TabIndex = 15;
            this.AddBT.Text = "Thêm";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // ticketpriceTB
            // 
            this.ticketpriceTB.Location = new System.Drawing.Point(142, 216);
            this.ticketpriceTB.Multiline = true;
            this.ticketpriceTB.Name = "ticketpriceTB";
            this.ticketpriceTB.Size = new System.Drawing.Size(228, 25);
            this.ticketpriceTB.TabIndex = 14;
            // 
            // cbbcinemaID
            // 
            this.cbbcinemaID.FormattingEnabled = true;
            this.cbbcinemaID.Location = new System.Drawing.Point(142, 133);
            this.cbbcinemaID.Name = "cbbcinemaID";
            this.cbbcinemaID.Size = new System.Drawing.Size(228, 24);
            this.cbbcinemaID.TabIndex = 13;
            // 
            // cbbformat
            // 
            this.cbbformat.FormattingEnabled = true;
            this.cbbformat.Location = new System.Drawing.Point(142, 50);
            this.cbbformat.Name = "cbbformat";
            this.cbbformat.Size = new System.Drawing.Size(228, 24);
            this.cbbformat.TabIndex = 12;
            this.cbbformat.SelectedIndexChanged += new System.EventHandler(this.cbbformat_SelectedIndexChanged);
            // 
            // manhinhTB
            // 
            this.manhinhTB.Location = new System.Drawing.Point(142, 171);
            this.manhinhTB.Multiline = true;
            this.manhinhTB.Name = "manhinhTB";
            this.manhinhTB.ReadOnly = true;
            this.manhinhTB.Size = new System.Drawing.Size(228, 25);
            this.manhinhTB.TabIndex = 11;
            // 
            // tenphimTB
            // 
            this.tenphimTB.Location = new System.Drawing.Point(142, 89);
            this.tenphimTB.Multiline = true;
            this.tenphimTB.Name = "tenphimTB";
            this.tenphimTB.ReadOnly = true;
            this.tenphimTB.Size = new System.Drawing.Size(228, 25);
            this.tenphimTB.TabIndex = 10;
            // 
            // malichchieuTB
            // 
            this.malichchieuTB.Location = new System.Drawing.Point(142, 4);
            this.malichchieuTB.Multiline = true;
            this.malichchieuTB.Name = "malichchieuTB";
            this.malichchieuTB.Size = new System.Drawing.Size(228, 25);
            this.malichchieuTB.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá vé:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpshowtime);
            this.groupBox1.Controls.Add(this.dtpshowdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian chiếu:";
            // 
            // dtpshowtime
            // 
            this.dtpshowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpshowtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpshowtime.Location = new System.Drawing.Point(89, 80);
            this.dtpshowtime.Name = "dtpshowtime";
            this.dtpshowtime.Size = new System.Drawing.Size(262, 27);
            this.dtpshowtime.TabIndex = 9;
            // 
            // dtpshowdate
            // 
            this.dtpshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpshowdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpshowdate.Location = new System.Drawing.Point(89, 32);
            this.dtpshowdate.Name = "dtpshowdate";
            this.dtpshowdate.Size = new System.Drawing.Size(262, 27);
            this.dtpshowdate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giờ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Màn hình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã định dạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch chiếu:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchBT);
            this.panel2.Controls.Add(this.saechTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 53);
            this.panel2.TabIndex = 1;
            // 
            // SearchBT
            // 
            this.SearchBT.BackColor = System.Drawing.Color.Teal;
            this.SearchBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBT.Location = new System.Drawing.Point(699, 11);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(104, 27);
            this.SearchBT.TabIndex = 19;
            this.SearchBT.Text = "Seach";
            this.SearchBT.UseVisualStyleBackColor = false;
            // 
            // saechTB
            // 
            this.saechTB.Location = new System.Drawing.Point(176, 13);
            this.saechTB.Multiline = true;
            this.saechTB.Name = "saechTB";
            this.saechTB.Size = new System.Drawing.Size(517, 25);
            this.saechTB.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm kiếm theo tên:";
            // 
            // dgvshowtime
            // 
            this.dgvshowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowtime.Location = new System.Drawing.Point(394, 63);
            this.dgvshowtime.Name = "dgvshowtime";
            this.dgvshowtime.RowHeadersWidth = 51;
            this.dgvshowtime.RowTemplate.Height = 24;
            this.dgvshowtime.Size = new System.Drawing.Size(848, 562);
            this.dgvshowtime.TabIndex = 2;
            // 
            // ShowTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.dgvshowtime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowTimeForm";
            this.Text = "ShowTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowtime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvshowtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowBT;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.TextBox ticketpriceTB;
        private System.Windows.Forms.ComboBox cbbcinemaID;
        private System.Windows.Forms.ComboBox cbbformat;
        private System.Windows.Forms.TextBox manhinhTB;
        private System.Windows.Forms.TextBox tenphimTB;
        private System.Windows.Forms.TextBox malichchieuTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpshowtime;
        private System.Windows.Forms.DateTimePicker dtpshowdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.TextBox saechTB;
        private System.Windows.Forms.Label label9;
    }
}