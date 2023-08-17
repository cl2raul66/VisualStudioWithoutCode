using FlowChartEditor.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChartEditor.Tools;

public class TVItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate PgDocument { get; set; }

    protected override DataTemplate SelectTemplateCore(object item)
    {
        if (item is TVItem tvItem)
        {
            return tvItem.DocumentType switch
            {
                _ => PgDocument!
            };
        }

        return base.SelectTemplateCore(item);
    }
}
