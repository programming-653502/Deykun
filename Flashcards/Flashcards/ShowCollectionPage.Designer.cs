namespace Flashcards
{
    partial class ShowCollectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCollectionPage));
            this.addCollectionBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.collectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.collection1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.numCollectionsLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.addCardPage = new Flashcards.AddCardPage();
            this.showCollectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.collectionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // addCollectionBtn
            // 
            this.addCollectionBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.addCollectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCollectionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCollectionBtn.BorderRadius = 0;
            this.addCollectionBtn.ButtonText = "  Добавить";
            this.addCollectionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCollectionBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addCollectionBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addCollectionBtn.Iconimage")));
            this.addCollectionBtn.Iconimage_right = null;
            this.addCollectionBtn.Iconimage_right_Selected = null;
            this.addCollectionBtn.Iconimage_Selected = null;
            this.addCollectionBtn.IconZoom = 60D;
            this.addCollectionBtn.IsTab = false;
            this.addCollectionBtn.Location = new System.Drawing.Point(700, 37);
            this.addCollectionBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addCollectionBtn.Name = "addCollectionBtn";
            this.addCollectionBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCollectionBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.addCollectionBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addCollectionBtn.selected = false;
            this.addCollectionBtn.Size = new System.Drawing.Size(179, 49);
            this.addCollectionBtn.TabIndex = 62;
            this.addCollectionBtn.Textcolor = System.Drawing.Color.White;
            this.addCollectionBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCollectionBtn.Click += new System.EventHandler(this.addCollectionBtn_Click);
            // 
            // collectionTable
            // 
            this.collectionTable.ColumnCount = 3;
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.Controls.Add(this.collection1, 0, 0);
            this.collectionTable.Controls.Add(this.collection2, 1, 0);
            this.collectionTable.Controls.Add(this.collection4, 0, 1);
            this.collectionTable.Controls.Add(this.collection5, 1, 1);
            this.collectionTable.Controls.Add(this.collection3, 2, 0);
            this.collectionTable.Controls.Add(this.collection6, 2, 1);
            this.collectionTable.Location = new System.Drawing.Point(130, 143);
            this.collectionTable.Name = "collectionTable";
            this.collectionTable.RowCount = 2;
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.collectionTable.Size = new System.Drawing.Size(707, 480);
            this.collectionTable.TabIndex = 61;
            // 
            // collection1
            // 
            this.collection1.BackColor = System.Drawing.Color.Transparent;
            this.collection1.color = System.Drawing.Color.Transparent;
            this.collection1.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection1.Image = ((System.Drawing.Image)(resources.GetObject("collection1.Image")));
            this.collection1.ImagePosition = 20;
            this.collection1.ImageZoom = 80;
            this.collection1.LabelPosition = 41;
            this.collection1.LabelText = "Tile 1";
            this.collection1.Location = new System.Drawing.Point(6, 6);
            this.collection1.Margin = new System.Windows.Forms.Padding(6);
            this.collection1.Name = "collection1";
            this.collection1.Size = new System.Drawing.Size(223, 228);
            this.collection1.TabIndex = 4;
            this.collection1.Click += new System.EventHandler(this.collection1_Click);
            // 
            // collection2
            // 
            this.collection2.BackColor = System.Drawing.Color.Transparent;
            this.collection2.color = System.Drawing.Color.Transparent;
            this.collection2.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection2.Image = ((System.Drawing.Image)(resources.GetObject("collection2.Image")));
            this.collection2.ImagePosition = 20;
            this.collection2.ImageZoom = 80;
            this.collection2.LabelPosition = 41;
            this.collection2.LabelText = "Tile 1";
            this.collection2.Location = new System.Drawing.Point(241, 6);
            this.collection2.Margin = new System.Windows.Forms.Padding(6);
            this.collection2.Name = "collection2";
            this.collection2.Size = new System.Drawing.Size(223, 228);
            this.collection2.TabIndex = 1;
            this.collection2.Click += new System.EventHandler(this.collection2_Click);
            // 
            // collection4
            // 
            this.collection4.BackColor = System.Drawing.Color.Transparent;
            this.collection4.color = System.Drawing.Color.Transparent;
            this.collection4.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection4.Image = ((System.Drawing.Image)(resources.GetObject("collection4.Image")));
            this.collection4.ImagePosition = 20;
            this.collection4.ImageZoom = 80;
            this.collection4.LabelPosition = 41;
            this.collection4.LabelText = "Tile 1";
            this.collection4.Location = new System.Drawing.Point(6, 246);
            this.collection4.Margin = new System.Windows.Forms.Padding(6);
            this.collection4.Name = "collection4";
            this.collection4.Size = new System.Drawing.Size(223, 228);
            this.collection4.TabIndex = 2;
            this.collection4.Click += new System.EventHandler(this.collection4_Click);
            // 
            // collection5
            // 
            this.collection5.BackColor = System.Drawing.Color.Transparent;
            this.collection5.color = System.Drawing.Color.Transparent;
            this.collection5.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection5.Image = ((System.Drawing.Image)(resources.GetObject("collection5.Image")));
            this.collection5.ImagePosition = 20;
            this.collection5.ImageZoom = 80;
            this.collection5.LabelPosition = 41;
            this.collection5.LabelText = "Tile 1";
            this.collection5.Location = new System.Drawing.Point(241, 246);
            this.collection5.Margin = new System.Windows.Forms.Padding(6);
            this.collection5.Name = "collection5";
            this.collection5.Size = new System.Drawing.Size(223, 228);
            this.collection5.TabIndex = 0;
            this.collection5.Click += new System.EventHandler(this.collection5_Click);
            // 
            // collection3
            // 
            this.collection3.BackColor = System.Drawing.Color.Transparent;
            this.collection3.color = System.Drawing.Color.Transparent;
            this.collection3.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection3.Image = ((System.Drawing.Image)(resources.GetObject("collection3.Image")));
            this.collection3.ImagePosition = 20;
            this.collection3.ImageZoom = 80;
            this.collection3.LabelPosition = 41;
            this.collection3.LabelText = "Tile 1";
            this.collection3.Location = new System.Drawing.Point(476, 6);
            this.collection3.Margin = new System.Windows.Forms.Padding(6);
            this.collection3.Name = "collection3";
            this.collection3.Size = new System.Drawing.Size(223, 228);
            this.collection3.TabIndex = 3;
            this.collection3.Click += new System.EventHandler(this.collection3_Click);
            // 
            // collection6
            // 
            this.collection6.BackColor = System.Drawing.Color.Transparent;
            this.collection6.color = System.Drawing.Color.Transparent;
            this.collection6.colorActive = System.Drawing.Color.LightSteelBlue;
            this.collection6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collection6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.collection6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collection6.Image = ((System.Drawing.Image)(resources.GetObject("collection6.Image")));
            this.collection6.ImagePosition = 20;
            this.collection6.ImageZoom = 80;
            this.collection6.LabelPosition = 41;
            this.collection6.LabelText = "Tile 1";
            this.collection6.Location = new System.Drawing.Point(476, 246);
            this.collection6.Margin = new System.Windows.Forms.Padding(6);
            this.collection6.Name = "collection6";
            this.collection6.Size = new System.Drawing.Size(223, 228);
            this.collection6.TabIndex = 5;
            this.collection6.Click += new System.EventHandler(this.collection6_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(23, 613);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(67, 62);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 59;
            this.backBtn.TabStop = false;
            this.backBtn.Zoom = 10;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.ImageActive = null;
            this.nextBtn.Location = new System.Drawing.Point(844, 613);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(67, 62);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 58;
            this.nextBtn.TabStop = false;
            this.nextBtn.Zoom = 10;
            // 
            // numCollectionsLabel
            // 
            this.numCollectionsLabel.AutoSize = true;
            this.numCollectionsLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.numCollectionsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numCollectionsLabel.Location = new System.Drawing.Point(110, 86);
            this.numCollectionsLabel.Name = "numCollectionsLabel";
            this.numCollectionsLabel.Size = new System.Drawing.Size(115, 33);
            this.numCollectionsLabel.TabIndex = 57;
            this.numCollectionsLabel.Text = "Всего : ";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(110, 34);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(358, 52);
            this.logoLabel.TabIndex = 56;
            this.logoLabel.Text = "Мои коллекции";
            // 
            // addCardPage
            // 
            this.addCardPage.Location = new System.Drawing.Point(0, -3);
            this.addCardPage.Name = "addCardPage";
            this.addCardPage.Size = new System.Drawing.Size(933, 738);
            this.addCardPage.TabIndex = 63;
            this.addCardPage.Visible = false;
            // 
            // showCollectionBtn
            // 
            this.showCollectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.showCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("showCollectionBtn.Image")));
            this.showCollectionBtn.ImageActive = null;
            this.showCollectionBtn.Location = new System.Drawing.Point(4, 57);
            this.showCollectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showCollectionBtn.Name = "showCollectionBtn";
            this.showCollectionBtn.Size = new System.Drawing.Size(67, 62);
            this.showCollectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showCollectionBtn.TabIndex = 64;
            this.showCollectionBtn.TabStop = false;
            this.showCollectionBtn.Visible = false;
            this.showCollectionBtn.Zoom = 10;
            this.showCollectionBtn.Click += new System.EventHandler(this.showCollectionBtn_Click);
            // 
            // ShowCollectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showCollectionBtn);
            this.Controls.Add(this.addCardPage);
            this.Controls.Add(this.addCollectionBtn);
            this.Controls.Add(this.collectionTable);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.numCollectionsLabel);
            this.Controls.Add(this.logoLabel);
            this.Name = "ShowCollectionPage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.ShowCollectionPage_Load);
            this.collectionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addCollectionBtn;
        private System.Windows.Forms.TableLayoutPanel collectionTable;
        private Bunifu.Framework.UI.BunifuTileButton collection1;
        private Bunifu.Framework.UI.BunifuTileButton collection2;
        private Bunifu.Framework.UI.BunifuTileButton collection3;
        private Bunifu.Framework.UI.BunifuTileButton collection4;
        private Bunifu.Framework.UI.BunifuTileButton collection5;
        private Bunifu.Framework.UI.BunifuTileButton collection6;
        private Bunifu.Framework.UI.BunifuImageButton backBtn;
        private Bunifu.Framework.UI.BunifuImageButton nextBtn;
        private System.Windows.Forms.Label numCollectionsLabel;
        private System.Windows.Forms.Label logoLabel;
        private AddCardPage addCardPage;
        private Bunifu.Framework.UI.BunifuImageButton showCollectionBtn;
    }
}
