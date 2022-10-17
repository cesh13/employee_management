using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EmployeeManagementDataAccess.DataConnection;

public class SqlDataAccess : IDataAccess
{
    private readonly IConfiguration _config;
    private string _connectionId;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
        _connectionId = "Default";
    }

    public async Task Execute<T>(string storedProcedure, T parameters)
    {
        using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(_connectionId)))
        {
            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<IEnumerable<T>> RetrieveMultiple<T, U>(string storedProcedure, U parameters)
    {
        using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(_connectionId)))
        {
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<T> RetrieveOne<T, U>(string storedProcedure, U parameters)
    {
        using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(_connectionId)))
        {
            return (await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure)).FirstOrDefault();
        }
    }
}
