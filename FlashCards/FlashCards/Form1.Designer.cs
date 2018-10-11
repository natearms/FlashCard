namespace FlashCards
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.answer = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.nextFlashCard = new System.Windows.Forms.Button();
            this.previousFlashCard = new System.Windows.Forms.Button();
            this.flashCardProgress = new System.Windows.Forms.Label();
            this.showAnswer = new System.Windows.Forms.Button();
            this.correctGuess = new System.Windows.Forms.Button();
            this.wrongGuess = new System.Windows.Forms.Button();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFlashCardRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigToolStripMenuItem
            // 
            this.openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            this.openConfigToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openConfigToolStripMenuItem.Text = "Open Config";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(544, 145);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(42, 13);
            this.answer.TabIndex = 2;
            this.answer.Text = "Answer";
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(544, 109);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(49, 13);
            this.question.TabIndex = 3;
            this.question.Text = "Question";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // nextFlashCard
            // 
            this.nextFlashCard.Location = new System.Drawing.Point(713, 182);
            this.nextFlashCard.Name = "nextFlashCard";
            this.nextFlashCard.Size = new System.Drawing.Size(75, 23);
            this.nextFlashCard.TabIndex = 4;
            this.nextFlashCard.Text = "Next";
            this.nextFlashCard.UseVisualStyleBackColor = true;
            // 
            // previousFlashCard
            // 
            this.previousFlashCard.Location = new System.Drawing.Point(336, 182);
            this.previousFlashCard.Name = "previousFlashCard";
            this.previousFlashCard.Size = new System.Drawing.Size(75, 23);
            this.previousFlashCard.TabIndex = 5;
            this.previousFlashCard.Text = "Previous";
            this.previousFlashCard.UseVisualStyleBackColor = true;
            // 
            // flashCardProgress
            // 
            this.flashCardProgress.AutoSize = true;
            this.flashCardProgress.Location = new System.Drawing.Point(713, 66);
            this.flashCardProgress.Name = "flashCardProgress";
            this.flashCardProgress.Size = new System.Drawing.Size(22, 13);
            this.flashCardProgress.TabIndex = 6;
            this.flashCardProgress.Text = "x/x";
            // 
            // showAnswer
            // 
            this.showAnswer.Location = new System.Drawing.Point(526, 182);
            this.showAnswer.Name = "showAnswer";
            this.showAnswer.Size = new System.Drawing.Size(86, 23);
            this.showAnswer.TabIndex = 7;
            this.showAnswer.Text = "Show Answer";
            this.showAnswer.UseVisualStyleBackColor = true;
            // 
            // correctGuess
            // 
            this.correctGuess.Location = new System.Drawing.Point(404, 235);
            this.correctGuess.Name = "correctGuess";
            this.correctGuess.Size = new System.Drawing.Size(75, 23);
            this.correctGuess.TabIndex = 8;
            this.correctGuess.Text = "Correct!";
            this.correctGuess.UseVisualStyleBackColor = true;
            // 
            // wrongGuess
            // 
            this.wrongGuess.Location = new System.Drawing.Point(632, 234);
            this.wrongGuess.Name = "wrongGuess";
            this.wrongGuess.Size = new System.Drawing.Size(75, 23);
            this.wrongGuess.TabIndex = 9;
            this.wrongGuess.Text = "Wrong :(";
            this.wrongGuess.UseVisualStyleBackColor = true;
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFlashCardRecordsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // manageFlashCardRecordsToolStripMenuItem
            // 
            this.manageFlashCardRecordsToolStripMenuItem.Name = "manageFlashCardRecordsToolStripMenuItem";
            this.manageFlashCardRecordsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.manageFlashCardRecordsToolStripMenuItem.Text = "Manage Flash Card Records";
            this.manageFlashCardRecordsToolStripMenuItem.Click += new System.EventHandler(this.manageFlashCardRecordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wrongGuess);
            this.Controls.Add(this.correctGuess);
            this.Controls.Add(this.showAnswer);
            this.Controls.Add(this.flashCardProgress);
            this.Controls.Add(this.previousFlashCard);
            this.Controls.Add(this.nextFlashCard);
            this.Controls.Add(this.question);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button nextFlashCard;
        private System.Windows.Forms.Button previousFlashCard;
        private System.Windows.Forms.Label flashCardProgress;
        private System.Windows.Forms.Button showAnswer;
        private System.Windows.Forms.Button correctGuess;
        private System.Windows.Forms.Button wrongGuess;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFlashCardRecordsToolStripMenuItem;
    }
}

