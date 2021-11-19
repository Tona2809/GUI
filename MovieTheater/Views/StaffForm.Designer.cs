
namespace MovieTheater
{
    partial class StaffForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowBT = new System.Windows.Forms.Button();
            this.Delbt = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.ngaysinhDTP = new System.Windows.Forms.DateTimePicker();
            this.CMNDTB = new System.Windows.Forms.TextBox();
            this.SDTTB = new System.Windows.Forms.TextBox();
            this.diachiTB = new System.Windows.Forms.TextBox();
            this.tenNVTB = new System.Windows.Forms.TextBox();
            this.maNVTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.liststaffDGV = new System.Windows.Forms.DataGridView();
            this.SearchBT = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liststaffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowBT);
            this.groupBox1.Controls.Add(this.Delbt);
            this.groupBox1.Controls.Add(this.EditBT);
            this.groupBox1.Controls.Add(this.AddBT);
            this.groupBox1.Controls.Add(this.ngaysinhDTP);
            this.groupBox1.Controls.Add(this.CMNDTB);
            this.groupBox1.Controls.Add(this.SDTTB);
            this.groupBox1.Controls.Add(this.diachiTB);
            this.groupBox1.Controls.Add(this.tenNVTB);
            this.groupBox1.Controls.Add(this.maNVTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // ShowBT
            // 
            this.ShowBT.BackColor = System.Drawing.Color.Teal;
            this.ShowBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBT.Location = new System.Drawing.Point(942, 171);
            this.ShowBT.Name = "ShowBT";
            this.ShowBT.Size = new System.Drawing.Size(92, 36);
            this.ShowBT.TabIndex = 18;
            this.ShowBT.Text = "Show";
            this.ShowBT.UseVisualStyleBackColor = false;
            this.ShowBT.Click += new System.EventHandler(this.ShowBT_Click);
            // 
            // Delbt
            // 
            this.Delbt.BackColor = System.Drawing.Color.Teal;
            this.Delbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delbt.Location = new System.Drawing.Point(837, 171);
            this.Delbt.Name = "Delbt";
            this.Delbt.Size = new System.Drawing.Size(92, 36);
            this.Delbt.TabIndex = 16;
            this.Delbt.Text = "Xóa";
            this.Delbt.UseVisualStyleBackColor = false;
            this.Delbt.Click += new System.EventHandler(this.Delbt_Click);
            // 
            // EditBT
            // 
            this.EditBT.BackColor = System.Drawing.Color.Teal;
            this.EditBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBT.Location = new System.Drawing.Point(739, 171);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(92, 36);
            this.EditBT.TabIndex = 15;
            this.EditBT.Text = "Sửa";
            this.EditBT.UseVisualStyleBackColor = false;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // ngaysinhDTP
            // 
            this.ngaysinhDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaysinhDTP.Location = new System.Drawing.Point(209, 127);
            this.ngaysinhDTP.Name = "ngaysinhDTP";
            this.ngaysinhDTP.Size = new System.Drawing.Size(314, 28);
            this.ngaysinhDTP.TabIndex = 12;
            // 
            // CMNDTB
            // 
            this.CMNDTB.Location = new System.Drawing.Point(720, 127);
            this.CMNDTB.Multiline = true;
            this.CMNDTB.Name = "CMNDTB";
            this.CMNDTB.Size = new System.Drawing.Size(314, 31);
            this.CMNDTB.TabIndex = 11;
            // 
            // SDTTB
            // 
            this.SDTTB.Location = new System.Drawing.Point(720, 77);
            this.SDTTB.Multiline = true;
            this.SDTTB.Name = "SDTTB";
            this.SDTTB.Size = new System.Drawing.Size(314, 31);
            this.SDTTB.TabIndex = 10;
            // 
            // diachiTB
            // 
            this.diachiTB.Location = new System.Drawing.Point(720, 26);
            this.diachiTB.Multiline = true;
            this.diachiTB.Name = "diachiTB";
            this.diachiTB.Size = new System.Drawing.Size(314, 31);
            this.diachiTB.TabIndex = 9;
            // 
            // tenNVTB
            // 
            this.tenNVTB.Location = new System.Drawing.Point(209, 77);
            this.tenNVTB.Multiline = true;
            this.tenNVTB.Name = "tenNVTB";
            this.tenNVTB.Size = new System.Drawing.Size(314, 31);
            this.tenNVTB.TabIndex = 8;
            // 
            // maNVTB
            // 
            this.maNVTB.Location = new System.Drawing.Point(209, 27);
            this.maNVTB.Multiline = true;
            this.maNVTB.Name = "maNVTB";
            this.maNVTB.Size = new System.Drawing.Size(314, 31);
            this.maNVTB.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số ĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(633, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.liststaffDGV);
            this.groupBox2.Controls.Add(this.SearchBT);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1523, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // liststaffDGV
            // 
            this.liststaffDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liststaffDGV.ColumnHeadersHeight = 29;
            this.liststaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.liststaffDGV.Location = new System.Drawing.Point(6, 75);
            this.liststaffDGV.Name = "liststaffDGV";
            this.liststaffDGV.RowHeadersWidth = 51;
            this.liststaffDGV.RowTemplate.Height = 24;
            this.liststaffDGV.Size = new System.Drawing.Size(1511, 302);
            this.liststaffDGV.TabIndex = 20;
            // 
            // SearchBT
            // 
            this.SearchBT.BackColor = System.Drawing.Color.Teal;
            this.SearchBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchBT.Location = new System.Drawing.Point(439, 36);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(92, 36);
            this.SearchBT.TabIndex = 19;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = false;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(119, 40);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(314, 31);
            this.txtname.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tìm kiếm:";
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.Teal;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBT.Location = new System.Drawing.Point(641, 171);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(92, 36);
            this.AddBT.TabIndex = 14;
            this.AddBT.Text = "Thêm";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1547, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liststaffDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShowBT;
        private System.Windows.Forms.Button Delbt;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.DateTimePicker ngaysinhDTP;
        private System.Windows.Forms.TextBox CMNDTB;
        private System.Windows.Forms.TextBox SDTTB;
        private System.Windows.Forms.TextBox diachiTB;
        private System.Windows.Forms.TextBox tenNVTB;
        private System.Windows.Forms.TextBox maNVTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView liststaffDGV;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBT;
    }
}