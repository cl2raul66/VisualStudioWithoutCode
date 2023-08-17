namespace FlowChartEditor.Models;

public class FlowLine : Flow
{
    public int Start { get; set; }
    public int End { get; set; }
    public string Direction => End > Start ? "down" :  "up";

    public FlowLine(int idx, int? end)
    {
        Idx = idx;
        Start = idx - 1;
        End = end is null ? idx + 1 : end.Value;
    }
}
