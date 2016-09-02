using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCoreAPI01.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebCoreAPI01.Controllers
{
    [Route("api/[controller]")]
    public class EmpleadoController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            var empleados = new List<Empleado>
           {
               new Empleado {IDEmpleado = 1,Nombres = "Jalpesh",Apellidos = "Vadgama",Designacion = "Technical Architect"},
               new Empleado {IDEmpleado = 2,Nombres = "Vishal",Apellidos = "Vadgama",Designacion = "Technical Lead"}
           };
           return empleados;
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
