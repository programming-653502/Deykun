using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flashcards
{
    public partial class LoginForm : Form
    {
        static String connectionString = "datasource=localhost;" +
            "port=3306;Initial Catalog='Flashcards';username=root;password=";

        MySqlConnection connection = new MySqlConnection(connectionString);

        public LoginForm()
        {
            InitializeComponent();
        }        

        private void enterDataButton_Click(object sender, EventArgs e)
        {
            //регистрация нового пользователя, создание таблицы для хранения коллекций

            UserInformation.username = usernameTextBox.Text;
            String tableCreateQuery = "CREATE TABLE " + UserInformation.username +
               " (ID int(5) AUTO_INCREMENT, collection varchar(40), keyword varchar(40) NOT NULL, " +
               "description text(40), image longblob NOT NULL, box int(5) NOT NULL, " +
               "PRIMARY KEY (ID));";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(tableCreateQuery, connection);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            //вставка записи о новом пользователе  в таблицу пользователей

            string insertQuery = "INSERT INTO Flashcards.users(username,password,mail) VALUES('"
                + usernameTextBox.Text + "','" + passwordTextBox.Text + "','" + mailTextBox.Text + "')";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы зарегистрированы!");
                    this.Hide();
                    MainForm fm = new MainForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //проверка логина и пароля в базе данных

            string selectQuery = "SELECT * FROM users WHERE username='"
                + usernameTextBox.Text + "' AND password='" + passwordTextBox.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                UserInformation.username = usernameTextBox.Text;
                MainForm fm = new MainForm();
                this.Hide();
                fm.Show();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте правильность логина и пароля!");
            }

            table.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == false)
                passwordTextBox.UseSystemPasswordChar = true;
            else
                passwordTextBox.UseSystemPasswordChar = false;
        }


        private void registrationButton_Click(object sender, EventArgs e)
        {
            mailTextBox.Visible = true;
            mailLabel.Visible = true;
            enterDataButton.Visible = true;
            enterDataButton.BringToFront();
        }
    }
}
