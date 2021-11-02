
namespace MovieTheater
{
    partial class GenreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.EditBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.motaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tentlTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maTLTB = new System.Windows.Forms.TextBox();
            this.TheloaiIDLB = new System.Windows.Forms.Label();
            this.genreDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShowBT);
            this.panel1.Controls.Add(this.deleteBT);
            this.panel1.Controls.Add(this.EditBT);
            this.panel1.Controls.Add(this.addBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 631);
            this.panel1.TabIndex = 0;
            // 
            // ShowBT
            // 
            this.ShowBT.BackColor = System.Drawing.Color.Teal;
            this.ShowBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBT.Location = new System.Drawing.Point(7, 446);
            this.ShowBT.Name = "ShowBT";
            this.ShowBT.Size = new System.Drawing.Size(450, 93);
            this.ShowBT.TabIndex = 5;
            this.ShowBT.Text = "Show";
            this.ShowBT.UseVisualStyleBackColor = false;
            this.ShowBT.Click += new System.EventHandler(this.ShowBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.Color.Teal;
            this.deleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(155, 281);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(152, 67);
            this.deleteBT.TabIndex = 4;
            this.deleteBT.Text = "Xóa";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // EditBT
            // 
            this.EditBT.BackColor = System.Drawing.Color.Teal;
            this.EditBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBT.Location = new System.Drawing.Point(313, 281);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(140, 67);
            this.EditBT.TabIndex = 3;
            this.EditBT.Text = "Sửa";
            this.EditBT.UseVisualStyleBackColor = false;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // addBT
            // 
            this.addBT.BackColor = System.Drawing.Color.Teal;
            this.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(8, 281);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(143, 67);
            this.addBT.TabIndex = 2;
            this.addBT.Text = "Thêm";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.motaTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tentlTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.maTLTB);
            this.panel2.Controls.Add(this.TheloaiIDLB);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 267);
            this.panel2.TabIndex = 1;
            // 
            // motaTB
            // 
            this.motaTB.Location = new System.Drawing.Point(137, 120);
            this.motaTB.Multiline = true;
            this.motaTB.Name = "motaTB";
            this.motaTB.Size = new System.Drawing.Size(296, 125);
            this.motaTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả:";
            // 
            // tentlTB
            // 
            this.tentlTB.Location = new System.Drawing.Point(137, 63);
            this.tentlTB.Multiline = true;
            this.tentlTB.Name = "tentlTB";
            this.tentlTB.Size = new System.Drawing.Size(296, 33);
            this.tentlTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên thể loại:";
            // 
            // maTLTB
            // 
            this.maTLTB.Location = new System.Drawing.Point(137, 9);
            this.maTLTB.Multiline = true;
            this.maTLTB.Name = "maTLTB";
            this.maTLTB.Size = new System.Drawing.Size(296, 33);
            this.maTLTB.TabIndex = 1;
            // 
            // TheloaiIDLB
            // 
            this.TheloaiIDLB.AutoSize = true;
            this.TheloaiIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheloaiIDLB.Location = new System.Drawing.Point(10, 17);
            this.TheloaiIDLB.Name = "TheloaiIDLB";
            this.TheloaiIDLB.Size = new System.Drawing.Size(113, 25);
            this.TheloaiIDLB.TabIndex = 0;
            this.TheloaiIDLB.Text = "Mã thể loại:";
            // 
            // genreDGV
            // 
            this.genreDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genreDGV.ColumnHeadersHeight = 29;
            this.genreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.genreDGV.Location = new System.Drawing.Point(476, 4);
            this.genreDGV.Name = "genreDGV";
            this.genreDGV.RowHeadersWidth = 51;
            this.genreDGV.RowTemplate.Height = 24;
            this.genreDGV.Size = new System.Drawing.Size(766, 631);
            this.genreDGV.TabIndex = 1;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.genreDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenreForm";
            this.Text = "Genre";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView genreDGV;
        private System.Windows.Forms.Label TheloaiIDLB;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox motaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tentlTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maTLTB;
        private System.Windows.Forms.Button ShowBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button EditBT;
    }
}