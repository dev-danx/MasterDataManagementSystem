using System.Data;
using Mdm.Core;
using Mdm.Core.Interfaces;
using Mdm.Infrastructure.Repositories;

namespace Mdm.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IDbConnection connection)
    {
        Element = new ElementRepository(connection);
    }

    public IElementRepository Element { get; }
}