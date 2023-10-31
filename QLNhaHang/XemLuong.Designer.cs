namespace QLNH
{
    partial class XemLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemLuong));
            pictureBox1 = new PictureBox();
            label9 = new Label();
            cb_month = new ComboBox();
            cb_year = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgv_salary = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btn_view = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_salary).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(285, 0);
            label9.Name = "label9";
            label9.Size = new Size(722, 76);
            label9.TabIndex = 35;
            label9.Text = "LƯƠNG";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_month
            // 
            cb_month.FormattingEnabled = true;
            cb_month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cb_month.Location = new Point(315, 165);
            cb_month.Name = "cb_month";
            cb_month.Size = new Size(151, 28);
            cb_month.TabIndex = 36;
            // 
            // cb_year
            // 
            cb_year.FormattingEnabled = true;
            cb_year.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cb_year.Location = new Point(513, 165);
            cb_year.Name = "cb_year";
            cb_year.Size = new Size(151, 28);
            cb_year.TabIndex = 37;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 137);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 38;
            label1.Text = "Chọn tháng";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(513, 137);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 39;
            label2.Text = "Chọn năm";
            // 
            // dgv_salary
            // 
            dgv_salary.AllowUserToAddRows = false;
            dgv_salary.AllowUserToDeleteRows = false;
            dgv_salary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_salary.BackgroundColor = SystemColors.Control;
            dgv_salary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_salary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_salary.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgv_salary.Location = new Point(285, 261);
            dgv_salary.Name = "dgv_salary";
            dgv_salary.ReadOnly = true;
            dgv_salary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_salary.RowHeadersWidth = 51;
            dgv_salary.RowTemplate.Height = 29;
            dgv_salary.Size = new Size(722, 355);
            dgv_salary.TabIndex = 40;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenNV";
            Column1.HeaderText = "Tên nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SoNgay";
            Column2.HeaderText = "Số ngày làm";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Luong";
            Column3.HeaderText = "Lương";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // btn_view
            // 
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.Image = (Image)resources.GetObject("btn_view.Image");
            btn_view.ImageAlign = ContentAlignment.MiddleLeft;
            btn_view.Location = new Point(736, 164);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(81, 29);
            btn_view.TabIndex = 41;
            btn_view.Text = "Xem";
            btn_view.TextAlign = ContentAlignment.MiddleRight;
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // XemLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1004, 612);
            Controls.Add(btn_view);
            Controls.Add(dgv_salary);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_year);
            Controls.Add(cb_month);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "XemLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XemLuong";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_salary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label9;
        private ComboBox cb_month;
        private ComboBox cb_year;
        private Label label1;
        private Label label2;
        private DataGridView dgv_salary;
        private Button btn_view;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}