using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class ProgressPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
          "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int cardIndex = 0; //индекс выводимой карточки
        int countTable; //количество записей в таблице
        int boxUp = 0; //количество карточек, поднявших свой box

        public ProgressPage()
        {
            InitializeComponent();
        }

        private void ProgressPage_Load(object sender, EventArgs e)
        {
            //делаем выборку сущетсвующих коллекций из таблицы

            String selectQuery = "SELECT DISTINCT collection FROM Flashcards." + UserInformation.username;

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
        }

        public void showData(int index)
        {
            //выводим карточку с заданым индексом на монитор

            MemoryStream ms;
            descriptionTextBox.Visible = false;
            cardNameTextBox.Visible = false;

            try
            {
                byte[] img = (byte[])table.Rows[index][4];
                ms = new MemoryStream(img);
                cardImage.Image = Image.FromStream(ms);
                cardNameTextBox.Text = System.Convert.ToString(table.Rows[index][2]);
                descriptionTextBox.Text = System.Convert.ToString(table.Rows[index][3]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cardImage_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Visible == false)
                descriptionTextBox.Visible = true;

            else if (descriptionTextBox.Visible == true)
                cardNameTextBox.Visible = true;
        }

        private void rememberBtn_Click(object sender, EventArgs e)
        {
            cardIndex++;
            boxUp++;

            if (cardIndex >= countTable)
            {
                showResults();
            }
            else
            {
                showData(cardIndex);
                int box = Convert.ToInt32(table.Rows[cardIndex][5]);

                if (box < 4)
                    box++;

                updateBoxInTable(box); //изменение box карточки
            }
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            cardIndex++;

            if (cardIndex >= countTable)
            {
                showResults();
            }
            else
            {
                showData(cardIndex);
                int box = Convert.ToInt32(table.Rows[cardIndex][5]);

                if (box > 1)
                    box--;

                updateBoxInTable(box); //изменение box карточки
            }
        }

        private void beginTestBtn_Click(object sender, EventArgs e)
        {
            //выбираем из таблицы записи, соответсвующие заданой коллекции

            String selectQuery = "SELECT * FROM Flashcards. " + UserInformation.username +
               " WHERE collection ='" + collectionCBox.Text + "'";

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

            collectionCBox.Visible = false;
            collectionLabel.Visible = false;
            beginTestBtn.Visible = false;
            cardImage.Visible = true;
            forgotBtn.Visible = true;
            rememberBtn.Visible = true;
            selectCollectionBtn.Visible = true;
            boxUp = 0;
            countTable = table.Rows.Count;
            showData(cardIndex);
        }

        private void selectCollectionBtn_Click(object sender, EventArgs e)
        {
            collectionCBox.Visible = true;
            collectionLabel.Visible = true;
            beginTestBtn.Visible = true;
            cardImage.Visible = false;
            forgotBtn.Visible = false;
            rememberBtn.Visible = false;
            selectCollectionBtn.Visible = false;
            resultTextBox.Visible = false;
            cardIndex = 0;
        }

        void showResults()
        {
            String result = "Тест успешно пройден! По его результатам вы выучили " +
                boxUp.ToString() + " слов(a). Для повторного прохождения теста нажмите" +
                " кнопку назад.";

            cardImage.Visible = false;
            forgotBtn.Visible = false;
            rememberBtn.Visible = false;
            resultTextBox.Visible = true;
            cardNameTextBox.Visible = false;
            descriptionTextBox.Visible = false;
            resultTextBox.Text = result;
        }

        void updateBoxInTable(int box)
        {
            //изменяем box карточки в таблице

            String updateQuery = "UPDATE Flashcards." + UserInformation.username +
                " SET  box = '" + box.ToString() +
               "' WHERE keyword = '" + table.Rows[cardIndex - 1][2].ToString() + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                command.ExecuteNonQuery();            
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

        private void showProgressBtn_Click(object sender, EventArgs e)
        {
            if (boxProgressPage.Visible == false)
                boxProgressPage.Visible = true;
            else boxProgressPage.Visible = false;

            showProgressBtn.BringToFront();
        }
    }
}
