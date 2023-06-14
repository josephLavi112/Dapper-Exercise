using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Exercise 
 
{
    public class DapperProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;

        public DapperProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }

       
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("select* from products; ");
        }
        public void InsertProduct(string newProductName)
        {
            _conn.Execute("INSERT INTO PRODUCTS (Name) VALUES (@productName);",
             new { departmentName = newProductName });
        }
    }
}
