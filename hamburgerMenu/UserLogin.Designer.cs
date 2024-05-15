namespace hamburgerMenu.UI
{
    partial class UserLogin
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
            label1 = new Label();
            label2 = new Label();
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 94);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 158);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(127, 91);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(100, 23);
            UsernameText.TabIndex = 2;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(127, 155);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(100, 23);
            PasswordText.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(268, 128);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 236);
            Controls.Add(LoginButton);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserLogin";
            Text = "Form4";
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private Button LoginButton;
    }
}