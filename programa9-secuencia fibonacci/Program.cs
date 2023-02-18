using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace programa9_secuencia_fibonacci
{
    internal class Program
    {
        class fibonacci
        {
            public int fin(int a)
            {
                if (a==0 || a==1)
                {
                    return a;
                }
                else
                {
                    return fin(a - 1) + fin(a - 2);
                }
            }
            ~fibonacci()
            {
                Console.WriteLine("\nMemoria Liberada de la Clase Fibonacci");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "programa9-secuencia fibonacci";

            Int16 op = 0;
            
            fibonacci f = new fibonacci();
            Stopwatch sw = new Stopwatch();

            long totalInicio = System.GC.GetTotalMemory(true);
            sw.Start();
            
            do
            {
                Console.Clear();
                Console.WriteLine("MENU FIBONACCI");
                Console.WriteLine("\n1.- Calcular Número de la Serie.");
                Console.WriteLine("2.- Salir del Programa.");
                Console.Write("\nOPCION: ");
                
                try
                {
                    op=Int16.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            
                            Console.Clear();
                            Console.Write("INGRESE UN NUMERO: ");
                            int n = int.Parse(Console.ReadLine());

                            int j = f.fin(n);

                            Console.WriteLine("\nEl numero es: {0} y la posicion es: {1}",n,j);
                            
                            break;
                            
                        case 2:
                            
                            sw.Stop();
                            TimeSpan ts = sw.Elapsed;

                            string elapsedTime = string.Format("\n{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                            Console.WriteLine("\nRun Time" + elapsedTime + " Milisegundos");

                            long totalFin = System.GC.GetTotalMemory(true);

                            Console.WriteLine("\nLa Cantidad de memoria en bytes utilizada es de: {0}", totalFin - totalInicio);

                            sw.Restart();

                            break;
                        default:
                            
                            Console.WriteLine("\nOpcion Invalida...");

                            break;
                    }
                }
                catch (FormatException a)
                {
                    Console.WriteLine("\n{0}",a.Message);
                    Console.ReadKey();
                }
                finally
                {
                    Console.WriteLine("\nPresione <ENTER> Para Salir...");
                    Console.ReadKey();
                }
            } while (op!=2);
            

        }
    }
}
