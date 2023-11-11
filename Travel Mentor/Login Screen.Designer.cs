namespace Travel_Mentor
{
    partial class Login_Screen
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
            this.usernameText = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginCheckBox = new System.Windows.Forms.CheckBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.registerCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameText.Location = new System.Drawing.Point(181, 110);
            this.usernameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(110, 25);
            this.usernameText.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(181, 290);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.Location = new System.Drawing.Point(181, 166);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(110, 25);
            this.passwordText.TabIndex = 4;
            // 
            // loginCheckBox
            // 
            this.loginCheckBox.AutoSize = true;
            this.loginCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginCheckBox.Location = new System.Drawing.Point(58, 31);
            this.loginCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginCheckBox.Name = "loginCheckBox";
            this.loginCheckBox.Size = new System.Drawing.Size(80, 32);
            this.loginCheckBox.TabIndex = 5;
            this.loginCheckBox.Text = "Login";
            this.loginCheckBox.UseVisualStyleBackColor = true;
            this.loginCheckBox.CheckedChanged += new System.EventHandler(this.loginCheckBox_CheckedChanged);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailText.Location = new System.Drawing.Point(181, 225);
            this.emailText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(110, 25);
            this.emailText.TabIndex = 7;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelemail.Location = new System.Drawing.Point(54, 225);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(61, 25);
            this.labelemail.TabIndex = 8;
            this.labelemail.Text = "E-mail";
            // 
            // registerCheckBox
            // 
            this.registerCheckBox.AutoSize = true;
            this.registerCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerCheckBox.Location = new System.Drawing.Point(238, 31);
            this.registerCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerCheckBox.Name = "registerCheckBox";
            this.registerCheckBox.Size = new System.Drawing.Size(101, 32);
            this.registerCheckBox.TabIndex = 9;
            this.registerCheckBox.Text = "Register";
            this.registerCheckBox.UseVisualStyleBackColor = true;
            this.registerCheckBox.CheckedChanged += new System.EventHandler(this.registerCheckBox_CheckedChanged);
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 382);
            this.Controls.Add(this.registerCheckBox);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.loginCheckBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.usernameText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Mentor Login";
            this.Load += new System.EventHandler(this.Login_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameText;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox passwordText;
        private CheckBox loginCheckBox;
        private TextBox emailText;
        private Label labelemail;
        private CheckBox registerCheckBox;
    }
}