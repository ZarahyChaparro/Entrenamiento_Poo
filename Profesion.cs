using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEntrenamiento__POO
{
    class Profesion //Polimorfismo
    {
        public virtual void Ocupacion()
        {
            Console.WriteLine("Ejerciendo una profesión");
        }
    }

    class Medico : Profesion
    {
        public override void Ocupacion()
        {
            Console.WriteLine("Cirugías y Chequeos");
        }
    }

    class Constructor : Profesion
    {
        public override void Ocupacion()
        {
            Console.WriteLine("Arreglos y Construcción de casas");
        }
    }

}

