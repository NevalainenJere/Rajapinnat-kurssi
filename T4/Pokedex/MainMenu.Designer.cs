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
            labelInfo = new Label();
            labelSearch = new Label();
            buttonSearch = new Button();
            pictureNormal = new PictureBox();
            pictureShiny = new PictureBox();
            labelNormal = new Label();
            labelShiny = new Label();
            buttonPrevious = new Button();
            buttonNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiny).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(377, 42);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(361, 31);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = Color.WhiteSmoke;
            labelInfo.BorderStyle = BorderStyle.FixedSingle;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInfo.Location = new Point(66, 122);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(826, 187);
            labelInfo.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(42, 42);
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
            buttonSearch.Location = new Point(775, 41);
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
            pictureNormal.BackColor = Color.Firebrick;
            pictureNormal.Image = Properties.Resources.no_pokemon_selected;
            pictureNormal.Location = new Point(66, 357);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(200, 200);
            pictureNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNormal.TabIndex = 4;
            pictureNormal.TabStop = false;
            // 
            // pictureShiny
            // 
            pictureShiny.BackColor = Color.Firebrick;
            pictureShiny.Image = Properties.Resources.no_pokemon_selected;
            pictureShiny.Location = new Point(347, 357);
            pictureShiny.Name = "pictureShiny";
            pictureShiny.Size = new Size(200, 200);
            pictureShiny.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureShiny.TabIndex = 4;
            pictureShiny.TabStop = false;
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelNormal.ForeColor = Color.White;
            labelNormal.Location = new Point(66, 324);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(96, 30);
            labelNormal.TabIndex = 5;
            labelNormal.Text = "Normal:";
            // 
            // labelShiny
            // 
            labelShiny.AutoSize = true;
            labelShiny.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelShiny.ForeColor = Color.White;
            labelShiny.Location = new Point(347, 324);
            labelShiny.Name = "labelShiny";
            labelShiny.Size = new Size(75, 30);
            labelShiny.TabIndex = 5;
            labelShiny.Text = "Shiny:";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrevious.Location = new Point(622, 357);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(294, 88);
            buttonPrevious.TabIndex = 6;
            buttonPrevious.Text = "Previous";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonNext.Location = new Point(622, 469);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(294, 88);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(970, 582);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(labelShiny);
            Controls.Add(labelNormal);
            Controls.Add(pictureShiny);
            Controls.Add(pictureNormal);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelInfo);
            Controls.Add(textBoxSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "Pokédex Desktop";
            ((System.ComponentModel.ISupportInitialize)pictureNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Label labelInfo;
        private Label labelSearch;
        private Button buttonSearch;
        private PictureBox pictureNormal;
        private PictureBox pictureShiny;
        private Label labelNormal;
        private Label labelShiny;
        private Button buttonPrevious;
        private Button buttonNext;
    }
}
