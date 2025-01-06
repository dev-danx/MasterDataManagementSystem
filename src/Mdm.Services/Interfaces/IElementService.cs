using Mdm.Core;

namespace Mdm.Services.Interfaces;

public interface IElementService
{
    Task CreateAsync(Element element);
    Task UpdateAsync(Element element);
    Task DeleteAsync(long id);
    Task<Element> GetByIdAsync(long id);
    Task<List<Element>> GetAllAsync();
    
}