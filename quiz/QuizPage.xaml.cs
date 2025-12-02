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

    public QuizPage()
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

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        if (whichPlayer == false)
        {
            if (whichPlayer == false)
            {
                whichPlayer = true;
                whichAnswer = false;
                ResetButtonColors();
                ShowQuestion();
                return;
            }
        }
        else
        {
            currentIndex++;

            if (currentIndex >= questions.Count)
            {
                await Navigation.PushAsync(new LiderBoard());
            }
            else
            {
                ShowQuestion();
            }
        }
    }

    private void ResetButtonColors()
    {
        button1.BackgroundColor = Color.FromArgb("#D9D9D9");
        button2.BackgroundColor = Color.FromArgb("#D9D9D9");
        button3.BackgroundColor = Color.FromArgb("#D9D9D9");
        button4.BackgroundColor = Color.FromArgb("#D9D9D9");
    }

    private async void LoadAndStart()
    {
        var data = await LoadQuestions();
        questions = data.Questions;
        ShowQuestion();
        
    }

    private void ShowQuestion()
    {
        whichAnswer = false;
        button1.BackgroundColor = Color.FromArgb("#D9D9D9");
        button2.BackgroundColor = Color.FromArgb("#D9D9D9");
        button3.BackgroundColor = Color.FromArgb("#D9D9D9");
        button4.BackgroundColor = Color.FromArgb("#D9D9D9");
        var q = questions[currentIndex];
        question.Text = q.QuestionText;

        
    }


    private void AnswerClicked(string chosenAnswer, Button clickedButton)
    {
        if (whichAnswer) return;

        whichAnswer = true;

        var q = questions[currentIndex];

        if (chosenAnswer == q.Correct)
        {
            if (whichPlayer == false)
                Player.Instance.Player1Score++;
            else
                Player.Instance.Player2Score++;
        }
        else
        {

           
        }
    }

    private void A_Clicked(object sender, EventArgs e)
    {
        AnswerClicked(button1.Text, button1);

    }

    private void B_Clicked(object sender, EventArgs e)
    {
        AnswerClicked(button2.Text, button2);
    }

    private void C_Clicked(object sender, EventArgs e)
    {
        AnswerClicked(button3.Text, button3);
    }

    private void D_Clicked(object sender, EventArgs e)
    {
        AnswerClicked(button4.Text, button4);
    
    }
}