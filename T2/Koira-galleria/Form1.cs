namespace Koira_galleria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AlignElemets();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is System.Drawing.Bitmap)
            {
                return;
            }
            else
            {
                MessageBox.Show("Älä härnää koiraa!!!");
            }
        }
        private void AlignElemets()
        {
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            comboBox1.Left = (this.ClientSize.Width - comboBox1.Width) / 2;
            buttonRandomDog.Left = (this.ClientSize.Width - buttonRandomDog.Width) / 2;
        }

        private void buttonRandomDog_Click(object sender, EventArgs e)
        {

        }
    }
}
