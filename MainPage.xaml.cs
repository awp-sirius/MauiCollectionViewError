namespace MauiCollectionViewError;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        ColView.ItemsSource = new List<string>()
        {
            "1","2","3","4"
        };
    }
}