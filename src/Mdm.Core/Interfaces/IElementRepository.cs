namespace Mdm.Core.Interfaces;

public interface IElementRepository
{
    Task<long> CreateAsync(Element model);
}