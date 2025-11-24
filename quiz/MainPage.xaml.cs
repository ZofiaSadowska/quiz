namespace quiz
{
    public partial class MainPage : ContentPage
    {
        private string filePath = Path.Combine(FileSystem.AppDataDirectory, "pytnia.json");

        public MainPage()
        {
            InitializeComponent();
        }



       
    }
}
