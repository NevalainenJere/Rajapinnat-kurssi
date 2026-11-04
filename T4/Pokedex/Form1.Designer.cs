namespace Pokedex
{
    partial class Form1
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
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(236, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(355, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = Color.WhiteSmoke;
            labelInfo.BorderStyle = BorderStyle.FixedSingle;
            labelInfo.Location = new Point(53, 98);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(661, 346);
            labelInfo.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Calibri", 12F);
            labelSearch.Location = new Point(34, 34);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(196, 24);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Hae Pokémon nimellä:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Yellow;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(620, 33);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Hae";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(776, 466);
            Controls.Add(buttonSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelInfo);
            Controls.Add(textBoxSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Label labelInfo;
        private Label labelSearch;
        private Button buttonSearch;
    }
}
