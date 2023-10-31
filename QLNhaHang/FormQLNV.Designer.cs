namespace Form1
{
    partial class FormQLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNV));
            dgv_NV = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button_delete = new Button();
            button_updateInfoNV = new Button();
            label9 = new Label();
            button_back = new Button();
            date_NV = new DateTimePicker();
            cb_GioiTinh = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button_addNV = new Button();
            label11 = new Label();
            txt_HoTen = new TextBox();
            label13 = new Label();
            txt_MaNV = new TextBox();
            label14 = new Label();
            label15 = new Label();
            Clear_InfoNV = new Button();
            txt_numberphone = new TextBox();
            txt_chucvu = new TextBox();
            pictureBox2 = new PictureBox();
            txt_luong = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_NV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_NV
            // 
            dgv_NV.AllowUserToAddRows = false;
            dgv_NV.AllowUserToDeleteRows = false;
            dgv_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NV.BackgroundColor = SystemColors.ControlLightLight;
            dgv_NV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_NV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NV.Columns.AddRange(new DataGridViewColumn[] { MaNV, TenNV, GioiTinh, NgaySinh, Sdt, Column1, Column2 });
            dgv_NV.GridColor = SystemColors.Desktop;
            dgv_NV.Location = new Point(265, 277);
            dgv_NV.Name = "dgv_NV";
            dgv_NV.ReadOnly = true;
            dgv_NV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_NV.RowHeadersWidth = 51;
            dgv_NV.RowTemplate.Height = 29;
            dgv_NV.Size = new Size(952, 377);
            dgv_NV.TabIndex = 0;
            dgv_NV.CellMouseClick += dgv_NV_CellMouseClick;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "TenNV";
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // Sdt
            // 
            Sdt.DataPropertyName = "Sdt";
            Sdt.HeaderText = "Điện thoại";
            Sdt.MinimumWidth = 6;
            Sdt.Name = "Sdt";
            Sdt.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ChucVu";
            Column1.HeaderText = "Chức vụ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Luong";
            Column2.HeaderText = "Lương";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ButtonHighlight;
            button_delete.Cursor = Cursors.Hand;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.ForeColor = SystemColors.ActiveCaptionText;
            button_delete.Image = (Image)resources.GetObject("button_delete.Image");
            button_delete.ImageAlign = ContentAlignment.MiddleLeft;
            button_delete.Location = new Point(967, 216);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(77, 32);
            button_delete.TabIndex = 17;
            button_delete.Text = "Xóa";
            button_delete.TextAlign = ContentAlignment.MiddleRight;
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_updateInfoNV
            // 
            button_updateInfoNV.BackColor = SystemColors.ButtonHighlight;
            button_updateInfoNV.Cursor = Cursors.Hand;
            button_updateInfoNV.FlatStyle = FlatStyle.Flat;
            button_updateInfoNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_updateInfoNV.ForeColor = SystemColors.ActiveCaptionText;
            button_updateInfoNV.Image = (Image)resources.GetObject("button_updateInfoNV.Image");
            button_updateInfoNV.ImageAlign = ContentAlignment.MiddleLeft;
            button_updateInfoNV.Location = new Point(868, 216);
            button_updateInfoNV.Name = "button_updateInfoNV";
            button_updateInfoNV.Size = new Size(82, 32);
            button_updateInfoNV.TabIndex = 16;
            button_updateInfoNV.Text = "Sửa";
            button_updateInfoNV.TextAlign = ContentAlignment.MiddleRight;
            button_updateInfoNV.UseVisualStyleBackColor = false;
            button_updateInfoNV.Click += button_updateInfoNV_Click;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(265, -1);
            label9.Name = "label9";
            label9.Size = new Size(952, 46);
            label9.TabIndex = 18;
            label9.Text = "QUẢN LÝ NHÂN VIÊN";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_back
            // 
            button_back.BackColor = SystemColors.ButtonHighlight;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.ForeColor = SystemColors.ActiveCaptionText;
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.ImageAlign = ContentAlignment.MiddleLeft;
            button_back.Location = new Point(44, 601);
            button_back.Name = "button_back";
            button_back.Size = new Size(104, 40);
            button_back.TabIndex = 19;
            button_back.Text = "Quay lại";
            button_back.TextAlign = ContentAlignment.MiddleRight;
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // date_NV
            // 
            date_NV.CustomFormat = "dd/M/yyyy";
            date_NV.Format = DateTimePickerFormat.Short;
            date_NV.Location = new Point(1026, 79);
            date_NV.Name = "date_NV";
            date_NV.Size = new Size(145, 27);
            date_NV.TabIndex = 58;
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_GioiTinh.Location = new Point(377, 150);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(145, 28);
            cb_GioiTinh.TabIndex = 55;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(918, 156);
            label7.Name = "label7";
            label7.Size = new Size(78, 27);
            label7.TabIndex = 53;
            label7.Text = "Chức vụ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(916, 119);
            label8.Name = "label8";
            label8.Size = new Size(104, 27);
            label8.TabIndex = 51;
            label8.Text = "Số điện thoại";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_addNV
            // 
            button_addNV.BackColor = SystemColors.ButtonHighlight;
            button_addNV.Cursor = Cursors.Hand;
            button_addNV.FlatStyle = FlatStyle.Flat;
            button_addNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_addNV.ForeColor = SystemColors.ActiveCaptionText;
            button_addNV.Image = (Image)resources.GetObject("button_addNV.Image");
            button_addNV.ImageAlign = ContentAlignment.MiddleLeft;
            button_addNV.Location = new Point(766, 216);
            button_addNV.Name = "button_addNV";
            button_addNV.Size = new Size(87, 32);
            button_addNV.TabIndex = 17;
            button_addNV.Text = "Thêm";
            button_addNV.TextAlign = ContentAlignment.MiddleRight;
            button_addNV.UseVisualStyleBackColor = false;
            button_addNV.Click += button_addNV_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(302, 150);
            label11.Name = "label11";
            label11.Size = new Size(78, 27);
            label11.TabIndex = 49;
            label11.Text = "Giới tính";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(377, 115);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(224, 27);
            txt_HoTen.TabIndex = 42;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(916, 83);
            label13.Name = "label13";
            label13.Size = new Size(80, 27);
            label13.TabIndex = 46;
            label13.Text = "Ngày sinh";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(377, 79);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(145, 27);
            txt_MaNV.TabIndex = 44;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(302, 115);
            label14.Name = "label14";
            label14.Size = new Size(78, 27);
            label14.TabIndex = 43;
            label14.Text = "Họ tên";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(302, 82);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 41;
            label15.Text = "Mã NV";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Clear_InfoNV
            // 
            Clear_InfoNV.BackColor = SystemColors.ButtonHighlight;
            Clear_InfoNV.Cursor = Cursors.Hand;
            Clear_InfoNV.FlatStyle = FlatStyle.Flat;
            Clear_InfoNV.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Clear_InfoNV.ForeColor = SystemColors.ActiveCaptionText;
            Clear_InfoNV.Image = (Image)resources.GetObject("Clear_InfoNV.Image");
            Clear_InfoNV.ImageAlign = ContentAlignment.MiddleLeft;
            Clear_InfoNV.Location = new Point(1059, 216);
            Clear_InfoNV.Name = "Clear_InfoNV";
            Clear_InfoNV.Size = new Size(112, 32);
            Clear_InfoNV.TabIndex = 59;
            Clear_InfoNV.Text = "Làm mới";
            Clear_InfoNV.TextAlign = ContentAlignment.MiddleRight;
            Clear_InfoNV.UseVisualStyleBackColor = false;
            Clear_InfoNV.Click += Clear_InfoNV_Click;
            // 
            // txt_numberphone
            // 
            txt_numberphone.Location = new Point(1026, 119);
            txt_numberphone.Name = "txt_numberphone";
            txt_numberphone.Size = new Size(145, 27);
            txt_numberphone.TabIndex = 60;
            // 
            // txt_chucvu
            // 
            txt_chucvu.Location = new Point(1026, 156);
            txt_chucvu.Name = "txt_chucvu";
            txt_chucvu.Size = new Size(145, 27);
            txt_chucvu.TabIndex = 61;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 230);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // txt_luong
            // 
            txt_luong.Location = new Point(377, 184);
            txt_luong.Name = "txt_luong";
            txt_luong.Size = new Size(145, 27);
            txt_luong.TabIndex = 62;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(302, 184);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 63;
            label1.Text = "Lương";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormQLNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1212, 653);
            Controls.Add(label1);
            Controls.Add(txt_luong);
            Controls.Add(txt_chucvu);
            Controls.Add(txt_numberphone);
            Controls.Add(Clear_InfoNV);
            Controls.Add(date_NV);
            Controls.Add(button_addNV);
            Controls.Add(label7);
            Controls.Add(button_delete);
            Controls.Add(button_updateInfoNV);
            Controls.Add(cb_GioiTinh);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(button_back);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(dgv_NV);
            Controls.Add(label11);
            Controls.Add(txt_HoTen);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txt_MaNV);
            Name = "FormQLNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLNV";
            Load += ListNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_NV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_NV;
        private Button button_delete;
        private Button button_updateInfoNV;
        private Label label9;
        private Button button_back;
        private DateTimePicker date_NV;
        private ComboBox cb_GioiTinh;
        private Label label7;
        private Label label8;
        private Button button_addNV;
        private Label label11;
        private TextBox txt_HoTen;
        private Label label13;
        private TextBox txt_MaNV;
        private Label label14;
        private Label label15;
        private Button Clear_InfoNV;
        private TextBox txt_numberphone;
        private TextBox txt_chucvu;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txt_luong;
        private Label label1;
    }
}