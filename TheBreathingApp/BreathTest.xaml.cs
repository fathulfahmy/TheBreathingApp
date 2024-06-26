namespace TheBreathingApp;

public partial class BreathTest : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    private int score = 0;

    public BreathTest()
    {
        InitializeComponent();
    }
    private void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = (RadioButton)sender;

        if (radioButton.GroupName == "Question1")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question2")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question3")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question4")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question5")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question6")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question7")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question8")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
        else if (radioButton.GroupName == "Question9")
        {
            score += int.Parse(radioButton.Value.ToString());
        }
    }

    async void OnSubmit(object sender, EventArgs e)
    {
        outputScore.Text = $"{score}";

        if (score <= 10)
        {
            outputResult.Text = "Low risk";
        }
        else if (score <= 20)
        {
            outputResult.Text = "Moderate risk";
        }
        else
        {
            outputResult.Text = "High risk";
        }

        var dateRecorded = DateTime.Now.ToString("dd/MM/yyyy");
        string result = outputResult.Text;
        await firebaseHelper.AddRecord(dateRecorded, score, result);

        await DisplayAlert("Record Saved", "Short of Breath Test Record has been saved", "OK");

    }
    private void OnReset(object sender, EventArgs e)
    {
        outputResult.Text = "Please fill the form";
        score = 0;
        outputScore.Text = $"{score}";
    }
}