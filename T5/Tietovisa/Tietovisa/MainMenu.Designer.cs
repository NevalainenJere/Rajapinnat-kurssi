namespace Tietovisa
{
    partial class MainMenu
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
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            labelNumberOfQuestions = new Label();
            labelCategory = new Label();
            labelQuestionType = new Label();
            labelDifficulty = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxQuestionType = new ComboBox();
            comboBoxDifficulty = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(470, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // labelNumberOfQuestions
            // 
            labelNumberOfQuestions.AutoSize = true;
            labelNumberOfQuestions.Location = new Point(313, 245);
            labelNumberOfQuestions.Name = "labelNumberOfQuestions";
            labelNumberOfQuestions.Size = new Size(151, 20);
            labelNumberOfQuestions.TabIndex = 1;
            labelNumberOfQuestions.Text = "Number of questions:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(313, 295);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(72, 20);
            labelCategory.TabIndex = 1;
            labelCategory.Text = "Category:";
            // 
            // labelQuestionType
            // 
            labelQuestionType.AutoSize = true;
            labelQuestionType.Location = new Point(313, 350);
            labelQuestionType.Name = "labelQuestionType";
            labelQuestionType.Size = new Size(104, 20);
            labelQuestionType.TabIndex = 1;
            labelQuestionType.Text = "Question type:";
            // 
            // labelDifficulty
            // 
            labelDifficulty.AutoSize = true;
            labelDifficulty.Location = new Point(313, 400);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new Size(72, 20);
            labelDifficulty.TabIndex = 1;
            labelDifficulty.Text = "Difficulty:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(470, 292);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 0;
            // 
            // comboBoxQuestionType
            // 
            comboBoxQuestionType.FormattingEnabled = true;
            comboBoxQuestionType.Location = new Point(470, 347);
            comboBoxQuestionType.Name = "comboBoxQuestionType";
            comboBoxQuestionType.Size = new Size(151, 28);
            comboBoxQuestionType.TabIndex = 0;
            // 
            // comboBoxDifficulty
            // 
            comboBoxDifficulty.FormattingEnabled = true;
            comboBoxDifficulty.Location = new Point(470, 397);
            comboBoxDifficulty.Name = "comboBoxDifficulty";
            comboBoxDifficulty.Size = new Size(151, 28);
            comboBoxDifficulty.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 514);
            Controls.Add(labelDifficulty);
            Controls.Add(labelQuestionType);
            Controls.Add(labelCategory);
            Controls.Add(labelNumberOfQuestions);
            Controls.Add(comboBoxDifficulty);
            Controls.Add(comboBoxQuestionType);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelNumberOfQuestions;
        private Label labelCategory;
        private Label labelQuestionType;
        private Label labelDifficulty;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxQuestionType;
        private ComboBox comboBoxDifficulty;
    }
}
