namespace TruongChiDung_2121110102.GUI
{
    partial class GiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masp = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.tensp = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPic = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rs = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgvSanPham.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvSanPham.Location = new System.Drawing.Point(15, 12);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1016, 338);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng Tồn Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(325, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá Sản Phẩm";
            // 
            // masp
            // 
            this.masp.Enabled = false;
            this.masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masp.Location = new System.Drawing.Point(132, 422);
            this.masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(153, 27);
            this.masp.TabIndex = 6;
            // 
            // soluong
            // 
            this.soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(132, 537);
            this.soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(153, 27);
            this.soluong.TabIndex = 7;
            this.soluong.TextChanged += new System.EventHandler(this.soluong_TextChanged);
            // 
            // tensp
            // 
            this.tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensp.Location = new System.Drawing.Point(132, 481);
            this.tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tensp.Name = "tensp";
            this.tensp.Size = new System.Drawing.Size(153, 27);
            this.tensp.TabIndex = 8;
            this.tensp.TextChanged += new System.EventHandler(this.tensp_TextChanged);
            // 
            // gia
            // 
            this.gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(424, 422);
            this.gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(121, 27);
            this.gia.TabIndex = 9;
            this.gia.TextChanged += new System.EventHandler(this.gia_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(827, 378);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 143);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(546, 574);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(92, 47);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Thêm";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(670, 573);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 48);
            this.btEdit.TabIndex = 15;
            this.btEdit.Text = "Sửa";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(776, 575);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(79, 46);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Xóa";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPic
            // 
            this.btPic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btPic.Image = ((System.Drawing.Image)(resources.GetObject("btPic.Image")));
            this.btPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPic.Location = new System.Drawing.Point(904, 575);
            this.btPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPic.Name = "btPic";
            this.btPic.Size = new System.Drawing.Size(81, 46);
            this.btPic.TabIndex = 17;
            this.btPic.Text = "Ảnh";
            this.btPic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPic.UseVisualStyleBackColor = true;
            this.btPic.Click += new System.EventHandler(this.btPic_Click);
            // 
            // btExit
            // 
            this.btExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.Location = new System.Drawing.Point(1025, 573);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(91, 46);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "Quay Lại";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLoad
            // 
            this.btLoad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btLoad.Image = ((System.Drawing.Image)(resources.GetObject("btLoad.Image")));
            this.btLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoad.Location = new System.Drawing.Point(5, 574);
            this.btLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(133, 46);
            this.btLoad.TabIndex = 19;
            this.btLoad.Text = "Xuất Excel";
            this.btLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(15, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhập từ khóa";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(132, 370);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(153, 27);
            this.search.TabIndex = 23;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(325, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thể Loại Sách";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 494);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // rs
            // 
            this.rs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rs.Image = ((System.Drawing.Image)(resources.GetObject("rs.Image")));
            this.rs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rs.Location = new System.Drawing.Point(434, 575);
            this.rs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(93, 46);
            this.rs.TabIndex = 26;
            this.rs.Text = "Tạo Lại";
            this.rs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rs.UseVisualStyleBackColor = true;
            this.rs.Click += new System.EventHandler(this.rs_Click);
            // 
            // PDF
            // 
            this.PDF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PDF.Image = ((System.Drawing.Image)(resources.GetObject("PDF.Image")));
            this.PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PDF.Location = new System.Drawing.Point(292, 574);
            this.PDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(126, 46);
            this.PDF.TabIndex = 27;
            this.PDF.Text = "Xuất PDF";
            this.PDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng Tồn Kho";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá Sản Phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nhà Cung Cấp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hình Ảnh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 631);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPic);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gia);
            this.Controls.Add(this.tensp);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.masp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSanPham);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GiaoDien";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GiaoDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox masp;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.TextBox tensp;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button rs;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}