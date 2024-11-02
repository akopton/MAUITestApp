using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Pages;

public partial class TestPage : TabbedPage
{
    public TestPage()
    {
        InitializeComponent();

        this.Children.Add(
            new ContentPage
            {
                Title = "Tab 3",
                Content = new ScrollView
                {
                    BackgroundColor = Colors.Aqua,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 100f,
                    Content = new Button { Text = "Tab 4" },
                },
            }
        );

        this.Children.Add(
            new ContentPage
            {
                Title = "Tab 4",
                Content = new ScrollView
                {
                    BackgroundColor = Colors.Aqua,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 300f,
                    Content = new Label { Text = "Tab 4" },
                },
            }
        );
    }

    private void OnDateCheckboxChange(object sender, CheckedChangedEventArgs e)
    {
        DatePicker.IsVisible = DateCheckbox.IsChecked switch
        {
            true => true,
            false => false,
        };
    }

    private void OnDatePageLinkClick(object sender, EventArgs e)
    {
        string dateValue;
        var date = DatePicker.Date;
        Navigation.PushAsync(new DatePage(date.ToShortDateString()));
    }
}
