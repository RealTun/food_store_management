namespace Form1
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            listview_Bill = new ListView();
            product = new ColumnHeader();
            SoLuongProduct = new ColumnHeader();
            price = new ColumnHeader();
            totalPrice = new ColumnHeader();
            label_numberBill = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label_discount = new Label();
            label8 = new Label();
            label_payment = new Label();
            label11 = new Label();
            label_makm = new Label();
            pictureBox1 = new PictureBox();
            label_nameCustomer = new Label();
            label_timeBill = new Label();
            bt_PrintBill = new Button();
            lb_nguoiban = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listview_Bill
            // 
            listview_Bill.Columns.AddRange(new ColumnHeader[] { product, SoLuongProduct, price, totalPrice });
            listview_Bill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listview_Bill.GridLines = true;
            listview_Bill.Location = new Point(55, 272);
            listview_Bill.Name = "listview_Bill";
            listview_Bill.Size = new Size(587, 343);
            listview_Bill.TabIndex = 10;
            listview_Bill.UseCompatibleStateImageBehavior = false;
            listview_Bill.View = View.Details;
            // 
            // product
            // 
            product.Text = "Sản phẩm";
            product.Width = 185;
            // 
            // SoLuongProduct
            // 
            SoLuongProduct.Text = "Số lượng";
            SoLuongProduct.Width = 100;
            // 
            // price
            // 
            price.Text = "Giá";
            price.Width = 120;
            // 
            // totalPrice
            // 
            totalPrice.Text = "Tổng tiền";
            totalPrice.Width = 160;
            // 
            // label_numberBill
            // 
            label_numberBill.BackColor = SystemColors.Control;
            label_numberBill.BorderStyle = BorderStyle.Fixed3D;
            label_numberBill.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_numberBill.Location = new Point(156, 154);
            label_numberBill.Name = "label_numberBill";
            label_numberBill.Size = new Size(166, 28);
            label_numberBill.TabIndex = 16;
            label_numberBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(48, 203);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 17;
            label2.Text = "Khách hàng";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(389, 157);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 18;
            label5.Text = "Thời gian";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(50, 158);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 15;
            label4.Text = "Hóa đơn số:";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(416, 643);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 19;
            label6.Text = "Giảm giá: \r\n";
            // 
            // label_discount
            // 
            label_discount.BackColor = SystemColors.Control;
            label_discount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_discount.Location = new Point(518, 639);
            label_discount.Name = "label_discount";
            label_discount.Size = new Size(124, 28);
            label_discount.TabIndex = 20;
            label_discount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(416, 682);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 21;
            label8.Text = "Thanh toán:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_payment
            // 
            label_payment.BackColor = SystemColors.Control;
            label_payment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_payment.Location = new Point(518, 682);
            label_payment.Name = "label_payment";
            label_payment.Size = new Size(124, 28);
            label_payment.TabIndex = 22;
            label_payment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(55, 639);
            label11.Name = "label11";
            label11.Size = new Size(162, 20);
            label11.TabIndex = 24;
            label11.Text = "Mã khuyến mại sử dụng";
            // 
            // label_makm
            // 
            label_makm.BackColor = SystemColors.ButtonFace;
            label_makm.BorderStyle = BorderStyle.FixedSingle;
            label_makm.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label_makm.Location = new Point(55, 664);
            label_makm.Name = "label_makm";
            label_makm.Size = new Size(230, 39);
            label_makm.TabIndex = 25;
            label_makm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label_nameCustomer
            // 
            label_nameCustomer.BackColor = SystemColors.Control;
            label_nameCustomer.BorderStyle = BorderStyle.Fixed3D;
            label_nameCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_nameCustomer.Location = new Point(156, 203);
            label_nameCustomer.Name = "label_nameCustomer";
            label_nameCustomer.Size = new Size(166, 28);
            label_nameCustomer.TabIndex = 29;
            label_nameCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_timeBill
            // 
            label_timeBill.BackColor = SystemColors.Control;
            label_timeBill.BorderStyle = BorderStyle.Fixed3D;
            label_timeBill.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_timeBill.Location = new Point(470, 158);
            label_timeBill.Name = "label_timeBill";
            label_timeBill.Size = new Size(172, 28);
            label_timeBill.TabIndex = 30;
            label_timeBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_PrintBill
            // 
            bt_PrintBill.FlatStyle = FlatStyle.Flat;
            bt_PrintBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_PrintBill.Image = (Image)resources.GetObject("bt_PrintBill.Image");
            bt_PrintBill.Location = new Point(507, 728);
            bt_PrintBill.Name = "bt_PrintBill";
            bt_PrintBill.Size = new Size(135, 38);
            bt_PrintBill.TabIndex = 31;
            bt_PrintBill.Text = "Thanh toán";
            bt_PrintBill.TextAlign = ContentAlignment.MiddleRight;
            bt_PrintBill.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_PrintBill.UseVisualStyleBackColor = true;
            bt_PrintBill.Click += bt_PrintBill_Click;
            // 
            // lb_nguoiban
            // 
            lb_nguoiban.BackColor = SystemColors.Control;
            lb_nguoiban.BorderStyle = BorderStyle.Fixed3D;
            lb_nguoiban.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nguoiban.Location = new Point(470, 204);
            lb_nguoiban.Name = "lb_nguoiban";
            lb_nguoiban.Size = new Size(172, 28);
            lb_nguoiban.TabIndex = 32;
            lb_nguoiban.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(389, 208);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 33;
            label3.Text = "Người lập";
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(682, 803);
            Controls.Add(label3);
            Controls.Add(lb_nguoiban);
            Controls.Add(bt_PrintBill);
            Controls.Add(label_timeBill);
            Controls.Add(label_nameCustomer);
            Controls.Add(pictureBox1);
            Controls.Add(label_makm);
            Controls.Add(label11);
            Controls.Add(label_payment);
            Controls.Add(label8);
            Controls.Add(label_discount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label_numberBill);
            Controls.Add(label4);
            Controls.Add(listview_Bill);
            Name = "FormBill";
            Text = "FormBill";
            Load += FormBill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listview_Bill;
        private ColumnHeader product;
        private ColumnHeader SoLuongProduct;
        private ColumnHeader price;
        private ColumnHeader totalPrice;
        private Label label_numberBill;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label_discount;
        private Label label8;
        private Label label_payment;
        private Label label11;
        private Label label_makm;
        private PictureBox pictureBox1;
        private Label label_nameCustomer;
        private Label label_timeBill;
        private Button bt_PrintBill;
        private Label lb_nguoiban;
        private Label label3;
    }
}