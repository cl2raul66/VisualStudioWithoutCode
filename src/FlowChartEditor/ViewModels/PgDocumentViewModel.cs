using CommunityToolkit.Mvvm.ComponentModel;
using FlowChartEditor.Models;
using FlowChartEditor.Tools.Enumerations;
using FlowToCSharpConverter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChartEditor.ViewModels;

public partial class PgDocumentViewModel : ObservableRecipient
{
    //readonly List<string> CurrentInstructions = new() { Instructions.Begin.ToString(), Instructions.End.ToString() };

    public PgDocumentViewModel()
    {        
        CodeContent = $"{Instructions.Begin}->{Instructions.End}";
    }

    [ObservableProperty]
    ObservableCollection<Flow> currentFlow = new();

    [ObservableProperty]
    Flow selectedFlow;

    [ObservableProperty]
    string codeContent;

    [ObservableProperty]
    int idxCurrentFlow;
    
    [ObservableProperty]
    int idxCurrentInstruction;

    #region Extra
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        if (e.PropertyName == nameof(CodeContent))
        {
            _ = ChangeCodecontent();
        }
    }

    async Task ChangeCodecontent()
    {
        await Task.CompletedTask;
    }
    #endregion
}
