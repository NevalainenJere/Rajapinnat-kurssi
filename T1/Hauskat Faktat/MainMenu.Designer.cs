namespace Hauskat_Faktat
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
            buttonGETFact = new Button();
            buttonGETBreed = new Button();
            labelCatInfo = new Label();
            pictureBoxCat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).BeginInit();
            SuspendLayout();
            // 
            // buttonGETFact
            // 
            buttonGETFact.Location = new Point(77, 58);
            buttonGETFact.Name = "buttonGETFact";
            buttonGETFact.Size = new Size(164, 29);
            buttonGETFact.TabIndex = 0;
            buttonGETFact.Text = "Random Cat Fact";
            buttonGETFact.UseVisualStyleBackColor = true;
            // 
            // buttonGETBreed
            // 
            buttonGETBreed.Location = new Point(479, 58);
            buttonGETBreed.Name = "buttonGETBreed";
            buttonGETBreed.Size = new Size(164, 29);
            buttonGETBreed.TabIndex = 1;
            buttonGETBreed.Text = "Random Cat Breed";
            buttonGETBreed.UseVisualStyleBackColor = true;
            // 
            // labelCatInfo
            // 
            labelCatInfo.BackColor = Color.White;
            labelCatInfo.BorderStyle = BorderStyle.FixedSingle;
            labelCatInfo.Enabled = false;
            labelCatInfo.Location = new Point(88, 136);
            labelCatInfo.Name = "labelCatInfo";
            labelCatInfo.Size = new Size(555, 236);
            labelCatInfo.TabIndex = 2;
            labelCatInfo.Text = ".";
            // 
            // pictureBoxCat
            // 
            pictureBoxCat.BackColor = Color.Transparent;
            pictureBoxCat.Image = Properties.Resources.cat_image_T1;
            pictureBoxCat.InitialImage = Properties.Resources.cat_image_T1;
            pictureBoxCat.Location = new Point(307, 14);
            pictureBoxCat.Name = "pictureBoxCat";
            pictureBoxCat.Size = new Size(110, 110);
            pictureBoxCat.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCat.TabIndex = 3;
            pictureBoxCat.TabStop = false;
            pictureBoxCat.Click += pictureBoxCat_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(737, 399);
            Controls.Add(pictureBoxCat);
            Controls.Add(labelCatInfo);
            Controls.Add(buttonGETBreed);
            Controls.Add(buttonGETFact);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGETFact;
        private Button buttonGETBreed;
        private Label labelCatInfo;
        private PictureBox pictureBoxCat;
    }
}
