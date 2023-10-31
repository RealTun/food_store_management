namespace Form1
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txt_userName = new TextBox();
            txt_passWord = new TextBox();
            button_Login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(181, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(181, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txt_userName
            // 
            txt_userName.Cursor = Cursors.IBeam;
            txt_userName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txt_userName.Location = new Point(243, 203);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(261, 27);
            txt_userName.TabIndex = 3;
            txt_userName.Text = "Username / id";
            txt_userName.MouseDoubleClick += txt_userName_MouseDoubleClick;
            // 
            // txt_passWord
            // 
            txt_passWord.Cursor = Cursors.IBeam;
            txt_passWord.Location = new Point(243, 261);
            txt_passWord.Name = "txt_passWord";
            txt_passWord.Size = new Size(261, 27);
            txt_passWord.TabIndex = 4;
            txt_passWord.Text = "password";
            txt_passWord.UseSystemPasswordChar = true;
            txt_passWord.MouseDoubleClick += txt_passWord_MouseDoubleClick;
            // 
            // button_Login
            // 
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Image = (Image)resources.GetObject("button_Login.Image");
            button_Login.ImageAlign = ContentAlignment.MiddleRight;
            button_Login.Location = new Point(316, 318);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(81, 29);
            button_Login.TabIndex = 5;
            button_Login.Text = "Login";
            button_Login.TextAlign = ContentAlignment.MiddleLeft;
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginUI
            // 
            AcceptButton = button_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(699, 397);
            Controls.Add(button_Login);
            Controls.Add(txt_passWord);
            Controls.Add(txt_userName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txt_userName;
        private TextBox txt_passWord;
        private Button button_Login;
        private PictureBox pictureBox1;
    }
}