using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Profesor
    {
        private String nombre;
        private Alumno alumno1=new Alumno();

        public string Nombre { get => nombre; set => nombre = value; }
        internal Alumno Alumno1 { get => alumno1; set => alumno1 = value; }
        public void capturarDatosAlumno()
        {
            string nombre;
            int nl;
            Console.WriteLine("ingrese NL: ");
            nl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese nombre: ");
            nombre = Console.ReadLine();
             alumno1.Nl = nl;
             alumno1.Nombre = nombre;
            
        }
        public void capturarMaterias()
        {
            string materia;
            for(int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Ingrese Materia: ");
                materia = Console.ReadLine();
                alumno1.agregarMaterias(materia);
            }
        }

        public void capturarCalificaciones()
        {
            int calificacion;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese calificacion de: " + alumno1.Materias[i]);
                calificacion = Convert.ToInt32(Console.ReadLine());
                alumno1.agregarCalificaciones(calificacion);
            }
        }
    }
}
