namespace Form1
{
    partial class Form_LapHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LapHoaDon));
            product = new ColumnHeader();
            button_back = new Button();
            tabPage1 = new TabPage();
            bt_pizaGaNuong = new Button();
            bt_pizaRauCu = new Button();
            bt_pizaHawai = new Button();
            bt_pizaPhoMai = new Button();
            bt_pizaThitXong = new Button();
            bt_pizaTomCock = new Button();
            btn = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            bt_GaToi = new Button();
            bt_GaPop = new Button();
            bt_GaHan = new Button();
            bt_GaPmai = new Button();
            tabPage3 = new TabPage();
            bt_myGiam = new Button();
            bt_myBo = new Button();
            bt_myKem = new Button();
            tabPage4 = new TabPage();
            bt_saladCaesar = new Button();
            bt_daCa = new Button();
            bt_khongXuong = new Button();
            bt_saladDac = new Button();
            tabPage6 = new TabPage();
            bt_banhToi = new Button();
            bt_banhKep = new Button();
            bt_banhNuong = new Button();
            tabPage5 = new TabPage();
            bt_aqua = new Button();
            bt_heineken = new Button();
            bt_7up = new Button();
            bt_tiger = new Button();
            bt_pepsi = new Button();
            bt_mirin = new Button();
            txt_timeOrder = new TextBox();
            txt_nameCus = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            listview_ThanhToan = new ListView();
            SoLuongProduct = new ColumnHeader();
            price = new ColumnHeader();
            totalPrice = new ColumnHeader();
            bt_clear = new Button();
            panel_chucnang = new Panel();
            bt_update = new Button();
            txt_amount = new TextBox();
            txt_nameProduct = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_totalProductPay = new TextBox();
            label6 = new Label();
            bt_delete = new Button();
            bt_bill = new Button();
            pictureBox1 = new PictureBox();
            txt_makm = new TextBox();
            btn_apmakm = new Button();
            label1 = new Label();
            cb_tennv = new ComboBox();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            panel_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // product
            // 
            product.Text = "Sản phẩm";
            product.Width = 185;
            // 
            // button_back
            // 
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.ImageAlign = ContentAlignment.MiddleLeft;
            button_back.Location = new Point(1362, 34);
            button_back.Name = "button_back";
            button_back.Size = new Size(38, 40);
            button_back.TabIndex = 3;
            button_back.TextAlign = ContentAlignment.MiddleRight;
            button_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(bt_pizaGaNuong);
            tabPage1.Controls.Add(bt_pizaRauCu);
            tabPage1.Controls.Add(bt_pizaHawai);
            tabPage1.Controls.Add(bt_pizaPhoMai);
            tabPage1.Controls.Add(bt_pizaThitXong);
            tabPage1.Controls.Add(bt_pizaTomCock);
            tabPage1.Controls.Add(btn);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(716, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pizza";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_pizaGaNuong
            // 
            bt_pizaGaNuong.BackColor = Color.White;
            bt_pizaGaNuong.BackgroundImage = (Image)resources.GetObject("bt_pizaGaNuong.BackgroundImage");
            bt_pizaGaNuong.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaGaNuong.Location = new Point(14, 458);
            bt_pizaGaNuong.Name = "bt_pizaGaNuong";
            bt_pizaGaNuong.Size = new Size(213, 197);
            bt_pizaGaNuong.TabIndex = 23;
            bt_pizaGaNuong.Text = "Pizza Gà nướng tam vị";
            bt_pizaGaNuong.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaGaNuong.UseVisualStyleBackColor = false;
            bt_pizaGaNuong.Click += btn_Click;
            // 
            // bt_pizaRauCu
            // 
            bt_pizaRauCu.BackColor = Color.White;
            bt_pizaRauCu.BackgroundImage = (Image)resources.GetObject("bt_pizaRauCu.BackgroundImage");
            bt_pizaRauCu.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaRauCu.Location = new Point(476, 245);
            bt_pizaRauCu.Name = "bt_pizaRauCu";
            bt_pizaRauCu.Size = new Size(213, 197);
            bt_pizaRauCu.TabIndex = 22;
            bt_pizaRauCu.Text = "Pizza Rau củ";
            bt_pizaRauCu.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaRauCu.UseVisualStyleBackColor = false;
            bt_pizaRauCu.Click += btn_Click;
            // 
            // bt_pizaHawai
            // 
            bt_pizaHawai.BackColor = Color.White;
            bt_pizaHawai.BackgroundImage = (Image)resources.GetObject("bt_pizaHawai.BackgroundImage");
            bt_pizaHawai.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaHawai.Location = new Point(247, 245);
            bt_pizaHawai.Name = "bt_pizaHawai";
            bt_pizaHawai.Size = new Size(213, 197);
            bt_pizaHawai.TabIndex = 21;
            bt_pizaHawai.Text = "Pizza Hawai";
            bt_pizaHawai.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaHawai.UseVisualStyleBackColor = false;
            bt_pizaHawai.Click += btn_Click;
            // 
            // bt_pizaPhoMai
            // 
            bt_pizaPhoMai.BackColor = Color.White;
            bt_pizaPhoMai.BackgroundImage = (Image)resources.GetObject("bt_pizaPhoMai.BackgroundImage");
            bt_pizaPhoMai.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaPhoMai.Location = new Point(14, 245);
            bt_pizaPhoMai.Name = "bt_pizaPhoMai";
            bt_pizaPhoMai.Size = new Size(213, 197);
            bt_pizaPhoMai.TabIndex = 20;
            bt_pizaPhoMai.Text = "Pizza Phô mai";
            bt_pizaPhoMai.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaPhoMai.UseVisualStyleBackColor = false;
            bt_pizaPhoMai.Click += btn_Click;
            // 
            // bt_pizaThitXong
            // 
            bt_pizaThitXong.BackColor = Color.White;
            bt_pizaThitXong.BackgroundImage = (Image)resources.GetObject("bt_pizaThitXong.BackgroundImage");
            bt_pizaThitXong.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaThitXong.Location = new Point(476, 23);
            bt_pizaThitXong.Name = "bt_pizaThitXong";
            bt_pizaThitXong.Size = new Size(213, 197);
            bt_pizaThitXong.TabIndex = 19;
            bt_pizaThitXong.Text = "Pizza Thịt xông khói";
            bt_pizaThitXong.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaThitXong.UseVisualStyleBackColor = false;
            bt_pizaThitXong.Click += btn_Click;
            // 
            // bt_pizaTomCock
            // 
            bt_pizaTomCock.BackColor = Color.White;
            bt_pizaTomCock.BackgroundImage = (Image)resources.GetObject("bt_pizaTomCock.BackgroundImage");
            bt_pizaTomCock.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pizaTomCock.Location = new Point(247, 23);
            bt_pizaTomCock.Name = "bt_pizaTomCock";
            bt_pizaTomCock.Size = new Size(213, 197);
            bt_pizaTomCock.TabIndex = 18;
            bt_pizaTomCock.Text = "Pizza Tôm Cocktail";
            bt_pizaTomCock.TextAlign = ContentAlignment.BottomCenter;
            bt_pizaTomCock.UseVisualStyleBackColor = false;
            bt_pizaTomCock.Click += btn_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.White;
            btn.BackgroundImage = (Image)resources.GetObject("btn.BackgroundImage");
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.Location = new Point(14, 23);
            btn.Name = "btn";
            btn.Size = new Size(213, 197);
            btn.TabIndex = 17;
            btn.Text = "Pizza Hải sản cao cấp";
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(120, 30);
            tabControl1.Location = new Point(29, 124);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 699);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bt_GaToi);
            tabPage2.Controls.Add(bt_GaPop);
            tabPage2.Controls.Add(bt_GaHan);
            tabPage2.Controls.Add(bt_GaPmai);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(716, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gà giòn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_GaToi
            // 
            bt_GaToi.BackColor = Color.White;
            bt_GaToi.BackgroundImage = (Image)resources.GetObject("bt_GaToi.BackgroundImage");
            bt_GaToi.BackgroundImageLayout = ImageLayout.Zoom;
            bt_GaToi.Location = new Point(23, 243);
            bt_GaToi.Name = "bt_GaToi";
            bt_GaToi.Size = new Size(194, 189);
            bt_GaToi.TabIndex = 16;
            bt_GaToi.Text = "Gà giòn xốt tương tỏi";
            bt_GaToi.TextAlign = ContentAlignment.BottomCenter;
            bt_GaToi.UseVisualStyleBackColor = false;
            bt_GaToi.Click += btn_Click;
            // 
            // bt_GaPop
            // 
            bt_GaPop.BackColor = Color.White;
            bt_GaPop.BackgroundImage = (Image)resources.GetObject("bt_GaPop.BackgroundImage");
            bt_GaPop.BackgroundImageLayout = ImageLayout.Zoom;
            bt_GaPop.Location = new Point(23, 23);
            bt_GaPop.Name = "bt_GaPop";
            bt_GaPop.Size = new Size(194, 189);
            bt_GaPop.TabIndex = 15;
            bt_GaPop.Text = "Gà Popcorn";
            bt_GaPop.TextAlign = ContentAlignment.BottomCenter;
            bt_GaPop.UseVisualStyleBackColor = false;
            bt_GaPop.Click += btn_Click;
            // 
            // bt_GaHan
            // 
            bt_GaHan.BackColor = Color.White;
            bt_GaHan.BackgroundImage = (Image)resources.GetObject("bt_GaHan.BackgroundImage");
            bt_GaHan.BackgroundImageLayout = ImageLayout.Zoom;
            bt_GaHan.Location = new Point(250, 23);
            bt_GaHan.Name = "bt_GaHan";
            bt_GaHan.Size = new Size(194, 189);
            bt_GaHan.TabIndex = 14;
            bt_GaHan.Text = "Gà giòn xốt Hàn";
            bt_GaHan.TextAlign = ContentAlignment.BottomCenter;
            bt_GaHan.UseVisualStyleBackColor = false;
            bt_GaHan.Click += btn_Click;
            // 
            // bt_GaPmai
            // 
            bt_GaPmai.BackColor = Color.White;
            bt_GaPmai.BackgroundImage = (Image)resources.GetObject("bt_GaPmai.BackgroundImage");
            bt_GaPmai.BackgroundImageLayout = ImageLayout.Zoom;
            bt_GaPmai.Location = new Point(485, 23);
            bt_GaPmai.Name = "bt_GaPmai";
            bt_GaPmai.Size = new Size(194, 189);
            bt_GaPmai.TabIndex = 13;
            bt_GaPmai.Text = "Gà lắc phô mai";
            bt_GaPmai.TextAlign = ContentAlignment.BottomCenter;
            bt_GaPmai.UseVisualStyleBackColor = false;
            bt_GaPmai.Click += btn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(bt_myGiam);
            tabPage3.Controls.Add(bt_myBo);
            tabPage3.Controls.Add(bt_myKem);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(716, 661);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mỳ Ý";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_myGiam
            // 
            bt_myGiam.BackColor = Color.White;
            bt_myGiam.BackgroundImage = (Image)resources.GetObject("bt_myGiam.BackgroundImage");
            bt_myGiam.BackgroundImageLayout = ImageLayout.Zoom;
            bt_myGiam.Location = new Point(254, 23);
            bt_myGiam.Name = "bt_myGiam";
            bt_myGiam.Size = new Size(194, 189);
            bt_myGiam.TabIndex = 12;
            bt_myGiam.Text = "Mỳ Ý giăm bông";
            bt_myGiam.TextAlign = ContentAlignment.BottomCenter;
            bt_myGiam.UseVisualStyleBackColor = false;
            bt_myGiam.Click += btn_Click;
            // 
            // bt_myBo
            // 
            bt_myBo.BackColor = Color.White;
            bt_myBo.BackgroundImage = (Image)resources.GetObject("bt_myBo.BackgroundImage");
            bt_myBo.BackgroundImageLayout = ImageLayout.Zoom;
            bt_myBo.Location = new Point(482, 23);
            bt_myBo.Name = "bt_myBo";
            bt_myBo.Size = new Size(194, 189);
            bt_myBo.TabIndex = 11;
            bt_myBo.Text = "Mỳ Ý thịt bò bằm";
            bt_myBo.TextAlign = ContentAlignment.BottomCenter;
            bt_myBo.UseVisualStyleBackColor = false;
            bt_myBo.Click += btn_Click;
            // 
            // bt_myKem
            // 
            bt_myKem.BackColor = Color.White;
            bt_myKem.BackgroundImage = (Image)resources.GetObject("bt_myKem.BackgroundImage");
            bt_myKem.BackgroundImageLayout = ImageLayout.Zoom;
            bt_myKem.Location = new Point(18, 23);
            bt_myKem.Name = "bt_myKem";
            bt_myKem.Size = new Size(200, 189);
            bt_myKem.TabIndex = 10;
            bt_myKem.Text = "Mỳ Ý sốt kem tươi";
            bt_myKem.TextAlign = ContentAlignment.BottomCenter;
            bt_myKem.UseVisualStyleBackColor = false;
            bt_myKem.Click += btn_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(bt_saladCaesar);
            tabPage4.Controls.Add(bt_daCa);
            tabPage4.Controls.Add(bt_khongXuong);
            tabPage4.Controls.Add(bt_saladDac);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(716, 661);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Salad";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // bt_saladCaesar
            // 
            bt_saladCaesar.BackColor = Color.White;
            bt_saladCaesar.BackgroundImage = (Image)resources.GetObject("bt_saladCaesar.BackgroundImage");
            bt_saladCaesar.BackgroundImageLayout = ImageLayout.Zoom;
            bt_saladCaesar.Location = new Point(23, 245);
            bt_saladCaesar.Name = "bt_saladCaesar";
            bt_saladCaesar.Size = new Size(194, 189);
            bt_saladCaesar.TabIndex = 19;
            bt_saladCaesar.Text = "Salad trộn xốt Caesar";
            bt_saladCaesar.TextAlign = ContentAlignment.BottomCenter;
            bt_saladCaesar.UseVisualStyleBackColor = false;
            bt_saladCaesar.Click += btn_Click;
            // 
            // bt_daCa
            // 
            bt_daCa.BackColor = Color.White;
            bt_daCa.BackgroundImage = (Image)resources.GetObject("bt_daCa.BackgroundImage");
            bt_daCa.BackgroundImageLayout = ImageLayout.Zoom;
            bt_daCa.Location = new Point(492, 23);
            bt_daCa.Name = "bt_daCa";
            bt_daCa.Size = new Size(194, 189);
            bt_daCa.TabIndex = 18;
            bt_daCa.Text = "Salad da cá hồi";
            bt_daCa.TextAlign = ContentAlignment.BottomCenter;
            bt_daCa.UseVisualStyleBackColor = false;
            bt_daCa.Click += btn_Click;
            // 
            // bt_khongXuong
            // 
            bt_khongXuong.BackColor = Color.White;
            bt_khongXuong.BackgroundImage = (Image)resources.GetObject("bt_khongXuong.BackgroundImage");
            bt_khongXuong.BackgroundImageLayout = ImageLayout.Zoom;
            bt_khongXuong.Location = new Point(259, 23);
            bt_khongXuong.Name = "bt_khongXuong";
            bt_khongXuong.Size = new Size(194, 189);
            bt_khongXuong.TabIndex = 17;
            bt_khongXuong.Text = "Salad gà không xương";
            bt_khongXuong.TextAlign = ContentAlignment.BottomCenter;
            bt_khongXuong.UseVisualStyleBackColor = false;
            bt_khongXuong.Click += btn_Click;
            // 
            // bt_saladDac
            // 
            bt_saladDac.BackColor = Color.White;
            bt_saladDac.BackgroundImage = (Image)resources.GetObject("bt_saladDac.BackgroundImage");
            bt_saladDac.BackgroundImageLayout = ImageLayout.Zoom;
            bt_saladDac.Location = new Point(23, 23);
            bt_saladDac.Name = "bt_saladDac";
            bt_saladDac.Size = new Size(194, 189);
            bt_saladDac.TabIndex = 16;
            bt_saladDac.Text = "Salad đặc sắc";
            bt_saladDac.TextAlign = ContentAlignment.BottomCenter;
            bt_saladDac.UseVisualStyleBackColor = false;
            bt_saladDac.Click += btn_Click;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(bt_banhToi);
            tabPage6.Controls.Add(bt_banhKep);
            tabPage6.Controls.Add(bt_banhNuong);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(716, 661);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Bánh mì";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // bt_banhToi
            // 
            bt_banhToi.BackColor = Color.White;
            bt_banhToi.BackgroundImage = (Image)resources.GetObject("bt_banhToi.BackgroundImage");
            bt_banhToi.BackgroundImageLayout = ImageLayout.Zoom;
            bt_banhToi.Location = new Point(16, 23);
            bt_banhToi.Name = "bt_banhToi";
            bt_banhToi.Size = new Size(194, 189);
            bt_banhToi.TabIndex = 14;
            bt_banhToi.Text = "Bánh mì bơ tỏi";
            bt_banhToi.TextAlign = ContentAlignment.BottomCenter;
            bt_banhToi.UseVisualStyleBackColor = false;
            bt_banhToi.Click += btn_Click;
            // 
            // bt_banhKep
            // 
            bt_banhKep.BackColor = Color.White;
            bt_banhKep.BackgroundImage = (Image)resources.GetObject("bt_banhKep.BackgroundImage");
            bt_banhKep.BackgroundImageLayout = ImageLayout.Zoom;
            bt_banhKep.Location = new Point(490, 23);
            bt_banhKep.Name = "bt_banhKep";
            bt_banhKep.Size = new Size(194, 189);
            bt_banhKep.TabIndex = 13;
            bt_banhKep.Text = "Bánh mì kẹp nướng";
            bt_banhKep.TextAlign = ContentAlignment.BottomCenter;
            bt_banhKep.UseVisualStyleBackColor = false;
            bt_banhKep.Click += btn_Click;
            // 
            // bt_banhNuong
            // 
            bt_banhNuong.BackColor = Color.White;
            bt_banhNuong.BackgroundImage = (Image)resources.GetObject("bt_banhNuong.BackgroundImage");
            bt_banhNuong.BackgroundImageLayout = ImageLayout.Zoom;
            bt_banhNuong.Location = new Point(252, 23);
            bt_banhNuong.Name = "bt_banhNuong";
            bt_banhNuong.Size = new Size(194, 189);
            bt_banhNuong.TabIndex = 12;
            bt_banhNuong.Text = "Bánh mì que nướng";
            bt_banhNuong.TextAlign = ContentAlignment.BottomCenter;
            bt_banhNuong.UseVisualStyleBackColor = false;
            bt_banhNuong.Click += btn_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(bt_aqua);
            tabPage5.Controls.Add(bt_heineken);
            tabPage5.Controls.Add(bt_7up);
            tabPage5.Controls.Add(bt_tiger);
            tabPage5.Controls.Add(bt_pepsi);
            tabPage5.Controls.Add(bt_mirin);
            tabPage5.ForeColor = SystemColors.Desktop;
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(716, 661);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Thức uống";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // bt_aqua
            // 
            bt_aqua.BackColor = Color.White;
            bt_aqua.BackgroundImage = (Image)resources.GetObject("bt_aqua.BackgroundImage");
            bt_aqua.BackgroundImageLayout = ImageLayout.Zoom;
            bt_aqua.Location = new Point(489, 239);
            bt_aqua.Name = "bt_aqua";
            bt_aqua.Size = new Size(194, 189);
            bt_aqua.TabIndex = 13;
            bt_aqua.Text = "Aquafina 500ml";
            bt_aqua.TextAlign = ContentAlignment.BottomCenter;
            bt_aqua.UseVisualStyleBackColor = false;
            bt_aqua.Click += btn_Click;
            // 
            // bt_heineken
            // 
            bt_heineken.BackColor = Color.White;
            bt_heineken.BackgroundImage = (Image)resources.GetObject("bt_heineken.BackgroundImage");
            bt_heineken.BackgroundImageLayout = ImageLayout.Zoom;
            bt_heineken.Location = new Point(260, 239);
            bt_heineken.Name = "bt_heineken";
            bt_heineken.Size = new Size(194, 189);
            bt_heineken.TabIndex = 12;
            bt_heineken.Text = "Heineken 330ml";
            bt_heineken.TextAlign = ContentAlignment.BottomCenter;
            bt_heineken.UseVisualStyleBackColor = false;
            bt_heineken.Click += btn_Click;
            // 
            // bt_7up
            // 
            bt_7up.BackColor = Color.White;
            bt_7up.BackgroundImage = (Image)resources.GetObject("bt_7up.BackgroundImage");
            bt_7up.BackgroundImageLayout = ImageLayout.Zoom;
            bt_7up.Location = new Point(489, 23);
            bt_7up.Name = "bt_7up";
            bt_7up.Size = new Size(194, 189);
            bt_7up.TabIndex = 11;
            bt_7up.Text = "7Up 330ml";
            bt_7up.TextAlign = ContentAlignment.BottomCenter;
            bt_7up.UseVisualStyleBackColor = false;
            bt_7up.Click += btn_Click;
            // 
            // bt_tiger
            // 
            bt_tiger.BackColor = Color.White;
            bt_tiger.BackgroundImage = (Image)resources.GetObject("bt_tiger.BackgroundImage");
            bt_tiger.BackgroundImageLayout = ImageLayout.Zoom;
            bt_tiger.Location = new Point(26, 239);
            bt_tiger.Name = "bt_tiger";
            bt_tiger.Size = new Size(200, 189);
            bt_tiger.TabIndex = 10;
            bt_tiger.Text = "Tiger Crystal 330ml";
            bt_tiger.TextAlign = ContentAlignment.BottomCenter;
            bt_tiger.UseVisualStyleBackColor = false;
            bt_tiger.Click += btn_Click;
            // 
            // bt_pepsi
            // 
            bt_pepsi.BackColor = Color.White;
            bt_pepsi.BackgroundImage = (Image)resources.GetObject("bt_pepsi.BackgroundImage");
            bt_pepsi.BackgroundImageLayout = ImageLayout.Zoom;
            bt_pepsi.Location = new Point(26, 23);
            bt_pepsi.Name = "bt_pepsi";
            bt_pepsi.Size = new Size(200, 189);
            bt_pepsi.TabIndex = 9;
            bt_pepsi.Text = "Pepsi 330ml";
            bt_pepsi.TextAlign = ContentAlignment.BottomCenter;
            bt_pepsi.UseVisualStyleBackColor = false;
            bt_pepsi.Click += btn_Click;
            // 
            // bt_mirin
            // 
            bt_mirin.BackColor = Color.White;
            bt_mirin.BackgroundImage = (Image)resources.GetObject("bt_mirin.BackgroundImage");
            bt_mirin.BackgroundImageLayout = ImageLayout.Zoom;
            bt_mirin.Location = new Point(260, 23);
            bt_mirin.Name = "bt_mirin";
            bt_mirin.Size = new Size(194, 189);
            bt_mirin.TabIndex = 8;
            bt_mirin.Text = "Mirinda Soda kem 330ml";
            bt_mirin.TextAlign = ContentAlignment.BottomCenter;
            bt_mirin.UseVisualStyleBackColor = false;
            bt_mirin.Click += btn_Click;
            // 
            // txt_timeOrder
            // 
            txt_timeOrder.BackColor = SystemColors.ControlLightLight;
            txt_timeOrder.Location = new Point(823, 128);
            txt_timeOrder.Name = "txt_timeOrder";
            txt_timeOrder.ReadOnly = true;
            txt_timeOrder.Size = new Size(177, 27);
            txt_timeOrder.TabIndex = 5;
            // 
            // txt_nameCus
            // 
            txt_nameCus.Location = new Point(1149, 128);
            txt_nameCus.Name = "txt_nameCus";
            txt_nameCus.Size = new Size(248, 27);
            txt_nameCus.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(823, 100);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 7;
            label2.Text = "Thời gian";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1149, 100);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 8;
            label3.Text = "(*) Khách hàng";
            // 
            // listview_ThanhToan
            // 
            listview_ThanhToan.Columns.AddRange(new ColumnHeader[] { product, SoLuongProduct, price, totalPrice });
            listview_ThanhToan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listview_ThanhToan.GridLines = true;
            listview_ThanhToan.Location = new Point(819, 240);
            listview_ThanhToan.Name = "listview_ThanhToan";
            listview_ThanhToan.Size = new Size(581, 419);
            listview_ThanhToan.TabIndex = 9;
            listview_ThanhToan.UseCompatibleStateImageBehavior = false;
            listview_ThanhToan.View = View.Details;
            listview_ThanhToan.MouseDoubleClick += listview_ThanhToan_MouseDoubleClick;
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
            // bt_clear
            // 
            bt_clear.BackColor = SystemColors.ControlLightLight;
            bt_clear.FlatStyle = FlatStyle.Flat;
            bt_clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_clear.Image = (Image)resources.GetObject("bt_clear.Image");
            bt_clear.Location = new Point(820, 677);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(40, 37);
            bt_clear.TabIndex = 10;
            bt_clear.TextAlign = ContentAlignment.MiddleRight;
            bt_clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_clear.UseVisualStyleBackColor = false;
            bt_clear.Click += bt_clear_Click;
            // 
            // panel_chucnang
            // 
            panel_chucnang.BackColor = Color.Beige;
            panel_chucnang.BorderStyle = BorderStyle.FixedSingle;
            panel_chucnang.Controls.Add(bt_update);
            panel_chucnang.Controls.Add(txt_amount);
            panel_chucnang.Controls.Add(txt_nameProduct);
            panel_chucnang.Controls.Add(label5);
            panel_chucnang.Controls.Add(label4);
            panel_chucnang.ForeColor = SystemColors.ControlText;
            panel_chucnang.Location = new Point(1144, 257);
            panel_chucnang.Name = "panel_chucnang";
            panel_chucnang.Size = new Size(256, 155);
            panel_chucnang.TabIndex = 11;
            // 
            // bt_update
            // 
            bt_update.FlatStyle = FlatStyle.Flat;
            bt_update.Location = new Point(160, 113);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(93, 33);
            bt_update.TabIndex = 4;
            bt_update.Text = "Xác nhận";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // txt_amount
            // 
            txt_amount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_amount.Location = new Point(3, 113);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(77, 27);
            txt_amount.TabIndex = 3;
            // 
            // txt_nameProduct
            // 
            txt_nameProduct.BackColor = SystemColors.ControlLightLight;
            txt_nameProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nameProduct.Location = new Point(3, 39);
            txt_nameProduct.Name = "txt_nameProduct";
            txt_nameProduct.ReadOnly = true;
            txt_nameProduct.Size = new Size(250, 27);
            txt_nameProduct.TabIndex = 2;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 85);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 1;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm";
            // 
            // txt_totalProductPay
            // 
            txt_totalProductPay.BackColor = SystemColors.ButtonHighlight;
            txt_totalProductPay.Location = new Point(1215, 746);
            txt_totalProductPay.Name = "txt_totalProductPay";
            txt_totalProductPay.ReadOnly = true;
            txt_totalProductPay.Size = new Size(186, 27);
            txt_totalProductPay.TabIndex = 12;
            txt_totalProductPay.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(1215, 718);
            label6.Name = "label6";
            label6.Size = new Size(186, 25);
            label6.TabIndex = 13;
            label6.Text = "(*) Số tiền thanh toán (vnd)";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = SystemColors.ControlLightLight;
            bt_delete.FlatStyle = FlatStyle.Flat;
            bt_delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_delete.Image = (Image)resources.GetObject("bt_delete.Image");
            bt_delete.ImageAlign = ContentAlignment.MiddleLeft;
            bt_delete.Location = new Point(880, 677);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(39, 37);
            bt_delete.TabIndex = 14;
            bt_delete.TextAlign = ContentAlignment.MiddleRight;
            bt_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_bill
            // 
            bt_bill.FlatStyle = FlatStyle.Flat;
            bt_bill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_bill.Image = (Image)resources.GetObject("bt_bill.Image");
            bt_bill.Location = new Point(1268, 783);
            bt_bill.Name = "bt_bill";
            bt_bill.Size = new Size(133, 40);
            bt_bill.TabIndex = 16;
            bt_bill.Text = "Thanh toán";
            bt_bill.TextAlign = ContentAlignment.MiddleRight;
            bt_bill.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_bill.UseVisualStyleBackColor = true;
            bt_bill.Click += bt_bill_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(752, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_makm
            // 
            txt_makm.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txt_makm.Location = new Point(1219, 677);
            txt_makm.Name = "txt_makm";
            txt_makm.Size = new Size(129, 27);
            txt_makm.TabIndex = 20;
            // 
            // btn_apmakm
            // 
            btn_apmakm.FlatStyle = FlatStyle.Flat;
            btn_apmakm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_apmakm.Location = new Point(1354, 677);
            btn_apmakm.Name = "btn_apmakm";
            btn_apmakm.Size = new Size(47, 27);
            btn_apmakm.TabIndex = 21;
            btn_apmakm.Text = "OK";
            btn_apmakm.UseVisualStyleBackColor = true;
            btn_apmakm.Click += btn_apmakm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1150, 170);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 23;
            label1.Text = "Nhân viên lập hóa đơn";
            // 
            // cb_tennv
            // 
            cb_tennv.FormattingEnabled = true;
            cb_tennv.Location = new Point(1150, 198);
            cb_tennv.Name = "cb_tennv";
            cb_tennv.Size = new Size(250, 28);
            cb_tennv.TabIndex = 22;
            // 
            // Form_LapHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1432, 853);
            Controls.Add(label1);
            Controls.Add(cb_tennv);
            Controls.Add(btn_apmakm);
            Controls.Add(txt_makm);
            Controls.Add(bt_bill);
            Controls.Add(bt_delete);
            Controls.Add(label6);
            Controls.Add(txt_totalProductPay);
            Controls.Add(panel_chucnang);
            Controls.Add(bt_clear);
            Controls.Add(listview_ThanhToan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_nameCus);
            Controls.Add(txt_timeOrder);
            Controls.Add(tabControl1);
            Controls.Add(button_back);
            Controls.Add(pictureBox1);
            Name = "Form_LapHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThanhToan";
            Load += ThanhToan_Load;
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            panel_chucnang.ResumeLayout(false);
            panel_chucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_back;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button bt_pepsi;
        private Button bt_mirin;
        private Button bt_myGiam;
        private Button bt_myBo;
        private Button bt_myKem;
        private TabPage tabPage6;
        private Button bt_banhToi;
        private Button bt_banhKep;
        private Button bt_banhNuong;
        private Button bt_heineken;
        private Button bt_7up;
        private Button bt_tiger;
        private Button bt_pizaGaNuong;
        private Button bt_pizaRauCu;
        private Button bt_pizaHawai;
        private Button bt_pizaPhoMai;
        private Button bt_pizaThitXong;
        private Button bt_pizaTomCock;
        private Button btn;
        private Button bt_GaToi;
        private Button bt_GaPop;
        private Button bt_GaHan;
        private Button bt_GaPmai;
        private Button bt_saladCaesar;
        private Button bt_daCa;
        private Button bt_khongXuong;
        private Button bt_saladDac;
        private TextBox txt_timeOrder;
        private TextBox txt_nameCus;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Button bt_aqua;
        private ListView listview_ThanhToan;
        private ColumnHeader SoLuongProduct;
        private ColumnHeader price;
        private ColumnHeader totalPrice;
        private ColumnHeader product;
        private Button bt_clear;
        private Panel panel_chucnang;
        private TextBox txt_amount;
        private TextBox txt_nameProduct;
        private Label label5;
        private Label label4;
        private Button bt_update;
        private TextBox txt_totalProductPay;
        private Label label6;
        private Button bt_delete;
        private Button bt_bill;
        private PictureBox pictureBox1;
        private TextBox txt_makm;
        private Button btn_apmakm;
        private Label label1;
        private ComboBox cb_tennv;
    }
}