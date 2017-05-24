using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class UpdateCard : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
           "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        string cardName;

        public UpdateCard()
        {
            InitializeComponent();
        }

        private void showCardPage_ButtonClick(object sender, EventArgs e)
        {
            cardName = showCardPage.cardClick;
            showCardPage.Visible = false;
            showCollectionBtn.Visible = true;

            showCard();
        }

        private void showCard ()
        {
            //выбираем из таблицы информацию о карточке и выводим

            String selectQuery = "SELECT * FROM Flashcards." + UserInformation.username + 
                " WHERE keyword = '" + cardName + "'";

            command = new MySqlCommand(selectQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();

            try
            {
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            byte[] img = (byte[])table.Rows[0][4];
            MemoryStream ms = new MemoryStream(img);
            cardImage.Image = Image.FromStream(ms);

            cardNameTextBox.Text = table.Rows[0][2].ToString();
            desciptionTextBox.Text = table.Rows[0][3].ToString();
            collectionTextBox.Text = table.Rows[0][1].ToString();
        }

        private void showCollectionBtn_Click(object sender, EventArgs e)
        {
            showCardPage.Visible = true;
            showCollectionBtn.Visible = false;
            showCard();
        }

        private void showCardPage_ButtonClick_1(object sender, EventArgs e)
        {
            showCardPage.Visible = false;
            showCollectionBtn.Visible = true;
            cardName = showCardPage.cardClick;
            showCard();
        }

        private void cardImage_Click(object sender, EventArgs e)
        {
            //открываем FileDialog для загрузки изображения в PictureBox

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif|*.jpg; *.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                cardImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void updateCardBtn_Click(object sender, EventArgs e)
        {
            //изменяем в таблице информацию о карточке с заданными параметрами

            String updateQuery = "UPDATE Flashcards." + UserInformation.username + 
                " SET  collection = '" + collectionTextBox.Text + "', keyword = '" + 
                cardNameTextBox.Text + "', description = '" + desciptionTextBox.Text +
               "' WHERE keyword = '" + cardName + "'";           

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                command.ExecuteNonQuery();
                cardName = cardNameTextBox.Text;
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
