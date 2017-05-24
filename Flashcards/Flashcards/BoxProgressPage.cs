using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flashcards
{
    public partial class BoxProgressPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
           "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public BoxProgressPage()
        {
            InitializeComponent();
        }

        private void BoxProgressPage_Load(object sender, EventArgs e)
        {
            // загружаем коллекции из таблицы в collectionCBox

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

            collectionCBox.SelectedItem = 0;
        }

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            if (collectionCBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите коллекцию");
            }
            else
            {
                showProgress();
            }
        }

        void showProgress()
        {
            //производим просчет количества карточек заданой коллекции в каждом box

            string collection = collectionCBox.SelectedItem.ToString();
            String selectQuery = "SELECT * FROM Flashcards." + UserInformation.username +
                " WHERE collection ='" + collection + "'";

            adapter = new MySqlDataAdapter(selectQuery, connection);
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            connection.Close();

            int[] box = new int[5];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int boxInTable = Convert.ToInt32(table.Rows[i][5]);
                box[boxInTable - 1]++;
            }

            collectionLab.Text = "Коллекция : " + collection;
            numCollectionLabel.Text = "Всего : " + table.Rows.Count;
            countBox1.Text = box[0].ToString();
            countBox2.Text = box[1].ToString();
            countBox3.Text = box[2].ToString();
            countBox4.Text = box[3].ToString();
            countBox5.Text = box[4].ToString();
        }
    }
}
