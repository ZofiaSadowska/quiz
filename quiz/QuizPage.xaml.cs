using System.Collections.ObjectModel;
using Microsoft.Maui.Graphics;
using System.Text.Json;


namespace quiz;

public partial class QuizPage : ContentPage
{
    public async Task<QuestionSet> LoadQuestions()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("pytnia.json");
        using var reader = new StreamReader(stream);

        string json = reader.ReadToEnd();

        return JsonSerializer.Deserialize<QuestionSet>(json);
    }

    private List<Question> questions;
    int currentIndex = 0;

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
        LoadAndStart();

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

    private async void LoadAndStart()
    {
        var data = await LoadQuestions();
        questions = data.Questions;
        var q = questions[currentIndex];
        var buttons = new List<Button> { button1, button2, button3, button4 };
        question.Text = q.QuestionText;
        for (int i = 0; i < buttons.Count; i++)
        {
            if (i < q.Answers.Count)
            {
                buttons[i].Text = q.Answers[i];
                buttons[i].BackgroundColor = Color.FromArgb("#D9D9D9");
            }    
        }
    }
    private void A_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            button1.BackgroundColor = Color.FromArgb("#E54F6D");
        }
        
    }

    private void B_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            button2.BackgroundColor = Color.FromArgb("#E54F6D");
        }
    }

    private void C_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            button3.BackgroundColor = Color.FromArgb("#E54F6D");
        }
    }

    private void D_Clicked(object sender, EventArgs e)
    {
        if (whichAnswer == true) { }
        else
        {
            whichAnswer = true;
            button4.BackgroundColor = Color.FromArgb("#E54F6D");
        }
    }
}