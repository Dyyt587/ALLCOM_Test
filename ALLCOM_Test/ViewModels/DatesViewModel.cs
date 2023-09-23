using System.Collections.ObjectModel;

using ALLCOM_Test.Contracts.ViewModels;
using ALLCOM_Test.Core.Contracts.Services;
using ALLCOM_Test.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace ALLCOM_Test.ViewModels;

public partial class DatesViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DatesViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
