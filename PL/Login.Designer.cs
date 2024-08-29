namespace PL
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
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            btnSign = new Button();
            label3 = new Label();
            Error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 264);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 193);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // username
            // 
            username.Location = new Point(228, 211);
            username.Name = "username";
            username.Size = new Size(220, 23);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(228, 282);
            password.Name = "password";
            password.Size = new Size(220, 23);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(286, 327);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(102, 32);
            btnSign.TabIndex = 4;
            btnSign.Text = "Sign In";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(204, 21);
            label3.Name = "label3";
            label3.Size = new Size(268, 62);
            label3.TabIndex = 5;
            label3.Text = "ElDOKKAN";
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.BackColor = Color.Red;
            Error.Font = new Font("PT Bold Arch", 30F);
            Error.ForeColor = Color.Transparent;
            Error.Location = new Point(153, 105);
            Error.Name = "Error";
            Error.Size = new Size(380, 71);
            Error.TabIndex = 6;
            Error.Text = "Inavalid Login";
            Error.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Error);
            Controls.Add(label3);
            Controls.Add(btnSign);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button btnSign;
        private Label label3;
        private Label Error;
    }
}
