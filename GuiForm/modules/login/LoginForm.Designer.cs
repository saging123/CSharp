using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GuiForm.Modules.Login
{
    partial class LoginForm
    {
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPass;

        private CheckBox chkShowPass;

        private void InitializeComponent()
        {
            // start Drawing the canvas
            txtPass = new TextBox();
            txtUser = new TextBox();
            lblPass = new Label();
            lblUser = new Label();
            btnLogin = new Button();
            chkShowPass = new CheckBox();


            // Label User
            lblUser.Text = "Username";
            lblUser.Location = new Point(20, 20);
            lblUser.Size = new Size(80, 20);

            // txt User
            txtUser.Location = new Point(20, 40);
            txtUser.Size = new Size(200, 20);


            // Label Password
            lblPass.Text = "Password";
            lblPass.Location = new Point(20, 70);


            // txt password
            txtPass.Location = new Point(20, 90);
            txtPass.Size = new Size(200, 40);
            txtPass.PasswordChar = '*';

            // chkk Show Pass
            chkShowPass.Location = new Point(235, 90);
            chkShowPass.Size = new Size(20, 20);
            chkShowPass.CheckedChanged += ShowPass;

            // Button
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(100, 125);
            btnLogin.Size = new Size(90, 30);
            // add login event
            btnLogin.Click += StartLogin;



            this.ClientSize = new Size(300, 160);

            // Disabled Resize
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Disabled Maximize
            this.MaximizeBox = false;

            this.Text = "Login Form";
            this.Controls.Add(lblUser);
            this.Controls.Add(txtUser);
            this.Controls.Add(lblPass);
            this.Controls.Add(txtPass);
            this.Controls.Add(chkShowPass);
            this.Controls.Add(btnLogin);

        }





    }





}