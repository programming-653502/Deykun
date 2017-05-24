using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flashcards
{
    public partial class ProfilePage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
            "port=3306;Initial Catalog='Flashcards';username=root;password=");

        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            // выбираем из таблицы запись о пользователе и выводим на монитор

            String selectQuery = "SELECT * FROM users WHERE username ='"+ UserInformation.username + "'";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                loginTextBox.Text = table.Rows[0][1].ToString();
                passwordTextBox.Text = table.Rows[0][2].ToString();
                mailTextBox.Text = table.Rows[0][3].ToString();
            }

            connection.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //выполняем запрос на изменение данных пользователя в таблице 

            String updateQuery = "UPDATE users SET  password = '" + passwordTextBox.Text +
               "', mail = '" + mailTextBox.Text +
              "' WHERE username = '" + UserInformation.username + "'";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ваши данные успешно изменены!");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка!");
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
    }
}
