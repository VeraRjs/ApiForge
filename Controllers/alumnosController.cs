using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace ApiForge{

    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IServiceAlumnos serviceAlumnos;
        public AlumnosController(IServiceAlumnos serviceAlumnos)
        {
            this.serviceAlumnos = serviceAlumnos;
        }
        // GET api/alumnos
        [HttpGet]
        public ActionResult<IEnumerable<Alumnos>> Get()
        {
            return serviceAlumnos.GetAll();
        }

        // GET api/alumnos/5
        [HttpGet("{id}")]
        public ActionResult<Alumnos> Get(int id)
        {
            return serviceAlumnos.Get(id);
        }

        // POST api/alumnos
        [HttpPost]
        public void Post([FromBody] Alumnos alumnos)
        {
            serviceAlumnos.Save(alumnos);
        }

        // PUT api/alumnos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Alumnos alumnos)
        {
            serviceAlumnos.Save(alumnos);
        }

        // DELETE api/alumnos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            serviceAlumnos.Delete(id);
        }
    }
}