using AngularApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AngularApp.Controllers
{
    [Route("api/productsInfo")]
    [ApiController]
    public class ProductsInfoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ProductInfo> Get()
        {

            var products = new List<ProductInfo>();

            using (SqlConnection connection = new SqlConnection("Data Source = SQL5104.site4now.net; Initial Catalog = db_a85176_liza03; User Id = db_a85176_liza03_admin; Password = lizali03"))
            {
                connection.Open();

                var result = connection.Query("SELECT [Products].[Name],[Products].[Price],[Categories].[Name] AS [Category],[Manufacturers].[Name] AS [Manufacturer] FROM [Products] JOIN [Categories] ON [Products].[CategoryId] = [Categories].[Id] JOIN [Manufacturers] ON [Products].[ManufacturerId] = [Manufacturers].[Id];");

                foreach (var item in result)
                {

                    ProductInfo productInfo = new ProductInfo(item.Name, item.Price, item.Category, item.Manufacturer);
                    products.Add(productInfo);
                }
            }
            return products;
        }
    }
}
