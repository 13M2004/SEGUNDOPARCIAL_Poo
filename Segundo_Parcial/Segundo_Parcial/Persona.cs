using Segundo_Parcial.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Segundo_Parcial
{
   
    public class Persona : IJubilacion
    {

        
        //Interface
        public virtual void MaxAnos()
        {
            Console.WriteLine("El máximo permitido son 20 años.");
        }


        //PROPIEDADES
        private string nombre; 
         private int edad;
         private int celular;
         private string profesion;


         //Encapsulación de Métodos
          public string Nombre { get => nombre; set => nombre = value; }
          public int Edad { get => edad; set => edad = value; }
          public int Celular { get => celular; set => celular = value; }
          public string Profesion { get => profesion; set => profesion = value; }


           //Metodo donde se aplica la herencia
          public void crearPersona(string _nombre, int _edad, int _celular, string _profesion)
          {
            //invocando al set
             nombre = _nombre;
             edad = _edad;
             celular = _celular;
             profesion = _profesion;
          }

       

    }
}
