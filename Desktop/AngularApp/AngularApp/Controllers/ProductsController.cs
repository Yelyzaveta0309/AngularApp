using AngularApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AngularApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet]

        public IEnumerable<Product> Get()
        {
            var products = new List<Product>();

            using (SqlConnection connection = new SqlConnection("Data Source = SQL5104.site4now.net; Initial Catalog = db_a85176_liza03; User Id = db_a85176_liza03_admin; Password = lizali03"))
            {
                connection.Open();

                products = connection.Query<Product>("SELECT * FROM [Products];").ToList();
            }
            return products;
        }
       
    }
}
