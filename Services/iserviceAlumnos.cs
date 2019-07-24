using System.Collections.Generic;
using System.Linq;
namespace ApiForge{
    public interface IServiceAlumnos
    {
        List<Alumnos> GetAll();
        Alumnos Get(int id);
        void Save(Alumnos alumnos);
        void Delete (int id);
    }
}