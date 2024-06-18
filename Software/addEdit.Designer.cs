namespace Software
{
    partial class addEdit
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
            txtName = new TextBox();
            txtCategory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSend = new Button();
            txtQuantity = new NumericUpDown();
            txtPrice = new NumericUpDown();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = SystemColors.InactiveCaption;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(106, 77);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name of the product";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(221, 20);
            txtName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCategory.BackColor = SystemColors.InactiveCaption;
            txtCategory.BorderStyle = BorderStyle.None;
            txtCategory.Cursor = Cursors.Hand;
            txtCategory.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(106, 145);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Category";
            txtCategory.RightToLeft = RightToLeft.No;
            txtCategory.Size = new Size(221, 20);
            txtCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(106, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(106, 113);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(106, 178);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = SystemColors.InactiveCaption;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Cursor = Cursors.Hand;
            txtDescription.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(106, 207);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description about the product.";
            txtDescription.RightToLeft = RightToLeft.No;
            txtDescription.Size = new Size(221, 20);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(106, 246);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(106, 322);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSend.BackColor = Color.LimeGreen;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(169, 410);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(84, 33);
            btnSend.TabIndex = 13;
            btnSend.Text = "Editar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.BackColor = SystemColors.InactiveCaption;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.InterceptArrowKeys = false;
            txtQuantity.Location = new Point(106, 280);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(221, 26);
            txtQuantity.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.BackColor = SystemColors.InactiveCaption;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Cursor = Cursors.Hand;
            txtPrice.DecimalPlaces = 2;
            txtPrice.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.InterceptArrowKeys = false;
            txtPrice.Location = new Point(106, 349);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(221, 26);
            txtPrice.TabIndex = 15;
            txtPrice.ThousandsSeparator = true;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(407, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 31);
            btnExit.TabIndex = 16;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // addEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(430, 510);
            Controls.Add(btnExit);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(btnSend);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addEdit";
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private Label label5;
        private Button btnSend;
        private NumericUpDown txtQuantity;
        private NumericUpDown txtPrice;
        private Button btnExit;
    }
}