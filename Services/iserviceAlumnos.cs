using System.Collections.Generic;
using System.Linq;
namespace apiForge{
    public interface iserviceAlumnos
    {
        List<Alumnos> GetAll();
        Alumnos Get(int id);
        void Save(Alumnos alumnos);
        void Delete (int id);
    }
}