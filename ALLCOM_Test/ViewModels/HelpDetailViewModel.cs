using ALLCOM_Test.Contracts.ViewModels;
using ALLCOM_Test.Core.Contracts.Services;
using ALLCOM_Test.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace ALLCOM_Test.ViewModels;

public partial class HelpDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public HelpDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
