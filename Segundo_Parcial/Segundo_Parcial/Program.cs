//Gestión de Empleados 

using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Segundo_Parcial;
using Segundo_Parcial.Clase_Hija;



namespace Segundo_Parcial
{
    class Program 
    {
        
        // Delegado para el evento
        public delegate void EmpleadoEventHandler(string message);

        // Evento  nuevo empleado
        public static event EmpleadoEventHandler EmpleadoAgregado;


        static void Main(string[] args)
        {
            // Suscripción al EVENTOOOO
            EmpleadoAgregado += MostrarMensajeEmpleadoAgregado;


            //Herencia clase persona-Jefe de empresa
            Jefe_de_Empresa objJefe = new Jefe_de_Empresa();
           objJefe.Nombre = "Manuel Mozón";
           objJefe.Edad = 23;
           objJefe.Celular = 58103302;
           objJefe.Profesion = "Ingeniero en Sistemas";
           objJefe.Puesto = "Jeje de Empresa";
           objJefe.Area = "Empresarial";
           objJefe.Sueldo = 40000;
            objJefe.PersonasaCargo = 5;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("           GESTIÓN EMPRESARIAL");
            Console.WriteLine(" La técnologia está a un solo click de ti");
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jefe de Empresa");
            Console.ResetColor();

            //DELEGADOS
            Bienvenida b1 = new Bienvenida(Saludo.Empresa);
            b1("Bienvenidos a la empresa lider de Técnologia");


            //Impresión del Polimorfismo
            Console.ForegroundColor = ConsoleColor.Green;


             //Impresión de la Interfaz
             Jefe_de_Empresa jefe = new Jefe_de_Empresa();
             Console.WriteLine(jefe.Describir());
             Console.ResetColor();

             Console.WriteLine("Nombre: " + objJefe.Nombre + "\nEdad: " + objJefe.Edad + "\nCelular: " + objJefe.Celular + "\nProfesión: " + objJefe.Profesion + "\nPuesto: " + objJefe.Puesto + "\nÁrea: " + objJefe.Area + "\nSueldo: " + objJefe.Sueldo + "\nPersonas a Cargo: " + objJefe.PersonasaCargo);
  
             Console.WriteLine("");

             //Herencia clase persona-Gerente de Ventas 
             Gerente_Ventas objVentas = new Gerente_Ventas();
             objVentas.Nombre = "Nayeli Urrutia";
             objVentas.Edad = 25;
             objVentas.Celular = 55443322;
             objVentas.Profesion = "Ingeniero en Sistenas";
             objVentas.Puesto = "Gerente de Ventas";
             objVentas.Area = "Ventas";
             objVentas.Sueldo = 20000;
             objVentas.PersonasaCargo = 10;

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Gerente de Ventas");
             Console.ResetColor();

             //DELEGADOS
             Bienvenida b2 = new Bienvenida(Saludo.Empresa);
             b1("Sera un gusto poderte servir.");

             //Impresión del Polimorfismo
             Console.ForegroundColor = ConsoleColor.Green;

             //Impresión del Interfaz
             Gerente_Ventas gerenteV = new Gerente_Ventas();
             Console.WriteLine(gerenteV.Describir());
             Console.ResetColor();

             Console.WriteLine("Nombre: " + objVentas.Nombre + "\nEdad: " + objVentas.Edad + "\nCelular: " + objVentas.Celular + "\nProfesión: " + objVentas.Profesion + "\nPuesto: " + objVentas.Puesto + "\nÁrea: " + objVentas.Area + "\nSueldo: " + objVentas.Sueldo + "\nPersonas a Cargo: " + objVentas.PersonasaCargo);
             // Agregar un empleado, dispara el EVENTO
                
             Console.WriteLine("");

             //Herencia clase persona-Gerente RH
             Gerente_RH objRH = new Gerente_RH();
             objRH.Nombre = "Pedro Marchorro";
             objRH.Edad = 23;
             objRH.Celular = 66992288;
             objRH.Profesion = "Auditor";
             objRH.Puesto = "Gerente de Ventas";
             objRH.Area = "Recursos Humanos";
             objRH.Sueldo = 20000;
             objRH.PersonasaCargo = 30;

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Gerente de Recursos Humanos");
             Console.ResetColor();

            //DELEGADOS
            Bienvenida b3 = new Bienvenida(Saludo.Empresa);
             b1("Sera un gusto poderte servir.");

             //Impresión del Polimorfismo
             Console.ForegroundColor = ConsoleColor.Green;

             //Impresión de la Interface
             Gerente_RH gerente_RH = new Gerente_RH();
             Console.WriteLine(gerente_RH.Describir());
             Console.ResetColor();

             Console.WriteLine("Nombre: " + objRH.Nombre + "\nEdad: " + objRH.Edad + "\nCelular: " + objRH.Celular + "\nProfesión: " + objRH.Profesion + "\nPuesto: " + objRH.Puesto + "\nÁrea: " + objRH.Area + "\nSueldo: " + objRH.Sueldo + "\nPersonas a Cargo: " + objRH.PersonasaCargo);
                
             Console.WriteLine("");

             //Herencia clase persona-Gerente Produccion
             Gerente_Produccion objProducc = new Gerente_Produccion();
             objProducc.Nombre = "Robin Orrellana";
             objProducc.Edad = 30;
             objProducc.Celular = 55445588;
             objProducc.Profesion = "Ingeniero Civil";
             objProducc.Puesto = "Gerente de Producción";
             objProducc.Area = "Producción";
             objProducc.Sueldo = 25000;
             objProducc.PersonasaCargo = 15;

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Gerente de Producción");
             Console.ResetColor();

             //DELEGADOS
             Bienvenida b4 = new Bienvenida(Saludo.Empresa);
             b1("Sera un gusto poderte servir.");

              //Impresión del Polimorfismo
             Console.ForegroundColor = ConsoleColor.Green;

             //Impresión de la Interface
             Gerente_Produccion gerenteP = new Gerente_Produccion();
             Console.WriteLine(gerenteP.Describir());
             Console.ResetColor();

             Console.WriteLine("Nombre: " + objProducc.Nombre + "\nEdad: " + objProducc.Edad + "\nCelular: " + objProducc.Celular + "\nProfesión: " + objProducc.Profesion + "\nPuesto: " + objProducc.Puesto + "\nÁrea: " + objProducc.Area + "\nSueldo: " + objProducc.Sueldo + "\nPersonas a Cargo: " + objProducc.PersonasaCargo);
       
             Console.WriteLine("");


             //Herencia clase persona-Gerente Finanzas
             Gerente_Finanzas objFinan = new Gerente_Finanzas();
             objFinan.Nombre = "Ivania Monzón";
             objFinan.Edad = 23;
             objFinan.Celular = 55445588;
             objFinan.Profesion = "Auditora";
             objFinan.Puesto = "Gerente de Finanzas";
             objFinan.Area = "Finanzas";
             objFinan.Sueldo = 18000;
             objFinan.PersonasaCargo = 5;

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Gerente de Finanzas");
             Console.ResetColor();

             //Delegados
             Bienvenida b5 = new Bienvenida(Saludo.Empresa);
             b1("Sera un gusto poderte servir.");

             //Impresión del Polimorfismo 
             Console.ForegroundColor = ConsoleColor.Green;

             //Impresión Interfaces
             Gerente_Finanzas gerenteF = new Gerente_Finanzas();
             Console.WriteLine(gerenteF.Describir());
             Console.ResetColor();

             Console.WriteLine("Nombre: " + objFinan.Nombre + "\nEdad: " + objFinan.Edad + "\nCelular: " + objFinan.Celular + "\nProfesión: " + objFinan.Profesion + "\nPuesto: " + objFinan.Puesto + "\nÁrea: " + objFinan.Area + "\nSueldo: " + objFinan.Sueldo + "\nPersonas a Cargo: " + objFinan.PersonasaCargo);
               
             Console.WriteLine("");


            // Nuevo Empleado, dispara el EVENTOOOO
            Console.ForegroundColor= ConsoleColor.Blue;  
            DispararEvento("Nuevo empleado: Juan Pérez");
            Console.ResetColor();

            // Mantener la consola abierta hasta que el usuario presione una tecla
            Console.ReadKey();


        }

        // Método para manejar el evento y mostrar el mensaje en pantalla
        private static void MostrarMensajeEmpleadoAgregado(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Método para disparar el EVEMTOOOO
        private static void DispararEvento(string mensaje)
        {
            // Verificar si hay suscriptores al EVENTOOOO
            if (EmpleadoAgregado != null)
            {
                // Disparar el EVENTOOOO con el mensaje proporcionado
                EmpleadoAgregado(mensaje);
            }
        }

        //DELEGADO
        public delegate void Bienvenida(string str);
        public class Saludo
        {
            public static void Empresa(string str)
            {
                Console.WriteLine(str);
            }
        }
            
        
    }
}
