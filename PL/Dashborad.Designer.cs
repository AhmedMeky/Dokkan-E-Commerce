namespace PL
{
    partial class Dashborad
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tb_dashborad = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dtgv_category = new Guna.UI2.WinForms.Guna2DataGridView();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl2 = new TabControl();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            menuStrip2 = new MenuStrip();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            tb_dashborad.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_category).BeginInit();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tb_dashborad
            // 
            tb_dashborad.Alignment = TabAlignment.Left;
            tb_dashborad.Controls.Add(tabPage5);
            tb_dashborad.Controls.Add(tabPage6);
            tb_dashborad.Controls.Add(tabPage1);
            tb_dashborad.Controls.Add(tabPage2);
            tb_dashborad.ItemSize = new Size(180, 40);
            tb_dashborad.Location = new Point(1, 5);
            tb_dashborad.Name = "tb_dashborad";
            tb_dashborad.SelectedIndex = 0;
            tb_dashborad.Size = new Size(913, 595);
            tb_dashborad.TabButtonHoverState.BorderColor = Color.Empty;
            tb_dashborad.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tb_dashborad.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tb_dashborad.TabButtonHoverState.ForeColor = Color.White;
            tb_dashborad.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tb_dashborad.TabButtonIdleState.BorderColor = Color.Empty;
            tb_dashborad.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tb_dashborad.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tb_dashborad.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tb_dashborad.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tb_dashborad.TabButtonSelectedState.BorderColor = Color.Empty;
            tb_dashborad.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tb_dashborad.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tb_dashborad.TabButtonSelectedState.ForeColor = Color.White;
            tb_dashborad.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tb_dashborad.TabButtonSize = new Size(180, 40);
            tb_dashborad.TabIndex = 0;
            tb_dashborad.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tabControl1);
            tabPage5.Location = new Point(184, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(725, 587);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Orders";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(guna2DataGridView1);
            tabPage6.Controls.Add(menuStrip2);
            tabPage6.Location = new Point(184, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(725, 587);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Product";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(184, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(725, 587);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgv_category);
            tabPage2.Controls.Add(menuStrip1);
            tabPage2.Location = new Point(184, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(725, 587);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Category";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(719, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // dtgv_category
            // 
            dtgv_category.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = Color.White;
            dtgv_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dtgv_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dtgv_category.ColumnHeadersHeight = 4;
            dtgv_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dtgv_category.DefaultCellStyle = dataGridViewCellStyle12;
            dtgv_category.GridColor = Color.FromArgb(231, 229, 255);
            dtgv_category.Location = new Point(0, 34);
            dtgv_category.Name = "dtgv_category";
            dtgv_category.RowHeadersVisible = false;
            dtgv_category.RowHeadersWidth = 51;
            dtgv_category.Size = new Size(725, 531);
            dtgv_category.TabIndex = 1;
            dtgv_category.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgv_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_category.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgv_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgv_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgv_category.ThemeStyle.BackColor = Color.White;
            dtgv_category.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dtgv_category.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dtgv_category.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv_category.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dtgv_category.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dtgv_category.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_category.ThemeStyle.HeaderStyle.Height = 4;
            dtgv_category.ThemeStyle.ReadOnly = false;
            dtgv_category.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgv_category.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_category.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dtgv_category.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgv_category.ThemeStyle.RowsStyle.Height = 29;
            dtgv_category.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dtgv_category.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 595);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(717, 558);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(717, 562);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(729, 591);
            tabControl2.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(721, 558);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(242, 92);
            tabPage8.TabIndex = 1;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem1 });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(719, 28);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(54, 24);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(3, 34);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(719, 553);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Dashborad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tb_dashborad);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashborad";
            Text = "Dashborad";
            tb_dashborad.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_category).EndInit();
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tb_dashborad;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_category;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private TabControl tabControl2;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}