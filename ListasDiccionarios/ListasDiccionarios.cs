using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDiccionarios {
    class ListasDiccionarios {
        private List<string> losNombres = new List<string>();
        private Dictionary<int, string> diccionarioNombres = new Dictionary<int, string>();

        public void AgregarNombre(string nombre) {
            losNombres.Add(nombre);
        }

        public void AgregarNombreDiccionario(int llave, string nombre) {
            diccionarioNombres.Add(llave, nombre);
        }

        public void BuscarNombreDiccionario(int llave) {
            string nombre = "";

            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Buscando nombre con llave " + llave);
            if(diccionarioNombres.TryGetValue(llave, out nombre)) { 
                Console.WriteLine("Nombre " + nombre);
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No existe llave en el diccionario");
            }
        }

        public void EliminarNombre(int indice) {
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Eliminando índice " + indice);
            losNombres.RemoveAt(indice);
        }

        public void EliminarNombre(string nombre) {
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Eliminando nombre " + nombre);
            for (int x = 0; x < losNombres.Count;++x) {
                if(losNombres[x] == nombre) {
                    Console.WriteLine("Nombre eliminado en la posición " + x);
                    losNombres.RemoveAt(x);
                }
            }
        }

        public void ObtenerNombresDiccionario() {
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Recorrido del diccionario");
            foreach (KeyValuePair<int, string> elemento in diccionarioNombres) {
                Console.WriteLine("LLave : " + elemento.Key + " - Valor : " + elemento.Value);
            }

        }

        public void ObtenerNombresLista() {
            //Console.WriteLine("\n------------------------\n");

            //Console.WriteLine("Recorrido con foreach");
            //foreach (string nom in losNombres) {
            //    Console.WriteLine("Nombre " + nom);
            //}
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("Recorrido tradicional for");
            for(int x = 0; x < losNombres.Count;++x) {
                Console.WriteLine("Nombre en la posición " + x +" -> " + losNombres[x]);
            }

        }

    }
}
