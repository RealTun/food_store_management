namespace Form1
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            label1 = new Label();
            datePickStart = new DateTimePicker();
            btn_statistical = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            lb_totalBill = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lb_Revenue = new Label();
            label4 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            lb_profit = new Label();
            label5 = new Label();
            panel5 = new Panel();
            lb_totalCus = new Label();
            label9 = new Label();
            datePickEnd = new DateTimePicker();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            lb_topOder = new Label();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            btn_viewall = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Thời Gian";
            // 
            // datePickStart
            // 
            datePickStart.CustomFormat = "dd/MM/yyyy";
            datePickStart.Format = DateTimePickerFormat.Custom;
            datePickStart.Location = new Point(141, 31);
            datePickStart.Name = "datePickStart";
            datePickStart.Size = new Size(221, 27);
            datePickStart.TabIndex = 1;
            // 
            // btn_statistical
            // 
            btn_statistical.FlatStyle = FlatStyle.Flat;
            btn_statistical.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_statistical.Location = new Point(659, 31);
            btn_statistical.Name = "btn_statistical";
            btn_statistical.Size = new Size(94, 29);
            btn_statistical.TabIndex = 6;
            btn_statistical.Text = "Lọc";
            btn_statistical.UseVisualStyleBackColor = true;
            btn_statistical.Click += btn_statistical_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(811, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 479);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lb_totalBill);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(38, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 61);
            panel2.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // lb_totalBill
            // 
            lb_totalBill.BackColor = SystemColors.ControlLightLight;
            lb_totalBill.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_totalBill.Location = new Point(88, 25);
            lb_totalBill.Name = "lb_totalBill";
            lb_totalBill.Size = new Size(144, 25);
            lb_totalBill.TabIndex = 9;
            lb_totalBill.Text = "10000";
            lb_totalBill.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 9;
            label2.Text = "Tổng số hóa đơn";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lb_Revenue);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(408, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 61);
            panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lb_Revenue
            // 
            lb_Revenue.BackColor = SystemColors.ControlLightLight;
            lb_Revenue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Revenue.Location = new Point(85, 28);
            lb_Revenue.Name = "lb_Revenue";
            lb_Revenue.Size = new Size(144, 25);
            lb_Revenue.TabIndex = 9;
            lb_Revenue.Text = "10000";
            lb_Revenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 3);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 9;
            label4.Text = "Doanh thu";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lb_profit);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(407, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 61);
            panel4.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // lb_profit
            // 
            lb_profit.BackColor = SystemColors.ControlLightLight;
            lb_profit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_profit.Location = new Point(89, 25);
            lb_profit.Name = "lb_profit";
            lb_profit.Size = new Size(131, 25);
            lb_profit.TabIndex = 9;
            lb_profit.Text = "10000";
            lb_profit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 3);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 9;
            label5.Text = "Lợi nhuận";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(lb_totalCus);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(37, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(272, 63);
            panel5.TabIndex = 11;
            // 
            // lb_totalCus
            // 
            lb_totalCus.BackColor = SystemColors.ControlLightLight;
            lb_totalCus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_totalCus.Location = new Point(88, 25);
            lb_totalCus.Name = "lb_totalCus";
            lb_totalCus.Size = new Size(79, 25);
            lb_totalCus.TabIndex = 10;
            lb_totalCus.Text = "10000";
            lb_totalCus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ControlLightLight;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(88, 0);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 11;
            label9.Text = "Số khách hàng";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // datePickEnd
            // 
            datePickEnd.CustomFormat = "dd/MM/yyyy";
            datePickEnd.Format = DateTimePickerFormat.Custom;
            datePickEnd.Location = new Point(407, 31);
            datePickEnd.Name = "datePickEnd";
            datePickEnd.Size = new Size(221, 27);
            datePickEnd.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(lb_topOder);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(39, 424);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 239);
            panel6.TabIndex = 33;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlLightLight;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 56);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // lb_topOder
            // 
            lb_topOder.BackColor = SystemColors.ControlLightLight;
            lb_topOder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_topOder.Location = new Point(22, 64);
            lb_topOder.Name = "lb_topOder";
            lb_topOder.Size = new Size(247, 174);
            lb_topOder.TabIndex = 10;
            lb_topOder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(73, 13);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 11;
            label8.Text = "Top 5 order";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(779, 80);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(421, 113);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // btn_viewall
            // 
            btn_viewall.FlatStyle = FlatStyle.Flat;
            btn_viewall.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_viewall.Location = new Point(779, 32);
            btn_viewall.Name = "btn_viewall";
            btn_viewall.Size = new Size(94, 29);
            btn_viewall.TabIndex = 34;
            btn_viewall.Text = "Tất cả";
            btn_viewall.UseVisualStyleBackColor = true;
            btn_viewall.Click += btn_viewall_Click;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1246, 693);
            Controls.Add(btn_viewall);
            Controls.Add(pictureBox6);
            Controls.Add(panel6);
            Controls.Add(datePickEnd);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_statistical);
            Controls.Add(datePickStart);
            Controls.Add(label1);
            Name = "ThongKe";
            Text = "Thống kê";
            Load += DoanhThu_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DateTimePicker datePickStart;
        private Button btn_statistical;
        private Panel panel1;
        private Panel panel2;
        private Label lb_totalBill;
        private Label label2;
        private Panel panel3;
        private Label lb_Revenue;
        private Label label4;
        private Panel panel4;
        private Label lb_profit;
        private Label label5;
        private Panel panel5;
        private Label lb_totalCus;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DateTimePicker datePickEnd;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label lb_topOder;
        private Label label8;
        private PictureBox pictureBox6;
        private Button btn_viewall;
    }
}