using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action;
            action = Metodo_1;
            action += Metodo_2;
            action += ConsumirMetodo_MostrarMensaje;
            action += () => {
                Console.WriteLine("Ejecutamos el metodo 3.");
            };
            action += Metodo_4;
            action += () =>
            {
                int a = 2, b = 3, c = a + b;
                Console.WriteLine($"La suma de {a} + {b} es = {c}");
            };
            action += Metodo_5;
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine("salto excepcion. Mensaje: " + ex.Message);
            }

            Console.WriteLine("Presione <enter> para salir..");
            Console.Read();

            //var fabrica = new Fabrica();
            //var controlador = new Controlador();
            ///*
            //controlador.ParaEquipamento += fabrica.dispositivo.PararDispositivo;
            //controlador.ParaEquipamento += fabrica.maquina.PararMaquina;
            //controlador.ParaEquipamento += fabrica.vehiculo.PararVehiculo;
            //*/
            //controlador.AgregarMetodosADelegado(fabrica.dispositivo.PararDispositivo);
            //controlador.AgregarMetodosADelegado(fabrica.maquina.PararMaquina);
            //controlador.AgregarMetodosADelegado(fabrica.vehiculo.PararVehiculo);
            //controlador.ParaEquipamento();
            //Console.Read();
        }

        static void Metodo_1()
        {
            Console.WriteLine("Ejecutamos el metodo 1.");
        }

        static void ConsumirMetodo_MostrarMensaje()
        {
            string mensaje = "este es para vos";
            MostrarMensaje(mensaje);
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"El mensaje es: {mensaje}");
        }

        static void Metodo_2()
        {
            Console.WriteLine("Ejecutamos el metodo 2 - Con retardo");
            Thread.Sleep(3000);
        }
        
        /*
        static void Metodo_3()
        {
            Console.WriteLine("Ejecutamos el metodo 3.");
        }
        */

        static void Metodo_4()
        {
            Console.WriteLine("Ejecutamos el metodo 4.");
            
        }

        static void Metodo_5()
        {
            Console.WriteLine("Ejecutamos el metodo 5.");
            throw (new Exception("Mi excepcion en metodo 4 - Stop!!.."));
        }


    }
}
