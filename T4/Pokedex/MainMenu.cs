using Newtonsoft.Json;
using System.Net;
using System.Runtime.CompilerServices;

namespace Pokedex
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new HttpClient();
        PokemonData pokeData = new PokemonData();
        Type1 pokeType1 = new Type1();
        int nextId;
        int previousId;
        public MainMenu()
        {
            InitializeComponent();
            InitialString();
            ButtonInitialize();
        }
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = textBoxSearch.Text.ToLower();
                textBoxSearch.Text = null;

                var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + search);
                var httpRequest = await client.GetAsync(endpoint);
                var result = await httpRequest.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<PokemonData>(result);
                string responseDisplay = PokemonDataString(response);
                PokemonSpriteFetch(response);
                ButtonRetrieve();
                ButtonTextSetter(response);

                labelInfo.Text = responseDisplay;

                nextId = response.id + 1;
                previousId = response.id - 1;

                if (labelInfo.Text == "Invalid name or ID!")
                {
                    ButtonInitialize();
                }
            }
            catch (NullReferenceException)
            {
                labelInfo.Text = $"Invalid name or ID!";
                ButtonInitialize();
            }

        }

        private void PokemonSpriteFetch(PokemonData? response)
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
                labelInfo.Text = $"Invalid name or ID!";
                ImageResetter();
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

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + nextId);

            var httpRequest = await client.GetAsync(endpoint);

            var result = await httpRequest.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<PokemonData>(result);

            string responseDisplay = PokemonDataString(response);
            PokemonSpriteFetch(response);
            ButtonRetrieve();
            ButtonTextSetter(response);

            previousId = nextId - 1;
            nextId += 1;

            labelInfo.Text = responseDisplay;
        }

        private async void buttonPrevious_Click(object sender, EventArgs e)
        {
            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + previousId);

            var httpRequest = await client.GetAsync(endpoint);

            var result = await httpRequest.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<PokemonData>(result);

            string responseDisplay = PokemonDataString(response);
            PokemonSpriteFetch(response);
            ButtonRetrieve();
            ButtonTextSetter(response);

            nextId = previousId + 1;
            previousId -= 1;

            labelInfo.Text = responseDisplay;
        }
        private void ButtonInitialize()
        {
            if (labelInfo.Text ==
                $"Name:\r\n" +
                $"Id:\r\n" +
                $"Type:\r\n" +
                $"Weight:\r\n" +
                $"Height:\r\n" +
                $"Stats\r\n")
            {
                buttonNext.Enabled = false;
                buttonNext.Visible = false;
                buttonPrevious.Enabled = false;
                buttonPrevious.Visible = false;
            }
            else if (labelInfo.Text == "Invalid name or ID!")
            {
                buttonNext.Enabled = false;
                buttonNext.Visible = false;
                buttonPrevious.Enabled = false;
                buttonPrevious.Visible = false;
            }
        }
        private void ButtonRetrieve()
        {
            buttonNext.Enabled = true;
            buttonNext.Visible = true;
            buttonPrevious.Enabled = true;
            buttonPrevious.Visible = true;
        }
        private async void ButtonTextSetter(PokemonData? response)
        {
            try
            {
                int nextId = response.id + 1;
                int previousId = response.id - 1;

                var endpointNext = new Uri("https://pokeapi.co/api/v2/pokemon/" + nextId);
                var endpointPrevious = new Uri("https://pokeapi.co/api/v2/pokemon/" + previousId);

                var httpRequestNext = await client.GetAsync(endpointNext);
                var httpRequestPrevious = await client.GetAsync(endpointPrevious);

                var resultNext = await httpRequestNext.Content.ReadAsStringAsync();
                var resultPrevious = await httpRequestPrevious.Content.ReadAsStringAsync();

                var responseNext = JsonConvert.DeserializeObject<PokemonData>(resultNext);
                var responsePrevious = JsonConvert.DeserializeObject<PokemonData>(resultPrevious);


                if (previousId == 0)
                {
                    buttonPrevious.Text = "Previous";
                    buttonPrevious.Enabled = false;
                    buttonPrevious.Visible = false;
                }
                else
                {
                    buttonPrevious.Text = $"Previous: {responsePrevious.name.ToUpper()}";
                }
                if (nextId == 1026)
                {
                    buttonNext.Text = "Next";
                    buttonNext.Enabled = false;
                    buttonNext.Visible = false;
                }
                else
                {
                    buttonNext.Text = $"Next: {responseNext.name.ToUpper()}";
                }

            }
            catch (NullReferenceException e)
            {
                labelInfo.Text = $"Invalid name or ID!\r\n\r\nPokémon amount as of November 10th, 2026 is 1025.";
            }
        }
        private void ImageResetter()
        {
            pictureNormal.Image = null;
            pictureShiny.Image = null;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }
    }
}
