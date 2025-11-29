

namespace DbForm.Modules.Login
{
    partial class LoginForm
    {
        private Label LblUsername;
        private Label LblPassword;

        private TextBox TxtUsername;
        private TextBox TxtPassword;

        private Button BtnLogin;
        private Button BtnRegister;

        
        public void DrawForm()
        {
            // Object Initialization
            this.LblPassword = new Label();
            this.LblUsername = new Label();
            this.TxtPassword = new TextBox();
            this.TxtUsername = new TextBox();
            this.BtnLogin = new Button();
            this.BtnRegister = new Button();

            // TEXT
            this.LblUsername.Text = "Enter Username";
            this.LblPassword.Text = "Enter Password";
            this.BtnLogin.Text    = "Login";
            this.BtnRegister.Text = "Register";

            this.Text             = "Login Form";

            // Position 
            this.LblUsername.Location       = new Point(50,10);
            this.TxtUsername.Location       = new Point(50,30);
            this.TxtUsername.Size           = new Size(200,20);

            this.LblPassword.Location       = new Point(50,60);
            this.TxtPassword.Location       = new Point(50,80);
            this.TxtPassword.Size           = new Size(200,20);


            this.BtnLogin.Location          = new Point(120,130);
            this.BtnLogin.Size              = new Size(60,30);
            this.BtnRegister.Location       = new Point(120,160);
            this.BtnRegister.Size           = new Size(60,30);

            // Special Text
            this.TxtPassword.PasswordChar   = '*';

            //events
            this.BtnLogin.Click += click_login;
            this.BtnRegister.Click  += click_register;


            // Draw Window
            this.ClientSize = new Size(300,200);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;


            // Adding
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegister);




        }
    }
}