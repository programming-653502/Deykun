namespace Flashcards
{
    partial class UpdateCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCard));
            this.collectionLabel = new System.Windows.Forms.Label();
            this.updateCardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.desciptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.showCollectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.showCardPage = new Flashcards.ShowCardPage();
            this.collectionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.collectionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collectionLabel.Location = new System.Drawing.Point(108, 107);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(179, 33);
            this.collectionLabel.TabIndex = 68;
            this.collectionLabel.Text = " Коллекция :";
            // 
            // updateCardBtn
            // 
            this.updateCardBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.updateCardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateCardBtn.BorderRadius = 0;
            this.updateCardBtn.ButtonText = "    Изменить";
            this.updateCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateCardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateCardBtn.Iconimage")));
            this.updateCardBtn.Iconimage_right = null;
            this.updateCardBtn.Iconimage_right_Selected = null;
            this.updateCardBtn.Iconimage_Selected = null;
            this.updateCardBtn.IconZoom = 45D;
            this.updateCardBtn.IsTab = false;
            this.updateCardBtn.Location = new System.Drawing.Point(673, 619);
            this.updateCardBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateCardBtn.Name = "updateCardBtn";
            this.updateCardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateCardBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.updateCardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateCardBtn.selected = false;
            this.updateCardBtn.Size = new System.Drawing.Size(189, 55);
            this.updateCardBtn.TabIndex = 66;
            this.updateCardBtn.Textcolor = System.Drawing.Color.White;
            this.updateCardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCardBtn.Click += new System.EventHandler(this.updateCardBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(615, 115);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(166, 20);
            this.errorLabel.TabIndex = 65;
            this.errorLabel.Text = "* Обязательное поле";
            this.errorLabel.Visible = false;
            // 
            // cardImage
            // 
            this.cardImage.BackColor = System.Drawing.SystemColors.Control;
            this.cardImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardImage.BackgroundImage")));
            this.cardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardImage.Location = new System.Drawing.Point(114, 215);
            this.cardImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(267, 246);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImage.TabIndex = 64;
            this.cardImage.TabStop = false;
            this.cardImage.Click += new System.EventHandler(this.cardImage_Click);
            // 
            // desciptionTextBox
            // 
            this.desciptionTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desciptionTextBox.Location = new System.Drawing.Point(461, 261);
            this.desciptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desciptionTextBox.Multiline = true;
            this.desciptionTextBox.Name = "desciptionTextBox";
            this.desciptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.desciptionTextBox.Size = new System.Drawing.Size(391, 186);
            this.desciptionTextBox.TabIndex = 63;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descriptionLabel.Location = new System.Drawing.Point(454, 215);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(157, 33);
            this.descriptionLabel.TabIndex = 61;
            this.descriptionLabel.Text = "Описание";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.AllowDrop = true;
            this.cardNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNameTextBox.Location = new System.Drawing.Point(461, 156);
            this.cardNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.cardNameTextBox.MaxLength = 50;
            this.cardNameTextBox.Multiline = true;
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(391, 36);
            this.cardNameTextBox.TabIndex = 62;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLabel.Location = new System.Drawing.Point(454, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 33);
            this.nameLabel.TabIndex = 60;
            this.nameLabel.Text = "Название";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(116, 33);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(428, 52);
            this.logoLabel.TabIndex = 59;
            this.logoLabel.Text = "Изменить карточку";
            // 
            // showCollectionBtn
            // 
            this.showCollectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.showCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("showCollectionBtn.Image")));
            this.showCollectionBtn.ImageActive = null;
            this.showCollectionBtn.Location = new System.Drawing.Point(24, 33);
            this.showCollectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showCollectionBtn.Name = "showCollectionBtn";
            this.showCollectionBtn.Size = new System.Drawing.Size(67, 62);
            this.showCollectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showCollectionBtn.TabIndex = 70;
            this.showCollectionBtn.TabStop = false;
            this.showCollectionBtn.Visible = false;
            this.showCollectionBtn.Zoom = 10;
            this.showCollectionBtn.Click += new System.EventHandler(this.showCollectionBtn_Click);
            // 
            // showCardPage
            // 
            this.showCardPage.cardClick = "Tile 1";
            this.showCardPage.Location = new System.Drawing.Point(0, 0);
            this.showCardPage.Name = "showCardPage";
            this.showCardPage.Size = new System.Drawing.Size(933, 738);
            this.showCardPage.TabIndex = 71;
            this.showCardPage.ButtonClick += new System.EventHandler(this.showCardPage_ButtonClick_1);
            // 
            // collectionTextBox
            // 
            this.collectionTextBox.AllowDrop = true;
            this.collectionTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collectionTextBox.Location = new System.Drawing.Point(114, 156);
            this.collectionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.collectionTextBox.MaxLength = 50;
            this.collectionTextBox.Multiline = true;
            this.collectionTextBox.Name = "collectionTextBox";
            this.collectionTextBox.Size = new System.Drawing.Size(267, 36);
            this.collectionTextBox.TabIndex = 72;
            // 
            // UpdateCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showCardPage);
            this.Controls.Add(this.showCollectionBtn);
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.updateCardBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.desciptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.collectionTextBox);
            this.Name = "UpdateCard";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label collectionLabel;
        private Bunifu.Framework.UI.BunifuFlatButton updateCardBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.TextBox desciptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label logoLabel;
        private Bunifu.Framework.UI.BunifuImageButton showCollectionBtn;
        private ShowCardPage showCardPage;
        private System.Windows.Forms.TextBox collectionTextBox;
    }
}
