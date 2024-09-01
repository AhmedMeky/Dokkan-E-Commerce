namespace PL
{
    partial class FrontEnd
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
            panel1 = new Panel();
            logBtn = new Button();
            AboutBtn = new Button();
            CartBtn = new Button();
            ProductBtn = new Button();
            panel2 = new Panel();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            PanelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(logBtn);
            panel1.Controls.Add(AboutBtn);
            panel1.Controls.Add(CartBtn);
            panel1.Controls.Add(ProductBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 721);
            panel1.TabIndex = 0;
            // 
            // logBtn
            // 
            logBtn.FlatStyle = FlatStyle.Flat;
            logBtn.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logBtn.ForeColor = SystemColors.ButtonHighlight;
            logBtn.Location = new Point(0, 307);
            logBtn.Margin = new Padding(3, 4, 3, 4);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(232, 52);
            logBtn.TabIndex = 5;
            logBtn.Text = "Log In ";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += logBtn_Click;
            // 
            // AboutBtn
            // 
            AboutBtn.FlatStyle = FlatStyle.Flat;
            AboutBtn.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutBtn.ForeColor = SystemColors.ButtonHighlight;
            AboutBtn.Location = new Point(0, 247);
            AboutBtn.Margin = new Padding(3, 4, 3, 4);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(232, 52);
            AboutBtn.TabIndex = 4;
            AboutBtn.Text = "About";
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // CartBtn
            // 
            CartBtn.FlatStyle = FlatStyle.Flat;
            CartBtn.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CartBtn.ForeColor = SystemColors.ButtonHighlight;
            CartBtn.Location = new Point(0, 187);
            CartBtn.Margin = new Padding(3, 4, 3, 4);
            CartBtn.Name = "CartBtn";
            CartBtn.Size = new Size(232, 52);
            CartBtn.TabIndex = 3;
            CartBtn.Text = "Cart";
            CartBtn.UseVisualStyleBackColor = true;
            CartBtn.Click += CartBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.FlatStyle = FlatStyle.Flat;
            ProductBtn.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductBtn.ForeColor = SystemColors.ButtonHighlight;
            ProductBtn.Location = new Point(0, 127);
            ProductBtn.Margin = new Padding(3, 4, 3, 4);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(232, 52);
            ProductBtn.TabIndex = 2;
            ProductBtn.Text = "Product";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(232, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 13);
            panel2.TabIndex = 1;
            // 
            // PanelMain
            // 
            PanelMain.Location = new Point(232, 127);
            PanelMain.Margin = new Padding(3, 4, 3, 4);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(784, 595);
            PanelMain.TabIndex = 0;
            // 
            // FrontEnd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 721);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrontEnd";
            Text = "FrontEnd";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ProductBtn;
        private Button logBtn;
        private Button AboutBtn;
        private Button CartBtn;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel PanelMain;
    }
}