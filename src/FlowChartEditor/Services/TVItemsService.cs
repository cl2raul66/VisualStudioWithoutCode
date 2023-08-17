using FlowChartEditor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChartEditor.Services;

public class TVItemsService
{
    readonly List<TVItem> tvitems = new();

    public IEnumerable<TVItem> GetTVItems => tvitems;

    public TVItem GetTvitemById(Guid id) => tvitems.FirstOrDefault(x=>x.Id == id);
}
