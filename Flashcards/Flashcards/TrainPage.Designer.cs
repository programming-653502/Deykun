namespace Flashcards
{
    partial class TrainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainPage));
            this.showTrainBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.train2Btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.train1Btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.logoLabel = new System.Windows.Forms.Label();
            this.matchWordsTrainPage = new Flashcards.MatchWordsTrainPage();
            this.keywordTrainPage = new Flashcards.KeywordTrainPage();
            ((System.ComponentModel.ISupportInitialize)(this.showTrainBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // showTrainBtn
            // 
            this.showTrainBtn.BackColor = System.Drawing.Color.Transparent;
            this.showTrainBtn.Image = ((System.Drawing.Image)(resources.GetObject("showTrainBtn.Image")));
            this.showTrainBtn.ImageActive = null;
            this.showTrainBtn.Location = new System.Drawing.Point(15, 40);
            this.showTrainBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showTrainBtn.Name = "showTrainBtn";
            this.showTrainBtn.Size = new System.Drawing.Size(67, 62);
            this.showTrainBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showTrainBtn.TabIndex = 54;
            this.showTrainBtn.TabStop = false;
            this.showTrainBtn.Visible = false;
            this.showTrainBtn.Zoom = 10;
            this.showTrainBtn.Click += new System.EventHandler(this.showTrainBtn_Click);
            // 
            // train2Btn
            // 
            this.train2Btn.BackColor = System.Drawing.Color.Transparent;
            this.train2Btn.color = System.Drawing.Color.Transparent;
            this.train2Btn.colorActive = System.Drawing.SystemColors.ActiveCaption;
            this.train2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.train2Btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.train2Btn.ForeColor = System.Drawing.Color.DimGray;
            this.train2Btn.Image = ((System.Drawing.Image)(resources.GetObject("train2Btn.Image")));
            this.train2Btn.ImagePosition = 0;
            this.train2Btn.ImageZoom = 100;
            this.train2Btn.LabelPosition = 41;
            this.train2Btn.LabelText = "MathTheWords";
            this.train2Btn.Location = new System.Drawing.Point(505, 222);
            this.train2Btn.Margin = new System.Windows.Forms.Padding(6);
            this.train2Btn.Name = "train2Btn";
            this.train2Btn.Size = new System.Drawing.Size(298, 279);
            this.train2Btn.TabIndex = 53;
            this.train2Btn.Click += new System.EventHandler(this.train2Btn_Click);
            // 
            // train1Btn
            // 
            this.train1Btn.BackColor = System.Drawing.Color.Transparent;
            this.train1Btn.color = System.Drawing.Color.Transparent;
            this.train1Btn.colorActive = System.Drawing.SystemColors.ActiveCaption;
            this.train1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.train1Btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.train1Btn.ForeColor = System.Drawing.Color.DimGray;
            this.train1Btn.Image = ((System.Drawing.Image)(resources.GetObject("train1Btn.Image")));
            this.train1Btn.ImagePosition = 0;
            this.train1Btn.ImageZoom = 100;
            this.train1Btn.LabelPosition = 41;
            this.train1Btn.LabelText = "EnterWOrd";
            this.train1Btn.Location = new System.Drawing.Point(111, 222);
            this.train1Btn.Margin = new System.Windows.Forms.Padding(6);
            this.train1Btn.Name = "train1Btn";
            this.train1Btn.Size = new System.Drawing.Size(295, 279);
            this.train1Btn.TabIndex = 52;
            this.train1Btn.Click += new System.EventHandler(this.train1Btn_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(131, 40);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(275, 52);
            this.logoLabel.TabIndex = 51;
            this.logoLabel.Text = "Тренировки";
            // 
            // matchWordsTrainPage
            // 
            this.matchWordsTrainPage.Location = new System.Drawing.Point(0, 0);
            this.matchWordsTrainPage.Name = "matchWordsTrainPage";
            this.matchWordsTrainPage.Size = new System.Drawing.Size(933, 738);
            this.matchWordsTrainPage.TabIndex = 55;
            this.matchWordsTrainPage.Visible = false;
            // 
            // keywordTrainPage
            // 
            this.keywordTrainPage.Location = new System.Drawing.Point(3, -3);
            this.keywordTrainPage.Name = "keywordTrainPage";
            this.keywordTrainPage.Size = new System.Drawing.Size(933, 738);
            this.keywordTrainPage.TabIndex = 56;
            this.keywordTrainPage.Visible = false;
            // 
            // TrainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keywordTrainPage);
            this.Controls.Add(this.matchWordsTrainPage);
            this.Controls.Add(this.showTrainBtn);
            this.Controls.Add(this.train2Btn);
            this.Controls.Add(this.train1Btn);
            this.Controls.Add(this.logoLabel);
            this.Name = "TrainPage";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.showTrainBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton showTrainBtn;
        private Bunifu.Framework.UI.BunifuTileButton train2Btn;
        private Bunifu.Framework.UI.BunifuTileButton train1Btn;
        private System.Windows.Forms.Label logoLabel;
        private MatchWordsTrainPage matchWordsTrainPage;
        private KeywordTrainPage keywordTrainPage;
    }
}
