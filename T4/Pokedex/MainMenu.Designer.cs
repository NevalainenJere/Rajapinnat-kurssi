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
            buttonCryLegacy = new Button();
            buttonCryLatest = new Button();
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
            pictureNormal.Location = new Point(34, 290);
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
            pictureShiny.Location = new Point(219, 290);
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
            labelNormal.Location = new Point(34, 263);
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
            labelShiny.Location = new Point(219, 263);
            labelShiny.Margin = new Padding(2, 0, 2, 0);
            labelShiny.Name = "labelShiny";
            labelShiny.Size = new Size(66, 25);
            labelShiny.TabIndex = 5;
            labelShiny.Text = "Shiny:";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrevious.Location = new Point(517, 290);
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
            buttonNext.Location = new Point(517, 379);
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
            // buttonCryLegacy
            // 
            buttonCryLegacy.Image = Properties.Resources.clker_free_vector_images_audio_297860_640;
            buttonCryLegacy.Location = new Point(411, 290);
            buttonCryLegacy.Name = "buttonCryLegacy";
            buttonCryLegacy.Size = new Size(75, 75);
            buttonCryLegacy.TabIndex = 8;
            buttonCryLegacy.UseVisualStyleBackColor = true;
            buttonCryLegacy.Click += buttonCryLegacy_Click;
            // 
            // buttonCryLatest
            // 
            buttonCryLatest.Image = Properties.Resources.clker_free_vector_images_audio_297860_640;
            buttonCryLatest.Location = new Point(411, 375);
            buttonCryLatest.Name = "buttonCryLatest";
            buttonCryLatest.Size = new Size(75, 75);
            buttonCryLatest.TabIndex = 8;
            buttonCryLatest.UseVisualStyleBackColor = true;
            buttonCryLatest.Click += buttonCryLatest_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(776, 466);
            Controls.Add(buttonCryLatest);
            Controls.Add(buttonCryLegacy);
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
            MaximizeBox = false;
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
        private Button buttonCryLegacy;
        private Button buttonCryLatest;
    }
}
