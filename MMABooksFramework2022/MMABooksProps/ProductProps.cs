/*using MMABooksTools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

using System;

using MMABooksTools;
using DBDataReader = MySql.Data.MySqlClient.MySqlDataReader;

using System.Text.Json;
using System.Text.Json.Serialization;
using MySql.Data.MySqlClient;

namespace MMABooksProps
{
    internal class ProductProps : IBaseProps
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public string GetState()
        {
            throw new NotImplementedException();
        }

        public void SetState(string jsonString)
        {
            throw new NotImplementedException();
        }

        public void SetState(DBDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
