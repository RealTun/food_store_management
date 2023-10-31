namespace Form1
{
    partial class QLKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKho));
            btn_refresh = new Button();
            dgv_stock = new DataGridView();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TienLai = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            txt_soluong = new TextBox();
            label_date = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label2 = new Label();
            txt_donGia = new TextBox();
            txt_maNL = new TextBox();
            label10 = new Label();
            txt_tenNL = new TextBox();
            label1 = new Label();
            datePickHSD = new DateTimePicker();
            label3 = new Label();
            btn_search = new Button();
            dateSearch = new DateTimePicker();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = SystemColors.ButtonHighlight;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = SystemColors.ActiveCaptionText;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.Location = new Point(678, 275);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(107, 36);
            btn_refresh.TabIndex = 57;
            btn_refresh.Text = "Làm mới";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dgv_stock
            // 
            dgv_stock.AllowUserToAddRows = false;
            dgv_stock.AllowUserToDeleteRows = false;
            dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_stock.BackgroundColor = SystemColors.ControlLightLight;
            dgv_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_stock.Columns.AddRange(new DataGridViewColumn[] { MaMon, TenMon, DonGia, TienLai, ThoiGian });
            dgv_stock.GridColor = SystemColors.Desktop;
            dgv_stock.Location = new Point(316, 334);
            dgv_stock.MultiSelect = false;
            dgv_stock.Name = "dgv_stock";
            dgv_stock.ReadOnly = true;
            dgv_stock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_stock.RowHeadersWidth = 51;
            dgv_stock.RowTemplate.Height = 29;
            dgv_stock.Size = new Size(968, 372);
            dgv_stock.TabIndex = 56;
            dgv_stock.CellMouseClick += dgv_stock_CellMouseClick;
            // 
            // MaMon
            // 
            MaMon.DataPropertyName = "MaNL";
            MaMon.HeaderText = "Mã nguyên liệu";
            MaMon.MinimumWidth = 6;
            MaMon.Name = "MaMon";
            MaMon.ReadOnly = true;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenNL";
            TenMon.HeaderText = "Tên nguyên liệu";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            TenMon.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // TienLai
            // 
            TienLai.DataPropertyName = "Soluong";
            TienLai.HeaderText = "Số lượng";
            TienLai.MinimumWidth = 6;
            TienLai.Name = "TienLai";
            TienLai.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "HSD";
            ThoiGian.HeaderText = "Hạn sử dụng";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // txt_soluong
            // 
            txt_soluong.BorderStyle = BorderStyle.FixedSingle;
            txt_soluong.Location = new Point(771, 106);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(182, 27);
            txt_soluong.TabIndex = 3;
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_date.ImageAlign = ContentAlignment.MiddleLeft;
            label_date.Location = new Point(695, 159);
            label_date.Name = "label_date";
            label_date.Size = new Size(39, 20);
            label_date.TabIndex = 54;
            label_date.Text = "HSD";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ButtonHighlight;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ActiveCaptionText;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(554, 275);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 36);
            btn_delete.TabIndex = 51;
            btn_delete.Text = "Xóa";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ButtonHighlight;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = SystemColors.ActiveCaptionText;
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(436, 275);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 38);
            btn_update.TabIndex = 52;
            btn_update.Text = "Sửa";
            btn_update.TextAlign = ContentAlignment.MiddleRight;
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ButtonHighlight;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = SystemColors.ActiveCaptionText;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(316, 275);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 37);
            btn_add.TabIndex = 53;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 198);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 50;
            label2.Text = "Đơn giá";
            // 
            // txt_donGia
            // 
            txt_donGia.BorderStyle = BorderStyle.FixedSingle;
            txt_donGia.Location = new Point(437, 195);
            txt_donGia.Name = "txt_donGia";
            txt_donGia.Size = new Size(182, 27);
            txt_donGia.TabIndex = 2;
            // 
            // txt_maNL
            // 
            txt_maNL.BorderStyle = BorderStyle.FixedSingle;
            txt_maNL.Location = new Point(437, 111);
            txt_maNL.Name = "txt_maNL";
            txt_maNL.Size = new Size(182, 27);
            txt_maNL.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(315, 156);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 47;
            label10.Text = "Tên nguyên liệu";
            // 
            // txt_tenNL
            // 
            txt_tenNL.BorderStyle = BorderStyle.FixedSingle;
            txt_tenNL.Location = new Point(437, 153);
            txt_tenNL.Name = "txt_tenNL";
            txt_tenNL.Size = new Size(182, 27);
            txt_tenNL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 113);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 45;
            label1.Text = "Mã nguyên liệu";
            // 
            // datePickHSD
            // 
            datePickHSD.Format = DateTimePickerFormat.Short;
            datePickHSD.Location = new Point(771, 154);
            datePickHSD.Name = "datePickHSD";
            datePickHSD.Size = new Size(182, 27);
            datePickHSD.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(695, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 63;
            label3.Text = "Số lượng";
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(1192, 298);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(78, 30);
            btn_search.TabIndex = 65;
            btn_search.Text = "Lọc";
            btn_search.TextAlign = ContentAlignment.MiddleRight;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // dateSearch
            // 
            dateSearch.Format = DateTimePickerFormat.Short;
            dateSearch.Location = new Point(1008, 298);
            dateSearch.Name = "dateSearch";
            dateSearch.Size = new Size(162, 27);
            dateSearch.TabIndex = 66;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 230);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(267, 1);
            label9.Name = "label9";
            label9.Size = new Size(1017, 46);
            label9.TabIndex = 68;
            label9.Text = "QUẢN LÝ NGUYÊN LIỆU";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QLKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1282, 706);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(dateSearch);
            Controls.Add(btn_search);
            Controls.Add(label3);
            Controls.Add(datePickHSD);
            Controls.Add(btn_refresh);
            Controls.Add(dgv_stock);
            Controls.Add(txt_soluong);
            Controls.Add(label_date);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(txt_donGia);
            Controls.Add(txt_maNL);
            Controls.Add(label10);
            Controls.Add(txt_tenNL);
            Controls.Add(label1);
            Name = "QLKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLKho";
            Load += QLKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_refresh;
        private DataGridView dgv_stock;
        private TextBox txt_soluong;
        private Label label_date;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label2;
        private TextBox txt_donGia;
        private TextBox txt_maNL;
        private Label label10;
        private TextBox txt_tenNL;
        private Label label1;
        private DateTimePicker datePickHSD;
        private Label label3;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TienLai;
        private DataGridViewTextBoxColumn ThoiGian;
        private Button btn_search;
        private DateTimePicker dateSearch;
        private PictureBox pictureBox2;
        private Label label9;
    }
}