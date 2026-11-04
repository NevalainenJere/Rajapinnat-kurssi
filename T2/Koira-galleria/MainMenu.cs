using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Koira_galleria
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public MainMenu()
        {
            InitializeComponent();
            AlignElemets();
            GetBreeds();
        }

        private async void GetBreeds()
        {
            var endpoint = new Uri("https://dog.ceo/api/breeds/list/all");
            var httpRequest = await client.GetAsync(endpoint);
            var result = await httpRequest.Content.ReadAsStringAsync();
            var jsonResponseParsed = JsonDocument.Parse(result);
            JsonElement message = jsonResponseParsed.RootElement.GetProperty("message");

            List<string> breeds = message.EnumerateObject().Select(breed => breed.Name).ToList();

            foreach (var breed in breeds)
            {
                comboBox1.Items.Add(breed);
            }

            //pictureBox1.ImageLocation = jsonResponseDeserialized.message;
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

        private async void buttonRandomDog_Click(object sender, EventArgs e)
        {
            await FetchRandomImage();
        }

        private async Task FetchRandomImage()
        {
            var endpoint = new Uri("https://dog.ceo/api/breeds/image/random");
            var httpRequest = await client.GetAsync(endpoint);
            var result = await httpRequest.Content.ReadAsStringAsync();
            var jsonResponseDeserialized = JsonConvert.DeserializeObject<Response>(result);

            pictureBox1.ImageLocation = jsonResponseDeserialized.message;
        }
    }
}
