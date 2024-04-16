namespace UchetZayavok.Forms
{
    partial class AuthorizationForm
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
            loginTextBox = new TextBox();
            passwTextBox = new TextBox();
            entryBtn = new Button();
            signUpBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(152, 116);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(131, 23);
            loginTextBox.TabIndex = 0;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // passwTextBox
            // 
            passwTextBox.Location = new Point(152, 164);
            passwTextBox.Name = "passwTextBox";
            passwTextBox.Size = new Size(131, 23);
            passwTextBox.TabIndex = 1;
            passwTextBox.TextChanged += passwTextBox_TextChanged;
            // 
            // entryBtn
            // 
            entryBtn.Enabled = false;
            entryBtn.Location = new Point(152, 193);
            entryBtn.Name = "entryBtn";
            entryBtn.Size = new Size(131, 27);
            entryBtn.TabIndex = 2;
            entryBtn.Text = "Войти";
            entryBtn.UseVisualStyleBackColor = true;
            entryBtn.Click += entryBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(152, 247);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(131, 27);
            signUpBtn.TabIndex = 3;
            signUpBtn.Text = "Зарегистрироваться";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 98);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 146);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль:";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 381);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUpBtn);
            Controls.Add(entryBtn);
            Controls.Add(passwTextBox);
            Controls.Add(loginTextBox);
            MaximizeBox = false;
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwTextBox;
        private Button entryBtn;
        private Button signUpBtn;
        private Label label1;
        private Label label2;
    }
}