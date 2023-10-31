namespace QLNH
{
    partial class QLKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKhuyenMai));
            label3 = new Label();
            btn_refresh = new Button();
            dgv_discount = new DataGridView();
            label_date = new Label();
            pictureBox1 = new PictureBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_back = new Button();
            label2 = new Label();
            txt_giatri = new TextBox();
            txt_makm = new TextBox();
            label10 = new Label();
            txt_tenkm = new TextBox();
            label1 = new Label();
            label9 = new Label();
            dateStart = new DateTimePicker();
            dateEnd = new DateTimePicker();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ThoigianBD = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_discount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(856, 73);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 61;
            label3.Text = "Ngày bắt đầu";
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = SystemColors.ButtonHighlight;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = SystemColors.ActiveCaptionText;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.Location = new Point(1067, 176);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(104, 36);
            btn_refresh.TabIndex = 59;
            btn_refresh.Text = "Làm mới";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dgv_discount
            // 
            dgv_discount.AllowUserToAddRows = false;
            dgv_discount.AllowUserToDeleteRows = false;
            dgv_discount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_discount.BackgroundColor = SystemColors.ControlLightLight;
            dgv_discount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_discount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_discount.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, ThoigianBD, Column5 });
            dgv_discount.GridColor = SystemColors.Desktop;
            dgv_discount.Location = new Point(258, 244);
            dgv_discount.MultiSelect = false;
            dgv_discount.Name = "dgv_discount";
            dgv_discount.ReadOnly = true;
            dgv_discount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_discount.RowHeadersWidth = 51;
            dgv_discount.RowTemplate.Height = 29;
            dgv_discount.Size = new Size(924, 437);
            dgv_discount.TabIndex = 58;
            dgv_discount.CellMouseClick += dgvFood_CellMouseClick;
            // 
            // label_date
            // 
            label_date.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_date.ImageAlign = ContentAlignment.MiddleLeft;
            label_date.Location = new Point(856, 110);
            label_date.Name = "label_date";
            label_date.Size = new Size(112, 20);
            label_date.TabIndex = 56;
            label_date.Text = "Ngày kết thúc";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ButtonHighlight;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = SystemColors.ActiveCaptionText;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(967, 176);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(70, 36);
            btn_delete.TabIndex = 54;
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
            btn_update.Location = new Point(871, 175);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(71, 36);
            btn_update.TabIndex = 53;
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
            btn_add.Location = new Point(752, 175);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 37);
            btn_add.TabIndex = 52;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ButtonHighlight;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ActiveCaptionText;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(38, 631);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(105, 40);
            btn_back.TabIndex = 51;
            btn_back.Text = "Quay lại";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(350, 153);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 50;
            label2.Text = "Giá trị";
            // 
            // txt_giatri
            // 
            txt_giatri.BorderStyle = BorderStyle.FixedSingle;
            txt_giatri.Location = new Point(434, 150);
            txt_giatri.Name = "txt_giatri";
            txt_giatri.Size = new Size(224, 27);
            txt_giatri.TabIndex = 49;
            // 
            // txt_makm
            // 
            txt_makm.BorderStyle = BorderStyle.FixedSingle;
            txt_makm.Location = new Point(434, 66);
            txt_makm.Name = "txt_makm";
            txt_makm.Size = new Size(224, 27);
            txt_makm.TabIndex = 46;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(350, 111);
            label10.Name = "label10";
            label10.Size = new Size(78, 27);
            label10.TabIndex = 47;
            label10.Text = "Tên KM";
            // 
            // txt_tenkm
            // 
            txt_tenkm.BorderStyle = BorderStyle.FixedSingle;
            txt_tenkm.Location = new Point(434, 108);
            txt_tenkm.Name = "txt_tenkm";
            txt_tenkm.Size = new Size(224, 27);
            txt_tenkm.TabIndex = 48;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 73);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 45;
            label1.Text = "Mã KM";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(258, -2);
            label9.Name = "label9";
            label9.Size = new Size(933, 44);
            label9.TabIndex = 62;
            label9.Text = "QUẢN LÝ KHUYẾN MẠI";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateStart
            // 
            dateStart.Format = DateTimePickerFormat.Short;
            dateStart.Location = new Point(968, 68);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(202, 27);
            dateStart.TabIndex = 63;
            // 
            // dateEnd
            // 
            dateEnd.Format = DateTimePickerFormat.Short;
            dateEnd.Location = new Point(967, 105);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(203, 27);
            dateEnd.TabIndex = 64;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaKM";
            Column1.HeaderText = "Mã khuyến mại";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenKM";
            Column2.HeaderText = "Tên khuyến mại";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Giatri";
            Column3.HeaderText = "Giá trị";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // ThoigianBD
            // 
            ThoigianBD.DataPropertyName = "ThoigianBD";
            ThoigianBD.HeaderText = "Ngày bắt đầu";
            ThoigianBD.MinimumWidth = 6;
            ThoigianBD.Name = "ThoigianBD";
            ThoigianBD.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ThoigianKT";
            Column5.HeaderText = "Ngày kết thúc";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // QLKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1182, 683);
            Controls.Add(dateEnd);
            Controls.Add(dateStart);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(btn_refresh);
            Controls.Add(dgv_discount);
            Controls.Add(label_date);
            Controls.Add(pictureBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(txt_giatri);
            Controls.Add(txt_makm);
            Controls.Add(label10);
            Controls.Add(txt_tenkm);
            Controls.Add(label1);
            Name = "QLKhuyenMai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLKhuyenMai";
            Load += QLKhuyenMai_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_discount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btn_refresh;
        private DataGridView dgv_discount;
        private Label label_date;
        private PictureBox pictureBox1;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Button btn_back;
        private Label label2;
        private TextBox txt_giatri;
        private TextBox txt_makm;
        private Label label10;
        private TextBox txt_tenkm;
        private Label label1;
        private Label label9;
        private DateTimePicker dateStart;
        private DateTimePicker dateEnd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ThoigianBD;
        private DataGridViewTextBoxColumn Column5;
    }
}