namespace QLNH
{
    partial class DatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatBan));
            btn_ban1 = new Button();
            btn_ban4 = new Button();
            btn_ban2 = new Button();
            btn_ban5 = new Button();
            btn_ban3 = new Button();
            btn_6 = new Button();
            txt_tenkh = new TextBox();
            txt_sdt = new TextBox();
            cb_tennv = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            txt_thoigian = new TextBox();
            txt_manv = new TextBox();
            btn_add = new Button();
            btn_refresh = new Button();
            label4 = new Label();
            label5 = new Label();
            txt_maban = new TextBox();
            label6 = new Label();
            dgv_datban = new DataGridView();
            pictureBox1 = new PictureBox();
            datePick = new DateTimePicker();
            btn_search = new Button();
            btn_delete = new Button();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_datban).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ban1
            // 
            btn_ban1.BackColor = SystemColors.ControlLightLight;
            btn_ban1.FlatStyle = FlatStyle.Flat;
            btn_ban1.Location = new Point(34, 68);
            btn_ban1.Name = "btn_ban1";
            btn_ban1.Size = new Size(154, 68);
            btn_ban1.TabIndex = 0;
            btn_ban1.Text = "Bàn 1";
            btn_ban1.UseVisualStyleBackColor = false;
            btn_ban1.Click += DatBan_Click;
            // 
            // btn_ban4
            // 
            btn_ban4.FlatStyle = FlatStyle.Flat;
            btn_ban4.Location = new Point(34, 211);
            btn_ban4.Name = "btn_ban4";
            btn_ban4.Size = new Size(154, 68);
            btn_ban4.TabIndex = 1;
            btn_ban4.Text = "Bàn 4";
            btn_ban4.UseVisualStyleBackColor = true;
            btn_ban4.Click += DatBan_Click;
            // 
            // btn_ban2
            // 
            btn_ban2.FlatStyle = FlatStyle.Flat;
            btn_ban2.Location = new Point(234, 68);
            btn_ban2.Name = "btn_ban2";
            btn_ban2.Size = new Size(154, 68);
            btn_ban2.TabIndex = 2;
            btn_ban2.Text = "Bàn 2";
            btn_ban2.UseVisualStyleBackColor = true;
            btn_ban2.Click += DatBan_Click;
            // 
            // btn_ban5
            // 
            btn_ban5.FlatStyle = FlatStyle.Flat;
            btn_ban5.Location = new Point(234, 211);
            btn_ban5.Name = "btn_ban5";
            btn_ban5.Size = new Size(154, 68);
            btn_ban5.TabIndex = 3;
            btn_ban5.Text = "Bàn 5";
            btn_ban5.UseVisualStyleBackColor = true;
            btn_ban5.Click += DatBan_Click;
            // 
            // btn_ban3
            // 
            btn_ban3.FlatStyle = FlatStyle.Flat;
            btn_ban3.Location = new Point(435, 68);
            btn_ban3.Name = "btn_ban3";
            btn_ban3.Size = new Size(154, 68);
            btn_ban3.TabIndex = 4;
            btn_ban3.Text = "Bàn 3";
            btn_ban3.UseVisualStyleBackColor = true;
            btn_ban3.Click += DatBan_Click;
            // 
            // btn_6
            // 
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Location = new Point(435, 211);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(154, 68);
            btn_6.TabIndex = 5;
            btn_6.Text = "Bàn 6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += DatBan_Click;
            // 
            // txt_tenkh
            // 
            txt_tenkh.Location = new Point(299, 134);
            txt_tenkh.Name = "txt_tenkh";
            txt_tenkh.Size = new Size(185, 27);
            txt_tenkh.TabIndex = 6;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(299, 213);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(185, 27);
            txt_sdt.TabIndex = 7;
            // 
            // cb_tennv
            // 
            cb_tennv.FormattingEnabled = true;
            cb_tennv.Location = new Point(56, 131);
            cb_tennv.Name = "cb_tennv";
            cb_tennv.Size = new Size(171, 28);
            cb_tennv.TabIndex = 8;
            cb_tennv.SelectedValueChanged += cb_tennv_SelectedValueChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 103);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 9;
            label1.Text = "Nhân viên lập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ban3);
            groupBox1.Controls.Add(btn_ban1);
            groupBox1.Controls.Add(btn_ban4);
            groupBox1.Controls.Add(btn_ban2);
            groupBox1.Controls.Add(btn_ban5);
            groupBox1.Controls.Add(btn_6);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 331);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bàn";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(299, 106);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 36;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(299, 185);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 37;
            label3.Text = "Điện thoại";
            // 
            // txt_thoigian
            // 
            txt_thoigian.Location = new Point(299, 285);
            txt_thoigian.Name = "txt_thoigian";
            txt_thoigian.Size = new Size(185, 27);
            txt_thoigian.TabIndex = 38;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(56, 213);
            txt_manv.Name = "txt_manv";
            txt_manv.ReadOnly = true;
            txt_manv.Size = new Size(171, 27);
            txt_manv.TabIndex = 39;
            // 
            // btn_add
            // 
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(540, 127);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(104, 34);
            btn_add.TabIndex = 41;
            btn_add.Text = "Đặt bàn";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_refresh.Location = new Point(540, 202);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(104, 38);
            btn_refresh.TabIndex = 48;
            btn_refresh.Text = "Làm mới";
            btn_refresh.TextAlign = ContentAlignment.MiddleRight;
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 185);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 50;
            label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(299, 260);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 51;
            label5.Text = "Thời gian";
            // 
            // txt_maban
            // 
            txt_maban.Location = new Point(56, 283);
            txt_maban.Name = "txt_maban";
            txt_maban.ReadOnly = true;
            txt_maban.Size = new Size(185, 27);
            txt_maban.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(56, 260);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 53;
            label6.Text = "Mã bàn";
            // 
            // dgv_datban
            // 
            dgv_datban.AllowUserToAddRows = false;
            dgv_datban.AllowUserToDeleteRows = false;
            dgv_datban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_datban.BackgroundColor = SystemColors.ControlLightLight;
            dgv_datban.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_datban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_datban.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dgv_datban.Location = new Point(677, 330);
            dgv_datban.Name = "dgv_datban";
            dgv_datban.ReadOnly = true;
            dgv_datban.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_datban.RowHeadersWidth = 51;
            dgv_datban.RowTemplate.Height = 29;
            dgv_datban.Size = new Size(583, 331);
            dgv_datban.TabIndex = 54;
            dgv_datban.CellMouseClick += dgv_datban_CellMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1288, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // datePick
            // 
            datePick.Format = DateTimePickerFormat.Short;
            datePick.Location = new Point(999, 285);
            datePick.Name = "datePick";
            datePick.Size = new Size(162, 27);
            datePick.TabIndex = 56;
            // 
            // btn_search
            // 
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(1182, 280);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(78, 30);
            btn_search.TabIndex = 57;
            btn_search.Text = "Lọc";
            btn_search.TextAlign = ContentAlignment.MiddleRight;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(1182, 242);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(78, 29);
            btn_delete.TabIndex = 58;
            btn_delete.Text = "Xóa";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MaBan";
            Column5.HeaderText = "Mã bàn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenBan";
            Column1.HeaderText = "Tên bàn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenKH";
            Column2.HeaderText = "Tên khách";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Sdt";
            Column3.HeaderText = "Điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Thoigian";
            Column4.HeaderText = "Thời gian";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // DatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1282, 688);
            Controls.Add(btn_delete);
            Controls.Add(btn_search);
            Controls.Add(datePick);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_datban);
            Controls.Add(label6);
            Controls.Add(txt_maban);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_refresh);
            Controls.Add(btn_add);
            Controls.Add(txt_manv);
            Controls.Add(txt_thoigian);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cb_tennv);
            Controls.Add(txt_sdt);
            Controls.Add(txt_tenkh);
            Name = "DatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatBan";
            Load += DatBan_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_datban).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ban1;
        private Button btn_ban4;
        private Button btn_ban2;
        private Button btn_ban5;
        private Button btn_ban3;
        private Button btn_6;
        private TextBox txt_tenkh;
        private TextBox txt_sdt;
        private ComboBox cb_tennv;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txt_thoigian;
        private TextBox txt_manv;
        private Button btn_add;
        private Button btn_refresh;
        private Label label4;
        private Label label5;
        private TextBox txt_maban;
        private Label label6;
        private DataGridView dgv_datban;
        private PictureBox pictureBox1;
        private DateTimePicker datePick;
        private Button btn_search;
        private Button btn_delete;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}