using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flashcards
{
    public partial class ShowCollectionPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
           "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int collectionIndex = 0;
        int countTable;
        string collectionName;

        public ShowCollectionPage()
        {
            InitializeComponent();
        }

        private void ShowCollectionPage_Load(object sender, EventArgs e)
        {
            //загружаем список коллекций из таблицы 

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


            countTable = table.Rows.Count;
            numCollectionsLabel.Text = "Всего : " + System.Convert.ToString(countTable);

            showData(collectionIndex);
            connection.Close();
        }

        public void showData(int index)
        {
            //выводим в collectionTable коллекции
            //пока в таблице есть  компоненты  BunifuTileButton
            
            foreach (Control control in collectionTable.Controls)
            {
                Bunifu.Framework.UI.BunifuTileButton button = control as 
                    Bunifu.Framework.UI.BunifuTileButton;

                if (button != null)
                {
                    if (countTable == 0)
                    {
                        button.Visible = true;
                        button.LabelText = "Время создать коллекцию!";
                    }
                    if (collectionIndex >= countTable)
                    {
                        button.Visible = false;
                    }
                    else
                    {
                        button.LabelText = table.Rows[collectionIndex][0].ToString();
                        button.Text = table.Rows[collectionIndex][0].ToString();
                        button.Visible = true;
                    }

                }

                collectionIndex++;
            }
        }

        public event EventHandler collectionClick;

        //передаем collectionName в другой UserControl

        public string collection
        {
            get { return this.collectionName; }
            set { this.collectionName = value; }
        }

        private void collection1_Click(object sender, EventArgs e)
        {
            collectionName =  collection1.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);       

        }

        private void collection2_Click(object sender, EventArgs e)
        {
            collectionName = collection2.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);
        }

        private void collection3_Click(object sender, EventArgs e)
        {
            collectionName = collection3.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);
        }

        private void collection4_Click(object sender, EventArgs e)
        {
            collectionName = collection4.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);
        }

        private void collection5_Click(object sender, EventArgs e)
        {
            collectionName = collection5.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);
        }

        private void collection6_Click(object sender, EventArgs e)
        {
            collectionName = collection6.LabelText;
            if (this.collectionClick != null)
                this.collectionClick(this, e);

        }

        private void addCollectionBtn_Click(object sender, EventArgs e)
        {
            addCardPage.Visible = true;
            showCollectionBtn.Visible = true;
            showCollectionBtn.BringToFront();

        }

        private void showCollectionBtn_Click(object sender, EventArgs e)
        {
            addCardPage.Visible = false;
            showCollectionBtn.Visible = false;
        }
    }
}
