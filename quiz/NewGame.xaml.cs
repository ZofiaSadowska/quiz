using System.Collections.ObjectModel;

namespace quiz;

public partial class NewGame : ContentPage
{
   
    public NewGame()
	{
        InitializeComponent();
	}

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        Player.Instance.Player1Name = player1Entry.Text;
        Player.Instance.Player2Name = player2Entry.Text;
        await Navigation.PushAsync(new QuizPage());
    }

    private async void Cofnij_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}