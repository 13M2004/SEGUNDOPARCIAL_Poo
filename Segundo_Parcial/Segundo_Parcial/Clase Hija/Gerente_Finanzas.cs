using Segundo_Parcial.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Clase_Hija
{
    public delegate string MensajeDelegate();

    //Hereencia de PERSONA
    internal class Gerente_Finanzas : Persona, IJubilacion //Clase nieto 
    {
        // Método para imprimir Delegado
        public void ImprimirF(MensajeDelegate delegado)
        {
            // Invocar el delegado para obtener el mensaje
            string mensaje = delegado();

            // Imprimir el mensaje
            Console.WriteLine(mensaje);
        }

        //Interface
        public override void MaxAnos()
        {
            Console.WriteLine("El Gerente de Finanzas tiene 16 año");
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
            return "Lleva el control económico de la empresa.";
            
        }

    }   
}
