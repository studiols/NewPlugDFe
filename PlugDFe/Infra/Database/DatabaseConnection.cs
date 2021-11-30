using System.Collections.Generic;
using System.Data;

namespace PlugDFe.Infra.Database
{
    public interface DatabaseConnection
    {
        DataTable Query(string txtSql);
        DataTable QueryPar(string txtSql, Dictionary<string, object> parameters);
        int Command(string txtSql);
        int CommandPar(string txtSql, Dictionary<string, object> parameters);
        void OpenConnection();
        void CloseConnection();
    }
}
