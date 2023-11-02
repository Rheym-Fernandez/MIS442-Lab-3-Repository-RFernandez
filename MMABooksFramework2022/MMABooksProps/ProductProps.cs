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
        //Properties for the Product
        public int ProductID { get; set; } = 0;

        public string ProductCode { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal UnitPrice { get; set; } = 0;
        public int OnHandQuantity { get; set; } = 0;

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
