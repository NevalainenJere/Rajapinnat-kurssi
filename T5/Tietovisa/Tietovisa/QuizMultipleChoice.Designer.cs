namespace Tietovisa
{
    partial class QuizMultipleChoice
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
            buttonAnswer1 = new Button();
            buttonAnswer2 = new Button();
            buttonAnswer3 = new Button();
            buttonAnswer4 = new Button();
            labelQuestionPointer = new Label();
            labelQuestion = new Label();
            SuspendLayout();
            // 
            // buttonAnswer1
            // 
            buttonAnswer1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnswer1.Location = new Point(202, 203);
            buttonAnswer1.Name = "buttonAnswer1";
            buttonAnswer1.Size = new Size(673, 86);
            buttonAnswer1.TabIndex = 0;
            buttonAnswer1.Text = "button1";
            buttonAnswer1.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer2
            // 
            buttonAnswer2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnswer2.Location = new Point(202, 295);
            buttonAnswer2.Name = "buttonAnswer2";
            buttonAnswer2.Size = new Size(673, 86);
            buttonAnswer2.TabIndex = 0;
            buttonAnswer2.Text = "button1";
            buttonAnswer2.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer3
            // 
            buttonAnswer3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnswer3.Location = new Point(202, 387);
            buttonAnswer3.Name = "buttonAnswer3";
            buttonAnswer3.Size = new Size(673, 86);
            buttonAnswer3.TabIndex = 0;
            buttonAnswer3.Text = "button1";
            buttonAnswer3.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer4
            // 
            buttonAnswer4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnswer4.Location = new Point(202, 479);
            buttonAnswer4.Name = "buttonAnswer4";
            buttonAnswer4.Size = new Size(673, 86);
            buttonAnswer4.TabIndex = 0;
            buttonAnswer4.Text = "button1";
            buttonAnswer4.UseVisualStyleBackColor = true;
            // 
            // labelQuestionPointer
            // 
            labelQuestionPointer.AutoSize = true;
            labelQuestionPointer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestionPointer.Location = new Point(76, 91);
            labelQuestionPointer.Name = "labelQuestionPointer";
            labelQuestionPointer.Size = new Size(102, 28);
            labelQuestionPointer.TabIndex = 1;
            labelQuestionPointer.Text = "Question:";
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(202, 91);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(774, 28);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT";
            // 
            // QuizMultipleChoice
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1086, 650);
            Controls.Add(labelQuestion);
            Controls.Add(labelQuestionPointer);
            Controls.Add(buttonAnswer4);
            Controls.Add(buttonAnswer3);
            Controls.Add(buttonAnswer2);
            Controls.Add(buttonAnswer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "QuizMultipleChoice";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnswer1;
        private Button buttonAnswer2;
        private Button buttonAnswer3;
        private Button buttonAnswer4;
        private Label labelQuestionPointer;
        private Label labelQuestion;
    }
}