using System;
using System.Collections.Generic;
using System.Text;

using MMABooksTools;
using DBDataReader = MySql.Data.MySqlClient.MySqlDataReader;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace MMABooksProps
{
    public class CustomerProps : IBaseProps
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
