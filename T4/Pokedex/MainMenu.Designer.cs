namespace Pokedex
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
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            buttonSearch = new Button();
            pictureNormal = new PictureBox();
            pictureShiny = new PictureBox();
            labelNormal = new Label();
            labelShiny = new Label();
            buttonPrevious = new Button();
            buttonNext = new Button();
            richTextBoxInfo = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiny).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(316, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(290, 27);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(34, 34);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(276, 24);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Hae Pokémon nimellä tai ID:llä:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Gold;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(620, 33);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Hae";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // pictureNormal
            // 
            pictureNormal.BackColor = Color.Firebrick;
            pictureNormal.Image = Properties.Resources.no_pokemon_selected;
            pictureNormal.Location = new Point(53, 286);
            pictureNormal.Margin = new Padding(2);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(160, 160);
            pictureNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNormal.TabIndex = 4;
            pictureNormal.TabStop = false;
            // 
            // pictureShiny
            // 
            pictureShiny.BackColor = Color.Firebrick;
            pictureShiny.Image = Properties.Resources.no_pokemon_selected;
            pictureShiny.Location = new Point(278, 286);
            pictureShiny.Margin = new Padding(2);
            pictureShiny.Name = "pictureShiny";
            pictureShiny.Size = new Size(160, 160);
            pictureShiny.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureShiny.TabIndex = 4;
            pictureShiny.TabStop = false;
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelNormal.ForeColor = Color.White;
            labelNormal.Location = new Point(53, 259);
            labelNormal.Margin = new Padding(2, 0, 2, 0);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(84, 25);
            labelNormal.TabIndex = 5;
            labelNormal.Text = "Normal:";
            // 
            // labelShiny
            // 
            labelShiny.AutoSize = true;
            labelShiny.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelShiny.ForeColor = Color.White;
            labelShiny.Location = new Point(278, 259);
            labelShiny.Margin = new Padding(2, 0, 2, 0);
            labelShiny.Name = "labelShiny";
            labelShiny.Size = new Size(66, 25);
            labelShiny.TabIndex = 5;
            labelShiny.Text = "Shiny:";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrevious.Location = new Point(498, 286);
            buttonPrevious.Margin = new Padding(2);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(235, 70);
            buttonPrevious.TabIndex = 6;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonNext.Location = new Point(498, 375);
            buttonNext.Margin = new Padding(2);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(235, 70);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Location = new Point(34, 71);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.Size = new Size(680, 175);
            richTextBoxInfo.TabIndex = 7;
            richTextBoxInfo.Text = "";
            richTextBoxInfo.Enter += richTextBoxInfo_Enter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(776, 466);
            Controls.Add(richTextBoxInfo);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(labelShiny);
            Controls.Add(labelNormal);
            Controls.Add(pictureShiny);
            Controls.Add(pictureNormal);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenu";
            Text = "Pokédex Desktop";
            ((System.ComponentModel.ISupportInitialize)pictureNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Label labelSearch;
        private Button buttonSearch;
        private PictureBox pictureNormal;
        private PictureBox pictureShiny;
        private Label labelNormal;
        private Label labelShiny;
        private Button buttonPrevious;
        private Button buttonNext;
        private RichTextBox richTextBoxInfo;
    }
}
