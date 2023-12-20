using ActividadEntrenamiento__POO;
using ActividadEntrenamiento_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEntrenamiento_POO
{
    class Program // Clase Principal
    {
        static void Main()
        {
            //Interfaz
            Console.WriteLine("Interfaz");
            Trabajo objTrabajo = new Trabajo();
            objTrabajo.AgregarProfesion("Médico", "Médico Pediatra");

            Console.WriteLine("Profesión: " + objTrabajo.Profesion + "  " + "Rol en el que se encuentra en su profesión: " + objTrabajo.Rolprofesion);



            // Polimorfismo

            Console.WriteLine("\nPolimorfismo");
            Profesion profesion1 = new Medico();
            Profesion profesion2 = new Constructor();

            profesion1.Ocupacion();
            profesion2.Ocupacion();


            // Implementación del método abstracto
            Console.WriteLine("\nMétodo Abstracto");
            Console.Write("Ingrese el nombre de la empresa: ");
            objTrabajo.Empresa = Console.ReadLine();

            Console.Write("Ingrese los años de experiencia: ");
            if (int.TryParse(Console.ReadLine(), out int añosExperiencia))
            {
                objTrabajo.AñosExperiencia = añosExperiencia;
            }
            else
            {
                Console.WriteLine("Entrada no válida para años de experiencia.");
               
            }

            
            objTrabajo.Presentarse();
            Console.ReadLine();
        }



    }




}
