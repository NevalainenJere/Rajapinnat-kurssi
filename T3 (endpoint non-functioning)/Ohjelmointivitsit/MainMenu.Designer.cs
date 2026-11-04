namespace Ohjelmointivitsit
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
            buttonJokeGenerate = new Button();
            labelJokeDisplay = new Label();
            SuspendLayout();
            // 
            // buttonJokeGenerate
            // 
            buttonJokeGenerate.BackColor = SystemColors.ActiveCaption;
            buttonJokeGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJokeGenerate.Location = new Point(283, 53);
            buttonJokeGenerate.Name = "buttonJokeGenerate";
            buttonJokeGenerate.Size = new Size(172, 61);
            buttonJokeGenerate.TabIndex = 0;
            buttonJokeGenerate.Text = "Generoi vitsi";
            buttonJokeGenerate.UseVisualStyleBackColor = false;
            buttonJokeGenerate.Click += this.buttonJokeGenerate_Click;
            // 
            // labelJokeDisplay
            // 
            labelJokeDisplay.BackColor = SystemColors.ControlLightLight;
            labelJokeDisplay.BorderStyle = BorderStyle.FixedSingle;
            labelJokeDisplay.Location = new Point(92, 150);
            labelJokeDisplay.Name = "labelJokeDisplay";
            labelJokeDisplay.Size = new Size(562, 259);
            labelJokeDisplay.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 455);
            Controls.Add(labelJokeDisplay);
            Controls.Add(buttonJokeGenerate);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainMenu";
            Text = "Vitsigeneraattori";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJokeGenerate;
        private Label labelJokeDisplay;
    }
}
