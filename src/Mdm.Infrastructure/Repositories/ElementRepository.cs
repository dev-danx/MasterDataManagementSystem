using System.Data;
using Dapper.Contrib.Extensions;
using Mdm.Core;
using Mdm.Core.Interfaces;
using Mdm.Infrastructure.Entities;

namespace Mdm.Infrastructure.Repositories;

public class ElementRepository(IDbConnection connection) : IElementRepository
{
    public async Task<long> CreateAsync(Element model)
    {
        using var con = connection;
        var entity = ElementEntity.FromModel(model);
        await con.InsertAsync(entity);
        return entity.Id;
    }
}