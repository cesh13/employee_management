namespace EmployeeManagementDataAccess.DataConnection
{
    public interface IDataAccess
    {
        Task<IEnumerable<T>> RetrieveMultiple<T, U>(string sql, U parameters);
        Task<T> RetrieveOne<T, U>(string sql, U parameters);
        Task Execute<T>(string sql, T parameters);
    }
}
