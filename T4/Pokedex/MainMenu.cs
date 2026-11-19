using NAudio.Vorbis;
using NAudio.Wave;
using Newtonsoft.Json;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class MainMenu : Form
    {
        private static readonly HttpClient client = new();
        //PokemonData pokeData = new PokemonData();
        //Type1 pokeType1 = new Type1();

        PokemonData? pokemonResponse;
        AbilityData? abilityResponse1;
        AbilityData? abilityResponse2;
        AbilityData? abilityResponse3;

        string abilityName1;
        string abilityName2;
        string abilityName3;
        string abilityDesc1;
        string abilityDesc2;
        string abilityDesc3;
        string abilityPokemon1;
        string abilityPokemon2;
        string abilityPokemon3;

        int nextId;
        int previousId;
        string pokemonTypes;
        string pokemonAbilities;
        string invalidInputError = $"Invalid name or ID!\r\n\r\nPokémon amount as of November 16th, 2026 is 1025.";
        string audioMissing = $"Sound file missing. :(";
        string initialDisplayString =
                $"Name:\r\n" +
                $"Id:\r\n" +
                $"Type:\r\n" +
                $"Weight:\r\n" +
                $"Height:\r\n" +
                $"Stats:\r\n" +
                $"Abilities:\r\n";

        public MainMenu()
        {
            InitializeComponent();
            AlignElements();
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
                pokemonResponse = JsonConvert.DeserializeObject<PokemonData>(result);
                string responseDisplay = PokemonDataString(pokemonResponse);

                PokemonSpriteFetch(pokemonResponse);

                if (pokemonResponse.name != null)
                {
                    ButtonRetrieve();
                    ButtonTextSetter(pokemonResponse);
                }
                else
                {
                    ErrorElementInitialize();
                }

                richTextBoxInfo.Text = responseDisplay;
                TypeColorSetter();

                nextId = pokemonResponse.id + 1;
                previousId = pokemonResponse.id - 1;

                //if (richTextBoxInfo.Text == invalidInputError)
                //{
                //    ErrorElementInitialize();
                //}
            }
            catch
            {
                richTextBoxInfo.Text = invalidInputError;
                ErrorElementInitialize();
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
                            richTextBoxInfo.SelectionColor = Color.Orange;
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
                ErrorElementInitialize();
            }
        }
        private string PokemonDataString(PokemonData? response)
        {

            try
            {
                List<string> typesToStringList = new List<string>();
                List<string> statsToStringList = new List<string>();
                List<string> abilitiesToStringList = new List<string>();
                pokemonTypes = "";
                pokemonAbilities = "";
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
                foreach (var pokeAbility in response.abilities)
                {
                    abilitiesToStringList.Add(pokeAbility.ability.name);
                }
                for (int i = 0; i < abilitiesToStringList.Count; i++)
                {
                    if (i == abilitiesToStringList.Count - 1)
                    {
                        pokemonAbilities += $"{abilitiesToStringList[i]}";
                        pokemonAbilities = pokemonAbilities;
                    }
                    else
                    {
                        pokemonAbilities += $"{abilitiesToStringList[i]}, ";
                    }
                }

                AbilityButtonSetter(abilitiesToStringList);

                return
                    $"Name: {pokemonName.ToUpper()}\r\n" +
                    $"Id: {pokemonId}\r\n" +
                    $"Type: {pokemonTypes.ToUpper()}\r\n" +
                    $"Weight: {pokemonWeight}\r\n" +
                    $"Height: {pokemonHeight}\r\n" +
                    $"Stats: {pokemonStats.ToUpper()}\r\n" +
                    $"Abilities: {pokemonAbilities.ToUpper()}\r\n";

            }
            catch (NullReferenceException e)
            {
                ErrorElementInitialize();
                return invalidInputError;
            }
        }
        private void InitialString()
        {
            richTextBoxInfo.Text = initialDisplayString;
        }

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/" + nextId);

            var httpRequest = await client.GetAsync(endpoint);

            var result = await httpRequest.Content.ReadAsStringAsync();

            pokemonResponse = JsonConvert.DeserializeObject<PokemonData>(result);

            string responseDisplay = PokemonDataString(pokemonResponse);
            PokemonSpriteFetch(pokemonResponse);
            ButtonRetrieve();
            ButtonTextSetter(pokemonResponse);

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

            pokemonResponse = JsonConvert.DeserializeObject<PokemonData>(result);

            string responseDisplay = PokemonDataString(pokemonResponse);
            PokemonSpriteFetch(pokemonResponse);
            ButtonRetrieve();
            ButtonTextSetter(pokemonResponse);

            nextId = previousId + 1;
            previousId -= 1;

            richTextBoxInfo.Text = responseDisplay;
            TypeColorSetter();
        }
        private void ButtonInitialize()
        {
            buttonNext.Enabled = false;
            buttonNext.Visible = false;
            buttonPrevious.Enabled = false;
            buttonPrevious.Visible = false;
            buttonCryLegacy.Enabled = false;
            buttonCryLegacy.Visible = false;
            buttonCryLatest.Enabled = false;
            buttonCryLatest.Visible = false;
            labelCryLegacy.Visible = false;
            labelCryLatest.Visible = false;
            buttonAbility1.Enabled = false;
            buttonAbility1.Visible = false;
            buttonAbility2.Enabled = false;
            buttonAbility2.Visible = false;
            buttonAbility3.Enabled = false;
            buttonAbility3.Visible = false;

            //else if (richTextBoxInfo.Text == invalidInputError)
            //{
            //    buttonNext.Enabled = false;
            //    buttonNext.Visible = false;
            //    buttonPrevious.Enabled = false;
            //    buttonPrevious.Visible = false;
            //    buttonCryLegacy.Enabled = false;
            //    buttonCryLegacy.Visible = false;
            //    buttonCryLatest.Enabled = false;
            //    buttonCryLatest.Visible = false;
            //    labelCryLegacy.Visible = false;
            //    labelCryLatest.Visible = false;
            //}
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
            labelCryLegacy.Visible = true;
            labelCryLatest.Visible = true;
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
                ErrorElementInitialize();
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

        private void buttonCryLegacy_Click(object sender, EventArgs e)
        {
            AudioPlayerLegacy(pokemonResponse);
        }

        private void buttonCryLatest_Click(object sender, EventArgs e)
        {
            AudioPlayerLatest(pokemonResponse);
        }
        private async void AudioPlayerLegacy(PokemonData? response)
        {
            try
            {
                if (response?.cries?.legacy == null)
                {
                    MessageBox.Show("No Legacy cry located.");
                    return;
                }

                string audioUrl = response.cries.legacy;
                using var httpClient = new HttpClient();
                using var stream = await httpClient.GetStreamAsync(audioUrl);
                using var ms = new MemoryStream();
                await stream.CopyToAsync(ms);
                ms.Position = 0;
                using var reader = new NAudio.Vorbis.VorbisWaveReader(ms);
                using var player = new NAudio.Wave.WaveOutEvent();
                player.Init(reader);
                player.Volume = 0.3f;
                player.Play();

                // Wait for playback to finish
                while (player.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(100);
                }
            }
            catch
            {
                MessageBox.Show(audioMissing);
            }

        }
        private async void AudioPlayerLatest(PokemonData? response)
        {
            try
            {
                if (response?.cries?.latest == null)
                {
                    MessageBox.Show("No Legacy cry located.");
                    return;
                }

                string audioUrl = response.cries.latest;
                using var httpClient = new HttpClient();
                using var stream = await httpClient.GetStreamAsync(audioUrl);
                using var ms = new MemoryStream();
                await stream.CopyToAsync(ms);
                ms.Position = 0;
                using var reader = new NAudio.Vorbis.VorbisWaveReader(ms);
                using var player = new NAudio.Wave.WaveOutEvent();
                player.Init(reader);
                player.Volume = 0.3f;
                player.Play();

                // Wait for playback to finish
                while (player.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(100);
                }
            }
            catch
            {
                MessageBox.Show(audioMissing);
            }

        }
        private void AlignElements()
        {
            richTextBoxInfo.Left = (this.ClientSize.Width - richTextBoxInfo.Width) / 2;
            labelSearch.Left = richTextBoxInfo.Left;
            buttonSearch.Left = richTextBoxInfo.Right - buttonSearch.Width;
            buttonAbility2.Left = buttonAbility1.Left + 150;
            buttonAbility3.Left = buttonAbility2.Left + 150;
        }
        private void ErrorElementInitialize()
        {
            ButtonInitialize();
            ImageResetter();
        }
        private void AbilityButtonSetter(List<string> abilitiesList)
        {
            try
            {
                if (abilitiesList.Count == 1)
                {
                    AbilityRequest(abilitiesList[0], null, null);

                    buttonAbility1.Text = abilitiesList[0].ToUpper();
                    buttonAbility1.Enabled = true;
                    buttonAbility1.Visible = true;
                    buttonAbility2.Enabled = false;
                    buttonAbility2.Visible = false;
                }
                else if (abilitiesList.Count == 2)
                {
                    AbilityRequest(abilitiesList[0], abilitiesList[1], null);

                    buttonAbility1.Text = abilitiesList[0].ToUpper();
                    buttonAbility2.Text = abilitiesList[1].ToUpper();
                    buttonAbility1.Enabled = true;
                    buttonAbility1.Visible = true;
                    buttonAbility2.Enabled = true;
                    buttonAbility2.Visible = true;
                    buttonAbility3.Enabled = false;
                    buttonAbility3.Visible = false;
                }
                else
                {
                    AbilityRequest(abilitiesList[0], abilitiesList[1], abilitiesList[2]);

                    buttonAbility1.Text = abilitiesList[0].ToUpper();
                    buttonAbility2.Text = abilitiesList[1].ToUpper();
                    buttonAbility3.Text = abilitiesList[2].ToUpper();
                    buttonAbility1.Enabled = true;
                    buttonAbility1.Visible = true;
                    buttonAbility2.Enabled = true;
                    buttonAbility2.Visible = true;
                    buttonAbility3.Enabled = true;
                    buttonAbility3.Visible = true;
                }
            }
            catch
            {
                richTextBoxInfo.Text = invalidInputError;
            }

        }

        private void buttonAbility1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{abilityName1.ToUpper()} is the first ability of {pokemonResponse.name.ToUpper()}.\r\n" +
                $"{abilityDesc1}\r\n\r\n" +
                $"The following Pokémon have this ability: {abilityPokemon1}");
        }

        private void buttonAbility2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{abilityName2.ToUpper()} is the first ability of {pokemonResponse.name.ToUpper()}.\r\n" +
                $"{abilityDesc2}\r\n\r\n" +
                $"The following Pokémon have this ability: {abilityPokemon2}");
        }

        private void buttonAbility3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{abilityName3.ToUpper()} is the first ability of {pokemonResponse.name.ToUpper()}.\r\n" +
                 $"{abilityDesc3}\r\n\r\n" +
                 $"The following Pokémon have this ability: {abilityPokemon3}");

        }
        private async void AbilityRequest(string? ability1, string? ability2, string? ability3)
        {
            List<string>? effectsToStringList = new();
            List<string>? abilityPokemonToStringList1 = new();
            List<string>? abilityPokemonToStringList2 = new();
            List<string>? abilityPokemonToStringList3 = new();

            string abilityPokemonListToString1;
            string abilityPokemonListToString2;
            string abilityPokemonListToString3;

            var endpoint1 = new Uri("https://pokeapi.co/api/v2/ability/" + ability1);
            var endpoint2 = new Uri("https://pokeapi.co/api/v2/ability/" + ability2);
            var endpoint3 = new Uri("https://pokeapi.co/api/v2/ability/" + ability3);

            var httpRequest1 = await client.GetAsync(endpoint1);
            var httpRequest2 = await client.GetAsync(endpoint2);
            var httpRequest3 = await client.GetAsync(endpoint3);

            var result1 = await httpRequest1.Content.ReadAsStringAsync();
            var result2 = await httpRequest2.Content.ReadAsStringAsync();
            var result3 = await httpRequest3.Content.ReadAsStringAsync();

            abilityResponse1 = JsonConvert.DeserializeObject<AbilityData>(result1);
            abilityResponse2 = JsonConvert.DeserializeObject<AbilityData>(result2);
            abilityResponse3 = JsonConvert.DeserializeObject<AbilityData>(result3);

            abilityName1 = abilityResponse1.name;
            abilityName2 = abilityResponse2.name;
            abilityName3 = abilityResponse3.name;

            if (abilityResponse1.effect_entries != null)
            {
                foreach (var effect in abilityResponse1.effect_entries)
                {
                    if (effect.language.name == "en")
                    {
                        effectsToStringList.Add(effect.effect);
                    }
                }
                foreach (var pokemon in abilityResponse1.pokemon)
                {
                    abilityPokemonToStringList1.Add(pokemon.ToString());
                }
            }
            if (abilityResponse2.effect_entries != null)
            {
                foreach (var effect in abilityResponse2.effect_entries)
                {
                    if (effect.language.name == "en")
                    {
                        effectsToStringList.Add(effect.effect);
                    }
                }
                foreach (var pokemon in abilityResponse2.pokemon)
                {
                    abilityPokemonToStringList2.Add(pokemon.ToString());
                }
            }
            if (abilityResponse3.effect_entries != null)
            {
                foreach (var effect in abilityResponse3.effect_entries)
                {
                    if (effect.language.name == "en")
                    {
                        effectsToStringList.Add(effect.effect);
                    }
                }
                foreach (var pokemon in abilityResponse3.pokemon)
                {
                    abilityPokemonToStringList3.Add(pokemon.ToString());
                }
            }

            if (effectsToStringList.Count == 1)
            {
                abilityDesc1 = effectsToStringList[0];
            }
            else if (effectsToStringList.Count == 2)
            {
                abilityDesc1 = effectsToStringList[0];
                abilityDesc2 = effectsToStringList[1];
            }
            else
            {
                abilityDesc1 = effectsToStringList[0];
                abilityDesc2 = effectsToStringList[1];
                abilityDesc3 = effectsToStringList[2];
            }

            abilityPokemonListToString1 = abilityPokemonToStringList1.ToString();
            abilityPokemonListToString2 = abilityPokemonToStringList2.ToString();
            abilityPokemonListToString3 = abilityPokemonToStringList3.ToString();
        }
    }
}
