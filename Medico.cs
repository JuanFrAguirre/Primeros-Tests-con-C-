using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._5
{
    class Medico
    {
        public int Matricula { get; set; }

        public string Nombre { get; set; }

        public int Sexo { get; set; }

        public int Especialidad { get; set; }

        public double Precio { get; set; }

        // -----------------------------------------

        public Medico(int matricula, string nombre, int sexo, int especialidad, double precio)
        {
            Matricula = matricula;

            Nombre = nombre;

            Sexo = sexo;

            Especialidad = especialidad;

            Precio = precio;
        }

        // -----------------------------------------





        public string MostrarInfo()
        {
            string sSexo, sEspecialidad;

            switch (Sexo)
            {
                case 1: sSexo = "Masculino";
                    break;
                case 2:
                    sSexo = "Femenino";
                    break;
                case 3:
                    sSexo = "No binario";
                    break;
                default: sSexo = "No especifica";
                    break;
            }

            switch (Especialidad)
            {
                case 1:
                    sEspecialidad = "Cardiologia";
                    break;
                case 2:
                    sEspecialidad = "Odontologia";
                    break;
                case 3:
                    sEspecialidad = "Pediatria";
                    break;
                default:
                    sEspecialidad = "No especifica";
                    break;
            }

            string mensaje = $"Matricula: {Matricula}\n" +
                $"Nombre: {Nombre}\n" +
                $"Sexo: {sSexo}\n" +
                $"Especialidad: {sEspecialidad}\n" +
                $"Precio Consulta: {Precio}";

            return mensaje;
        }

        public double CalcularPrecioGral(int contadorConsultas, double totalAcumulado)
        {
            return totalAcumulado / contadorConsultas;
        }
    }
}
