namespace Flashcards
{
    partial class ProgressPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressPage));
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.selectCollectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.beginTestBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collectionLabel = new System.Windows.Forms.Label();
            this.collectionCBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.forgotBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rememberBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.showProgressBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.boxProgressPage = new Flashcards.BoxProgressPage();
            ((System.ComponentModel.ISupportInitialize)(this.selectCollectionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.resultTextBox.Location = new System.Drawing.Point(173, 296);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(619, 137);
            this.resultTextBox.TabIndex = 76;
            this.resultTextBox.Visible = false;
            // 
            // selectCollectionBtn
            // 
            this.selectCollectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectCollectionBtn.Image")));
            this.selectCollectionBtn.ImageActive = null;
            this.selectCollectionBtn.Location = new System.Drawing.Point(0, 53);
            this.selectCollectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectCollectionBtn.Name = "selectCollectionBtn";
            this.selectCollectionBtn.Size = new System.Drawing.Size(67, 62);
            this.selectCollectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectCollectionBtn.TabIndex = 75;
            this.selectCollectionBtn.TabStop = false;
            this.selectCollectionBtn.Visible = false;
            this.selectCollectionBtn.Zoom = 10;
            this.selectCollectionBtn.Click += new System.EventHandler(this.selectCollectionBtn_Click);
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
            this.beginTestBtn.Location = new System.Drawing.Point(333, 386);
            this.beginTestBtn.Margin = new System.Windows.Forms.Padding(6);
            this.beginTestBtn.Name = "beginTestBtn";
            this.beginTestBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.beginTestBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.beginTestBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.beginTestBtn.selected = false;
            this.beginTestBtn.Size = new System.Drawing.Size(262, 53);
            this.beginTestBtn.TabIndex = 74;
            this.beginTestBtn.Textcolor = System.Drawing.Color.White;
            this.beginTestBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.beginTestBtn.Click += new System.EventHandler(this.beginTestBtn_Click);
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.collectionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collectionLabel.Location = new System.Drawing.Point(324, 241);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(282, 52);
            this.collectionLabel.TabIndex = 73;
            this.collectionLabel.Text = " Коллекция :";
            // 
            // collectionCBox
            // 
            this.collectionCBox.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.collectionCBox.FormattingEnabled = true;
            this.collectionCBox.Location = new System.Drawing.Point(333, 319);
            this.collectionCBox.Name = "collectionCBox";
            this.collectionCBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.collectionCBox.Size = new System.Drawing.Size(262, 40);
            this.collectionCBox.TabIndex = 72;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(333, 498);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(267, 65);
            this.descriptionTextBox.TabIndex = 71;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionTextBox.Visible = false;
            // 
            // forgotBtn
            // 
            this.forgotBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.forgotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forgotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgotBtn.BorderRadius = 0;
            this.forgotBtn.ButtonText = "  Не помню";
            this.forgotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.forgotBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.forgotBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("forgotBtn.Iconimage")));
            this.forgotBtn.Iconimage_right = null;
            this.forgotBtn.Iconimage_right_Selected = null;
            this.forgotBtn.Iconimage_Selected = null;
            this.forgotBtn.IconZoom = 70D;
            this.forgotBtn.IsTab = false;
            this.forgotBtn.Location = new System.Drawing.Point(173, 616);
            this.forgotBtn.Margin = new System.Windows.Forms.Padding(6);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forgotBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.forgotBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.forgotBtn.selected = false;
            this.forgotBtn.Size = new System.Drawing.Size(245, 73);
            this.forgotBtn.TabIndex = 70;
            this.forgotBtn.Textcolor = System.Drawing.Color.White;
            this.forgotBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.forgotBtn.Visible = false;
            this.forgotBtn.Click += new System.EventHandler(this.forgotBtn_Click);
            // 
            // rememberBtn
            // 
            this.rememberBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.rememberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rememberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rememberBtn.BorderRadius = 0;
            this.rememberBtn.ButtonText = "  Помню";
            this.rememberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rememberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.rememberBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.rememberBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("rememberBtn.Iconimage")));
            this.rememberBtn.Iconimage_right = null;
            this.rememberBtn.Iconimage_right_Selected = null;
            this.rememberBtn.Iconimage_Selected = null;
            this.rememberBtn.IconZoom = 70D;
            this.rememberBtn.IsTab = false;
            this.rememberBtn.Location = new System.Drawing.Point(547, 616);
            this.rememberBtn.Margin = new System.Windows.Forms.Padding(6);
            this.rememberBtn.Name = "rememberBtn";
            this.rememberBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rememberBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.rememberBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.rememberBtn.selected = false;
            this.rememberBtn.Size = new System.Drawing.Size(245, 73);
            this.rememberBtn.TabIndex = 69;
            this.rememberBtn.Textcolor = System.Drawing.Color.White;
            this.rememberBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rememberBtn.Visible = false;
            this.rememberBtn.Click += new System.EventHandler(this.rememberBtn_Click);
            // 
            // cardImage
            // 
            this.cardImage.Location = new System.Drawing.Point(333, 229);
            this.cardImage.Margin = new System.Windows.Forms.Padding(4);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(267, 246);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImage.TabIndex = 67;
            this.cardImage.TabStop = false;
            this.cardImage.Visible = false;
            this.cardImage.Click += new System.EventHandler(this.cardImage_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(87, 53);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(113, 52);
            this.logoLabel.TabIndex = 66;
            this.logoLabel.Text = "Тест";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cardNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNameTextBox.Font = new System.Drawing.Font("Century Gothic", 25.8F);
            this.cardNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardNameTextBox.Location = new System.Drawing.Point(333, 157);
            this.cardNameTextBox.Multiline = true;
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(267, 65);
            this.cardNameTextBox.TabIndex = 77;
            this.cardNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardNameTextBox.Visible = false;
            // 
            // showProgressBtn
            // 
            this.showProgressBtn.BackColor = System.Drawing.Color.Transparent;
            this.showProgressBtn.color = System.Drawing.Color.Transparent;
            this.showProgressBtn.colorActive = System.Drawing.SystemColors.InactiveCaption;
            this.showProgressBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProgressBtn.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.showProgressBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showProgressBtn.Image = ((System.Drawing.Image)(resources.GetObject("showProgressBtn.Image")));
            this.showProgressBtn.ImagePosition = 10;
            this.showProgressBtn.ImageZoom = 50;
            this.showProgressBtn.LabelPosition = 27;
            this.showProgressBtn.LabelText = "Прогресс";
            this.showProgressBtn.Location = new System.Drawing.Point(795, 39);
            this.showProgressBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showProgressBtn.Name = "showProgressBtn";
            this.showProgressBtn.Size = new System.Drawing.Size(102, 93);
            this.showProgressBtn.TabIndex = 96;
            this.showProgressBtn.Click += new System.EventHandler(this.showProgressBtn_Click);
            // 
            // boxProgressPage
            // 
            this.boxProgressPage.Location = new System.Drawing.Point(0, -3);
            this.boxProgressPage.Name = "boxProgressPage";
            this.boxProgressPage.Size = new System.Drawing.Size(933, 738);
            this.boxProgressPage.TabIndex = 97;
            this.boxProgressPage.Visible = false;
            // 
            // ProgressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxProgressPage);
            this.Controls.Add(this.showProgressBtn);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.selectCollectionBtn);
            this.Controls.Add(this.beginTestBtn);
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.collectionCBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.forgotBtn);
            this.Controls.Add(this.rememberBtn);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.logoLabel);
            this.Name = "ProgressPage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.ProgressPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCollectionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private Bunifu.Framework.UI.BunifuImageButton selectCollectionBtn;
        private Bunifu.Framework.UI.BunifuFlatButton beginTestBtn;
        private System.Windows.Forms.Label collectionLabel;
        private System.Windows.Forms.ComboBox collectionCBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton forgotBtn;
        private Bunifu.Framework.UI.BunifuFlatButton rememberBtn;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private Bunifu.Framework.UI.BunifuTileButton showProgressBtn;
        private BoxProgressPage boxProgressPage;
    }
}
