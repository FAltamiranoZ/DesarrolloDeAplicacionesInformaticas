using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1RepasoExamen
{
    class Aspirante
    {
        public String nombre, apellidoPaterno, apellidoMaterno, sexo, correo, fechaDeNacimiento, programa;
        public int grado;
        public Aspirante(String nombre, String apellidoPaterno, String apellidoMaterno, String sexo, String correo, String fechaDeNacimiento, int grado, string programa)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.sexo = sexo;
            this.correo = correo;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.grado = grado;
            this.programa = programa;
        }
        public Aspirante(String nombre, String apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
            this.nombre = nombre;
        }

    }
}
