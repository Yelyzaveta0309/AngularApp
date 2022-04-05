using AngularApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AngularApp.Controllers
{
    [Route("api/manufacturers")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Manufacturer> Get()
        {
            var manufacturers = new List<Manufacturer>();

            using (SqlConnection connection = new SqlConnection("Data Source = SQL5104.site4now.net; Initial Catalog = db_a85176_liza03; User Id = db_a85176_liza03_admin; Password = lizali03"))
            {
                connection.Open();

                manufacturers = connection.Query<Manufacturer>("SELECT * FROM Manufacturer;").ToList();
            }
            return manufacturers;
        }
    }
}
