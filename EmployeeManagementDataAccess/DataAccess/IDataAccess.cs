using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDataAccess.DataAccess
{
    interface IDataAccess
    {
        List<T> RetrieveMultiple<T, U>(string sql, U parameters);
        T RetrieveOne<T, U>(string sql, U parameters);
        void Execute<T>(string sql, T parameters);
    }
}
