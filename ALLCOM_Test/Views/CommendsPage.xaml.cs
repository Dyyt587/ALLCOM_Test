using ALLCOM_Test.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace ALLCOM_Test.Views;

public sealed partial class CommendsPage : Page
{
    public CommendsViewModel ViewModel
    {
        get;
    }

    public CommendsPage()
    {
        ViewModel = App.GetService<CommendsViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
