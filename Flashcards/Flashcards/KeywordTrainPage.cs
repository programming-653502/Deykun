using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class KeywordTrainPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
           "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int cardIndex = 0;
        int countTable;

        public KeywordTrainPage()
        {
            InitializeComponent();
        }

        private void KeywordTrainPage_Load(object sender, EventArgs e)
        {
            //загружаем коллекции из таблицы

            String selectQuery = "SELECT DISTINCT collection FROM Flashcards." + 
                UserInformation.username;

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

            connection.Close();

            int index = 0;
            foreach (DataRow row in table.Rows)
            {
                collectionCBox.Items.Add(table.Rows[index][0].ToString());
                index++;
            }

            boxCBox.Items.Add("Все");
            boxCBox.Items.Add("Box 1 : каждый день");
            boxCBox.Items.Add("Box 2 : раз в 2-3 дня");
            boxCBox.Items.Add("Box 3 : раз в неделю");
            boxCBox.Items.Add("Box 4 : раз в месяц");
        }

        public void showData(int index)
        {
            //выводим карточку на экран
                        
            try
            {
                byte[] img = (byte[])table.Rows[index][4];
                MemoryStream ms = new MemoryStream(img);
                cardImage.Image = Image.FromStream(ms);
                keywordHint.Text = System.Convert.ToString(table.Rows[index][2]);
                descriptionHint.Text = System.Convert.ToString(table.Rows[index][3]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void nextCardBtn_Click(object sender, EventArgs e)
        {
            cardIndex++;
            descriptionHint.Visible = false;
            keywordHint.Visible = false;

            if (cardIndex >= countTable)
            {
                string message = "Отлично! Тренировка закончена! ";
                keywordTextBox.Text = "";
                errorLabel.Visible = false;
                TextBox.Text = message;
                collectionCBox.Visible = false;
                beginTestBtn.Visible = false;
                collectionLabel.Visible = false;
                cardImage.Visible = false;
                nextCardBtn.Visible = false;
                keywordTextBox.Visible = false;

                TextBox.Visible = true;
                tryAgainBtn.Visible = true;
            }
            else
            {
                if (keywordTextBox.Text == keywordHint.Text)
                {
                    errorLabel.Visible = false;
                    keywordTextBox.Text = null;
                    showData(cardIndex);
                }
                else errorLabel.Visible = true;

            }
        }

        private void hintBtn_Click(object sender, EventArgs e)
        {
            if (descriptionHint.Visible == false)
                descriptionHint.Visible = true;
            else
                keywordHint.Visible = true;
        }

        private void beginTestBtn_Click(object sender, EventArgs e)
        {
            //делаем выборку карточек с задаными box и коллекцией

            int box = boxCBox.SelectedIndex;
            String selectQuery;
            if (box == 0)
            {
                selectQuery = "SELECT * FROM Flashcards." + UserInformation.username +
               " WHERE collection ='" + collectionCBox.Text + "'";
            }
            else
            {
                selectQuery = "SELECT * FROM Flashcards." + UserInformation.username +
               " WHERE collection ='" + collectionCBox.Text + "' AND box = '" + box.ToString() + "'";
            }

            command = new MySqlCommand(selectQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table.Clear();

            try
            {
                adapter.Fill(table);
            }
            finally
            {
                connection.Close();
            }

            countTable = table.Rows.Count;
            if (countTable == 0)
            {
                MessageBox.Show("Тут ничего нет :( ");
            }
            else
            {
                showData(cardIndex);

                collectionCBox.Visible = false;
                beginTestBtn.Visible = false;
                collectionLabel.Visible = false;
                boxCBox.Visible = false;
                boxLabel.Visible = false;
                cardImage.Visible = true;
                nextCardBtn.Visible = true;
                keywordTextBox.Visible = true;
            }
        }

        private void selectCollectionBtn_Click(object sender, EventArgs e)
        {
            collectionCBox.Visible = true;
            beginTestBtn.Visible = true;
            collectionLabel.Visible = true;
            cardImage.Visible = false;
            nextCardBtn.Visible = false;
        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            collectionLabel.Visible = true;
            collectionCBox.Visible = true;
            beginTestBtn.Visible = true;
            boxCBox.Visible = true;
            boxLabel.Visible = true;
            cardImage.Visible = false;
            nextCardBtn.Visible = false;
            keywordTextBox.Visible = false;
            tryAgainBtn.Visible = false;
            TextBox.Visible = false;
            cardIndex = 0;
        }
    }
}
