using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class SQLServerConfiguration
    {

        public SQLServerConfiguration(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public string connectionString { get; set; }

    }
}
