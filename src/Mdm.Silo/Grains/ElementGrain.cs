using Mdm.Core;
using Mdm.Core.Grains;
using Orleans;

namespace Mdm.Silo.Grains;


public class ElementGrain : Grain, IElementGrain
{
    private Element? _state;
    public Task CreateAsync(Element element)
    {
        _state = element;
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Element element)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }
}