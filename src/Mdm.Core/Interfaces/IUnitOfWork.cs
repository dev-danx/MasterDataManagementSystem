namespace Mdm.Core.Interfaces;

public interface IUnitOfWork
{
    public IElementRepository Element { get; }
}