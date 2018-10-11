namespace FlashCards
{
    partial class ManageFlashCards
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
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wrongCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.correctCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.categoryFieldLabel = new System.Windows.Forms.Label();
            this.questionFieldLabel = new System.Windows.Forms.Label();
            this.answerFieldLabel = new System.Windows.Forms.Label();
            this.newRecord = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.idFieldLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.manageCategoriesButton = new System.Windows.Forms.Button();
            this.modifySelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.category,
            this.question,
            this.answer,
            this.wrongCount,
            this.correctCount});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 252);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 100;
            // 
            // question
            // 
            this.question.Text = "Question";
            this.question.Width = 200;
            // 
            // answer
            // 
            this.answer.Text = "Answer";
            this.answer.Width = 200;
            // 
            // wrongCount
            // 
            this.wrongCount.Text = "Wrong Count";
            this.wrongCount.Width = 100;
            // 
            // correctCount
            // 
            this.correctCount.Text = "Correct Count";
            this.correctCount.Width = 100;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(213, 132);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(250, 100);
            this.questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(521, 132);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(250, 100);
            this.answerTextBox.TabIndex = 3;
            // 
            // categoryFieldLabel
            // 
            this.categoryFieldLabel.AutoSize = true;
            this.categoryFieldLabel.Location = new System.Drawing.Point(210, 66);
            this.categoryFieldLabel.Name = "categoryFieldLabel";
            this.categoryFieldLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryFieldLabel.TabIndex = 4;
            this.categoryFieldLabel.Text = "Category";
            // 
            // questionFieldLabel
            // 
            this.questionFieldLabel.AutoSize = true;
            this.questionFieldLabel.Location = new System.Drawing.Point(158, 135);
            this.questionFieldLabel.Name = "questionFieldLabel";
            this.questionFieldLabel.Size = new System.Drawing.Size(49, 13);
            this.questionFieldLabel.TabIndex = 5;
            this.questionFieldLabel.Text = "Question";
            // 
            // answerFieldLabel
            // 
            this.answerFieldLabel.AutoSize = true;
            this.answerFieldLabel.Location = new System.Drawing.Point(473, 135);
            this.answerFieldLabel.Name = "answerFieldLabel";
            this.answerFieldLabel.Size = new System.Drawing.Size(42, 13);
            this.answerFieldLabel.TabIndex = 6;
            this.answerFieldLabel.Text = "Answer";
            // 
            // newRecord
            // 
            this.newRecord.Location = new System.Drawing.Point(13, 29);
            this.newRecord.Name = "newRecord";
            this.newRecord.Size = new System.Drawing.Size(110, 23);
            this.newRecord.TabIndex = 7;
            this.newRecord.Text = "New +";
            this.newRecord.UseVisualStyleBackColor = true;
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(13, 58);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(110, 23);
            this.saveRecord.TabIndex = 8;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            // 
            // idFieldLabel
            // 
            this.idFieldLabel.AutoSize = true;
            this.idFieldLabel.Location = new System.Drawing.Point(213, 40);
            this.idFieldLabel.Name = "idFieldLabel";
            this.idFieldLabel.Size = new System.Drawing.Size(16, 13);
            this.idFieldLabel.TabIndex = 9;
            this.idFieldLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(265, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(266, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 30);
            this.listBox1.TabIndex = 11;
            // 
            // manageCategoriesButton
            // 
            this.manageCategoriesButton.Location = new System.Drawing.Point(13, 87);
            this.manageCategoriesButton.Name = "manageCategoriesButton";
            this.manageCategoriesButton.Size = new System.Drawing.Size(110, 23);
            this.manageCategoriesButton.TabIndex = 12;
            this.manageCategoriesButton.Text = "Manage Categories";
            this.manageCategoriesButton.UseVisualStyleBackColor = true;
            this.manageCategoriesButton.Click += new System.EventHandler(this.manageCategoriesButton_Click);
            // 
            // modifySelectionButton
            // 
            this.modifySelectionButton.Location = new System.Drawing.Point(13, 223);
            this.modifySelectionButton.Name = "modifySelectionButton";
            this.modifySelectionButton.Size = new System.Drawing.Size(110, 23);
            this.modifySelectionButton.TabIndex = 13;
            this.modifySelectionButton.Text = "Modify Selected";
            this.modifySelectionButton.UseVisualStyleBackColor = true;
            // 
            // ManageFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifySelectionButton);
            this.Controls.Add(this.manageCategoriesButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idFieldLabel);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.newRecord);
            this.Controls.Add(this.answerFieldLabel);
            this.Controls.Add(this.questionFieldLabel);
            this.Controls.Add(this.categoryFieldLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.listView1);
            this.Name = "ManageFlashCards";
            this.Text = "ManageFlashCards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader answer;
        private System.Windows.Forms.ColumnHeader wrongCount;
        private System.Windows.Forms.ColumnHeader correctCount;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label categoryFieldLabel;
        private System.Windows.Forms.Label questionFieldLabel;
        private System.Windows.Forms.Label answerFieldLabel;
        private System.Windows.Forms.Button newRecord;
        private System.Windows.Forms.Button saveRecord;
        private System.Windows.Forms.Label idFieldLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button manageCategoriesButton;
        private System.Windows.Forms.Button modifySelectionButton;
    }
}