using Mdm.Core;
using Mdm.Core.Grains;
using Orleans;

namespace Mdm.Silo.Grains;

public class ElementTypeGrain : Grain<ElementType>, IElementTypeGrain
{
    
    public Task CreateAsync(ElementType elementType)
    {
        State = elementType;
        return Task.CompletedTask;
    }

    public Task<ElementType> GetAsync()
    {
        return Task.FromResult(State);
    }
}