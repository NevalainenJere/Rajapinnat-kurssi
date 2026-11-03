using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hauskat_Faktat
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
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

        private async void buttonGETFact_Click(object sender, EventArgs e)
        {
            try
            {
                var endpoint = new Uri("https://catfact.ninja/fact");

                var httpRequest = await client.GetAsync(endpoint);

                var result = await httpRequest.Content.ReadAsStringAsync();

                var jsonResponseDeserialized = JsonConvert.DeserializeObject<Message>(result);

                if (result != null)
                {
                    labelCatInfo.Text = jsonResponseDeserialized.fact;
                }
                else
                {
                    labelCatInfo.Text = "The Http request produced no response.";
                }
            }
            catch (HttpRequestException ex)
            {
                labelCatInfo.Text = "There was an error: " + ex.Message;
            }
        }

        private async void buttonGETBreed_Click(object sender, EventArgs e)
        {
            int breedTotalCount = 97;
            Random rand = new Random(breedTotalCount);

            try
            {
                var endpoint = new Uri("https://catfact.ninja/breeds");

                var httpRequest = await client.GetAsync(endpoint);

                var result = await httpRequest.Content.ReadAsStringAsync();

                int resultCount = result.Length;

                var jsonResponseDeserialized = JsonConvert.DeserializeObject<Message>(result);
                var jsonResponseRandom = rand.Next(result[rand.Next()]);


                if (result != null)
                {
                    
                    labelCatInfo.Text = jsonResponseDeserialized.breed;
                }
                else
                {
                    labelCatInfo.Text = "The Http request produced no response.";
                }
            }
            catch (HttpRequestException ex)
            {
                labelCatInfo.Text = "There was an error: " + ex.Message;
            }
        }
    }
}

