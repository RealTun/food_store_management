namespace Form1
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            button_LichLam = new Button();
            button_NhanVien = new Button();
            btn_BanHang = new Button();
            label1 = new Label();
            button_MonAn = new Button();
            btn_HoaDon = new Button();
            bt_statistical = new Button();
            panel1 = new Panel();
            btn_kho = new Button();
            btn_khuyenmai = new Button();
            btn_ban = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_LichLam
            // 
            button_LichLam.BackColor = Color.Firebrick;
            button_LichLam.Cursor = Cursors.Hand;
            button_LichLam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_LichLam.ForeColor = SystemColors.ControlLightLight;
            button_LichLam.Location = new Point(220, 57);
            button_LichLam.Name = "button_LichLam";
            button_LichLam.Size = new Size(130, 40);
            button_LichLam.TabIndex = 0;
            button_LichLam.Text = "Lịch làm";
            button_LichLam.UseVisualStyleBackColor = false;
            button_LichLam.Click += button_LichLam_Click;
            // 
            // button_NhanVien
            // 
            button_NhanVien.BackColor = Color.Firebrick;
            button_NhanVien.Cursor = Cursors.Hand;
            button_NhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_NhanVien.ForeColor = SystemColors.ControlLightLight;
            button_NhanVien.Location = new Point(33, 57);
            button_NhanVien.Name = "button_NhanVien";
            button_NhanVien.Size = new Size(130, 40);
            button_NhanVien.TabIndex = 1;
            button_NhanVien.Text = "Nhân viên";
            button_NhanVien.UseVisualStyleBackColor = false;
            button_NhanVien.Click += button_NhanVien_Click;
            // 
            // btn_BanHang
            // 
            btn_BanHang.BackColor = Color.Firebrick;
            btn_BanHang.Cursor = Cursors.Hand;
            btn_BanHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BanHang.ForeColor = SystemColors.ControlLightLight;
            btn_BanHang.Location = new Point(220, 145);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(130, 40);
            btn_BanHang.TabIndex = 3;
            btn_BanHang.Text = "Đặt món";
            btn_BanHang.UseVisualStyleBackColor = false;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("PizzaHut Font", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(1094, 104);
            label1.TabIndex = 4;
            label1.Text = "Pizza    Hut    Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_MonAn
            // 
            button_MonAn.BackColor = Color.Firebrick;
            button_MonAn.Cursor = Cursors.Hand;
            button_MonAn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_MonAn.ForeColor = SystemColors.ControlLightLight;
            button_MonAn.Location = new Point(33, 145);
            button_MonAn.Name = "button_MonAn";
            button_MonAn.Size = new Size(130, 40);
            button_MonAn.TabIndex = 5;
            button_MonAn.Text = "Món ăn";
            button_MonAn.UseVisualStyleBackColor = false;
            button_MonAn.Click += button_MonAn_Click;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.BackColor = Color.Firebrick;
            btn_HoaDon.Cursor = Cursors.Hand;
            btn_HoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HoaDon.ForeColor = SystemColors.ControlLightLight;
            btn_HoaDon.Location = new Point(33, 319);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(130, 40);
            btn_HoaDon.TabIndex = 6;
            btn_HoaDon.Text = "Hoàn trả";
            btn_HoaDon.UseVisualStyleBackColor = false;
            btn_HoaDon.Click += btn_HoaDon_Click;
            // 
            // bt_statistical
            // 
            bt_statistical.BackColor = Color.Firebrick;
            bt_statistical.Cursor = Cursors.Hand;
            bt_statistical.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bt_statistical.ForeColor = SystemColors.ControlLightLight;
            bt_statistical.Location = new Point(220, 319);
            bt_statistical.Name = "bt_statistical";
            bt_statistical.Size = new Size(130, 40);
            bt_statistical.TabIndex = 7;
            bt_statistical.Text = "Thống kê";
            bt_statistical.UseVisualStyleBackColor = false;
            bt_statistical.Click += bt_statistical_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btn_kho);
            panel1.Controls.Add(btn_khuyenmai);
            panel1.Controls.Add(btn_ban);
            panel1.Controls.Add(button_LichLam);
            panel1.Controls.Add(bt_statistical);
            panel1.Controls.Add(button_NhanVien);
            panel1.Controls.Add(btn_HoaDon);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(button_MonAn);
            panel1.Location = new Point(-1, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 520);
            panel1.TabIndex = 8;
            // 
            // btn_kho
            // 
            btn_kho.BackColor = Color.Firebrick;
            btn_kho.Cursor = Cursors.Hand;
            btn_kho.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kho.ForeColor = SystemColors.ControlLightLight;
            btn_kho.Location = new Point(33, 397);
            btn_kho.Name = "btn_kho";
            btn_kho.Size = new Size(130, 40);
            btn_kho.TabIndex = 10;
            btn_kho.Text = "Kho";
            btn_kho.UseVisualStyleBackColor = false;
            btn_kho.Click += btn_kho_Click;
            // 
            // btn_khuyenmai
            // 
            btn_khuyenmai.BackColor = Color.Firebrick;
            btn_khuyenmai.Cursor = Cursors.Hand;
            btn_khuyenmai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_khuyenmai.ForeColor = SystemColors.ControlLightLight;
            btn_khuyenmai.Location = new Point(220, 234);
            btn_khuyenmai.Name = "btn_khuyenmai";
            btn_khuyenmai.Size = new Size(130, 40);
            btn_khuyenmai.TabIndex = 9;
            btn_khuyenmai.Text = "Khuyến mại";
            btn_khuyenmai.UseVisualStyleBackColor = false;
            btn_khuyenmai.Click += btn_khuyenmai_Click;
            // 
            // btn_ban
            // 
            btn_ban.BackColor = Color.Firebrick;
            btn_ban.Cursor = Cursors.Hand;
            btn_ban.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ban.ForeColor = SystemColors.ControlLightLight;
            btn_ban.Location = new Point(33, 234);
            btn_ban.Name = "btn_ban";
            btn_ban.Size = new Size(130, 40);
            btn_ban.TabIndex = 8;
            btn_ban.Text = "Bàn";
            btn_ban.UseVisualStyleBackColor = false;
            btn_ban.Click += btn_ban_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(377, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(716, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 619);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            Load += App_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_LichLam;
        private Button button_NhanVien;
        private Button btn_BanHang;
        private Label label1;
        private Button button_MonAn;
        private Button btn_HoaDon;
        private Button bt_statistical;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_ban;
        private Button btn_khuyenmai;
        private Button btn_kho;
    }
}