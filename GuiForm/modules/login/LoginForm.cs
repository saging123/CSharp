
using System.Windows.Forms;

namespace GuiForm.Modules.Login
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void StartLogin(object? sender, EventArgs args)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            bool isValidAccount = username == "Kim" && password == "absent";
            string msg = isValidAccount ? "Welcome !" : "You are not him and you never will!";
            MessageBox.Show(msg);
        }
        private void ShowPass(object? sender, EventArgs args)
        {
            bool isChecked = chkShowPass.Checked;
            txtPass.PasswordChar = isChecked ? '\0' : '*';
         }
        
    }
}