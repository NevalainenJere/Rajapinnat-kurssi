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
        string pokemonTypes;
        string invalidInputError = $"Invalid name or ID!\r\n\r\nPokémon amount as of November 13th, 2026 is 1025.";

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

                richTextBoxInfo.Text = responseDisplay;
                TypeColorSetter();

                nextId = response.id + 1;
                previousId = response.id - 1;

                if (richTextBoxInfo.Text == invalidInputError)
                {
                    ButtonInitialize();
                }
            }
            catch (NullReferenceException)
            {
                richTextBoxInfo.Text = invalidInputError;
                ButtonInitialize();
            }

        }

        private void TypeColorSetter()
        {
            string targetLine = "Type:";
            int typesIndex = richTextBoxInfo.Text.IndexOf(targetLine);
            int searchStart = typesIndex + targetLine.Length;
            string target = pokemonTypes.ToUpper();
            int startIndex = 1;

            List<string> items = target.Split(',', ' ').ToList();

            if (startIndex != -1)
            {
                foreach (var item in items)
                {
                    switch (item)
                    {
                        case "NORMAL":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Gray;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "FIRE":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Red;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "WATER":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Blue;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "ELECTRIC":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Gold;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "GRASS":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.LimeGreen;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "ICE":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.LightSkyBlue;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "FIGHTING":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.SaddleBrown;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "POISON":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.MediumVioletRed;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "GROUND":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.SandyBrown;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "FLYING":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.DeepSkyBlue;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "PSYCHIC":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.DeepPink;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "BUG":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Olive;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "ROCK":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Tan;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "GHOST":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.LightSlateGray;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "DRAGON":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.DodgerBlue;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "DARK":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Maroon;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "STEEL":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Silver;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        case "FAIRY":
                            startIndex = richTextBoxInfo.Text.IndexOf(item, searchStart);
                            target = item;
                            richTextBoxInfo.Select(startIndex, target.Length);
                            richTextBoxInfo.SelectionColor = Color.Violet;
                            richTextBoxInfo.SelectionLength = 0;
                            break;
                        default:
                            break;

                    }
                }
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
                richTextBoxInfo.Text = invalidInputError;
                ImageResetter();
            }
        }
        private  string PokemonDataString(PokemonData? response)
        {

            try
            {
                List<string> typesToStringList = new List<string>();
                List<string> statsToStringList = new List<string>();
                pokemonTypes = "";
                string pokemonStats = "";

                string pokemonName = response.name;
                int pokemonId = response.id;
                int pokemonWeight = response.weight;
                int pokemonHeight = response.height;

                foreach (var pokeType in response.types)
                {
                    typesToStringList.Add(pokeType.type.name);
                }
                for (int i = 0; i < typesToStringList.Count; i++)
                {
                    if (i == typesToStringList.Count - 1)
                    {
                        pokemonTypes += $"{typesToStringList[i]}";
                        pokemonTypes = pokemonTypes;
                    }
                    else
                    {
                        pokemonTypes += $"{typesToStringList[i]}, ";
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
                        pokemonStats += $"{statsToStringList[i]}";
                        pokemonStats = pokemonStats;
                    }
                    else if ((i + 1) % 2 == 0)
                    {
                        pokemonStats += $"{statsToStringList[i]}, ";
                    }
                    else
                    {
                        pokemonStats += $"{statsToStringList[i]}: ";
                    }
                }
                return
                    $"Name: {pokemonName.ToUpper()}\r\n" +
                    $"Id: {pokemonId}\r\n" +
                    $"Type: {pokemonTypes.ToUpper()}\r\n" +
                    $"Weight: {pokemonWeight}\r\n" +
                    $"Height: {pokemonHeight}\r\n" +
                    $"Stats: {pokemonStats.ToUpper()}\r\n";
            }
            catch (NullReferenceException e)
            {
                return invalidInputError;
            }
        }
        private void InitialString()
        {
            richTextBoxInfo.Text =
                $"Name:\r\n" +
                $"Id:\r\n" +
                $"Type:\r\n" +
                $"Weight:\r\n" +
                $"Height:\r\n" +
                $"Stats:\r\n";
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

            richTextBoxInfo.Text = responseDisplay;
            TypeColorSetter();
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

            richTextBoxInfo.Text = responseDisplay;
            TypeColorSetter();
        }
        private void ButtonInitialize()
        {
            if (richTextBoxInfo.Text ==
                $"Name:\r\n" +
                $"Id:\r\n" +
                $"Type:\r\n" +
                $"Weight:\r\n" +
                $"Height:\r\n" +
                $"Stats:\r\n")
            {
                buttonNext.Enabled = false;
                buttonNext.Visible = false;
                buttonPrevious.Enabled = false;
                buttonPrevious.Visible = false;
                buttonCryLegacy.Enabled = false;
                buttonCryLegacy.Visible = false;
                buttonCryLatest.Enabled = false;
                buttonCryLatest.Visible = false;
            }
            else if (richTextBoxInfo.Text == invalidInputError)
            {
                buttonNext.Enabled = false;
                buttonNext.Visible = false;
                buttonPrevious.Enabled = false;
                buttonPrevious.Visible = false;
                buttonCryLegacy.Enabled = false;
                buttonCryLegacy.Visible = false;
                buttonCryLatest.Enabled = false;
                buttonCryLatest.Visible = false;
            }
        }
        private void ButtonRetrieve()
        {
            buttonNext.Enabled = true;
            buttonNext.Visible = true;
            buttonPrevious.Enabled = true;
            buttonPrevious.Visible = true;
            buttonCryLegacy.Enabled = true;
            buttonCryLegacy.Visible = true;
            buttonCryLatest.Enabled = true;
            buttonCryLatest.Visible = true;
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
                richTextBoxInfo.Text = invalidInputError;
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
        private void richTextBoxInfo_Enter(object sender, EventArgs e)
        {
            ActiveControl = buttonSearch;
        }
    }
}
