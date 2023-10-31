namespace Form1
{
    partial class FormQLLL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLLL));
            cb_TenNV = new ComboBox();
            label1 = new Label();
            label9 = new Label();
            label7 = new Label();
            button_back = new Button();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            dateWorkPick = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cb_calam = new ComboBox();
            btn_add = new Button();
            dgv_lichlam = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btn_delete = new Button();
            btn_update = new Button();
            btn_search = new Button();
            btn_luong = new Button();
            txt_manv = new TextBox();
            label4 = new Label();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_lichlam).BeginInit();
            SuspendLayout();
            // 
            // cb_TenNV
            // 
            cb_TenNV.DisplayMember = "string";
            cb_TenNV.FormattingEnabled = true;
            cb_TenNV.Location = new Point(324, 126);
            cb_TenNV.Name = "cb_TenNV";
            cb_TenNV.Size = new Size(185, 28);
            cb_TenNV.TabIndex = 1;
            cb_TenNV.ValueMember = "string";
            cb_TenNV.SelectedValueChanged += cb_TenNV_SelectedValueChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(324, 98);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 2;
            label1.Text = "Chọn nhân viên";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(324, 0);
            label9.Name = "label9";
            label9.Size = new Size(908, 76);
            label9.TabIndex = 19;
            label9.Text = "LỊCH LÀM";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(-473, 68);
            label7.Name = "label7";
            label7.Size = new Size(307, 661);
            label7.TabIndex = 20;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_back
            // 
            button_back.BackColor = SystemColors.ControlLightLight;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.ForeColor = SystemColors.ControlText;
            button_back.Location = new Point(59, 591);
            button_back.Name = "button_back";
            button_back.Size = new Size(84, 35);
            button_back.TabIndex = 27;
            button_back.Text = "Quay lại";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Info;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(59, 321);
            label11.Name = "label11";
            label11.Size = new Size(174, 91);
            label11.TabIndex = 30;
            label11.Text = "Note:\r\nCA 1: 7H- 12H\r\nCA 2: 12H - 17H\r\nCA 3: 17H- 22H\r\n\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // dateWorkPick
            // 
            dateWorkPick.Format = DateTimePickerFormat.Short;
            dateWorkPick.Location = new Point(324, 201);
            dateWorkPick.Name = "dateWorkPick";
            dateWorkPick.Size = new Size(174, 27);
            dateWorkPick.TabIndex = 35;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(324, 172);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 36;
            label2.Text = "Chọn ngày làm";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(564, 172);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 38;
            label3.Text = "Chọn ca làm";
            // 
            // cb_calam
            // 
            cb_calam.DisplayMember = "string";
            cb_calam.FormattingEnabled = true;
            cb_calam.Items.AddRange(new object[] { "1", "2", "3" });
            cb_calam.Location = new Point(564, 200);
            cb_calam.Name = "cb_calam";
            cb_calam.Size = new Size(185, 28);
            cb_calam.TabIndex = 37;
            cb_calam.ValueMember = "string";
            // 
            // btn_add
            // 
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(907, 126);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 29);
            btn_add.TabIndex = 39;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_lichlam
            // 
            dgv_lichlam.AllowUserToAddRows = false;
            dgv_lichlam.AllowUserToDeleteRows = false;
            dgv_lichlam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lichlam.BackgroundColor = SystemColors.ControlLightLight;
            dgv_lichlam.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_lichlam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lichlam.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column3, Column2 });
            dgv_lichlam.Location = new Point(324, 261);
            dgv_lichlam.Name = "dgv_lichlam";
            dgv_lichlam.ReadOnly = true;
            dgv_lichlam.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_lichlam.RowHeadersWidth = 51;
            dgv_lichlam.RowTemplate.Height = 29;
            dgv_lichlam.Size = new Size(908, 396);
            dgv_lichlam.TabIndex = 40;
            dgv_lichlam.CellMouseClick += dgv_lichlam_CellMouseClick;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MaNV";
            Column4.HeaderText = "Mã nhân viên";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenNV";
            Column1.HeaderText = "Tên nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Ca";
            Column3.HeaderText = "Ca làm";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "NgayLam";
            Column2.HeaderText = "Ngày làm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(1130, 126);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 29);
            btn_delete.TabIndex = 41;
            btn_delete.Text = "Xóa";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(1019, 126);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(86, 29);
            btn_update.TabIndex = 42;
            btn_update.Text = "Sửa";
            btn_update.TextAlign = ContentAlignment.MiddleRight;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(909, 203);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(82, 29);
            btn_search.TabIndex = 43;
            btn_search.Text = "Lọc";
            btn_search.TextAlign = ContentAlignment.MiddleRight;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_luong
            // 
            btn_luong.FlatStyle = FlatStyle.Flat;
            btn_luong.Image = (Image)resources.GetObject("btn_luong.Image");
            btn_luong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_luong.Location = new Point(1107, 202);
            btn_luong.Name = "btn_luong";
            btn_luong.Size = new Size(113, 30);
            btn_luong.TabIndex = 44;
            btn_luong.Text = "Xem lương";
            btn_luong.TextAlign = ContentAlignment.MiddleRight;
            btn_luong.UseVisualStyleBackColor = true;
            btn_luong.Click += btn_luong_Click;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(564, 125);
            txt_manv.Name = "txt_manv";
            txt_manv.ReadOnly = true;
            txt_manv.Size = new Size(185, 27);
            txt_manv.TabIndex = 45;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(564, 95);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 46;
            label4.Text = "Mã nhân viên";
            // 
            // btn_refresh
            // 
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.Location = new Point(997, 203);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(104, 29);
            btn_refresh.TabIndex = 47;
            btn_refresh.Text = "Làm mới";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // FormQLLL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1232, 653);
            Controls.Add(btn_refresh);
            Controls.Add(label4);
            Controls.Add(txt_manv);
            Controls.Add(btn_luong);
            Controls.Add(btn_search);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(dgv_lichlam);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(cb_calam);
            Controls.Add(label2);
            Controls.Add(dateWorkPick);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(button_back);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(cb_TenNV);
            Name = "FormQLLL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQLLL";
            Load += FormQLLL_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_lichlam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_TenNV;
        private Label label1;
        private Label label9;
        private Label label7;
        private Button button_back;
        private Label label11;
        private PictureBox pictureBox1;
        private DateTimePicker dateWorkPick;
        private Label label2;
        private Label label3;
        private ComboBox cb_calam;
        private Button btn_add;
        private DataGridView dgv_lichlam;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_search;
        private Button btn_luong;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txt_manv;
        private Label label4;
        private Button btn_refresh;
    }
}