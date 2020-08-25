using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RegistrationInformation.Models;

namespace RegistrationInformation.Controllers
{
    public class ServiceController : Controller
    {
        public MyDbContext context;
        public ServiceController(MyDbContext _context)
        {
            context = _context;
        }
        public IActionResult GetAllProvinces()
        {
           
            using(var db = new MyDbContext())
            {
                var data = context.provinces.ToList();
                return Ok(data);
            }
        }
        public IActionResult GetAllDistrictByProvinceId(int? id)
        {
            using (var connection = new SqlConnection("Server=TUNGVADILLO\\SQLEXPRESS;Database=VietNamDb;Trusted_Connection=True;"))
            {
                string query = "select * from district where district._province_id= @Id";
                var districts = connection.Query<District>(query, new { Id = id });

                return Ok(districts);
            }
        }
        public IActionResult GetAllWardByDistrictId(int? id)
        {
            using (var connection = new SqlConnection("Server=TUNGVADILLO\\SQLEXPRESS;Database=VietNamDb;Trusted_Connection=True;"))
            {
                string query = "select * from ward where ward._district_id = @Id";
                var districts = connection.Query<District>(query, new { Id = id });

                return Ok(districts);
            }
        }
    }
}
