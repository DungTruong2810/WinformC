namespace TruongChiDung_2121110102.GUI
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.QLNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mnv = new System.Windows.Forms.TextBox();
            this.tnv = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.bted = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.QLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // QLNV
            // 
            this.QLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.QLNV.Location = new System.Drawing.Point(13, 103);
            this.QLNV.Name = "QLNV";
            this.QLNV.RowHeadersWidth = 51;
            this.QLNV.RowTemplate.Height = 24;
            this.QLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QLNV.Size = new System.Drawing.Size(533, 396);
            this.QLNV.TabIndex = 0;
            this.QLNV.SelectionChanged += new System.EventHandler(this.QLNV_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa Chỉ";
            // 
            // mnv
            // 
            this.mnv.Location = new System.Drawing.Point(741, 103);
            this.mnv.Name = "mnv";
            this.mnv.Size = new System.Drawing.Size(240, 22);
            this.mnv.TabIndex = 7;
            this.mnv.TextChanged += new System.EventHandler(this.mnv_TextChanged);
            this.mnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mnv_KeyPress);
            // 
            // tnv
            // 
            this.tnv.Location = new System.Drawing.Point(741, 159);
            this.tnv.Name = "tnv";
            this.tnv.Size = new System.Drawing.Size(240, 22);
            this.tnv.TabIndex = 8;
            this.tnv.TextChanged += new System.EventHandler(this.tnv_TextChanged);
            this.tnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tnv_KeyPress);
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(741, 327);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(240, 22);
            this.dc.TabIndex = 11;
            // 
            // btadd
            // 
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(601, 437);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(79, 49);
            this.btadd.TabIndex = 13;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdel
            // 
            this.btdel.Image = ((System.Drawing.Image)(resources.GetObject("btdel.Image")));
            this.btdel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdel.Location = new System.Drawing.Point(725, 437);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(79, 49);
            this.btdel.TabIndex = 14;
            this.btdel.Text = "Xóa";
            this.btdel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // bted
            // 
            this.bted.Image = ((System.Drawing.Image)(resources.GetObject("bted.Image")));
            this.bted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bted.Location = new System.Drawing.Point(860, 437);
            this.bted.Name = "bted";
            this.bted.Size = new System.Drawing.Size(79, 49);
            this.bted.TabIndex = 15;
            this.bted.Text = "Sửa";
            this.bted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bted.UseVisualStyleBackColor = true;
            this.bted.Click += new System.EventHandler(this.bted_Click);
            // 
            // btback
            // 
            this.btback.Image = ((System.Drawing.Image)(resources.GetObject("btback.Image")));
            this.btback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btback.Location = new System.Drawing.Point(999, 437);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(98, 49);
            this.btback.TabIndex = 16;
            this.btback.Text = "Quay Lại";
            this.btback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quản Lý Nhân Viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(741, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(741, 273);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 19;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(878, 273);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 20;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 511);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.bted);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.tnv);
            this.Controls.Add(this.mnv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QLNV);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mnv;
        private System.Windows.Forms.TextBox tnv;
        private System.Windows.Forms.TextBox dc;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button bted;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}