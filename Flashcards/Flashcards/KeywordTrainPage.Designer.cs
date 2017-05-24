namespace Flashcards
{
    partial class KeywordTrainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeywordTrainPage));
            this.boxCBox = new System.Windows.Forms.ComboBox();
            this.boxLabel = new System.Windows.Forms.Label();
            this.tryAgainBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.selectCollectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.beginTestBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collectionCBox = new System.Windows.Forms.ComboBox();
            this.collectionLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.hintBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextCardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.descriptionHint = new System.Windows.Forms.TextBox();
            this.keywordHint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectCollectionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // boxCBox
            // 
            this.boxCBox.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.boxCBox.FormattingEnabled = true;
            this.boxCBox.Location = new System.Drawing.Point(385, 292);
            this.boxCBox.Name = "boxCBox";
            this.boxCBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxCBox.Size = new System.Drawing.Size(266, 32);
            this.boxCBox.TabIndex = 89;
            // 
            // boxLabel
            // 
            this.boxLabel.AutoSize = true;
            this.boxLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.boxLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boxLabel.Location = new System.Drawing.Point(197, 292);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(142, 33);
            this.boxLabel.TabIndex = 88;
            this.boxLabel.Text = "Уровень :";
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.tryAgainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tryAgainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tryAgainBtn.BorderRadius = 0;
            this.tryAgainBtn.ButtonText = " Попробовать еще";
            this.tryAgainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tryAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.tryAgainBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.tryAgainBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("tryAgainBtn.Iconimage")));
            this.tryAgainBtn.Iconimage_right = null;
            this.tryAgainBtn.Iconimage_right_Selected = null;
            this.tryAgainBtn.Iconimage_Selected = null;
            this.tryAgainBtn.IconZoom = 60D;
            this.tryAgainBtn.IsTab = false;
            this.tryAgainBtn.Location = new System.Drawing.Point(322, 380);
            this.tryAgainBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tryAgainBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.tryAgainBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.tryAgainBtn.selected = false;
            this.tryAgainBtn.Size = new System.Drawing.Size(329, 63);
            this.tryAgainBtn.TabIndex = 87;
            this.tryAgainBtn.Textcolor = System.Drawing.Color.White;
            this.tryAgainBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tryAgainBtn.Visible = false;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // selectCollectionBtn
            // 
            this.selectCollectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectCollectionBtn.Image")));
            this.selectCollectionBtn.ImageActive = null;
            this.selectCollectionBtn.Location = new System.Drawing.Point(26, 66);
            this.selectCollectionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectCollectionBtn.Name = "selectCollectionBtn";
            this.selectCollectionBtn.Size = new System.Drawing.Size(67, 62);
            this.selectCollectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectCollectionBtn.TabIndex = 86;
            this.selectCollectionBtn.TabStop = false;
            this.selectCollectionBtn.Visible = false;
            this.selectCollectionBtn.Zoom = 10;
            this.selectCollectionBtn.Click += new System.EventHandler(this.selectCollectionBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.TextBox.Location = new System.Drawing.Point(324, 282);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(359, 97);
            this.TextBox.TabIndex = 85;
            this.TextBox.Visible = false;
            // 
            // beginTestBtn
            // 
            this.beginTestBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.beginTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.beginTestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beginTestBtn.BorderRadius = 0;
            this.beginTestBtn.ButtonText = "      Начать";
            this.beginTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.beginTestBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.beginTestBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("beginTestBtn.Iconimage")));
            this.beginTestBtn.Iconimage_right = null;
            this.beginTestBtn.Iconimage_right_Selected = null;
            this.beginTestBtn.Iconimage_Selected = null;
            this.beginTestBtn.IconZoom = 60D;
            this.beginTestBtn.IsTab = false;
            this.beginTestBtn.Location = new System.Drawing.Point(361, 380);
            this.beginTestBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.beginTestBtn.Name = "beginTestBtn";
            this.beginTestBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.beginTestBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.beginTestBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.beginTestBtn.selected = false;
            this.beginTestBtn.Size = new System.Drawing.Size(266, 53);
            this.beginTestBtn.TabIndex = 84;
            this.beginTestBtn.Textcolor = System.Drawing.Color.White;
            this.beginTestBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.beginTestBtn.Click += new System.EventHandler(this.beginTestBtn_Click);
            // 
            // collectionCBox
            // 
            this.collectionCBox.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.collectionCBox.FormattingEnabled = true;
            this.collectionCBox.Location = new System.Drawing.Point(385, 230);
            this.collectionCBox.Name = "collectionCBox";
            this.collectionCBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.collectionCBox.Size = new System.Drawing.Size(266, 32);
            this.collectionCBox.TabIndex = 83;
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.collectionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collectionLabel.Location = new System.Drawing.Point(197, 226);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(172, 33);
            this.collectionLabel.TabIndex = 82;
            this.collectionLabel.Text = "Коллекция :";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(361, 480);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(192, 17);
            this.errorLabel.TabIndex = 79;
            this.errorLabel.Text = "* Неверно! Попробуйте еще";
            this.errorLabel.Visible = false;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.keywordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.keywordTextBox.Location = new System.Drawing.Point(362, 524);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(267, 40);
            this.keywordTextBox.TabIndex = 78;
            this.keywordTextBox.Visible = false;
            // 
            // hintBtn
            // 
            this.hintBtn.BackColor = System.Drawing.Color.Transparent;
            this.hintBtn.Image = ((System.Drawing.Image)(resources.GetObject("hintBtn.Image")));
            this.hintBtn.ImageActive = ((System.Drawing.Image)(resources.GetObject("hintBtn.ImageActive")));
            this.hintBtn.Location = new System.Drawing.Point(836, 89);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(71, 71);
            this.hintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hintBtn.TabIndex = 77;
            this.hintBtn.TabStop = false;
            this.hintBtn.Zoom = 10;
            this.hintBtn.Click += new System.EventHandler(this.hintBtn_Click);
            // 
            // nextCardBtn
            // 
            this.nextCardBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.nextCardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextCardBtn.BorderRadius = 0;
            this.nextCardBtn.ButtonText = "     Дальше";
            this.nextCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.nextCardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nextCardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("nextCardBtn.Iconimage")));
            this.nextCardBtn.Iconimage_right = null;
            this.nextCardBtn.Iconimage_right_Selected = null;
            this.nextCardBtn.Iconimage_Selected = null;
            this.nextCardBtn.IconZoom = 70D;
            this.nextCardBtn.IsTab = false;
            this.nextCardBtn.Location = new System.Drawing.Point(362, 599);
            this.nextCardBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextCardBtn.Name = "nextCardBtn";
            this.nextCardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextCardBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.nextCardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nextCardBtn.selected = false;
            this.nextCardBtn.Size = new System.Drawing.Size(266, 73);
            this.nextCardBtn.TabIndex = 76;
            this.nextCardBtn.Textcolor = System.Drawing.Color.White;
            this.nextCardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nextCardBtn.Visible = false;
            this.nextCardBtn.Click += new System.EventHandler(this.nextCardBtn_Click);
            // 
            // cardImage
            // 
            this.cardImage.Location = new System.Drawing.Point(361, 214);
            this.cardImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(267, 246);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImage.TabIndex = 75;
            this.cardImage.TabStop = false;
            this.cardImage.Visible = false;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(100, 76);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(113, 52);
            this.logoLabel.TabIndex = 74;
            this.logoLabel.Text = "Тест";
            // 
            // descriptionHint
            // 
            this.descriptionHint.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionHint.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.descriptionHint.Location = new System.Drawing.Point(640, 166);
            this.descriptionHint.Multiline = true;
            this.descriptionHint.Name = "descriptionHint";
            this.descriptionHint.Size = new System.Drawing.Size(267, 65);
            this.descriptionHint.TabIndex = 90;
            this.descriptionHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.descriptionHint.Visible = false;
            // 
            // keywordHint
            // 
            this.keywordHint.BackColor = System.Drawing.SystemColors.Control;
            this.keywordHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keywordHint.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.keywordHint.Location = new System.Drawing.Point(640, 249);
            this.keywordHint.Multiline = true;
            this.keywordHint.Name = "keywordHint";
            this.keywordHint.Size = new System.Drawing.Size(267, 65);
            this.keywordHint.TabIndex = 91;
            this.keywordHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.keywordHint.Visible = false;
            // 
            // KeywordTrainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keywordHint);
            this.Controls.Add(this.descriptionHint);
            this.Controls.Add(this.boxCBox);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.selectCollectionBtn);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.beginTestBtn);
            this.Controls.Add(this.collectionCBox);
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.nextCardBtn);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.logoLabel);
            this.Name = "KeywordTrainPage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.KeywordTrainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCollectionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxCBox;
        private System.Windows.Forms.Label boxLabel;
        private Bunifu.Framework.UI.BunifuFlatButton tryAgainBtn;
        private Bunifu.Framework.UI.BunifuImageButton selectCollectionBtn;
        private System.Windows.Forms.TextBox TextBox;
        private Bunifu.Framework.UI.BunifuFlatButton beginTestBtn;
        private System.Windows.Forms.ComboBox collectionCBox;
        private System.Windows.Forms.Label collectionLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private Bunifu.Framework.UI.BunifuImageButton hintBtn;
        private Bunifu.Framework.UI.BunifuFlatButton nextCardBtn;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox descriptionHint;
        private System.Windows.Forms.TextBox keywordHint;
    }
}
