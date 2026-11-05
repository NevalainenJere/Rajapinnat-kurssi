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
            string search = textBoxSearch.Text.ToLower();
            textBoxSearch.Text = null;

            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + search);
            var httpRequest = await client.GetAsync(endpoint); 
            var result = await httpRequest.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Response>(result);

            if (response is null)
            {
                labelInfo.Text = "Could not read the Pokémon response.";
                return;
            }

            var output = $"{response.Name}\r\n";

            foreach (var pokemonStat in response.Stats)
            {
                output += $"{pokemonStat.Stat?.Name}: {pokemonStat.BaseStat}\r\n";
            }

            labelInfo.Text = output;

        }
    }
}
