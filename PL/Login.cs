using Eldokkan.pl;

namespace PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void tb_username_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
        }



        private void tb_username_mouseleave(object sender, EventArgs e)
        {
            if (tb_username.Text == string.Empty)
                tb_username.DefaultText = "User Name";
        }

        private void tb_password_MouseLeave(object sender, EventArgs e)
        {
            if (tb_password.Text == string.Empty)
                tb_password.DefaultText = "Password";
        }

        private void tb_password_MouseHover(object sender, EventArgs e)
        {
            tb_password.Clear();

        }

        private void btnSign_Click_1(object sender, EventArgs e)
        {
            var user = tb_username.Text;
            var pass = tb_password.Text;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            using (SignUp sign = new SignUp())
            {
                sign.ShowDialog();

                this.Hide();
            }
        }
    }
}
