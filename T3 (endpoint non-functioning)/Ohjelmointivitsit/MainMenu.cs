using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ohjelmointivitsit
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public MainMenu()
        {
            InitializeComponent();
            AlignElements();
        }
        private void AlignElements()
        {
            buttonJokeGenerate.Left = (this.ClientSize.Width - buttonJokeGenerate.Width) / 2;
            labelJokeDisplay.Left = (this.ClientSize.Width - labelJokeDisplay.Width) / 2;
        }
        private async void buttonJokeGenerate_Click(object sender, System.EventArgs e)
        {
            try
            {
                var endpoint = new Uri("https://programming-quotesapi.vercel.app/api/random");
                var httpRequest = await client.GetAsync(endpoint);
                var result = await httpRequest.Content.ReadAsStringAsync();
                var jsonResponseDeserialized = JsonConvert.DeserializeObject<Response>(result);
            }
            catch(HttpRequestException ex)
            {
                labelJokeDisplay.Text = "Virhe: " + ex;
            }
            catch(JsonReaderException ex)
            {
                labelJokeDisplay.Text = "Virhe: " + ex;
            }
            
        }
    }
}
