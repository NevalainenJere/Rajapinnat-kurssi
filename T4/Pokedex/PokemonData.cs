using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{

    public class PokemonData
    {
        public int id { get; set; }
        public string name { get; set; }
        //public int base_experience { get; set; }
        public int height { get; set; }
        //public bool is_default { get; set; }
        //public int order { get; set; }
        public int weight { get; set; }
        public Ability[] abilities { get; set; }
        //public Past_Abilities[] past_abilities { get; set; }
        //public PokemonForm[] forms { get; set; }
        //public Game_Indices[] game_indices { get; set; }
        //public Held_Items[] held_items { get; set; }
        //public string location_area_encounters { get; set; }
        //public Move[] moves { get; set; }
        //public Species species { get; set; }
        public Sprites sprites { get; set; }
        public Cries cries { get; set; }
        public Stat[] stats { get; set; }
        //public Past_Stats[] past_stats { get; set; }
        public Type[] types { get; set; }
        //public object[] past_types { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprites
    {
        public Other other { get; set; }
        public Versions1 versions { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Other
    {
        public Home home { get; set; }
        public Showdown showdown { get; set; }
        public Dream_World dream_world { get; set; }
        public OfficialArtwork officialartwork { get; set; }
    }

    public class Home
    {
        public string front_shiny { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Showdown
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Dream_World
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class OfficialArtwork
    {
        public Versions versions { get; set; }
        public string front_shiny { get; set; }
        public string front_default { get; set; }
    }

    public class Versions
    {
        public GenerationI generationi { get; set; }
        public GenerationIi generationii { get; set; }
    }

    public class GenerationI
    {
        public RedAndBlue redandblue { get; set; }
        public RedAndGreen redandgreen { get; set; }
    }

    public class RedAndBlue
    {
        public string front_default { get; set; }
    }

    public class RedAndGreen
    {
        public string front_default { get; set; }
    }

    public class GenerationIi
    {
        public GoldAndSilver goldandsilver { get; set; }
    }

    public class GoldAndSilver
    {
        public object front_default { get; set; }
    }

    public class Versions1
    {
        public GenerationI1 generationi { get; set; }
        public GenerationV generationv { get; set; }
        public GenerationIi1 generationii { get; set; }
        public GenerationIv generationiv { get; set; }
        public GenerationIx generationix { get; set; }
        public GenerationVi generationvi { get; set; }
        public GenerationIii generationiii { get; set; }
        public GenerationVii generationvii { get; set; }
        public GenerationViii generationviii { get; set; }
    }

    public class GenerationI1
    {
        public Yellow yellow { get; set; }
        public RedBlue redblue { get; set; }
        public RedGreenJapan redgreenjapan { get; set; }
    }

    public class Yellow
    {
        public string back_gbc { get; set; }
        public string back_gray { get; set; }
        public string front_gbc { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_transparent_gray { get; set; }
        public string front_transparent_gray { get; set; }
    }

    public class RedBlue
    {
        public string back_gray { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_transparent_gray { get; set; }
        public string front_transparent_gray { get; set; }
    }

    public class RedGreenJapan
    {
        public string back_gray { get; set; }
        public string front_gray { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class GenerationV
    {
        public Icons icons { get; set; }
        public BlackWhite blackwhite { get; set; }
    }

    public class Icons
    {
        public Animated animated { get; set; }
        public string front_default { get; set; }
    }

    public class Animated
    {
        public string front_default { get; set; }
    }

    public class BlackWhite
    {
        public Animated1 animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated1
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationIi1
    {
        public Gold gold { get; set; }
        public Silver silver { get; set; }
        public Crystal crystal { get; set; }
    }

    public class Gold
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class Silver
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class Crystal
    {
        public Animated2 animated { get; set; }
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string back_transparent { get; set; }
        public string front_transparent { get; set; }
        public string back_shiny_transparent { get; set; }
        public string front_shiny_transparent { get; set; }
    }

    public class Animated2
    {
        public string front_shiny { get; set; }
        public string front_default { get; set; }
    }

    public class GenerationIv
    {
        public Icons1 icons { get; set; }
        public Platinum platinum { get; set; }
        public DiamondPearl diamondpearl { get; set; }
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
    }

    public class Icons1
    {
        public string front_default { get; set; }
    }

    public class Platinum
    {
        public Animated3 animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated3
    {
        public string front_shiny { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class DiamondPearl
    {
        public Animated4 animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated4
    {
        public string front_shiny { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        public Animated5 animated { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Animated5
    {
        public string front_shiny { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationIx
    {
        public Champions champions { get; set; }
        public LegendsZa legendsza { get; set; }
        public ScarletViolet scarletviolet { get; set; }
    }

    public class Champions
    {
        public Icons2 icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons2
    {
        public string front_shiny { get; set; }
        public string front_default { get; set; }
    }

    public class LegendsZa
    {
        public Icons3 icons { get; set; }
        public object back_shiny { get; set; }
        public object back_female { get; set; }
        public object front_shiny { get; set; }
        public object back_default { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons3
    {
        public object front_shiny { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class ScarletViolet
    {
        public Icons4 icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons4
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class GenerationVi
    {
        public XY xy { get; set; }
        public Icons5 icons { get; set; }
        public OmegaRubyAlphaSapphire omegarubyalphasapphire { get; set; }
    }

    public class XY
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons5
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class OmegaRubyAlphaSapphire
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class GenerationIii
    {
        public Icons6 icons { get; set; }
        public Emerald emerald { get; set; }
        public RubySapphire rubysapphire { get; set; }
        public FireredLeafgreen fireredleafgreen { get; set; }
    }

    public class Icons6
    {
        public string front_default { get; set; }
    }

    public class Emerald
    {
        public Animated6 animated { get; set; }
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class Animated6
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class RubySapphire
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class FireredLeafgreen
    {
        public string back_shiny { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
    }

    public class GenerationVii
    {
        public Icons7 icons { get; set; }
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
        public LetsGoPikachuLetsGoEevee letsgopikachuletsgoeevee { get; set; }
    }

    public class Icons7
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class UltraSunUltraMoon
    {
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class LetsGoPikachuLetsGoEevee
    {
        public Icons8 icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons8
    {
        public string front_default { get; set; }
    }

    public class GenerationViii
    {
        public SwordShield swordshield { get; set; }
        public LegendsArceus legendsarceus { get; set; }
        public BrilliantDiamondShiningPearl brilliantdiamondshiningpearl { get; set; }
    }

    public class SwordShield
    {
        public Icons9 icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons9
    {
        public object front_female { get; set; }
        public string front_default { get; set; }
    }

    public class LegendsArceus
    {
        public Icons10 icons { get; set; }
        public object back_shiny { get; set; }
        public object back_female { get; set; }
        public object front_shiny { get; set; }
        public object back_default { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons10
    {
        public object front_shiny { get; set; }
        public object front_female { get; set; }
        public object front_default { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class BrilliantDiamondShiningPearl
    {
        public Icons11 icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }

    public class Icons11
    {
        public string front_default { get; set; }
    }

    public class Cries
    {
        public string latest { get; set; }
        public string legacy { get; set; }
    }

    public class Ability
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability1 ability { get; set; }
    }

    public class Ability1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Past_Abilities
    {
        public Generation generation { get; set; }
        public Ability2[] abilities { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability2
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public object ability { get; set; }
    }

    public class PokemonForm
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Game_Indices
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Held_Items
    {
        public Item item { get; set; }
        public Version_Details[] version_details { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Details
    {
        public int rarity { get; set; }
        public Version1 version { get; set; }
    }

    public class Version1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public Move1 move { get; set; }
        public Version_Group_Details[] version_group_details { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_Group_Details
    {
        public int level_learned_at { get; set; }
        public Version_Group version_group { get; set; }
        public Move_Learn_Method move_learn_method { get; set; }
        public object order { get; set; }
    }

    public class Version_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move_Learn_Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat1 stat { get; set; }
    }

    public class Stat1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Past_Stats
    {
        public Generation1 generation { get; set; }
        public Stat2[] stats { get; set; }
    }

    public class Generation1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat2
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat3 stat { get; set; }
    }

    public class Stat3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type1 type { get; set; }
    }

    public class Type1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
