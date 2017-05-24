using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void collectionsButton_Click(object sender, EventArgs e)
        {
            updateCard.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            trainPage.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profilePage.BringToFront();
        }

        private void progressButton_Click(object sender, EventArgs e)
        {
            progressPage.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePage.BringToFront();
        }

        private void menuClick_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 50)
            {
                menuPanel.Width = 200;
            }
            else
            {
                menuPanel.Width = 50;
            }
        }
    }
}
