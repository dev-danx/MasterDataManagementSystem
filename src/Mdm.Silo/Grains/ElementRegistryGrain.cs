using Mdm.Core.Grains;

namespace Mdm.Silo.Grains;

public class ElementRegistryGrain(ILogger<ElementRegistryGrain> logger): Grain<Dictionary<Guid,Guid>>, IElementRegistryGrain
{
    public async Task RegisterElementAsync(Guid elementId, Guid typeId)
    {
        logger.LogInformation("Registering element {elementId} with type {typeId}",elementId,typeId);
        State.Add(typeId,elementId);
        await WriteStateAsync();
    }

    public Task<List<Guid>> ElementsByTypeAsync(Guid? typeId)
    {
        if (!typeId.HasValue)
        {
            return Task.FromResult(State.Values.ToList());
        }
        var result = State.Where(x => x.Key == typeId);
        return Task.FromResult(result.Select(x => x.Value).ToList());
    }
}