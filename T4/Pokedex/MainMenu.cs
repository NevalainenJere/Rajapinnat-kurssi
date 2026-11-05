using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Pokedex
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public MainMenu()
        {
            InitializeComponent();
        }
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            List<char> types = new List<char>();
            string search = textBoxSearch.Text.ToLower();
            textBoxSearch.Text = null;

            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + search);
            var httpRequest = await client.GetAsync(endpoint); 
            var result = await httpRequest.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(result);

            foreach (var type in response.types)
            {
                types.Add(type);
            }

            string responseDisplay = $"Name: {response.name}\r\nId: {response.id}\r\nTypes: {response.types}";

            labelInfo.Text = responseDisplay;
        }
    }
}
