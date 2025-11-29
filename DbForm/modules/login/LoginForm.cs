using DbForm.Modules.Register;
using MySql.Data.MySqlClient;// <--  Add this line

namespace DbForm.Modules.Login
{
    
    public partial class LoginForm : Form
    {
         private string ConnectionString = "Server=localhost;Database=csharpprogram;User ID=root;Password=;";
        public LoginForm()
        {
            this.DrawForm();
        }

        public void click_login(object s, EventArgs args)
        {
            string Username = this.TxtUsername.Text.Trim();
            string Password = this.TxtPassword.Text.Trim();
            if(Username.Length < 5)
            {
                MessageBox.Show("Username must be 5 or more characters");
            }
            else if (Password.Length < 8)
            {
                 MessageBox.Show("Password must be 8 or more characters");
            }
            else
            {
                string msg = "Invalid Username or Password";
                bool isValidLogin = this.isValidLogin(Username,Password);
                // Perform Login
                if (isValidLogin)
                {
                    msg = "Welcome " + Username;
                }
                 MessageBox.Show(msg);
            }
        }

        public void click_register(object s, EventArgs args)
        {
            this.Hide();
            using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog();
            }
            this.Show();
        
        }

        public bool isValidLogin(string username, string password)
        {
            using MySqlConnection connection = new MySqlConnection(this.ConnectionString);
            string query = "SELECT * FROM `users` WHERE username = @user AND password = @pwd;";
            using MySqlCommand cmd = new MySqlCommand(query,connection);

            cmd.Parameters.AddWithValue("@user",username);
            cmd.Parameters.AddWithValue("@pwd",password);
            connection.Open();

            using MySqlDataReader reader = cmd.ExecuteReader();
            bool isValid = reader.Read();
            return isValid;
        }

    }
}