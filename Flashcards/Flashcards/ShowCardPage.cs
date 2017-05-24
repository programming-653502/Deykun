using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flashcards
{
    public partial class ShowCardPage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;" +
          "port=3306;username=root;password=");

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        int cardIndex = 0;
        int countTable;
        string cardName;

        public ShowCardPage()
        {
            InitializeComponent();
        }

        private void ShowCardPage_Load(object sender, EventArgs e)
        {
            loadTable();
          
        }

        public void showData(int index)
        {
            //выводим карточки во все  BunifuTileButton в collectionTable

            MemoryStream ms;
            byte[] img;
            foreach (Control control in collectionTable.Controls)
            {              

                Bunifu.Framework.UI.BunifuTileButton button = control 
                    as Bunifu.Framework.UI.BunifuTileButton;

                if (button != null)
                {
                    if (countTable == 0)
                    {
                        button.Visible = true;
                        button.LabelText = "Время создать коллекцию!";
                    }
                    if (cardIndex >= countTable)
                    {
                        button.Visible = false;
                    }
                    else
                    {
                        img = (byte[])table.Rows[cardIndex][4];
                        ms = new MemoryStream(img);
                        button.Image = Image.FromStream(ms);
                        button.LabelText = table.Rows[cardIndex][2].ToString();
                        button.Visible = true;
                    }

                }

                cardIndex++;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (cardIndex >= countTable - 6)
                cardIndex = countTable - 6;

            showData(cardIndex);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            cardIndex -= 13;
            if (cardIndex < 0)
                cardIndex = 0;

            showData(cardIndex);
        }

        //событие, при которым мы отправляем значение cardName в другой UserControl
        public event EventHandler ButtonClick;

        public string cardClick
        {
            get { return this.cardName;  }
            set { this.cardName = value;  }
        }

       

        private void loadTable ()
        {
            //загружаем заданую коллекцию из таблицы 

            String selectQuery = "SELECT * FROM Flashcards." + UserInformation.username + 
                " WHERE collection = '" + cardName + "'";

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
            numCardLabel.Text = "Всего : " + System.Convert.ToString(countTable);
            cardIndex = 0;
            showData(cardIndex);
            connection.Close();
        }

        private void showCollectionBtn_Click(object sender, EventArgs e)
        {
            showCollectionPage.Visible = true;
            showCollectionBtn.Visible = false;
            loadTable();
        }

        private void showCollectionPage_collectionClick_1(object sender, EventArgs e)
        {
            cardName = showCollectionPage.collection;
            showCollectionPage.Visible = false;
            showCollectionBtn.Visible = true;
            loadTable();
        }

        private void collection1_Click(object sender, EventArgs e)
        {
            cardName = collection1.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        
        private void collection2_Click(object sender, EventArgs e)
        {
            cardName = collection2.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void collection3_Click(object sender, EventArgs e)
        {
            cardName = collection3.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void collection4_Click(object sender, EventArgs e)
        {
            cardName = collection4.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void collection5_Click(object sender, EventArgs e)
        {
            cardName = collection5.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void collection6_Click(object sender, EventArgs e)
        {
            cardName = collection6.LabelText;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
