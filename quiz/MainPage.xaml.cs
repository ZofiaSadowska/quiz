namespace quiz
{
    public partial class MainPage : ContentPage
    {
        

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
