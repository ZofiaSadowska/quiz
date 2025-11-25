using System.Collections.ObjectModel;

namespace quiz;

public partial class QuizPage : ContentPage
{
    private string filePath = Path.Combine(FileSystem.AppDataDirectory, "pytnia.json");

    public QuizPage( )
	{
		InitializeComponent();
        

        if (whichPlayer == false)
        {
            player_name.Text = Player.Instance.Player1Name;
        }
        else
        {
            player_name.Text = Player.Instance.Player2Name;
        }

    }
    bool whichPlayer = false;
    bool whichAnswer = false;


    private async void Cofnij_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void Submit_Clicked(object sender, EventArgs e)
    {
        whichPlayer = true;

    }

    









    private void A_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            A.BackgroundColor = System.Drawing.Color.FromHtml("#E54F6D");
        }
        
    }

    private void B_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            A.BackgroundColor = "#E54F6D";
        }
    }

    private void C_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            A.BackgroundColor = "#E54F6D";
        }
    }

    private void D_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            A.BackgroundColor = "#E54F6D";
        }
    }
}