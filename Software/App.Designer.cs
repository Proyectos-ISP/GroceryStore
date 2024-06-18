namespace Software
{
    partial class App
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

        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            panel2 = new Panel();
            btnAddProduct = new Button();
            btnList = new Button();
            btnHome = new Button();
            pictureBox1 = new PictureBox();
            infoPanel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(btnAddProduct);
            panel2.Controls.Add(btnList);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 780);
            panel2.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.InactiveBorder;
            btnAddProduct.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = SystemColors.ActiveCaptionText;
            btnAddProduct.Image = Properties.Resources.Add;
            btnAddProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProduct.Location = new Point(0, 217);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.RightToLeft = RightToLeft.No;
            btnAddProduct.Size = new Size(195, 43);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.TextAlign = ContentAlignment.MiddleRight;
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnList
            // 
            btnList.BackColor = SystemColors.InactiveBorder;
            btnList.BackgroundImageLayout = ImageLayout.Zoom;
            btnList.FlatAppearance.BorderSize = 0;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.ForeColor = SystemColors.ActiveCaptionText;
            btnList.Image = Properties.Resources.MaterialSymbolsEventListSharp;
            btnList.ImageAlign = ContentAlignment.MiddleLeft;
            btnList.Location = new Point(0, 168);
            btnList.Name = "btnList";
            btnList.RightToLeft = RightToLeft.No;
            btnList.Size = new Size(195, 43);
            btnList.TabIndex = 2;
            btnList.Text = "Products";
            btnList.TextAlign = ContentAlignment.MiddleRight;
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.InactiveCaption;
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = Properties.Resources.Home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 119);
            btnHome.Name = "btnHome";
            btnHome.RightToLeft = RightToLeft.No;
            btnHome.Size = new Size(195, 43);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(47, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // infoPanel
            // 
            infoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoPanel.AutoSize = true;
            infoPanel.Location = new Point(194, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(851, 780);
            infoPanel.TabIndex = 1;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 780);
            Controls.Add(infoPanel);
            Controls.Add(panel2);
            Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnHome;
        private Panel infoPanel;
        private Button btnList;
        private Button btnAddProduct;
    }
}
