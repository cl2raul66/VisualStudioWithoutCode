using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowToCSharpConverter;

public class Parser
{
    readonly List<string> Flows;
    public string Title { get; private set; } 

    public Parser()
    {
        Flows = new() { "Begin", "End" };
    }

    void SetDocumentTitle(string title) => Title = title; 

    async void ReadDocument(string path)
    {
        using (StringReader stringReader = new(path))
        {
            var rDocument = await stringReader.ReadToEndAsync();
            foreach (var item in rDocument.Split("->"))
            {
                Flows.Insert(1, item);
            }
        }
    }
}
