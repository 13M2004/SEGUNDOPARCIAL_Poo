using Segundo_Parcial.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Clase_Hija
{
    //Hereencia de PERSONA
    internal class Gerente_Produccion : Persona, IJubilacion //Clase nieto 
    {

        //Interface
        public override void MaxAnos()
        {
            Console.WriteLine("El Gerente de Produción tiene 7 año");
        }

        //Abstracción
        private string puesto;
        private string area;
        private double sueldo;
        private int personasaCargo;

        //Encapsulamiento
        public string Puesto { get => puesto; set => puesto = value; }
        public string Area { get => area; set => area = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int PersonasaCargo { get => personasaCargo; set => personasaCargo = value; }

        



        //Polimorfismo
        public string Describir()
        {
            MaxAnos();
            return "Abastecimiento de productos.";

        }

    }
}
