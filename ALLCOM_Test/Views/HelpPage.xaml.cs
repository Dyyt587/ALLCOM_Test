using ALLCOM_Test.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ALLCOM_Test.Views;

public sealed partial class HelpPage : Page
{
    public HelpViewModel ViewModel
    {
        get;
    }

    public HelpPage()
    {
        ViewModel = App.GetService<HelpViewModel>();
        InitializeComponent();
    }
}
