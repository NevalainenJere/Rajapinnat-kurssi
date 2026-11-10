using Newtonsoft.Json;

namespace Pokedex
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
        PokemonData pokeData = new PokemonData();
        Type1 pokeType1 = new Type1();
        public MainMenu()
        {
            InitializeComponent();
            InitialString();
        }
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            textBoxSearch.Text = null;

            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + search);
            var httpRequest = await client.GetAsync(endpoint);
            var result = await httpRequest.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<PokemonData>(result);
            string responseDisplay = PokemonDataString(response);
            PokemonSpriteFetch(response);

            labelInfo.Text = responseDisplay;
        }

        public void PokemonSpriteFetch(PokemonData? response)
        {
            try
            {
                string PokemonSpriteDefault = response.sprites.front_default;
                string PokemonSpriteShiny = response.sprites.front_shiny;

                pictureNormal.ImageLocation = PokemonSpriteDefault;
                pictureShiny.ImageLocation = PokemonSpriteShiny;
            }
            catch (NullReferenceException e)
            {

            }
        }
        private static string PokemonDataString(PokemonData? response)
        {

            try
            {
                List<string> typesToStringList = new List<string>();
                List<string> statsToStringList = new List<string>();
                string PokemonTypes = "";
                string PokemonStats = "";

                string PokemonName = response.name;
                int PokemonId = response.id;
                int PokemonWeight = response.weight;
                int PokemonHeight = response.height;

                foreach (var pokeType in response.types)
                {
                    typesToStringList.Add(pokeType.type.name);
                }
                for (int i = 0; i < typesToStringList.Count; i++)
                {
                    if (i == typesToStringList.Count - 1)
                    {
                        PokemonTypes += $"{typesToStringList[i]}";
                        PokemonTypes = PokemonTypes;
                    }
                    else
                    {
                        PokemonTypes += $"{typesToStringList[i]}, ";
                    }
                }

                foreach (var pokeStat in response.stats)
                {
                    statsToStringList.Add(pokeStat.stat.name.ToUpper());
                    statsToStringList.Add(pokeStat.base_stat.ToString());
                }
                for (int i = 0; i < statsToStringList.Count; i++)
                {
                    if (i == statsToStringList.Count - 1)
                    {
                        //PokemonStats = statsToString.Remove(statsToString.Length - 1);
                        PokemonStats += $"{statsToStringList[i]}";
                        PokemonStats = PokemonStats;
                    }
                    else if ((i + 1) % 2 == 0)
                    {
                        PokemonStats += $"{statsToStringList[i]}, ";
                    }
                    else
                    {
                        PokemonStats += $"{statsToStringList[i]}: ";
                    }
                }
                return
                    $"Name: {PokemonName.ToUpper()}\r\n" +
                    $"Id: {PokemonId}\r\n" +
                    $"Type: {PokemonTypes.ToUpper()}\r\n" +
                    $"Weight: {PokemonWeight}\r\n" +
                    $"Height: {PokemonHeight}\r\n" +
                    $"Stats: {PokemonStats.ToUpper()}\r\n";
            }
            catch (NullReferenceException e)
            {
                return $"Invalid name or ID!";
            }
        }
        private void InitialString()
        {
            labelInfo.Text = 
                $"Name:\r\n" +
                $"Id:\r\n" +
                $"Type:\r\n" +
                $"Weight:\r\n" +
                $"Height:\r\n" +
                $"Stats\r\n";
        }
    }
}
