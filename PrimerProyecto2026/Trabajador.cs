using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto2026
{
    public class Trabajador
    {
        public int Sueldo { get; set; }
        public string Nombres { get; set; }

        public String Nombres2 { get; set; }

        public string Apellidos { get; set; }

        public string NombresCompletos { get; set; }

        public string DNI { get; set; }

        public int TipoTrabajador { get; set; }

        public double calcularSueldoNeto()
        {

            double sueldoNeto = 0;
            sueldoNeto = Sueldo - (Sueldo * 0.08);

            return sueldoNeto;

        }

        public void asignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;

        }
    }
}