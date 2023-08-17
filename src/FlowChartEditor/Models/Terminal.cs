using FlowChartEditor.Tools.Enumerations;

namespace FlowChartEditor.Models;

public class Terminal : Instruction
{
    public Terminal(Instructions typeInstruction)
    {
        TypeInstruction = typeInstruction;
    }
}
