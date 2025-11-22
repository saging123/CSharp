namespace DbForm.Modules.Register
{
    partial class RegisterForm
    {
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label LblUsername;
        private Label LblPassword;

        private Button BtnRegister;

        public void DrawForm()
        {
            // INITIALIZE

            this.LblUsername = new Label();
            this.LblPassword = new Label();
            this.TxtUsername = new TextBox();
            this.TxtPassword = new TextBox();
            this.BtnRegister = new Button();

            // TEXT
            this.LblUsername.Text = "Username: ";
            this.LblPassword.Text = "Password: ";
            this.BtnRegister.Text = "Register";

            // ALIGNMENT / POSITION
            this.LblUsername.Location   = new Point(50,10);
            this.TxtUsername.Location   = new Point(50,30);
            this.TxtUsername.Size       = new Size(200,20);

            this.LblPassword.Location   = new Point(50,60);
            this.TxtPassword.Location   = new Point(50,80);
            this.TxtPassword.Size       = new Size(200,20);

            this.BtnRegister.Location = new Point(120,130);
            this.BtnRegister.Size = new Size(60,30);

            // CUSTOMIZATION
            this.TxtPassword.PasswordChar   = '*';
            this.Text                       = "Registration Form";

            // EVENTS
            this.BtnRegister.Click += click_register;

            // Draw Window
            this.ClientSize = new Size(300,170);

            // disabled maximize;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Start Adding Components to the FORM
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtUsername);

            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtPassword);

            this.Controls.Add(this.BtnRegister);
            
        }
    }
}