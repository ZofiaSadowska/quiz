namespace quiz
{
    public partial class MainPage : ContentPage
    {
        private string filePath = Path.Combine(FileSystem.AppDataDirectory, "pytnia.json");

        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewGame());
        }

        private async void LiderBoard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LiderBoard());
        }

        
    }
}
