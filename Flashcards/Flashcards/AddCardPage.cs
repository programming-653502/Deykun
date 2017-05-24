using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class AddCardPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
                   "port=3306;Initial Catalog='Flashcards';username=root;password=");

        public AddCardPage()
        {
            InitializeComponent();
        }

        private void AddCardPage_Load(object sender, EventArgs e)
        {
            //загружаем в компонент collectionCBox коллекции, выбранные из таблицы
            
            String selectQuery = "SELECT  DISTINCT  collection FROM Flashcards." + 
                UserInformation.username;
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.Close();

            int collectionIndex = 0;

            foreach (DataRow row in table.Rows)
            {
                collectionCBox.Items.Add(table.Rows[collectionIndex][0].ToString());
                collectionIndex++;
            }

            errorLabel.Visible = false;
        }

        private void cardImage_Click(object sender, EventArgs e)
        { 
            // открытие FileDialog при нажатии на cardImage для выбора картинки

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif|*.jpg; *.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                cardImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void addCardBtn_Click(object sender, EventArgs e)
        {
            //запрос на добавление карточки с задаными параметрами в таблицу

            String insetQuery = "INSERT INTO Flashcards." + UserInformation.username + 
                "(collection, keyword, description,image,box) VALUES('" + collectionCBox.Text + "','"
                 + cardNameTextBox.Text + "', '" + desciptionTextBox.Text + "', @image,1)";
           
            if (!string.IsNullOrEmpty(cardNameTextBox.Text) && 
                !string.IsNullOrWhiteSpace(cardNameTextBox.Text) &&
                cardImage.Image != null)
            {
                MySqlCommand command;
                MemoryStream ms = new MemoryStream();
                cardImage.Image.Save(ms, cardImage.Image.RawFormat);
                byte[] img = ms.ToArray();

                connection.Open();
                command = new MySqlCommand(insetQuery, connection);
                command.Parameters.Add("@image", MySqlDbType.Blob);
                command.Parameters["@image"].Value = img;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Карточка добавлена!");
                }

                connection.Close();

                cardImage.Image = null;
                cardImage.Invalidate();
                desciptionTextBox.Text = "";
                cardNameTextBox.Text = "";
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
