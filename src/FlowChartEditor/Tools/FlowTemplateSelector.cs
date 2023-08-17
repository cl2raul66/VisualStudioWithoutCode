using FlowChartEditor.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FlowChartEditor.Tools;

public class FlowTemplateSelector : DataTemplateSelector
{
    public DataTemplate TerminalTemplate { get; set; }
    public DataTemplate ConnectorTemplate { get; set; }
    public DataTemplate FlowLineTemplate { get; set; }
    public DataTemplate InputTemplate { get; set; }
    public DataTemplate OutputTemplate { get; set; }
    public DataTemplate ProcessTemplate { get; set; }
    public DataTemplate DecisionTemplate { get; set; }
    public DataTemplate LoopTemplate { get; set; }

    protected override DataTemplate SelectTemplateCore(object item)
    {
        return item switch
        {
            Terminal _ => TerminalTemplate,
            Connector _ => ConnectorTemplate,
            FlowLine _ => FlowLineTemplate,
            Input _ => InputTemplate,
            Output _ => OutputTemplate,
            Process _ => ProcessTemplate,
            Decision _ => DecisionTemplate,
            Loop _ => LoopTemplate,
            _ => base.SelectTemplateCore(item)
        };
    }
}
