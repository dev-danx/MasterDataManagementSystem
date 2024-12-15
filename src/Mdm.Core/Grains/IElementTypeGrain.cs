using Orleans;

namespace Mdm.Core.Grains;

public interface IElementTypeGrain : IGrainWithGuidKey
{
    Task CreateAsync(ElementType elementType);
    Task<ElementType> GetAsync();
}