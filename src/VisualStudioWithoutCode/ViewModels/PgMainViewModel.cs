using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioWithoutCode.ViewModels;

public partial class PgMainViewModel : ObservableRecipient
{
    [RelayCommand]
    void CreateProject() { }

    #region Extra
    protected override void OnActivated()
    {
        base.OnActivated();
    }
    #endregion
}
