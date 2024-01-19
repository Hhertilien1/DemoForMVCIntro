using System.Data;
using System;
using DEMOFORMVC.Models;
using Dapper;

namespace DEMOFORMVC
{
    public class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;
        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;

        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

