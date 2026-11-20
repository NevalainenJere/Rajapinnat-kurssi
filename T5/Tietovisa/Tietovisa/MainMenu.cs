namespace Tietovisa
{
    public partial class MainMenu : Form
    {
        string urlBase = "https://opentdb.com/api.php?";
        string numberOfQuestions;
        string category;
        string difficulty;
        string questionType;
        public MainMenu()
        {
            InitializeComponent();
        }
    }
}
