using QLNH;

namespace Form1
{
    public partial class App : Form
    {
        private bool Permission { set; get; }
        public App()
        {
            InitializeComponent();
        }

        public App(bool pms)
        {
            InitializeComponent();
            Permission = pms;
        }

        private void button_LichLam_Click(object sender, EventArgs e)
        {
            new FormQLLL().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            new FormQLNV().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void button_MonAn_Click(object sender, EventArgs e)
        {
            new FormQLMonAn().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            new Form_LapHoaDon().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            new ListBill().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void bt_statistical_Click(object sender, EventArgs e)
        {
            new ThongKe().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void App_Load(object sender, EventArgs e)
        {
            if (!Permission)
            {
                bt_statistical.Enabled = false;
                button_LichLam.Enabled = false;
                button_MonAn.Enabled = false;
                button_NhanVien.Enabled = false;
                btn_khuyenmai.Enabled = false;
                btn_kho.Enabled = false;
                btn_HoaDon.Enabled = false;
                btn_ban.Enabled = false;
            }
        }

        private void btn_ban_Click(object sender, EventArgs e)
        {
            new QLBan().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            new QLKhuyenMai().Show();
            WindowState = FormWindowState.Minimized;
        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            new QLKho().Show();
            WindowState = FormWindowState.Minimized;
        }
    }
}
