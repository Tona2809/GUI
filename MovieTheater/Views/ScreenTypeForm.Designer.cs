
namespace MovieTheater.Views
{
    partial class ScreenTypeForm
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
            this.dgvscreen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maIDTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.ADDBT = new System.Windows.Forms.Button();
            this.editBT = new System.Windows.Forms.Button();
            this.delBT = new System.Windows.Forms.Button();
            this.showBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.showBT);
            this.panel1.Controls.Add(this.delBT);
            this.panel1.Controls.Add(this.editBT);
            this.panel1.Controls.Add(this.ADDBT);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.maIDTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 418);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvscreen
            // 
            this.dgvscreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvscreen.ColumnHeadersHeight = 29;
            this.dgvscreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvscreen.Location = new System.Drawing.Point(433, 13);
            this.dgvscreen.Name = "dgvscreen";
            this.dgvscreen.RowHeadersWidth = 51;
            this.dgvscreen.RowTemplate.Height = 24;
            this.dgvscreen.Size = new System.Drawing.Size(801, 612);
            this.dgvscreen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã loại màn hình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên màn hình:";
            // 
            // maIDTB
            // 
            this.maIDTB.Location = new System.Drawing.Point(20, 95);
            this.maIDTB.Multiline = true;
            this.maIDTB.Name = "maIDTB";
            this.maIDTB.Size = new System.Drawing.Size(378, 41);
            this.maIDTB.TabIndex = 5;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(20, 211);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(378, 41);
            this.nameTB.TabIndex = 6;
            // 
            // ADDBT
            // 
            this.ADDBT.BackColor = System.Drawing.Color.Teal;
            this.ADDBT.Location = new System.Drawing.Point(20, 274);
            this.ADDBT.Name = "ADDBT";
            this.ADDBT.Size = new System.Drawing.Size(161, 49);
            this.ADDBT.TabIndex = 7;
            this.ADDBT.Text = "ADD";
            this.ADDBT.UseVisualStyleBackColor = false;
            this.ADDBT.Click += new System.EventHandler(this.ADDBT_Click);
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.Teal;
            this.editBT.Location = new System.Drawing.Point(239, 274);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(159, 49);
            this.editBT.TabIndex = 8;
            this.editBT.Text = "EDIT";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // delBT
            // 
            this.delBT.BackColor = System.Drawing.Color.Teal;
            this.delBT.Location = new System.Drawing.Point(20, 353);
            this.delBT.Name = "delBT";
            this.delBT.Size = new System.Drawing.Size(161, 49);
            this.delBT.TabIndex = 9;
            this.delBT.Text = "DELETE";
            this.delBT.UseVisualStyleBackColor = false;
            this.delBT.Click += new System.EventHandler(this.delBT_Click);
            // 
            // showBT
            // 
            this.showBT.BackColor = System.Drawing.Color.Teal;
            this.showBT.Location = new System.Drawing.Point(239, 353);
            this.showBT.Name = "showBT";
            this.showBT.Size = new System.Drawing.Size(159, 49);
            this.showBT.TabIndex = 10;
            this.showBT.Text = "SHOW";
            this.showBT.UseVisualStyleBackColor = false;
            this.showBT.Click += new System.EventHandler(this.showBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "SCREENTYPE";
            // 
            // ScreenTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.dgvscreen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenTypeForm";
            this.Text = "ScreenTypeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvscreen;
        private System.Windows.Forms.Button showBT;
        private System.Windows.Forms.Button delBT;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Button ADDBT;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox maIDTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}