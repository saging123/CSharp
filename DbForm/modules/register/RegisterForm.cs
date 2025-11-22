using System.Windows.Forms;
using MySql.Data.MySqlClient;// <--  Add this line

namespace DbForm.Modules.Register
{
    public partial class RegisterForm:Form
    {

        private string ConnectionString = "Server=localhost;Database=csharpprogram;User ID=root;Password=;";
        public RegisterForm()
        {
            DrawForm();
        }
        public void click_register(object sender, EventArgs e)
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
                bool isInserted = this.Register(Username,Password);
                String msg = "Failed to Register";

                if (isInserted)
                {
                    msg = "You are now registered";
                    // RESET FIELDS
                    this.TxtPassword.Text = "";
                    this.TxtUsername.Text = "";
                }
                 MessageBox.Show(msg);
            }
        }

        public bool Register(string uname, string password)
        {
            using MySqlConnection connection = new MySqlConnection(this.ConnectionString);
            string InsertQuery = "INSERT INTO users (username,password) VALUES (@user,@pwd)";
            using MySqlCommand cmd = new MySqlCommand(InsertQuery,connection);
            
            cmd.Parameters.AddWithValue("@user", uname);
            cmd.Parameters.AddWithValue("@pwd", password);
            
            connection.Open();
            bool isSuccess = cmd.ExecuteNonQuery() > 0;
            return isSuccess;
        }

    }
}