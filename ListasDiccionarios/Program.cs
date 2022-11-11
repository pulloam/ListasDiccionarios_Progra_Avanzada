using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDiccionarios {
    class Program {
        static void Main(string[] args) {
            LinqTrabajo listaUno = new LinqTrabajo();

            listaUno.AgregarAlumnos("Juanito", 3.9f);
            listaUno.AgregarAlumnos("Leo", 5f);
            listaUno.AgregarAlumnos("Emilia", 5.5f);
            listaUno.AgregarAlumnos("Paula", 4.4f);
            listaUno.AgregarAlumnos("Luis", 2.9f);

            listaUno.AlumnosAprobados();


            //listaUno.AgregarNombre("Juanito");
            //listaUno.AgregarNombre("Leo");
            //listaUno.AgregarNombre("Emilia");
            //listaUno.AgregarNombre("Luis");
            //listaUno.AgregarNombre("Pedro");
            //listaUno.AgregarNombre("Alejandro");

            //listaUno.ElementosPares();
            //listaUno.BuscarNombres();



            //ListasDiccionarios diccionarioUno = new ListasDiccionarios();
            //diccionarioUno.AgregarNombreDiccionario(111, "Juanito");
            //diccionarioUno.AgregarNombreDiccionario(222, "Maria");
            //diccionarioUno.AgregarNombreDiccionario(333, "Pepito");
            //diccionarioUno.AgregarNombreDiccionario(444, "Emilia");
            //diccionarioUno.AgregarNombreDiccionario(555, "Valentina");

            //diccionarioUno.ObtenerNombresDiccionario();

            //diccionarioUno.BuscarNombreDiccionario(555);
            
            //listaUno.AgregarNombre("Juanito");
            //listaUno.AgregarNombre("Maria");
            //listaUno.AgregarNombre("Pepito");
            //listaUno.AgregarNombre("Emilia");
            //listaUno.AgregarNombre("Valentina");

            //listaUno.ObtenerNombresLista();

            //listaUno.EliminarNombre(2);

            //listaUno.EliminarNombre("Valentina");

            //listaUno.ObtenerNombresLista();

            Console.ReadKey();
        }
    }
}
