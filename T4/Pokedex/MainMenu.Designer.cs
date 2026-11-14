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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
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
            labelCryLegacy = new Label();
            labelCryLatest = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiny).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(429, 40);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(652, 31);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(94, 40);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(327, 29);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Hae Pokémon nimellä tai ID:llä:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Gold;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(1105, 37);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(118, 36);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Hae";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // pictureNormal
            // 
            pictureNormal.BackColor = Color.Transparent;
            pictureNormal.Image = Properties.Resources.no_pokemon_selected;
            pictureNormal.Location = new Point(45, 473);
            pictureNormal.Margin = new Padding(2);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(200, 200);
            pictureNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNormal.TabIndex = 4;
            pictureNormal.TabStop = false;
            // 
            // pictureShiny
            // 
            pictureShiny.BackColor = Color.Transparent;
            pictureShiny.Image = Properties.Resources.no_pokemon_selected;
            pictureShiny.Location = new Point(353, 473);
            pictureShiny.Margin = new Padding(2);
            pictureShiny.Name = "pictureShiny";
            pictureShiny.Size = new Size(200, 200);
            pictureShiny.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureShiny.TabIndex = 4;
            pictureShiny.TabStop = false;
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.BackColor = Color.Transparent;
            labelNormal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNormal.ForeColor = Color.Black;
            labelNormal.Location = new Point(39, 432);
            labelNormal.Margin = new Padding(2, 0, 2, 0);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(107, 32);
            labelNormal.TabIndex = 5;
            labelNormal.Text = "Normal:";
            // 
            // labelShiny
            // 
            labelShiny.AutoSize = true;
            labelShiny.BackColor = Color.Transparent;
            labelShiny.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelShiny.ForeColor = Color.Black;
            labelShiny.Location = new Point(347, 432);
            labelShiny.Margin = new Padding(2, 0, 2, 0);
            labelShiny.Name = "labelShiny";
            labelShiny.Size = new Size(83, 32);
            labelShiny.TabIndex = 5;
            labelShiny.Text = "Shiny:";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonPrevious.Location = new Point(985, 475);
            buttonPrevious.Margin = new Padding(2);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(294, 88);
            buttonPrevious.TabIndex = 6;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonNext.Location = new Point(985, 587);
            buttonNext.Margin = new Padding(2);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(294, 88);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // richTextBoxInfo
            // 
            richTextBoxInfo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxInfo.Location = new Point(94, 92);
            richTextBoxInfo.Margin = new Padding(4);
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.Size = new Size(1129, 246);
            richTextBoxInfo.TabIndex = 7;
            richTextBoxInfo.Text = "";
            richTextBoxInfo.Enter += richTextBoxInfo_Enter;
            // 
            // buttonCryLegacy
            // 
            buttonCryLegacy.FlatAppearance.BorderColor = Color.Black;
            buttonCryLegacy.FlatAppearance.BorderSize = 4;
            buttonCryLegacy.Image = Properties.Resources.clker_free_vector_images_audio_297860_640;
            buttonCryLegacy.Location = new Point(642, 581);
            buttonCryLegacy.Margin = new Padding(4);
            buttonCryLegacy.Name = "buttonCryLegacy";
            buttonCryLegacy.Size = new Size(94, 94);
            buttonCryLegacy.TabIndex = 8;
            buttonCryLegacy.UseVisualStyleBackColor = true;
            buttonCryLegacy.Click += buttonCryLegacy_Click;
            // 
            // buttonCryLatest
            // 
            buttonCryLatest.FlatAppearance.BorderColor = Color.Black;
            buttonCryLatest.FlatAppearance.BorderSize = 4;
            buttonCryLatest.Image = Properties.Resources.clker_free_vector_images_audio_297860_640;
            buttonCryLatest.Location = new Point(807, 581);
            buttonCryLatest.Margin = new Padding(4);
            buttonCryLatest.Name = "buttonCryLatest";
            buttonCryLatest.Size = new Size(94, 94);
            buttonCryLatest.TabIndex = 8;
            buttonCryLatest.UseVisualStyleBackColor = true;
            buttonCryLatest.Click += buttonCryLatest_Click;
            // 
            // labelCryLegacy
            // 
            labelCryLegacy.AutoSize = true;
            labelCryLegacy.BackColor = Color.Transparent;
            labelCryLegacy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCryLegacy.Location = new Point(611, 545);
            labelCryLegacy.Name = "labelCryLegacy";
            labelCryLegacy.Size = new Size(156, 32);
            labelCryLegacy.TabIndex = 9;
            labelCryLegacy.Text = "Cry (Legacy)";
            // 
            // labelCryLatest
            // 
            labelCryLatest.AutoSize = true;
            labelCryLatest.BackColor = Color.Transparent;
            labelCryLatest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCryLatest.Location = new Point(777, 545);
            labelCryLatest.Name = "labelCryLatest";
            labelCryLatest.Size = new Size(145, 32);
            labelCryLatest.TabIndex = 9;
            labelCryLatest.Text = "Cry (Latest)";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            BackgroundImage = Properties.Resources.form_background;
            ClientSize = new Size(1318, 712);
            Controls.Add(labelCryLatest);
            Controls.Add(labelCryLegacy);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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
        private Label labelCryLegacy;
        private Label labelCryLatest;
    }
}
