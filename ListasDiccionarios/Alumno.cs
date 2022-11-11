using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDiccionarios {
    class Alumno {
        public string Nombre { get; set; }
        public float Nota { get; set; }

        public Alumno(string nombre, float nota) {
            this.Nombre = nombre;
            this.Nota = nota;
        }
    }
}
