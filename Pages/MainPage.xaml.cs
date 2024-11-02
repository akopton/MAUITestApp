namespace TestApp1.Pages;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time xd";
        else
            CounterBtn.Text = $"this is Clicked {count} times xd";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnTestPageLinkClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TestPage());
    }
}
