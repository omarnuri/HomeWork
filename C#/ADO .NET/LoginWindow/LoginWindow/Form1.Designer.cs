namespace LoginWindow
{
    partial class Form1
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
            loginTextBox = new TextBox();
            label1 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(281, 175);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(194, 23);
            loginTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 147);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(281, 223);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(194, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 203);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(335, 252);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.ForeColor = Color.Red;
            messageLabel.Location = new Point(335, 290);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 15);
            messageLabel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(messageLabel);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(loginTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private Label label1;
        private TextBox passwordTextBox;
        private Label label2;
        private Button loginButton;
        private Label messageLabel;
    }
}