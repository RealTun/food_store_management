namespace Form1
{
    partial class FormQLMonAn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLMonAn));
            txt_maMon = new TextBox();
            label10 = new Label();
            txt_tenMon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_donGia = new TextBox();
            button_back = new Button();
            button_OK = new Button();
            button_Update = new Button();
            button_Xoa = new Button();
            pictureBox1 = new PictureBox();
            txt_thoiGian = new TextBox();
            label_date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvFood = new DataGridView();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TienLai = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            button_reset = new Button();
            txt_income = new TextBox();
            label3 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // txt_maMon
            // 
            txt_maMon.BorderStyle = BorderStyle.FixedSingle;
            txt_maMon.Location = new Point(377, 69);
            txt_maMon.Name = "txt_maMon";
            txt_maMon.Size = new Size(224, 27);
            txt_maMon.TabIndex = 21;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(293, 114);
            label10.Name = "label10";
            label10.Size = new Size(78, 27);
            label10.TabIndex = 22;
            label10.Text = "Tên món";
            // 
            // txt_tenMon
            // 
            txt_tenMon.BorderStyle = BorderStyle.FixedSingle;
            txt_tenMon.Location = new Point(377, 111);
            txt_tenMon.Name = "txt_tenMon";
            txt_tenMon.Size = new Size(224, 27);
            txt_tenMon.TabIndex = 23;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 76);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 20;
            label1.Text = "Mã món";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(293, 156);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 25;
            label2.Text = "Đơn giá";
            // 
            // txt_donGia
            // 
            txt_donGia.BorderStyle = BorderStyle.FixedSingle;
            txt_donGia.Location = new Point(377, 153);
            txt_donGia.Name = "txt_donGia";
            txt_donGia.Size = new Size(224, 27);
            txt_donGia.TabIndex = 24;
            // 
            // button_back
            // 
            button_back.BackColor = SystemColors.ButtonHighlight;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.ForeColor = SystemColors.ActiveCaptionText;
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.ImageAlign = ContentAlignment.MiddleLeft;
            button_back.Location = new Point(64, 619);
            button_back.Name = "button_back";
            button_back.Size = new Size(105, 40);
            button_back.TabIndex = 27;
            button_back.Text = "Quay lại";
            button_back.TextAlign = ContentAlignment.MiddleRight;
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // button_OK
            // 
            button_OK.BackColor = SystemColors.ButtonHighlight;
            button_OK.FlatStyle = FlatStyle.Flat;
            button_OK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_OK.ForeColor = SystemColors.ActiveCaptionText;
            button_OK.Image = (Image)resources.GetObject("button_OK.Image");
            button_OK.ImageAlign = ContentAlignment.MiddleLeft;
            button_OK.Location = new Point(723, 173);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(90, 37);
            button_OK.TabIndex = 28;
            button_OK.Text = "Thêm";
            button_OK.TextAlign = ContentAlignment.MiddleRight;
            button_OK.UseVisualStyleBackColor = false;
            button_OK.Click += button_OK_Click;
            // 
            // button_Update
            // 
            button_Update.BackColor = SystemColors.ButtonHighlight;
            button_Update.FlatStyle = FlatStyle.Flat;
            button_Update.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Update.ForeColor = SystemColors.ActiveCaptionText;
            button_Update.Image = (Image)resources.GetObject("button_Update.Image");
            button_Update.ImageAlign = ContentAlignment.MiddleLeft;
            button_Update.Location = new Point(842, 173);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(71, 36);
            button_Update.TabIndex = 28;
            button_Update.Text = "Sửa";
            button_Update.TextAlign = ContentAlignment.MiddleRight;
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = SystemColors.ButtonHighlight;
            button_Xoa.FlatStyle = FlatStyle.Flat;
            button_Xoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Xoa.ForeColor = SystemColors.ActiveCaptionText;
            button_Xoa.Image = (Image)resources.GetObject("button_Xoa.Image");
            button_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            button_Xoa.Location = new Point(938, 174);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(70, 36);
            button_Xoa.TabIndex = 28;
            button_Xoa.Text = "Xóa";
            button_Xoa.TextAlign = ContentAlignment.MiddleRight;
            button_Xoa.UseVisualStyleBackColor = false;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // txt_thoiGian
            // 
            txt_thoiGian.BorderStyle = BorderStyle.FixedSingle;
            txt_thoiGian.Location = new Point(936, 114);
            txt_thoiGian.Name = "txt_thoiGian";
            txt_thoiGian.Size = new Size(206, 27);
            txt_thoiGian.TabIndex = 38;
            // 
            // label_date
            // 
            label_date.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_date.ImageAlign = ContentAlignment.MiddleLeft;
            label_date.Location = new Point(849, 121);
            label_date.Name = "label_date";
            label_date.Size = new Size(76, 20);
            label_date.TabIndex = 37;
            label_date.Text = "Thời gian";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dgvFood
            // 
            dgvFood.AllowUserToAddRows = false;
            dgvFood.AllowUserToDeleteRows = false;
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.BackgroundColor = SystemColors.ControlLightLight;
            dgvFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Columns.AddRange(new DataGridViewColumn[] { MaMon, TenMon, DonGia, TienLai, ThoiGian });
            dgvFood.GridColor = SystemColors.Desktop;
            dgvFood.Location = new Point(270, 242);
            dgvFood.MultiSelect = false;
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvFood.RowHeadersWidth = 51;
            dgvFood.RowTemplate.Height = 29;
            dgvFood.Size = new Size(920, 437);
            dgvFood.TabIndex = 41;
            dgvFood.CellMouseClick += dgvFood_CellMouseClick;
            // 
            // MaMon
            // 
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "Mã món";
            MaMon.MinimumWidth = 6;
            MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // TienLai
            // 
            TienLai.DataPropertyName = "TienLai";
            TienLai.HeaderText = "Lợi nhuận";
            TienLai.MinimumWidth = 6;
            TienLai.Name = "TienLai";
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian cập nhật";
            ThoiGian.MinimumWidth = 6;
            ThoiGian.Name = "ThoiGian";
            // 
            // button_reset
            // 
            button_reset.BackColor = SystemColors.ButtonHighlight;
            button_reset.FlatStyle = FlatStyle.Flat;
            button_reset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_reset.ForeColor = SystemColors.ActiveCaptionText;
            button_reset.Image = (Image)resources.GetObject("button_reset.Image");
            button_reset.ImageAlign = ContentAlignment.MiddleLeft;
            button_reset.Location = new Point(1038, 174);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(104, 36);
            button_reset.TabIndex = 42;
            button_reset.Text = "Làm mới";
            button_reset.TextAlign = ContentAlignment.MiddleRight;
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += button_reset_Click;
            // 
            // txt_income
            // 
            txt_income.BorderStyle = BorderStyle.FixedSingle;
            txt_income.Location = new Point(936, 76);
            txt_income.Name = "txt_income";
            txt_income.Size = new Size(206, 27);
            txt_income.TabIndex = 43;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(849, 83);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 44;
            label3.Text = "Lợi nhuận";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(257, 0);
            label9.Name = "label9";
            label9.Size = new Size(933, 44);
            label9.TabIndex = 45;
            label9.Text = "QUẢN LÝ MÓN ĂN";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormQLMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1182, 683);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(txt_income);
            Controls.Add(button_reset);
            Controls.Add(dgvFood);
            Controls.Add(txt_thoiGian);
            Controls.Add(label_date);
            Controls.Add(pictureBox1);
            Controls.Add(button_Xoa);
            Controls.Add(button_Update);
            Controls.Add(button_OK);
            Controls.Add(button_back);
            Controls.Add(label2);
            Controls.Add(txt_donGia);
            Controls.Add(txt_maMon);
            Controls.Add(label10);
            Controls.Add(txt_tenMon);
            Controls.Add(label1);
            Name = "FormQLMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMonAn";
            Load += FormAddMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_maMon;
        private Label label10;
        private TextBox txt_tenMon;
        private Label label1;
        private Label label2;
        private TextBox txt_donGia;
        private Button button_back;
        private Button button_OK;
        private Button button_Update;
        private Button button_Xoa;
        private PictureBox pictureBox1;
        private TextBox txt_thoiGian;
        private Label label_date;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvFood;
        private Button button_reset;
        private TextBox txt_income;
        private Label label3;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TienLai;
        private DataGridViewTextBoxColumn ThoiGian;
        private Label label9;
    }
}