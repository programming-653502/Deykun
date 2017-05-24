namespace Flashcards
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.profileButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.trainBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collectionsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuClick = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateCard = new Flashcards.UpdateCard();
            this.trainPage = new Flashcards.TrainPage();
            this.profilePage = new Flashcards.ProfilePage();
            this.progressPage = new Flashcards.ProgressPage();
            this.homePage = new Flashcards.HomePage();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.Controls.Add(this.profileButton);
            this.menuPanel.Controls.Add(this.trainBtn);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.progressButton);
            this.menuPanel.Controls.Add(this.collectionsButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.menuClick);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.menuPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.menuPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.menuPanel.GradientTopRight = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Quality = 10;
            this.menuPanel.Size = new System.Drawing.Size(267, 738);
            this.menuPanel.TabIndex = 3;
            // 
            // profileButton
            // 
            this.profileButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileButton.BorderRadius = 0;
            this.profileButton.ButtonText = "   Профиль";
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.Iconcolor = System.Drawing.Color.Transparent;
            this.profileButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("profileButton.Iconimage")));
            this.profileButton.Iconimage_right = null;
            this.profileButton.Iconimage_right_Selected = null;
            this.profileButton.Iconimage_Selected = null;
            this.profileButton.IconZoom = 50D;
            this.profileButton.IsTab = false;
            this.profileButton.Location = new System.Drawing.Point(0, 151);
            this.profileButton.Margin = new System.Windows.Forms.Padding(5);
            this.profileButton.Name = "profileButton";
            this.profileButton.Normalcolor = System.Drawing.Color.Transparent;
            this.profileButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.profileButton.OnHoverTextColor = System.Drawing.Color.White;
            this.profileButton.selected = false;
            this.profileButton.Size = new System.Drawing.Size(267, 59);
            this.profileButton.TabIndex = 9;
            this.profileButton.Textcolor = System.Drawing.Color.White;
            this.profileButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.trainBtn.BackColor = System.Drawing.Color.Transparent;
            this.trainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainBtn.BorderRadius = 0;
            this.trainBtn.ButtonText = "   Тренировки";
            this.trainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.trainBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("trainBtn.Iconimage")));
            this.trainBtn.Iconimage_right = null;
            this.trainBtn.Iconimage_right_Selected = null;
            this.trainBtn.Iconimage_Selected = null;
            this.trainBtn.IconZoom = 50D;
            this.trainBtn.IsTab = false;
            this.trainBtn.Location = new System.Drawing.Point(0, 289);
            this.trainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.trainBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.trainBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.trainBtn.selected = false;
            this.trainBtn.Size = new System.Drawing.Size(267, 59);
            this.trainBtn.TabIndex = 8;
            this.trainBtn.Textcolor = System.Drawing.Color.White;
            this.trainBtn.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.ButtonText = "   Выход";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitButton.Iconimage")));
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconZoom = 50D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(0, 427);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.exitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(267, 59);
            this.exitButton.TabIndex = 7;
            this.exitButton.Textcolor = System.Drawing.Color.White;
            this.exitButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // progressButton
            // 
            this.progressButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.progressButton.BackColor = System.Drawing.Color.Transparent;
            this.progressButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressButton.BorderRadius = 0;
            this.progressButton.ButtonText = "   Прогресс ";
            this.progressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressButton.Iconcolor = System.Drawing.Color.Transparent;
            this.progressButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("progressButton.Iconimage")));
            this.progressButton.Iconimage_right = null;
            this.progressButton.Iconimage_right_Selected = null;
            this.progressButton.Iconimage_Selected = null;
            this.progressButton.IconZoom = 50D;
            this.progressButton.IsTab = false;
            this.progressButton.Location = new System.Drawing.Point(0, 358);
            this.progressButton.Margin = new System.Windows.Forms.Padding(5);
            this.progressButton.Name = "progressButton";
            this.progressButton.Normalcolor = System.Drawing.Color.Transparent;
            this.progressButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.progressButton.OnHoverTextColor = System.Drawing.Color.White;
            this.progressButton.selected = false;
            this.progressButton.Size = new System.Drawing.Size(267, 59);
            this.progressButton.TabIndex = 4;
            this.progressButton.Textcolor = System.Drawing.Color.White;
            this.progressButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.progressButton.Click += new System.EventHandler(this.progressButton_Click);
            // 
            // collectionsButton
            // 
            this.collectionsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.collectionsButton.BackColor = System.Drawing.Color.Transparent;
            this.collectionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.collectionsButton.BorderRadius = 0;
            this.collectionsButton.ButtonText = "   Коллекции";
            this.collectionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectionsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.collectionsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("collectionsButton.Iconimage")));
            this.collectionsButton.Iconimage_right = null;
            this.collectionsButton.Iconimage_right_Selected = null;
            this.collectionsButton.Iconimage_Selected = null;
            this.collectionsButton.IconZoom = 50D;
            this.collectionsButton.IsTab = false;
            this.collectionsButton.Location = new System.Drawing.Point(0, 220);
            this.collectionsButton.Margin = new System.Windows.Forms.Padding(5);
            this.collectionsButton.Name = "collectionsButton";
            this.collectionsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.collectionsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.collectionsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.collectionsButton.selected = false;
            this.collectionsButton.Size = new System.Drawing.Size(267, 59);
            this.collectionsButton.TabIndex = 2;
            this.collectionsButton.Textcolor = System.Drawing.Color.White;
            this.collectionsButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.collectionsButton.Click += new System.EventHandler(this.collectionsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.BorderRadius = 0;
            this.homeButton.ButtonText = "   Главная ";
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.homeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("homeButton.Iconimage")));
            this.homeButton.Iconimage_right = null;
            this.homeButton.Iconimage_right_Selected = null;
            this.homeButton.Iconimage_Selected = null;
            this.homeButton.IconZoom = 50D;
            this.homeButton.IsTab = false;
            this.homeButton.Location = new System.Drawing.Point(0, 82);
            this.homeButton.Margin = new System.Windows.Forms.Padding(5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.homeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(267, 59);
            this.homeButton.TabIndex = 1;
            this.homeButton.Textcolor = System.Drawing.Color.White;
            this.homeButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // menuClick
            // 
            this.menuClick.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.menuClick.BackColor = System.Drawing.Color.Transparent;
            this.menuClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuClick.BorderRadius = 0;
            this.menuClick.ButtonText = "";
            this.menuClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuClick.Iconcolor = System.Drawing.Color.Transparent;
            this.menuClick.Iconimage = ((System.Drawing.Image)(resources.GetObject("menuClick.Iconimage")));
            this.menuClick.Iconimage_right = null;
            this.menuClick.Iconimage_right_Selected = null;
            this.menuClick.Iconimage_Selected = null;
            this.menuClick.IconZoom = 60D;
            this.menuClick.IsTab = false;
            this.menuClick.Location = new System.Drawing.Point(4, 14);
            this.menuClick.Margin = new System.Windows.Forms.Padding(5);
            this.menuClick.Name = "menuClick";
            this.menuClick.Normalcolor = System.Drawing.Color.Transparent;
            this.menuClick.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.menuClick.OnHoverTextColor = System.Drawing.Color.White;
            this.menuClick.selected = false;
            this.menuClick.Size = new System.Drawing.Size(47, 46);
            this.menuClick.TabIndex = 0;
            this.menuClick.Textcolor = System.Drawing.Color.White;
            this.menuClick.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClick.Click += new System.EventHandler(this.menuClick_Click);
            // 
            // updateCard
            // 
            this.updateCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateCard.Location = new System.Drawing.Point(267, 0);
            this.updateCard.Name = "updateCard";
            this.updateCard.Size = new System.Drawing.Size(933, 738);
            this.updateCard.TabIndex = 4;
            // 
            // trainPage
            // 
            this.trainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainPage.Location = new System.Drawing.Point(267, 0);
            this.trainPage.Name = "trainPage";
            this.trainPage.Size = new System.Drawing.Size(933, 738);
            this.trainPage.TabIndex = 5;
            // 
            // profilePage
            // 
            this.profilePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage.Location = new System.Drawing.Point(267, 0);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(933, 738);
            this.profilePage.TabIndex = 6;
            // 
            // progressPage
            // 
            this.progressPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPage.Location = new System.Drawing.Point(267, 0);
            this.progressPage.Name = "progressPage";
            this.progressPage.Size = new System.Drawing.Size(933, 738);
            this.progressPage.TabIndex = 7;
            // 
            // homePage
            // 
            this.homePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage.Location = new System.Drawing.Point(267, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(933, 738);
            this.homePage.TabIndex = 8;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.menuPanel;
            this.bunifuDragControl.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 738);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.progressPage);
            this.Controls.Add(this.profilePage);
            this.Controls.Add(this.trainPage);
            this.Controls.Add(this.updateCard);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuGradientPanel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton profileButton;
        private Bunifu.Framework.UI.BunifuFlatButton trainBtn;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        private Bunifu.Framework.UI.BunifuFlatButton progressButton;
        private Bunifu.Framework.UI.BunifuFlatButton collectionsButton;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
        private Bunifu.Framework.UI.BunifuFlatButton menuClick;
        private UpdateCard updateCard;
        private TrainPage trainPage;
        private ProfilePage profilePage;
        private ProgressPage progressPage;
        private HomePage homePage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
    }
}