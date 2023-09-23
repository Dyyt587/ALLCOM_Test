using ALLCOM_Test.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ALLCOM_Test.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class DatesPage : Page
{
    public DatesViewModel ViewModel
    {
        get;
    }

    public DatesPage()
    {
        ViewModel = App.GetService<DatesViewModel>();
        InitializeComponent();
    }
}
