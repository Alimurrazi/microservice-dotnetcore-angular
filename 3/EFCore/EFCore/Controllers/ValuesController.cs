using EFCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public ValuesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var entity = _context.Model.FindEntityType(typeof(Student).FullName);

            var tableName = entity.GetTableName();
            var schemaName = entity.GetSchema();
            var key = entity.FindPrimaryKey();
            var properties = entity.GetProperties();

            return Ok(entity);
        }
    }
}
