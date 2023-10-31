using Form1.Connect_DB.Services;

namespace Form1
{
    public partial class LoginUI : Form
    {
        AccountService accountService { get; set; }
        public LoginUI()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void txt_userName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_userName.Text = "";
        }

        private void txt_passWord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_passWord.Text = "";
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userName.Text) || string.IsNullOrEmpty(txt_passWord.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool ResultLog = accountService.IsExisted(txt_userName.Text, txt_passWord.Text);
            bool Permission = accountService.Decentralization(txt_userName.Text);

            if (ResultLog)
            {
                MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new App(Permission).Show();
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản vừa nhập chưa chính xác!", "Vui lòng xem lại thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userName.Focus();
            }
        }
    }
}
