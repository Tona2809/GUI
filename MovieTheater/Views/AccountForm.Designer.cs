
namespace MovieTheater
{
    partial class AccountForm
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
            this.DELBT = new System.Windows.Forms.GroupBox();
            this.EDITBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.tenNVTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loaitkNBR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maNVCBB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ShowBT = new System.Windows.Forms.Button();
            this.dtvAccount = new System.Windows.Forms.DataGridView();
            this.DELBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaitkNBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // DELBT
            // 
            this.DELBT.Controls.Add(this.EDITBT);
            this.DELBT.Controls.Add(this.button1);
            this.DELBT.Controls.Add(this.AddBT);
            this.DELBT.Controls.Add(this.tenNVTB);
            this.DELBT.Controls.Add(this.label4);
            this.DELBT.Controls.Add(this.loaitkNBR);
            this.DELBT.Controls.Add(this.label3);
            this.DELBT.Controls.Add(this.maNVCBB);
            this.DELBT.Controls.Add(this.label2);
            this.DELBT.Controls.Add(this.UsernameTB);
            this.DELBT.Controls.Add(this.label1);
            this.DELBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELBT.Location = new System.Drawing.Point(13, 13);
            this.DELBT.Name = "DELBT";
            this.DELBT.Size = new System.Drawing.Size(1011, 134);
            this.DELBT.TabIndex = 0;
            this.DELBT.TabStop = false;
            this.DELBT.Text = "Thông tin tài khoản";
            // 
            // EDITBT
            // 
            this.EDITBT.BackColor = System.Drawing.Color.Teal;
            this.EDITBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EDITBT.Location = new System.Drawing.Point(785, 23);
            this.EDITBT.Name = "EDITBT";
            this.EDITBT.Size = new System.Drawing.Size(92, 36);
            this.EDITBT.TabIndex = 17;
            this.EDITBT.Text = "Sửa";
            this.EDITBT.UseVisualStyleBackColor = false;
            this.EDITBT.Click += new System.EventHandler(this.EDITBT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(903, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.Teal;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBT.Location = new System.Drawing.Point(678, 23);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(92, 36);
            this.AddBT.TabIndex = 15;
            this.AddBT.Text = "Thêm";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // tenNVTB
            // 
            this.tenNVTB.Location = new System.Drawing.Point(493, 84);
            this.tenNVTB.Name = "tenNVTB";
            this.tenNVTB.Size = new System.Drawing.Size(165, 30);
            this.tenNVTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên NV:";
            // 
            // loaitkNBR
            // 
            this.loaitkNBR.Location = new System.Drawing.Point(494, 29);
            this.loaitkNBR.Name = "loaitkNBR";
            this.loaitkNBR.Size = new System.Drawing.Size(164, 30);
            this.loaitkNBR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại TK:";
            // 
            // maNVCBB
            // 
            this.maNVCBB.FormattingEnabled = true;
            this.maNVCBB.Location = new System.Drawing.Point(151, 81);
            this.maNVCBB.Name = "maNVCBB";
            this.maNVCBB.Size = new System.Drawing.Size(165, 33);
            this.maNVCBB.TabIndex = 3;
            this.maNVCBB.SelectedIndexChanged += new System.EventHandler(this.maNVCBB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NV:";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(151, 29);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(165, 30);
            this.UsernameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1042, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tìm theo tên:";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(1168, 30);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(241, 30);
            this.searchTB.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1426, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "FIND";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowBT
            // 
            this.ShowBT.BackColor = System.Drawing.Color.Teal;
            this.ShowBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBT.Location = new System.Drawing.Point(13, 153);
            this.ShowBT.Name = "ShowBT";
            this.ShowBT.Size = new System.Drawing.Size(92, 30);
            this.ShowBT.TabIndex = 19;
            this.ShowBT.Text = "SHOW";
            this.ShowBT.UseVisualStyleBackColor = false;
            this.ShowBT.Click += new System.EventHandler(this.ShowBT_Click);
            // 
            // dtvAccount
            // 
            this.dtvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAccount.Location = new System.Drawing.Point(13, 190);
            this.dtvAccount.Name = "dtvAccount";
            this.dtvAccount.RowHeadersWidth = 51;
            this.dtvAccount.RowTemplate.Height = 24;
            this.dtvAccount.Size = new System.Drawing.Size(1505, 443);
            this.dtvAccount.TabIndex = 20;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1547, 637);
            this.Controls.Add(this.dtvAccount);
            this.Controls.Add(this.ShowBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DELBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.DELBT.ResumeLayout(false);
            this.DELBT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaitkNBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DELBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown loaitkNBR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox maNVCBB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenNVTB;
        private System.Windows.Forms.Button EDITBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ShowBT;
        private System.Windows.Forms.DataGridView dtvAccount;
    }
}