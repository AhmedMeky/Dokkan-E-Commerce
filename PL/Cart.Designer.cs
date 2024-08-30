namespace PL
{
    partial class Cart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CartList = new ListBox();
            SuspendLayout();
            // 
            // CartList
            // 
            CartList.FormattingEnabled = true;
            CartList.ItemHeight = 15;
            CartList.Location = new Point(3, 3);
            CartList.Name = "CartList";
            CartList.Size = new Size(369, 394);
            CartList.TabIndex = 0;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(CartList);
            Name = "Cart";
            Size = new Size(600, 400);
            Load += Cart_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox CartList;
    }
}
