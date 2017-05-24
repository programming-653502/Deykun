namespace Flashcards
{
    partial class ShowCardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCardPage));
            this.collectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.collection4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.collection3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.numCardLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.showCollectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.showCollectionPage = new Flashcards.ShowCollectionPage();
            this.collectionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionTable
            // 
            this.collectionTable.ColumnCount = 3;
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.Controls.Add(this.collection4, 0, 1);
            this.collectionTable.Controls.Add(this.collection5, 0, 1);
            this.collectionTable.Controls.Add(this.collection6, 0, 1);
            this.collectionTable.Controls.Add(this.collection1, 0, 0);
            this.collectionTable.Controls.Add(this.collection2, 1, 0);
            this.collectionTable.Controls.Add(this.collection3, 2, 0);
            this.collectionTable.Location = new System.Drawing.Point(122, 148);
            this.collectionTable.Name = "collectionTable";
            this.collectionTable.RowCount = 2;
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.collectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.collectionTable.Size = new System.Drawing.Size(707, 480);
            this.collectionTable.TabIndex = 58;
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
            this.collection4.TabIndex = 10;
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
            this.collection5.TabIndex = 9;
            this.collection5.Click += new System.EventHandler(this.collection5_Click);
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
            this.collection6.TabIndex = 8;
            this.collection6.Click += new System.EventHandler(this.collection6_Click);
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
            this.collection1.TabIndex = 5;
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
            this.collection2.TabIndex = 7;
            this.collection2.Click += new System.EventHandler(this.collection2_Click);
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
            this.collection3.TabIndex = 6;
            this.collection3.Click += new System.EventHandler(this.collection3_Click);
            // 
            // numCardLabel
            // 
            this.numCardLabel.AutoSize = true;
            this.numCardLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.numCardLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numCardLabel.Location = new System.Drawing.Point(113, 84);
            this.numCardLabel.Name = "numCardLabel";
            this.numCardLabel.Size = new System.Drawing.Size(115, 33);
            this.numCardLabel.TabIndex = 57;
            this.numCardLabel.Text = "Всего : ";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(113, 32);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(322, 52);
            this.logoLabel.TabIndex = 56;
            this.logoLabel.Text = "Мои карточки";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(28, 608);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(67, 62);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 61;
            this.backBtn.TabStop = false;
            this.backBtn.Zoom = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.ImageActive = null;
            this.nextBtn.Location = new System.Drawing.Point(850, 608);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(67, 62);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 60;
            this.nextBtn.TabStop = false;
            this.nextBtn.Zoom = 10;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // showCollectionBtn
            // 
            this.showCollectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.showCollectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("showCollectionBtn.Image")));
            this.showCollectionBtn.ImageActive = null;
            this.showCollectionBtn.Location = new System.Drawing.Point(28, 32);
            this.showCollectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showCollectionBtn.Name = "showCollectionBtn";
            this.showCollectionBtn.Size = new System.Drawing.Size(67, 62);
            this.showCollectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showCollectionBtn.TabIndex = 63;
            this.showCollectionBtn.TabStop = false;
            this.showCollectionBtn.Visible = false;
            this.showCollectionBtn.Zoom = 10;
            this.showCollectionBtn.Click += new System.EventHandler(this.showCollectionBtn_Click);
            // 
            // showCollectionPage
            // 
            this.showCollectionPage.collection = null;
            this.showCollectionPage.Location = new System.Drawing.Point(-3, 0);
            this.showCollectionPage.Name = "showCollectionPage";
            this.showCollectionPage.Size = new System.Drawing.Size(933, 738);
            this.showCollectionPage.TabIndex = 64;
            this.showCollectionPage.collectionClick += new System.EventHandler(this.showCollectionPage_collectionClick_1);
            // 
            // ShowCardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showCollectionPage);
            this.Controls.Add(this.showCollectionBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.collectionTable);
            this.Controls.Add(this.numCardLabel);
            this.Controls.Add(this.logoLabel);
            this.Name = "ShowCardPage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.ShowCardPage_Load);
            this.collectionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCollectionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel collectionTable;
        private Bunifu.Framework.UI.BunifuTileButton collection4;
        private Bunifu.Framework.UI.BunifuTileButton collection5;
        private Bunifu.Framework.UI.BunifuTileButton collection6;
        private Bunifu.Framework.UI.BunifuTileButton collection1;
        private Bunifu.Framework.UI.BunifuTileButton collection2;
        private Bunifu.Framework.UI.BunifuTileButton collection3;
        private System.Windows.Forms.Label numCardLabel;
        private System.Windows.Forms.Label logoLabel;
        private Bunifu.Framework.UI.BunifuImageButton backBtn;
        private Bunifu.Framework.UI.BunifuImageButton nextBtn;
        private Bunifu.Framework.UI.BunifuImageButton showCollectionBtn;
        private ShowCollectionPage showCollectionPage;
    }
}
