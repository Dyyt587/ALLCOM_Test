using ALLCOM_Test.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace ALLCOM_Test.Views;

public sealed partial class PartsPage : Page
{
    public PartsViewModel ViewModel
    {
        get;
    }

    public PartsPage()
    {
        ViewModel = App.GetService<PartsViewModel>();
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
