namespace FeedbackApplicatieFutureFlow
{
    partial class LoginScreenForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginScreenPanel = new System.Windows.Forms.Panel();
            this.CreateStudentPanel = new System.Windows.Forms.Panel();
            this.CreateStudentMessageLabel = new System.Windows.Forms.Label();
            this.CancelCreateStudentButton = new System.Windows.Forms.Button();
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.CreatePasswordTextbox = new System.Windows.Forms.TextBox();
            this.CreateUsernameTextbox = new System.Windows.Forms.TextBox();
            this.CreateEmailTextbox = new System.Windows.Forms.TextBox();
            this.CreateLastnameTextbox = new System.Windows.Forms.TextBox();
            this.CreateFirstnameTextbox = new System.Windows.Forms.TextBox();
            this.CreatePasswordLabel = new System.Windows.Forms.Label();
            this.CreateUsernameLabel = new System.Windows.Forms.Label();
            this.CreateEmailLabel = new System.Windows.Forms.Label();
            this.CreateLastnameLabel = new System.Windows.Forms.Label();
            this.CreateFirstnameLabel = new System.Windows.Forms.Label();
            this.LoginScreenPicturebox = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordButton = new System.Windows.Forms.Button();
            this.LoginScreenCloseButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.WrongInlogMessageLabel = new System.Windows.Forms.Label();
            this.LoginScreenPanel.SuspendLayout();
            this.CreateStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginScreenPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(819, 374);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(139, 60);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Aanmelden";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(617, 251);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(341, 23);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(617, 305);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(341, 23);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Location = new System.Drawing.Point(420, 246);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(159, 25);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Gebruikersnaam";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Location = new System.Drawing.Point(420, 300);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 25);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Wachtwoord";
            // 
            // LoginScreenPanel
            // 
            this.LoginScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LoginScreenPanel.Controls.Add(this.CreateStudentPanel);
            this.LoginScreenPanel.Controls.Add(this.LoginScreenPicturebox);
            this.LoginScreenPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginScreenPanel.Name = "LoginScreenPanel";
            this.LoginScreenPanel.Size = new System.Drawing.Size(334, 689);
            this.LoginScreenPanel.TabIndex = 5;
            // 
            // CreateStudentPanel
            // 
            this.CreateStudentPanel.Controls.Add(this.CreateStudentMessageLabel);
            this.CreateStudentPanel.Controls.Add(this.CancelCreateStudentButton);
            this.CreateStudentPanel.Controls.Add(this.CreateStudentButton);
            this.CreateStudentPanel.Controls.Add(this.CreatePasswordTextbox);
            this.CreateStudentPanel.Controls.Add(this.CreateUsernameTextbox);
            this.CreateStudentPanel.Controls.Add(this.CreateEmailTextbox);
            this.CreateStudentPanel.Controls.Add(this.CreateLastnameTextbox);
            this.CreateStudentPanel.Controls.Add(this.CreateFirstnameTextbox);
            this.CreateStudentPanel.Controls.Add(this.CreatePasswordLabel);
            this.CreateStudentPanel.Controls.Add(this.CreateUsernameLabel);
            this.CreateStudentPanel.Controls.Add(this.CreateEmailLabel);
            this.CreateStudentPanel.Controls.Add(this.CreateLastnameLabel);
            this.CreateStudentPanel.Controls.Add(this.CreateFirstnameLabel);
            this.CreateStudentPanel.Location = new System.Drawing.Point(8, 175);
            this.CreateStudentPanel.Name = "CreateStudentPanel";
            this.CreateStudentPanel.Size = new System.Drawing.Size(312, 493);
            this.CreateStudentPanel.TabIndex = 1;
            this.CreateStudentPanel.Visible = false;
            // 
            // CreateStudentMessageLabel
            // 
            this.CreateStudentMessageLabel.AutoSize = true;
            this.CreateStudentMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CreateStudentMessageLabel.Location = new System.Drawing.Point(72, 263);
            this.CreateStudentMessageLabel.Name = "CreateStudentMessageLabel";
            this.CreateStudentMessageLabel.Size = new System.Drawing.Size(177, 15);
            this.CreateStudentMessageLabel.TabIndex = 15;
            this.CreateStudentMessageLabel.Text = "Account succesvol aangemaakt!";
            this.CreateStudentMessageLabel.Visible = false;
            // 
            // CancelCreateStudentButton
            // 
            this.CancelCreateStudentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelCreateStudentButton.Location = new System.Drawing.Point(46, 301);
            this.CancelCreateStudentButton.Name = "CancelCreateStudentButton";
            this.CancelCreateStudentButton.Size = new System.Drawing.Size(97, 44);
            this.CancelCreateStudentButton.TabIndex = 14;
            this.CancelCreateStudentButton.Text = "Annuleren";
            this.CancelCreateStudentButton.UseVisualStyleBackColor = true;
            this.CancelCreateStudentButton.Click += new System.EventHandler(this.CancelCreateStudentButton_Click);
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateStudentButton.Location = new System.Drawing.Point(177, 301);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(97, 44);
            this.CreateStudentButton.TabIndex = 13;
            this.CreateStudentButton.Text = "Aanmaken";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // CreatePasswordTextbox
            // 
            this.CreatePasswordTextbox.Location = new System.Drawing.Point(140, 211);
            this.CreatePasswordTextbox.Name = "CreatePasswordTextbox";
            this.CreatePasswordTextbox.Size = new System.Drawing.Size(159, 23);
            this.CreatePasswordTextbox.TabIndex = 12;
            // 
            // CreateUsernameTextbox
            // 
            this.CreateUsernameTextbox.Location = new System.Drawing.Point(140, 170);
            this.CreateUsernameTextbox.Name = "CreateUsernameTextbox";
            this.CreateUsernameTextbox.Size = new System.Drawing.Size(159, 23);
            this.CreateUsernameTextbox.TabIndex = 11;
            // 
            // CreateEmailTextbox
            // 
            this.CreateEmailTextbox.Location = new System.Drawing.Point(140, 130);
            this.CreateEmailTextbox.Name = "CreateEmailTextbox";
            this.CreateEmailTextbox.Size = new System.Drawing.Size(159, 23);
            this.CreateEmailTextbox.TabIndex = 10;
            // 
            // CreateLastnameTextbox
            // 
            this.CreateLastnameTextbox.Location = new System.Drawing.Point(140, 91);
            this.CreateLastnameTextbox.Name = "CreateLastnameTextbox";
            this.CreateLastnameTextbox.Size = new System.Drawing.Size(159, 23);
            this.CreateLastnameTextbox.TabIndex = 9;
            // 
            // CreateFirstnameTextbox
            // 
            this.CreateFirstnameTextbox.Location = new System.Drawing.Point(140, 53);
            this.CreateFirstnameTextbox.Name = "CreateFirstnameTextbox";
            this.CreateFirstnameTextbox.Size = new System.Drawing.Size(159, 23);
            this.CreateFirstnameTextbox.TabIndex = 9;
            // 
            // CreatePasswordLabel
            // 
            this.CreatePasswordLabel.AutoSize = true;
            this.CreatePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePasswordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CreatePasswordLabel.Location = new System.Drawing.Point(15, 211);
            this.CreatePasswordLabel.Name = "CreatePasswordLabel";
            this.CreatePasswordLabel.Size = new System.Drawing.Size(98, 20);
            this.CreatePasswordLabel.TabIndex = 5;
            this.CreatePasswordLabel.Text = "Wachtwoord";
            // 
            // CreateUsernameLabel
            // 
            this.CreateUsernameLabel.AutoSize = true;
            this.CreateUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateUsernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CreateUsernameLabel.Location = new System.Drawing.Point(15, 169);
            this.CreateUsernameLabel.Name = "CreateUsernameLabel";
            this.CreateUsernameLabel.Size = new System.Drawing.Size(80, 20);
            this.CreateUsernameLabel.TabIndex = 4;
            this.CreateUsernameLabel.Text = "Username";
            // 
            // CreateEmailLabel
            // 
            this.CreateEmailLabel.AutoSize = true;
            this.CreateEmailLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateEmailLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CreateEmailLabel.Location = new System.Drawing.Point(15, 130);
            this.CreateEmailLabel.Name = "CreateEmailLabel";
            this.CreateEmailLabel.Size = new System.Drawing.Size(47, 20);
            this.CreateEmailLabel.TabIndex = 4;
            this.CreateEmailLabel.Text = "Email";
            // 
            // CreateLastnameLabel
            // 
            this.CreateLastnameLabel.AutoSize = true;
            this.CreateLastnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateLastnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CreateLastnameLabel.Location = new System.Drawing.Point(15, 90);
            this.CreateLastnameLabel.Name = "CreateLastnameLabel";
            this.CreateLastnameLabel.Size = new System.Drawing.Size(95, 20);
            this.CreateLastnameLabel.TabIndex = 4;
            this.CreateLastnameLabel.Text = "Achternaam";
            // 
            // CreateFirstnameLabel
            // 
            this.CreateFirstnameLabel.AutoSize = true;
            this.CreateFirstnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateFirstnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CreateFirstnameLabel.Location = new System.Drawing.Point(15, 52);
            this.CreateFirstnameLabel.Name = "CreateFirstnameLabel";
            this.CreateFirstnameLabel.Size = new System.Drawing.Size(81, 20);
            this.CreateFirstnameLabel.TabIndex = 4;
            this.CreateFirstnameLabel.Text = "Voornaam";
            // 
            // LoginScreenPicturebox
            // 
            this.LoginScreenPicturebox.Location = new System.Drawing.Point(92, 25);
            this.LoginScreenPicturebox.Name = "LoginScreenPicturebox";
            this.LoginScreenPicturebox.Size = new System.Drawing.Size(140, 107);
            this.LoginScreenPicturebox.TabIndex = 0;
            this.LoginScreenPicturebox.TabStop = false;
            // 
            // ForgotPasswordButton
            // 
            this.ForgotPasswordButton.FlatAppearance.BorderSize = 0;
            this.ForgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPasswordButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ForgotPasswordButton.Location = new System.Drawing.Point(340, 633);
            this.ForgotPasswordButton.Name = "ForgotPasswordButton";
            this.ForgotPasswordButton.Size = new System.Drawing.Size(290, 35);
            this.ForgotPasswordButton.TabIndex = 6;
            this.ForgotPasswordButton.Text = "Wachtwoord vergeten?";
            this.ForgotPasswordButton.UseVisualStyleBackColor = true;
            // 
            // LoginScreenCloseButton
            // 
            this.LoginScreenCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LoginScreenCloseButton.FlatAppearance.BorderSize = 0;
            this.LoginScreenCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginScreenCloseButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginScreenCloseButton.ForeColor = System.Drawing.Color.Red;
            this.LoginScreenCloseButton.Location = new System.Drawing.Point(1017, 12);
            this.LoginScreenCloseButton.Name = "LoginScreenCloseButton";
            this.LoginScreenCloseButton.Size = new System.Drawing.Size(67, 66);
            this.LoginScreenCloseButton.TabIndex = 7;
            this.LoginScreenCloseButton.Text = "X";
            this.LoginScreenCloseButton.UseVisualStyleBackColor = false;
            this.LoginScreenCloseButton.Click += new System.EventHandler(this.LoginScreenCloseButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CreateAccountButton.Location = new System.Drawing.Point(794, 633);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(290, 35);
            this.CreateAccountButton.TabIndex = 8;
            this.CreateAccountButton.Text = "Account aanmaken";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // WrongInlogMessageLabel
            // 
            this.WrongInlogMessageLabel.AutoSize = true;
            this.WrongInlogMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongInlogMessageLabel.Location = new System.Drawing.Point(700, 345);
            this.WrongInlogMessageLabel.Name = "WrongInlogMessageLabel";
            this.WrongInlogMessageLabel.Size = new System.Drawing.Size(184, 15);
            this.WrongInlogMessageLabel.TabIndex = 16;
            this.WrongInlogMessageLabel.Text = "Verkeerde inloggevens ingevoerd!";
            this.WrongInlogMessageLabel.Visible = false;
            // 
            // LoginScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1096, 689);
            this.Controls.Add(this.WrongInlogMessageLabel);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LoginScreenCloseButton);
            this.Controls.Add(this.ForgotPasswordButton);
            this.Controls.Add(this.LoginScreenPanel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Shown += new System.EventHandler(this.LoginScreenForm_Shown);
            this.LoginScreenPanel.ResumeLayout(false);
            this.CreateStudentPanel.ResumeLayout(false);
            this.CreateStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginScreenPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextbox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Panel LoginScreenPanel;
        private PictureBox LoginScreenPicturebox;
        private Button ForgotPasswordButton;
        private Button LoginScreenCloseButton;
        private Button CreateAccountButton;
        private Panel CreateStudentPanel;
        private Label CreatePasswordLabel;
        private Label CreateUsernameLabel;
        private Label CreateEmailLabel;
        private Label CreateLastnameLabel;
        private Label CreateFirstnameLabel;
        private TextBox CreatePasswordTextbox;
        private TextBox CreateUsernameTextbox;
        private TextBox CreateEmailTextbox;
        private TextBox CreateLastnameTextbox;
        private TextBox CreateFirstnameTextbox;
        private Button CreateStudentButton;
        private Button CancelCreateStudentButton;
        private Label CreateStudentMessageLabel;
        private Label WrongInlogMessageLabel;
    }
}