using Mdm.Core;
using Mdm.Core.Grains;

namespace Mdm.Silo.Grains;


public class ElementGrain(IGrainFactory grainFactory) : Grain<Element>, IElementGrain
{
    public async Task CreateAsync(Element element)
    {
        State = element;
        var registry = grainFactory.GetGrain<IElementRegistryGrain>(Constants.ElementRegistryGrainKey);
        await registry.RegisterElementAsync(this.GetPrimaryKey(), element.Type.Id);
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