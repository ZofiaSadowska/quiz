namespace quiz;

public partial class LiderBoard : ContentPage
{
	public LiderBoard()
	{
		InitializeComponent();

		wyniki_1.Text = Player.Instance.Player1Name;
        wyniki_2.Text = Player.Instance.Player2Name;
		punkty_1.Text = Player.Instance.Player1Score.ToString();
        punkty_2.Text = Player.Instance.Player2Score.ToString();
    }

    private async void NewGame_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewGame());
    }
}