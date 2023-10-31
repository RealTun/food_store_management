namespace QLNH
{
    partial class QLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBan));
            dgv_ban = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txt_maban = new TextBox();
            label1 = new Label();
            cb_loaiban = new ComboBox();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txt_tenban = new TextBox();
            label9 = new Label();
            btn_refresh = new Button();
            btn_back = new Button();
            btn_datban = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ban).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_ban
            // 
            dgv_ban.AllowUserToAddRows = false;
            dgv_ban.AllowUserToDeleteRows = false;
            dgv_ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ban.BackgroundColor = SystemColors.ControlLightLight;
            dgv_ban.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_ban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ban.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgv_ban.Location = new Point(271, 261);
            dgv_ban.MultiSelect = false;
            dgv_ban.Name = "dgv_ban";
            dgv_ban.ReadOnly = true;
            dgv_ban.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_ban.RowHeadersWidth = 51;
            dgv_ban.RowTemplate.Height = 29;
            dgv_ban.Size = new Size(754, 352);
            dgv_ban.TabIndex = 0;
            dgv_ban.CellMouseClick += dgv_ban_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaBan";
            Column1.HeaderText = "Mã bàn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenBan";
            Column2.HeaderText = "Tên bàn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "LoaiBan";
            Column3.HeaderText = "Loại bàn";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // txt_maban
            // 
            txt_maban.Location = new Point(406, 94);
            txt_maban.Name = "txt_maban";
            txt_maban.Size = new Size(156, 27);
            txt_maban.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(323, 101);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã bàn";
            // 
            // cb_loaiban
            // 
            cb_loaiban.FormattingEnabled = true;
            cb_loaiban.Items.AddRange(new object[] { "Nhỏ", "Vừa", "Lớn" });
            cb_loaiban.Location = new Point(762, 93);
            cb_loaiban.Name = "cb_loaiban";
            cb_loaiban.Size = new Size(151, 28);
            cb_loaiban.TabIndex = 3;
            // 
            // btn_update
            // 
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(697, 211);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(86, 29);
            btn_update.TabIndex = 45;
            btn_update.Text = "Sửa";
            btn_update.TextAlign = ContentAlignment.MiddleRight;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(801, 211);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 29);
            btn_delete.TabIndex = 44;
            btn_delete.Text = "Xóa";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(590, 211);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 29);
            btn_add.TabIndex = 43;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 230);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(690, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 47;
            label2.Text = "Loại bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(323, 151);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 48;
            label3.Text = "Tên bàn";
            // 
            // txt_tenban
            // 
            txt_tenban.Location = new Point(406, 148);
            txt_tenban.Name = "txt_tenban";
            txt_tenban.Size = new Size(156, 27);
            txt_tenban.TabIndex = 49;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(271, 1);
            label9.Name = "label9";
            label9.Size = new Size(754, 46);
            label9.TabIndex = 50;
            label9.Text = "QUẢN LÝ BÀN";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = SystemColors.ButtonHighlight;
            btn_refresh.Cursor = Cursors.Hand;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_refresh.ForeColor = SystemColors.ActiveCaptionText;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.Location = new Point(902, 211);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(112, 29);
            btn_refresh.TabIndex = 60;
            btn_refresh.Text = "Làm mới";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ButtonHighlight;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ActiveCaptionText;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(72, 537);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(111, 35);
            btn_back.TabIndex = 61;
            btn_back.Text = "Quay lại";
            btn_back.TextAlign = ContentAlignment.MiddleRight;
            btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_datban
            // 
            btn_datban.FlatStyle = FlatStyle.Flat;
            btn_datban.Image = (Image)resources.GetObject("btn_datban.Image");
            btn_datban.ImageAlign = ContentAlignment.MiddleLeft;
            btn_datban.Location = new Point(902, 164);
            btn_datban.Name = "btn_datban";
            btn_datban.Size = new Size(112, 29);
            btn_datban.TabIndex = 62;
            btn_datban.Text = "Đặt bàn";
            btn_datban.TextAlign = ContentAlignment.MiddleRight;
            btn_datban.UseVisualStyleBackColor = true;
            btn_datban.Click += btn_datban_Click;
            // 
            // QLBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1026, 611);
            Controls.Add(btn_datban);
            Controls.Add(btn_back);
            Controls.Add(btn_refresh);
            Controls.Add(label9);
            Controls.Add(txt_tenban);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(cb_loaiban);
            Controls.Add(label1);
            Controls.Add(txt_maban);
            Controls.Add(dgv_ban);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QLBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLBan";
            Load += QLBan_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ban).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ban;
        private TextBox txt_maban;
        private Label label1;
        private ComboBox cb_loaiban;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TextBox txt_tenban;
        private Label label9;
        private Button btn_refresh;
        private Button btn_back;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btn_datban;
    }
}