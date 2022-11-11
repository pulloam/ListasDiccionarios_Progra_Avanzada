using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDiccionarios {
    class LinqTrabajo {
        private List<string> losNombres = new List<string>();
        private List<Alumno> losAlumnos = new List<Alumno>();
        private int[] numeros = {3,6,1,5,9,2,4};

        public void AgregarNombre(string nombre) {
            losNombres.Add(nombre);
        }

        public void AgregarAlumnos(string nombre, float nota) {
            losAlumnos.Add(new Alumno(nombre, nota));
        }

        public void AlumnosAprobados() {
            string[] aprobados = (from a in losAlumnos
                                  where a.Nota >= 4
                                  orderby a.Nota
                                  select a.Nombre).ToArray();


            foreach (string n in aprobados) {
                    Console.WriteLine(n);
            }

            float promedio = (from a in losAlumnos
                              select a.Nota).Average();

            Alumno[] sobrePromedio = (from a in losAlumnos
                                      where a.Nota >= promedio
                                      orderby a.Nota
                                      select a).ToArray();

            Console.WriteLine("Promedio " + promedio);
            Console.WriteLine("Alumnos sobre el promedio");

            foreach (Alumno a in sobrePromedio)
                Console.WriteLine("Nombre : " + a.Nombre + ", Nota :" + a.Nota);

            //Linq métodos
            float sumaNota = losAlumnos.Sum(a => a.Nota);
            Console.WriteLine("la suma es " + sumaNota);
        }

        public void BuscarNombres() {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ejecución inmediata de Linq en lista losNombres");
            List<string> nombres = (from n in losNombres
                           where n.Length >= 5
                           orderby n
                           select n).ToList();

            foreach (string n in nombres)
                Console.WriteLine(n);
        }

        public void ElementosPares() {
            //Ejecucion inmediata
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ejecución inmediata de Linq");

            int[] pares = (from num in numeros 
                           where num % 2 == 0
                           orderby num descending
                           select num).ToArray();

            foreach(int num in pares)
                Console.WriteLine(num);

            Console.WriteLine("\nEjecución diferida");

            var paresDos = from num in numeros
                           where num % 2 == 0
                           orderby num descending
                           select num;

            numeros[0] = 8;

            foreach (int num in paresDos) {
                Console.WriteLine(num);
            }


        }

    }
}
