using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowToCSharpConverter;

public class Code
{
    readonly List<string> Instructions = new();

    void ExtractInstruction(string code) => Instructions.AddRange(code.Split("->"));
}
