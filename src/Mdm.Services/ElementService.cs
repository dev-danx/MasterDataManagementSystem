using Mdm.Core;
using Mdm.Core.Interfaces;
using Mdm.Services.Interfaces;

namespace Mdm.Services;

public class ElementService(IUnitOfWork unitOfWork) : IElementService
{
    
    public async Task CreateAsync(Element element)
    {
        await unitOfWork.Element.CreateAsync(element);
    }

    public Task UpdateAsync(Element element)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Element> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Element>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}