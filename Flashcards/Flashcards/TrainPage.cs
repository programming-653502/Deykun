using System;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class TrainPage : UserControl
    {
        public TrainPage()
        {
            InitializeComponent();
        }

        private void train2Btn_Click(object sender, EventArgs e)
        {
            matchWordsTrainPage.Visible = true;
            showTrainBtn.Visible = true;
            showTrainBtn.BringToFront();
            matchWordsTrainPage.showData();
        }

        private void showTrainBtn_Click(object sender, EventArgs e)
        {
            matchWordsTrainPage.Visible = false;
            keywordTrainPage.Visible = false;
            showTrainBtn.Visible = false;
        }

        private void train1Btn_Click(object sender, EventArgs e)
        {
            keywordTrainPage.Visible = true;
            showTrainBtn.Visible = true;
            showTrainBtn.BringToFront();
        }
    }
}
