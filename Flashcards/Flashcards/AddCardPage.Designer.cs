namespace Flashcards
{
    partial class AddCardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCardPage));
            this.collectionLabel = new System.Windows.Forms.Label();
            this.collectionCBox = new System.Windows.Forms.ComboBox();
            this.addCardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.desciptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.collectionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collectionLabel.Location = new System.Drawing.Point(85, 149);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(172, 33);
            this.collectionLabel.TabIndex = 68;
            this.collectionLabel.Text = " Коллекция ";
            // 
            // collectionCBox
            // 
            this.collectionCBox.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.collectionCBox.FormattingEnabled = true;
            this.collectionCBox.Location = new System.Drawing.Point(91, 198);
            this.collectionCBox.Name = "collectionCBox";
            this.collectionCBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.collectionCBox.Size = new System.Drawing.Size(267, 40);
            this.collectionCBox.TabIndex = 67;
            // 
            // addCardBtn
            // 
            this.addCardBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.addCardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCardBtn.BorderRadius = 0;
            this.addCardBtn.ButtonText = "    Добавить";
            this.addCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addCardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addCardBtn.Iconimage")));
            this.addCardBtn.Iconimage_right = null;
            this.addCardBtn.Iconimage_right_Selected = null;
            this.addCardBtn.Iconimage_Selected = null;
            this.addCardBtn.IconZoom = 60D;
            this.addCardBtn.IsTab = false;
            this.addCardBtn.Location = new System.Drawing.Point(650, 661);
            this.addCardBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addCardBtn.Name = "addCardBtn";
            this.addCardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCardBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.addCardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addCardBtn.selected = false;
            this.addCardBtn.Size = new System.Drawing.Size(189, 55);
            this.addCardBtn.TabIndex = 66;
            this.addCardBtn.Textcolor = System.Drawing.Color.White;
            this.addCardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardBtn.Click += new System.EventHandler(this.addCardBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(592, 157);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(166, 20);
            this.errorLabel.TabIndex = 65;
            this.errorLabel.Text = "* Обязательное поле";
            this.errorLabel.Visible = false;
            // 
            // cardImage
            // 
            this.cardImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardImage.BackgroundImage")));
            this.cardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardImage.Location = new System.Drawing.Point(91, 257);
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
            this.desciptionTextBox.Location = new System.Drawing.Point(438, 303);
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
            this.descriptionLabel.Location = new System.Drawing.Point(431, 257);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(157, 33);
            this.descriptionLabel.TabIndex = 61;
            this.descriptionLabel.Text = "Описание";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.AllowDrop = true;
            this.cardNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNameTextBox.Location = new System.Drawing.Point(438, 198);
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
            this.nameLabel.Location = new System.Drawing.Point(431, 149);
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
            this.logoLabel.Location = new System.Drawing.Point(82, 67);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(424, 52);
            this.logoLabel.TabIndex = 59;
            this.logoLabel.Text = "Добавить карточку";
            // 
            // AddCardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.collectionCBox);
            this.Controls.Add(this.addCardBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.desciptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoLabel);
            this.Name = "AddCardPage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.AddCardPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label collectionLabel;
        private System.Windows.Forms.ComboBox collectionCBox;
        private Bunifu.Framework.UI.BunifuFlatButton addCardBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.TextBox desciptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label logoLabel;
    }
}
