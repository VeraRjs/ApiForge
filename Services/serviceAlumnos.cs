using System;
using System.Collections.Generic;
using System.Linq;


namespace ApiForge{
public class ServiceAlumnos: IServiceAlumnos{


          private  static List<Alumnos> list;
        public ServiceAlumnos()
        {
            list = new List<Alumnos>();
            list.Add(new Alumnos()
            {
                nombre = "Fernando",
                apellido = "niz",
                especialidad = "IT",
                edad = 18,
                dni = "43798787",
                ID = 1
            });
        
        }
        public List<Alumnos> GetAll()
        {
            return list;
        }    
        public Alumnos Get(int id)
        {
            return list.FirstOrDefault(b => b.ID == id);
        }
        public void Save(Alumnos alumnos)
        {
            this.Delete(alumnos.ID);
            list.Add(alumnos);
        }
        public void Delete(int id)
        {
            var alumnos = this.Get(id);
            if (alumnos != null)
            {
                list.Remove(alumnos);
            }
        }
}

}