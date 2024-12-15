using Mdm.Core;
using Mdm.Core.Grains;
using Orleans;

namespace Mdm.Silo.Grains;

public class ElementTypeGrain : Grain, IElementTypeGrain
{
    private ElementType? _state;
    
    public Task CreateAsync(ElementType elementType)
    {
        _state = elementType;
        return Task.CompletedTask;
    }

    public Task<ElementType?> GetAsync()
    {
        return Task.FromResult(_state);
    }
}