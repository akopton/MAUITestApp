using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Pages;

public partial class DatePage : ContentPage
{
    public DatePage(string date)
    {
        InitializeComponent();
        DateLabel.Text = date;
    }
}
