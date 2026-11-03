namespace Hauskat_Faktat
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Form1_Resize(this, EventArgs.Empty);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int margin = 100;

            buttonGETFact.Left = margin;
            buttonGETBreed.Left = this.ClientSize.Width - buttonGETBreed.Width - margin;
            labelCatInfo.Left = (this.ClientSize.Width - labelCatInfo.Width) / 2;
            pictureBoxCat.Left = (this.ClientSize.Width - pictureBoxCat.Width) / 2;
        }

        private void pictureBoxCat_Click(object sender, EventArgs e)
        {

        }
    }
}
