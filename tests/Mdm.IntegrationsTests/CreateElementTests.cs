using System.Data;
using Bogus;
using Mdm.Core;
using Mdm.Infrastructure;
using Mdm.Services;
using Mdm.Services.Interfaces;
using Microsoft.Data.Sqlite;

namespace Mdm.IntegrationsTests;

public class CreateElementTests
{
    private readonly IElementService _service;

    public CreateElementTests()
    {
        var unitOfWork = new UnitOfWork(TestDatabase.CreateConnection());
        _service = new ElementService(unitOfWork);
    }
    
    [Fact]
    public async Task Create()
    {
        var testDataGenerator = new Faker<Element>();
        var testData = testDataGenerator.Generate();
        await _service.CreateAsync(testData);
    }
}