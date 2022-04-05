using AngularApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AngularApp.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection("Data Source = SQL5104.site4now.net; Initial Catalog = db_a85176_liza03; User Id = db_a85176_liza03_admin; Password = lizali03"))
            {
                connection.Open();

                categories = connection.Query<Category>("SELECT * FROM Categories;").ToList();
            }
            return categories;
        }
    }
}
