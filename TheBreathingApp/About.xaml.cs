namespace TheBreathingApp;

public partial class About : ContentPage
{
    public About()
    {
        InitializeComponent();

        string name = AppInfo.Current.Name;
        string package = AppInfo.Current.PackageName;
        string version = AppInfo.Current.VersionString;
        string build = AppInfo.Current.BuildString;

        appName.Text = name;
        packageName.Text = package;
        appVersion.Text = version;
        appBuild.Text = build;
    }
}