using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEntrenamiento__POO
{
    public interface ITrabajo //Interfaz
    {
        string Profesion { get; set; }
        string Rolprofesion { get; set; }

        void AgregarProfesion(string _profesion, string _rolprofesion);
    }
}
