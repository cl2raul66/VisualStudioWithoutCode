using FlowChartEditor.Tools.Enumerations;
using System.Collections.Generic;

namespace FlowChartEditor.Models;

public class Instruction : Flow
{
    public Instructions TypeInstruction { get; set; }
    public List<Property>? Properties { get; set; }
}
