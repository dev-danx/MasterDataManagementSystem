using Orleans;

namespace Mdm.Core.Grains;

public interface IElementGrain : IGrainWithGuidKey
{
    Task CreateAsync(Element element);
    Task UpdateAsync(Element element);
    Task DeleteAsync();
}