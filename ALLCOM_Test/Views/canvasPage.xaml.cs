using ALLCOM_Test.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ALLCOM_Test.Views;

public sealed partial class canvasPage : Page
{
    public canvasViewModel ViewModel
    {
        get;
    }

    public canvasPage()
    {
        ViewModel = App.GetService<canvasViewModel>();
        InitializeComponent();
    }
}
