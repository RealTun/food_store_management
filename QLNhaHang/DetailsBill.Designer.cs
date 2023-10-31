namespace Form1
{
    partial class DetailsBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsBill));
            lb_time = new Label();
            lb_nameCus = new Label();
            label5 = new Label();
            label2 = new Label();
            lb_numBill = new Label();
            label4 = new Label();
            label8 = new Label();
            dgv_billDetails = new DataGridView();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            lb_makm = new Label();
            label11 = new Label();
            label3 = new Label();
            lb_nguoiban = new Label();
            lb_tongtien = new Label();
            btn_hoantra = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_billDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_time
            // 
            lb_time.BackColor = SystemColors.ButtonFace;
            lb_time.BorderStyle = BorderStyle.Fixed3D;
            lb_time.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_time.Location = new Point(469, 143);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(172, 28);
            lb_time.TabIndex = 38;
            lb_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_nameCus
            // 
            lb_nameCus.BackColor = SystemColors.ButtonFace;
            lb_nameCus.BorderStyle = BorderStyle.Fixed3D;
            lb_nameCus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nameCus.Location = new Point(149, 191);
            lb_nameCus.Name = "lb_nameCus";
            lb_nameCus.Size = new Size(166, 28);
            lb_nameCus.TabIndex = 37;
            lb_nameCus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(393, 146);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 35;
            label5.Text = "Thời gian";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(41, 191);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 34;
            label2.Text = "Khách hàng";
            // 
            // lb_numBill
            // 
            lb_numBill.BackColor = SystemColors.ButtonFace;
            lb_numBill.BorderStyle = BorderStyle.Fixed3D;
            lb_numBill.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_numBill.Location = new Point(149, 142);
            lb_numBill.Name = "lb_numBill";
            lb_numBill.Size = new Size(166, 28);
            lb_numBill.TabIndex = 33;
            lb_numBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(41, 142);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 32;
            label4.Text = "Hóa đơn số:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(516, 611);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 42;
            label8.Text = "Đã thanh toán";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgv_billDetails
            // 
            dgv_billDetails.AllowUserToAddRows = false;
            dgv_billDetails.AllowUserToDeleteRows = false;
            dgv_billDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_billDetails.BackgroundColor = SystemColors.ControlLightLight;
            dgv_billDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_billDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_billDetails.Columns.AddRange(new DataGridViewColumn[] { TenMon, SoLuong, DonGia, TongTien });
            dgv_billDetails.GridColor = SystemColors.Desktop;
            dgv_billDetails.Location = new Point(41, 242);
            dgv_billDetails.Name = "dgv_billDetails";
            dgv_billDetails.ReadOnly = true;
            dgv_billDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_billDetails.RowHeadersWidth = 51;
            dgv_billDetails.RowTemplate.Height = 29;
            dgv_billDetails.Size = new Size(600, 366);
            dgv_billDetails.TabIndex = 44;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món ăn";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            TenMon.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(685, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // lb_makm
            // 
            lb_makm.BackColor = SystemColors.ButtonFace;
            lb_makm.BorderStyle = BorderStyle.FixedSingle;
            lb_makm.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lb_makm.Location = new Point(41, 655);
            lb_makm.Name = "lb_makm";
            lb_makm.Size = new Size(230, 39);
            lb_makm.TabIndex = 47;
            lb_makm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(41, 630);
            label11.Name = "label11";
            label11.Size = new Size(162, 20);
            label11.TabIndex = 46;
            label11.Text = "Mã khuyến mại sử dụng";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(388, 191);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 49;
            label3.Text = "Người lập";
            // 
            // lb_nguoiban
            // 
            lb_nguoiban.BackColor = SystemColors.Control;
            lb_nguoiban.BorderStyle = BorderStyle.Fixed3D;
            lb_nguoiban.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nguoiban.Location = new Point(469, 187);
            lb_nguoiban.Name = "lb_nguoiban";
            lb_nguoiban.Size = new Size(172, 28);
            lb_nguoiban.TabIndex = 48;
            lb_nguoiban.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_tongtien
            // 
            lb_tongtien.BackColor = SystemColors.Control;
            lb_tongtien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tongtien.Location = new Point(516, 647);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new Size(124, 28);
            lb_tongtien.TabIndex = 51;
            lb_tongtien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_hoantra
            // 
            btn_hoantra.FlatStyle = FlatStyle.Flat;
            btn_hoantra.Image = (Image)resources.GetObject("btn_hoantra.Image");
            btn_hoantra.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoantra.Location = new Point(527, 691);
            btn_hoantra.Name = "btn_hoantra";
            btn_hoantra.Size = new Size(113, 36);
            btn_hoantra.TabIndex = 52;
            btn_hoantra.Text = "Hoàn trả";
            btn_hoantra.TextAlign = ContentAlignment.MiddleRight;
            btn_hoantra.UseVisualStyleBackColor = true;
            btn_hoantra.Click += btn_hoantra_Click;
            // 
            // DetailsBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(682, 753);
            Controls.Add(btn_hoantra);
            Controls.Add(lb_tongtien);
            Controls.Add(label3);
            Controls.Add(lb_nguoiban);
            Controls.Add(lb_makm);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_billDetails);
            Controls.Add(label8);
            Controls.Add(lb_time);
            Controls.Add(lb_nameCus);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lb_numBill);
            Controls.Add(label4);
            Name = "DetailsBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailsBill";
            Load += DetailsBill_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_billDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_time;
        private Label lb_nameCus;
        private Label label5;
        private Label label2;
        private Label lb_numBill;
        private Label label4;
        private Label label8;
        private DataGridView dgv_billDetails;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TongTien;
        private PictureBox pictureBox1;
        private Label lb_makm;
        private Label label11;
        private Label label3;
        private Label lb_nguoiban;
        private Label lb_tongtien;
        private Button btn_hoantra;
    }
}