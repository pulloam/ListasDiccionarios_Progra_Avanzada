using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDiccionarios {
    class Program {
        static void Main(string[] args) {
            ListasDiccionarios listaUno = new ListasDiccionarios();
            ListasDiccionarios diccionarioUno = new ListasDiccionarios();

            diccionarioUno.AgregarNombreDiccionario(111, "Juanito");
            diccionarioUno.AgregarNombreDiccionario(222, "Maria");
            diccionarioUno.AgregarNombreDiccionario(333, "Pepito");
            diccionarioUno.AgregarNombreDiccionario(444, "Emilia");
            diccionarioUno.AgregarNombreDiccionario(555, "Valentina");

            diccionarioUno.ObtenerNombresDiccionario();

            diccionarioUno.BuscarNombreDiccionario(555);
            
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
