namespace Flashcards
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.logoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // profileImage
            // 
            this.profileImage.Image = ((System.Drawing.Image)(resources.GetObject("profileImage.Image")));
            this.profileImage.Location = new System.Drawing.Point(375, 161);
            this.profileImage.Margin = new System.Windows.Forms.Padding(4);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(133, 123);
            this.profileImage.TabIndex = 30;
            this.profileImage.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Изменить";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(685, 639);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateBtn.OnHovercolor = System.Drawing.Color.MediumSlateBlue;
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(179, 49);
            this.updateBtn.TabIndex = 29;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.mailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailLabel.Location = new System.Drawing.Point(243, 536);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(105, 33);
            this.mailLabel.TabIndex = 28;
            this.mailLabel.Text = "Почта :";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.mailTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailTextBox.Location = new System.Drawing.Point(409, 530);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(208, 36);
            this.mailTextBox.TabIndex = 27;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Location = new System.Drawing.Point(243, 438);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 33);
            this.passwordLabel.TabIndex = 26;
            this.passwordLabel.Text = "Пароль :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordTextBox.Location = new System.Drawing.Point(409, 432);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(208, 36);
            this.passwordTextBox.TabIndex = 25;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 15.8F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginLabel.Location = new System.Drawing.Point(243, 348);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(109, 33);
            this.loginLabel.TabIndex = 24;
            this.loginLabel.Text = "Логин :";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Century Gothic", 12.8F);
            this.loginTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginTextBox.Location = new System.Drawing.Point(409, 342);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(208, 36);
            this.loginTextBox.TabIndex = 23;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoLabel.Location = new System.Drawing.Point(68, 51);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(330, 52);
            this.logoLabel.TabIndex = 22;
            this.logoLabel.Text = "Мой профиль";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.logoLabel);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileImage;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label logoLabel;
    }
}
