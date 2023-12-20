using ActividadEntrenamiento__POO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEntrenamiento_POO
{
    public class Trabajo : Persona, ITrabajo
    {
        // Propiedades encapsuladas
        private string empresa;
        private int añosExperiencia;

        private string profesion; //Propiedad - atributos
        private string rolprofesion; //Propiedad

        //Metodo Get and Set
        public string Profesion { get => profesion; set => profesion = value; }
        public string Rolprofesion { get => rolprofesion; set => rolprofesion = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public int AñosExperiencia { get => añosExperiencia; set => añosExperiencia = value; }


        // Implementación del método abstracto
        public override void Presentarse()
        {
            Console.WriteLine(string.IsNullOrEmpty(empresa)
            ? "No se ha proporcionado información sobre la empresa."
            : $"Hola, trabajo en {empresa} con {añosExperiencia} años de experiencia.");
        }


        //Metodo
        public void AgregarProfesion(string _profesion, string _rolprofesion)
        {
            profesion = _profesion;
            rolprofesion = _rolprofesion;
            Console.WriteLine("Se ha cumplido la gestión para conseguir empleo.");
        }


    }
}
