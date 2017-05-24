using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class MatchWordsTrainPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
           "port=3306;username=root;password=");

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int countTable;

        Bunifu.Framework.UI.BunifuTileButton firstClicked = null;
        Bunifu.Framework.UI.BunifuTileButton secondClicked = null;

        public MatchWordsTrainPage()
        {
            InitializeComponent();
        }

        private void MatchWordsTrainPage_Load(object sender, EventArgs e)
        {
            //выбираем коллекции из табоицы 

            String selectQuery = "SELECT DISTINCT collection FROM Flashcards." +
              UserInformation.username;

            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

            int index = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                collectionCBox.Items.Add(dataTable.Rows[index][0].ToString());
                index++;
            }

            beginCardBtn.Visible = true;
        }

        public void showData()
        {
            //формируем массив из случайных эменетов в таблице 

            MemoryStream ms;
            Random rand = new Random();
            int[] randomCard = new int[9];
            for (int i = 0; i < 9; i++)
            {
                randomCard[i] = rand.Next(0, countTable);
            }

            int index = 0;

            //выводим карточки пока в imageTable есть элементы BunifuTileButton

            foreach (Control control in imagesTable.Controls)
            {
                Bunifu.Framework.UI.BunifuTileButton cardImage = control as Bunifu.Framework.UI.BunifuTileButton;

                if (cardImage != null)
                {
                    byte[] img = (byte[])table.Rows[randomCard[index]][4];
                    ms = new MemoryStream(img);
                    cardImage.Image = Image.FromStream(ms);
                    cardImage.LabelText = table.Rows[randomCard[index]][2].ToString();
                    cardImage.ForeColor = Color.White;
                    cardImage.Visible = true;
                }
                index++;
            }

            index = 0;

            //выводим карточки пока в keywordTable есть элементы BunifuTileButton

            foreach (Control control in keywordsTable.Controls)
            {
                Bunifu.Framework.UI.BunifuTileButton cardImage = control as Bunifu.Framework.UI.BunifuTileButton;

                if (cardImage != null)
                {
                    cardImage.LabelText = table.Rows[randomCard[index]][2].ToString();
                    cardImage.Visible = true;
                    cardImage.ForeColor = Color.White;
                }
                index++;
            }

            index = 0;
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
                return;

            Bunifu.Framework.UI.BunifuTileButton clickedCard = sender as Bunifu.Framework.UI.BunifuTileButton;

            //меняем параметры выделенной карточки

            if (clickedCard != null)
            {
                if (clickedCard.ForeColor == Color.Red)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedCard;
                    firstClicked.ForeColor = Color.Red;
                    return;
                }

                secondClicked = clickedCard;
                secondClicked.BackColor = Color.Red;
                
                //сравниваем текст выделеных карточек
                
                if (firstClicked.LabelText == secondClicked.LabelText)
                {

                    firstClicked.Visible = false;
                    secondClicked.Visible = false;
                    firstClicked = null;
                    secondClicked = null;
                    CheckForWinner();
                    return;
                }
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.ForeColor = Color.White;
            secondClicked.ForeColor = Color.White;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            //при совпадении Visible = false;
            //если у всех элементов Visible = false, то конец

            foreach (Control control in keywordsTable.Controls)
            {
                Bunifu.Framework.UI.BunifuTileButton clickedCard = control as Bunifu.Framework.UI.BunifuTileButton;

                if (clickedCard != null)
                {
                    if (clickedCard.Visible == true)
                        return;
                }
            }
            
            collectionCBox.Visible = true;
            beginCardBtn.Visible = true;
            collectionLabel.Visible = true;
        }

        private void beginCardBtn_Click(object sender, EventArgs e)
        {
            //загрузка карточек из выбранной коллекции 

            string collection = collectionCBox.SelectedText;
            String selectQuery = "SELECT * FROM Flashcards." + UserInformation.username +
                " WHERE collection = '" + collection + "'";
            collectionCBox.Visible = false;
            beginCardBtn.Visible = false;
            collectionLabel.Visible = false;


            adapter = new MySqlDataAdapter(selectQuery, connection);
            table = new DataTable();
            adapter.Fill(table);
            countTable = table.Rows.Count;

            if (countTable == 0)
            {
                MessageBox.Show("Тут еще ничего нет:(");
            }
            else 
                showData();

            connection.Close();
        }
    }
}
