namespace TheBreathingApp;

public partial class Records : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();

    public Records()
    {
        InitializeComponent();
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        displayRecord.ItemsSource = await firebaseHelper.GetAllTestRecords();
    }

}