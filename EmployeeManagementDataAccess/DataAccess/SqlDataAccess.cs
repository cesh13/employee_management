using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDataAccess.DataAccess;

class SqlDataAccess : IDataAccess
{
    public void Execute<T>(string sql, T parameters)
    {
        throw new NotImplementedException();
    }

    public List<T> RetrieveMultiple<T, U>(string sql, U parameters)
    {
        throw new NotImplementedException();
    }

    public T RetrieveOne<T, U>(string sql, U parameters)
    {
        throw new NotImplementedException();
    }
}
