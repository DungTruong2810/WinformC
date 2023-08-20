namespace TruongChiDung_2121110102.GUI
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            this.label1 = new System.Windows.Forms.Label();
            this.btĐX = new System.Windows.Forms.Button();
            this.btEX = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảSáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ Thống Quản Lý Thư Viện";
            // 
            // btĐX
            // 
            this.btĐX.Location = new System.Drawing.Point(689, 440);
            this.btĐX.Name = "btĐX";
            this.btĐX.Size = new System.Drawing.Size(107, 45);
            this.btĐX.TabIndex = 6;
            this.btĐX.Text = "Đăng Xuất";
            this.btĐX.UseVisualStyleBackColor = true;
            this.btĐX.Click += new System.EventHandler(this.btĐX_Click);
            // 
            // btEX
            // 
            this.btEX.Location = new System.Drawing.Point(830, 440);
            this.btEX.Name = "btEX";
            this.btEX.Size = new System.Drawing.Size(95, 45);
            this.btEX.TabIndex = 7;
            this.btEX.Text = "Thoát";
            this.btEX.UseVisualStyleBackColor = true;
            this.btEX.Click += new System.EventHandler(this.btEX_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDiệnToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDiệnToolStripMenuItem
            // 
            this.giaoDiệnToolStripMenuItem.Name = "giaoDiệnToolStripMenuItem";
            this.giaoDiệnToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.giaoDiệnToolStripMenuItem.Text = "Giao Diện";
            this.giaoDiệnToolStripMenuItem.Click += new System.EventHandler(this.giaoDiệnToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMượnTrảSáchToolStripMenuItem1,
            this.quảnLýTácGiảToolStripMenuItem,
            this.đọcGiảToolStripMenuItem});
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Danh Mục";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảSáchToolStripMenuItem1
            // 
            this.quảnLýMượnTrảSáchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.quảnLýMượnTrảSáchToolStripMenuItem1.Name = "quảnLýMượnTrảSáchToolStripMenuItem1";
            this.quảnLýMượnTrảSáchToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.quảnLýMượnTrảSáchToolStripMenuItem1.Text = "Quản Lý Mượn-Trả Sách";
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mượnSáchToolStripMenuItem.Text = "Mượn Sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.trảSáchToolStripMenuItem.Text = "Trả Sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản Lý Tác Giả";
            // 
            // đọcGiảToolStripMenuItem
            // 
            this.đọcGiảToolStripMenuItem.Name = "đọcGiảToolStripMenuItem";
            this.đọcGiảToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.đọcGiảToolStripMenuItem.Text = "Đọc Giả";
            this.đọcGiảToolStripMenuItem.Click += new System.EventHandler(this.đọcGiảToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(993, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btEX);
            this.Controls.Add(this.btĐX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DanhMuc";
            this.Text = "DanhMuc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btĐX;
        private System.Windows.Forms.Button btEX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảSáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcGiảToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
    }
}