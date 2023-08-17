using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlowChartEditor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChartEditor.ViewModels;

public partial class PgPgMainViewModel : ObservableRecipient
{
    [ObservableProperty]
    ObservableCollection<TVItem> tvitems = new();

    [ObservableProperty]
    TVItem selectedTVItem;

    [RelayCommand]
    void AddDocument()
    {
        Tvitems.Add(new(Guid.NewGuid(), $"Algorithm {Tvitems.Count + 1}", "c")); 
        SelectedTVItem = Tvitems.Last();
    }
    
    [RelayCommand]
    void CloseDocument()
    {
        var idx = Tvitems.IndexOf(SelectedTVItem);
        Tvitems.RemoveAt(idx);
        SelectedTVItem = Tvitems.LastOrDefault();
    }
}
