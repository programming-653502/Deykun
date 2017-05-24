namespace Flashcards
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.registrationButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.enterDataButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.showPasswordBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.enterDataButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.bunifuGradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.mailLabel.Location = new System.Drawing.Point(20, 231);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(60, 21);
            this.mailLabel.TabIndex = 19;
            this.mailLabel.Text = "Почта";
            this.mailLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(20, 184);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 21);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.loginLabel.Location = new System.Drawing.Point(20, 133);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 21);
            this.loginLabel.TabIndex = 17;
            this.loginLabel.Text = "Логин ";
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "             Вход";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconZoom = 50D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(52, 316);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.Transparent;
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(271, 59);
            this.loginButton.TabIndex = 15;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrationButton.BorderRadius = 0;
            this.registrationButton.ButtonText = "       Регистрация";
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Iconcolor = System.Drawing.Color.Transparent;
            this.registrationButton.Iconimage = null;
            this.registrationButton.Iconimage_right = null;
            this.registrationButton.Iconimage_right_Selected = null;
            this.registrationButton.Iconimage_Selected = null;
            this.registrationButton.IconZoom = 50D;
            this.registrationButton.IsTab = false;
            this.registrationButton.Location = new System.Drawing.Point(52, 265);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(5);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Normalcolor = System.Drawing.Color.Transparent;
            this.registrationButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.registrationButton.OnHoverTextColor = System.Drawing.Color.White;
            this.registrationButton.selected = false;
            this.registrationButton.Size = new System.Drawing.Size(271, 59);
            this.registrationButton.TabIndex = 14;
            this.registrationButton.Textcolor = System.Drawing.Color.White;
            this.registrationButton.TextFont = new System.Drawing.Font("Century Gothic", 12.8F);
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // enterDataButton
            // 
            this.enterDataButton.BackColor = System.Drawing.SystemColors.Window;
            this.enterDataButton.Image = ((System.Drawing.Image)(resources.GetObject("enterDataButton.Image")));
            this.enterDataButton.ImageActive = null;
            this.enterDataButton.Location = new System.Drawing.Point(240, 228);
            this.enterDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterDataButton.Name = "enterDataButton";
            this.enterDataButton.Size = new System.Drawing.Size(27, 30);
            this.enterDataButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enterDataButton.TabIndex = 13;
            this.enterDataButton.TabStop = false;
            this.enterDataButton.Visible = false;
            this.enterDataButton.Zoom = 10;
            this.enterDataButton.Click += new System.EventHandler(this.enterDataButton_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.mailTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mailTextBox.Location = new System.Drawing.Point(110, 228);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(157, 30);
            this.mailTextBox.TabIndex = 12;
            this.mailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mailTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordTextBox.Location = new System.Drawing.Point(110, 181);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 30);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameTextBox.Location = new System.Drawing.Point(110, 133);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 30);
            this.usernameTextBox.TabIndex = 8;
            this.usernameTextBox.Tag = "";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(97, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(170, 74);
            this.label.TabIndex = 3;
            this.label.Text = "Вход";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(319, 14);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 7;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 10;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // bunifuGradientPanel
            // 
            this.bunifuGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel.BackgroundImage")));
            this.bunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel.Controls.Add(this.showPasswordBtn);
            this.bunifuGradientPanel.Controls.Add(this.mailLabel);
            this.bunifuGradientPanel.Controls.Add(this.passwordLabel);
            this.bunifuGradientPanel.Controls.Add(this.loginLabel);
            this.bunifuGradientPanel.Controls.Add(this.loginButton);
            this.bunifuGradientPanel.Controls.Add(this.registrationButton);
            this.bunifuGradientPanel.Controls.Add(this.enterDataButton);
            this.bunifuGradientPanel.Controls.Add(this.mailTextBox);
            this.bunifuGradientPanel.Controls.Add(this.passwordTextBox);
            this.bunifuGradientPanel.Controls.Add(this.usernameTextBox);
            this.bunifuGradientPanel.Controls.Add(this.label);
            this.bunifuGradientPanel.Controls.Add(this.exitBtn);
            this.bunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel.Name = "bunifuGradientPanel";
            this.bunifuGradientPanel.Quality = 10;
            this.bunifuGradientPanel.Size = new System.Drawing.Size(372, 380);
            this.bunifuGradientPanel.TabIndex = 2;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.bunifuGradientPanel;
            this.dragControl.Vertical = true;
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackColor = System.Drawing.SystemColors.Window;
            this.showPasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordBtn.Image")));
            this.showPasswordBtn.ImageActive = null;
            this.showPasswordBtn.Location = new System.Drawing.Point(232, 181);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(35, 30);
            this.showPasswordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasswordBtn.TabIndex = 20;
            this.showPasswordBtn.TabStop = false;
            this.showPasswordBtn.Zoom = 8;
            this.showPasswordBtn.Click += new System.EventHandler(this.showPasswordBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 380);
            this.Controls.Add(this.bunifuGradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enterDataButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.bunifuGradientPanel.ResumeLayout(false);
            this.bunifuGradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuFlatButton registrationButton;
        private Bunifu.Framework.UI.BunifuImageButton enterDataButton;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Bunifu.Framework.UI.BunifuImageButton showPasswordBtn;
    }
}

