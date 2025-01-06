using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Mdm.IntegrationsTests;

public static class TestDatabase
{
    public static IDbConnection CreateConnection()
    {
        var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();
        // Create a table
        connection.Execute(@"
CREATE TABLE Element (
    Id INTEGER PRIMARY KEY, 
    Name TEXT, 
    TypeId INTEGER,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
                     )");

        return connection;
    }
}