using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        public  struct Empleado
        {
            int codigo;
            string nombre;
            float salario;
        }
        static void Main(string[] args)
        {

            // tipos de datos 
            int num1, num2;
            short corto = 5660;
            num1 = 5877;
            float flotante = 3.14f;
            double doble = 15.2d;
            decimal deci = 15.15m;
            byte b = 25;
            long larga = 123456789132456;
            ulong ulargo = 56;
            Boolean boleano = false;
            char Letra = 'a';
            string cadena = "Hoy es lunes 18 de setiembre";

            // var // dynanmic

            var variable = 15.25f;
            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";
            dinamica = true;
            dinamica = 'c';

            // arreglos 
            int n=4;
            string[] musico = new string[n];
            string[] temporal = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[100];
            /*
             * i = 0, 1,2,3,4

             */
            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Digite el salario:");
                salario[i] = float.Parse(Console.ReadLine());
            }

            if (true)
            {

            }
            
            while (true) { }

            do
            {

            } while (true);



            Console.WriteLine(  "Listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

          


            Console.ReadLine();
            string[] nombres = new string[] {"Ringo", "George", "Paul", "John" };

            
        }

    }

}




