namespace Tietovisa
{
    partial class QuizBoolean
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
            buttonTrue = new Button();
            buttonFalse = new Button();
            labelQuestion = new Label();
            SuspendLayout();
            // 
            // buttonTrue
            // 
            buttonTrue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTrue.Location = new Point(46, 398);
            buttonTrue.Name = "buttonTrue";
            buttonTrue.Size = new Size(423, 157);
            buttonTrue.TabIndex = 0;
            buttonTrue.Text = "TRUE";
            buttonTrue.UseVisualStyleBackColor = true;
            buttonTrue.Click += buttonTrue_Click;
            // 
            // buttonFalse
            // 
            buttonFalse.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFalse.Location = new Point(608, 398);
            buttonFalse.Name = "buttonFalse";
            buttonFalse.Size = new Size(423, 157);
            buttonFalse.TabIndex = 0;
            buttonFalse.Text = "FALSE";
            buttonFalse.UseVisualStyleBackColor = true;
            buttonFalse.Click += buttonFalse_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.Location = new Point(46, 112);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(985, 123);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "ACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT PLACEHOLDERTEXT ";
            // 
            // QuizBoolean
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 650);
            Controls.Add(labelQuestion);
            Controls.Add(buttonFalse);
            Controls.Add(buttonTrue);
            Name = "QuizBoolean";
            Text = "QuizBoolean";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTrue;
        private Button buttonFalse;
        private Label labelQuestion;
    }
}