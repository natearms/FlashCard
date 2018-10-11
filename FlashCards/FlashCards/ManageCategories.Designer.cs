namespace FlashCards
{
    partial class ManageCategories
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idLabelText = new System.Windows.Forms.Label();
            this.categoryLabelText = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.newCategory = new System.Windows.Forms.Button();
            this.saveCategory = new System.Windows.Forms.Button();
            this.modifyCateogry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.categoryName});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 270);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 168);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // categoryName
            // 
            this.categoryName.Text = "Category";
            this.categoryName.Width = 200;
            // 
            // idLabelText
            // 
            this.idLabelText.AutoSize = true;
            this.idLabelText.Location = new System.Drawing.Point(163, 16);
            this.idLabelText.Name = "idLabelText";
            this.idLabelText.Size = new System.Drawing.Size(18, 13);
            this.idLabelText.TabIndex = 1;
            this.idLabelText.Text = "ID";
            // 
            // categoryLabelText
            // 
            this.categoryLabelText.AutoSize = true;
            this.categoryLabelText.Location = new System.Drawing.Point(132, 43);
            this.categoryLabelText.Name = "categoryLabelText";
            this.categoryLabelText.Size = new System.Drawing.Size(49, 13);
            this.categoryLabelText.TabIndex = 2;
            this.categoryLabelText.Text = "Category";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(187, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(187, 39);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 4;
            // 
            // newCategory
            // 
            this.newCategory.Location = new System.Drawing.Point(13, 16);
            this.newCategory.Name = "newCategory";
            this.newCategory.Size = new System.Drawing.Size(75, 23);
            this.newCategory.TabIndex = 5;
            this.newCategory.Text = "New +";
            this.newCategory.UseVisualStyleBackColor = true;
            // 
            // saveCategory
            // 
            this.saveCategory.Location = new System.Drawing.Point(13, 46);
            this.saveCategory.Name = "saveCategory";
            this.saveCategory.Size = new System.Drawing.Size(75, 23);
            this.saveCategory.TabIndex = 6;
            this.saveCategory.Text = "Save";
            this.saveCategory.UseVisualStyleBackColor = true;
            this.saveCategory.Click += new System.EventHandler(this.saveCategory_Click);
            // 
            // modifyCateogry
            // 
            this.modifyCateogry.Location = new System.Drawing.Point(13, 241);
            this.modifyCateogry.Name = "modifyCateogry";
            this.modifyCateogry.Size = new System.Drawing.Size(107, 23);
            this.modifyCateogry.TabIndex = 7;
            this.modifyCateogry.Text = "Modify Selected";
            this.modifyCateogry.UseVisualStyleBackColor = true;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 460);
            this.Controls.Add(this.modifyCateogry);
            this.Controls.Add(this.saveCategory);
            this.Controls.Add(this.newCategory);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.categoryLabelText);
            this.Controls.Add(this.idLabelText);
            this.Controls.Add(this.listView1);
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader categoryName;
        private System.Windows.Forms.Label idLabelText;
        private System.Windows.Forms.Label categoryLabelText;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button newCategory;
        private System.Windows.Forms.Button saveCategory;
        private System.Windows.Forms.Button modifyCateogry;
    }
}