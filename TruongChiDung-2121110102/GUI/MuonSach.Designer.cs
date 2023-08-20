namespace TruongChiDung_2121110102.GUI
{
    partial class MuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonSach));
            this.label1 = new System.Windows.Forms.Label();
            this.dsm1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.TextBox();
            this.Tdg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Del = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.Mpm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsm1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Mượn";
            // 
            // dsm1
            // 
            this.dsm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsm1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dsm1.Location = new System.Drawing.Point(532, 61);
            this.dsm1.Name = "dsm1";
            this.dsm1.RowHeadersWidth = 51;
            this.dsm1.RowTemplate.Height = 24;
            this.dsm1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsm1.Size = new System.Drawing.Size(560, 440);
            this.dsm1.TabIndex = 1;
            this.dsm1.SelectionChanged += new System.EventHandler(this.dsm1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu Mượn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Đọc Giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Sản Phẩm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Hẹn Trả";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sl);
            this.panel1.Controls.Add(this.Tdg);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Del);
            this.panel1.Controls.Add(this.STT);
            this.panel1.Controls.Add(this.MS);
            this.panel1.Controls.Add(this.Mpm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 440);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số Lượng Còn Lại";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 24);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 296);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày Hẹn Trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mã Sản Phẩm";
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(120, 251);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(205, 22);
            this.sl.TabIndex = 22;
            this.sl.TextChanged += new System.EventHandler(this.sl_TextChanged);
            // 
            // Tdg
            // 
            this.Tdg.Location = new System.Drawing.Point(126, 108);
            this.Tdg.Name = "Tdg";
            this.Tdg.Size = new System.Drawing.Size(199, 22);
            this.Tdg.TabIndex = 20;
            this.Tdg.TextChanged += new System.EventHandler(this.Tdg_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tên Đọc Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số Lượng";
            // 
            // Del
            // 
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del.Location = new System.Drawing.Point(160, 377);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(90, 60);
            this.Del.TabIndex = 17;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // STT
            // 
            this.STT.Image = ((System.Drawing.Image)(resources.GetObject("STT.Image")));
            this.STT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.STT.Location = new System.Drawing.Point(279, 377);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(99, 60);
            this.STT.TabIndex = 16;
            this.STT.Text = "Sửa";
            this.STT.UseVisualStyleBackColor = true;
            this.STT.Click += new System.EventHandler(this.STT_Click);
            // 
            // MS
            // 
            this.MS.Image = ((System.Drawing.Image)(resources.GetObject("MS.Image")));
            this.MS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MS.Location = new System.Drawing.Point(26, 377);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(116, 60);
            this.MS.TabIndex = 13;
            this.MS.Text = "Mượn Sách";
            this.MS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // Mpm
            // 
            this.Mpm.Location = new System.Drawing.Point(125, 52);
            this.Mpm.Name = "Mpm";
            this.Mpm.Size = new System.Drawing.Size(199, 22);
            this.Mpm.TabIndex = 7;
            this.Mpm.TextChanged += new System.EventHandler(this.Mpm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Phiếu Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông Tin Mượn Sách";
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(3, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(33, 26);
            this.Back.TabIndex = 20;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 513);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dsm1);
            this.Controls.Add(this.label1);
            this.Name = "MuonSach";
            this.Text = "MuonSach";
            this.Load += new System.EventHandler(this.MuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsm1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button STT;
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.TextBox Mpm;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tdg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}