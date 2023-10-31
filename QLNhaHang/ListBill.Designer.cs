namespace Form1
{
    partial class ListBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBill));
            dgv_HD = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            txt_search = new TextBox();
            btn_search = new Button();
            pictureBox1 = new PictureBox();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_HD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_HD
            // 
            dgv_HD.AllowUserToAddRows = false;
            dgv_HD.AllowUserToDeleteRows = false;
            dgv_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HD.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_HD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_HD.ColumnHeadersHeight = 29;
            dgv_HD.Columns.AddRange(new DataGridViewColumn[] { MaHD, TenKH, SoTien, ThoiGian });
            dgv_HD.Dock = DockStyle.Bottom;
            dgv_HD.GridColor = SystemColors.Desktop;
            dgv_HD.Location = new Point(0, 233);
            dgv_HD.MultiSelect = false;
            dgv_HD.Name = "dgv_HD";
            dgv_HD.ReadOnly = true;
            dgv_HD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_HD.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgv_HD.RowTemplate.Height = 29;
            dgv_HD.Size = new Size(677, 408);
            dgv_HD.TabIndex = 0;
            dgv_HD.CellMouseDoubleClick += dgv_HD_CellMouseDoubleClick;
            // 
            // MaHD
            // 
            MaHD.DataPropertyName = "MaHD";
            MaHD.HeaderText = "Mã hóa đơn";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // SoTien
            // 
            SoTien.DataPropertyName = "SoTien";
            SoTien.HeaderText = "Tổng tiền";
            SoTien.MinimumWidth = 6;
            SoTien.Name = "SoTien";
            SoTien.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txt_search.Location = new Point(393, 179);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(133, 27);
            txt_search.TabIndex = 4;
            txt_search.Text = "Nhập số hóa đơn";
            txt_search.DoubleClick += txt_search_DoubleClick;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ControlLightLight;
            btn_search.FlatStyle = FlatStyle.Popup;
            btn_search.ForeColor = SystemColors.ControlLightLight;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.Location = new Point(542, 178);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(51, 29);
            btn_search.TabIndex = 5;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(677, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = SystemColors.ControlLightLight;
            btn_refresh.FlatStyle = FlatStyle.Popup;
            btn_refresh.ForeColor = SystemColors.ControlLightLight;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.Location = new Point(614, 179);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(51, 29);
            btn_refresh.TabIndex = 7;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // ListBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(677, 641);
            Controls.Add(btn_refresh);
            Controls.Add(pictureBox1);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(dgv_HD);
            Name = "ListBill";
            Text = "HoaDon";
            Load += QuanLyHD_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_HD;
        private TextBox txt_search;
        private Button btn_search;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn SoTien;
        private DataGridViewTextBoxColumn ThoiGian;
        private Button btn_refresh;
    }
}