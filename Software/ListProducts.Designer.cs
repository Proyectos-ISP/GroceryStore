namespace Software
{
    partial class ListProducts
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
            dataProductsView = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProductsView).BeginInit();
            SuspendLayout();
            // 
            // dataProductsView
            // 
            dataProductsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataProductsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductsView.Location = new Point(0, 0);
            dataProductsView.Name = "dataProductsView";
            dataProductsView.ReadOnly = true;
            dataProductsView.RowHeadersVisible = false;
            dataProductsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProductsView.Size = new Size(715, 340);
            dataProductsView.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.Orange;
            btnEdit.BackgroundImageLayout = ImageLayout.Center;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.ImageAlign = ContentAlignment.BottomLeft;
            btnEdit.Location = new Point(721, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(721, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnRemove_Click;
            // 
            // ListProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dataProductsView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListProducts";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataProductsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataProductsView;
        private Button btnEdit;
        private Button btnDelete;
    }
}