namespace Mdm.Core.Grains;

public interface IElementRegistryGrain : IGrainWithStringKey
{
    Task RegisterElementAsync(Guid elementId, Guid typeId);
    Task<List<Guid>> ElementsByTypeAsync(Guid? typeId);
}