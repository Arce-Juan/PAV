using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegados
{
    public class PracticaDelegadosLambda
    {
        public PracticaDelegadosLambda()
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


            Console.WriteLine("*************************");
            Console.WriteLine(" DELEGADOS CON PARAMETROS");
            Console.WriteLine("*************************");

            Action<string> DelegadoConParametro = MostrarMensaje;
            DelegadoConParametro += (mensaje) =>
            {
                Console.WriteLine($"El mensaje con un delegado con exprecion lambda es: {mensaje}");
            };
            //DelegadoConParametro("Estamos accediendo desde un delegado con parametros");
            DelegadoConParametro("nuevo mensaje");

            Console.WriteLine("*************************");
            Console.WriteLine(" algunas expresiones lambda");
            Console.WriteLine("*************************");

            Func<int, int, int> DelegadoConRetorno;
            DelegadoConRetorno = (a, b) =>
            {
                Console.WriteLine($"La suma con funcion abtracta es: {a + b}");
                return a + b;
            };
            DelegadoConRetorno += SumaDeNumerosMultiplicadosPor10;
            int resultado = DelegadoConRetorno(5, 5);
            Console.WriteLine($"la suma con delegados es: {resultado}");

            Func<string, int, int, decimal> DelegadoMultiplesTipos;
            DelegadoMultiplesTipos = MensajeConDivisionDeNumeros;
            DelegadoMultiplesTipos += (string mensaje, int a, int b) =>
            {
                Console.WriteLine($"Desde expresion lambda: El mensaje es: {mensaje} y la division es: {a / b}");
                return (a / b);
            };
            DelegadoMultiplesTipos("mensaje desde controller", 400, 5);
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
            Console.WriteLine($"El mensaje de Metodo (MostrarMensaje) es: {mensaje}");
        }

        static void Metodo_2()
        {
            Console.WriteLine("Ejecutamos el metodo 2 - Con retardo");
            Thread.Sleep(1500);
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

        static int SumaDeNumerosMultiplicadosPor10(int a, int b)
        {
            Console.WriteLine($"El resultado de la suma en una fucnio es: {(a + b) * 10}");
            return (a + b) * 10;
        }

        static decimal MensajeConDivisionDeNumeros(string mensaje, int a, int b)
        {
            Console.WriteLine($"Desde el Metodo: El mensaje es: {mensaje} y la division es: {a / b}");
            return (a / b);
        }

        
    }
}
