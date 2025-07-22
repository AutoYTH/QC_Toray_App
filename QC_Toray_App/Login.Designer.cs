namespace QC_Toray_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            lbLogin = new Label();
            txbPassword = new TextBox();
            txbUser = new TextBox();
            btnLogin = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(310, 150);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbLogin
            // 
            lbLogin.Anchor = AnchorStyles.Top;
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(552, 455);
            lbLogin.Margin = new Padding(3);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(127, 54);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbPassword
            // 
            txbPassword.Anchor = AnchorStyles.Top;
            txbPassword.Location = new Point(466, 605);
            txbPassword.Name = "txbPassword";
            txbPassword.PlaceholderText = "Passoword";
            txbPassword.Size = new Size(289, 29);
            txbPassword.TabIndex = 2;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUser
            // 
            txbUser.Anchor = AnchorStyles.Top;
            txbUser.Location = new Point(466, 555);
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "Username";
            txbUser.Size = new Size(289, 29);
            txbUser.TabIndex = 2;
            txbUser.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = SystemColors.AppWorkspace;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Location = new Point(466, 655);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(289, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = SystemColors.Control;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Location = new Point(431, 446);
            listView1.Name = "listView1";
            listView1.Size = new Size(351, 274);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 861);
            Controls.Add(btnLogin);
            Controls.Add(txbUser);
            Controls.Add(txbPassword);
            Controls.Add(lbLogin);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbLogin;
        private TextBox txbPassword;
        private TextBox txbUser;
        private Button btnLogin;
        private ListView listView1;
    }
}
