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
        //Properties for the Customer
        public string CustomerID { get; set; } = "";

        public string Name { get; set; } = "";

        public string Address { get; set; } = "";

        public string State { get; set; } = "";

        public string ZipCode { get; set; } = "";


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
