using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int elemento;
            string nombre;
            Arbol arbolito = new Arbol();
            do
            {
                Console.WriteLine("1.Agregar nodo");
                Console.WriteLine("2.Recorrer el arbol InOrder");
                Console.WriteLine("3.Recorrer el arbol PreOrder");
                Console.WriteLine("4.Recorrer el arbol PostOrder");
                Console.WriteLine("5.Buscar un nodo");
                Console.WriteLine("6.Eliminar un nodo");
                Console.WriteLine("7 Salir");
                Console.WriteLine("Eliga una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese el numero del elemento");
                            elemento = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nombre del nodo");
                            nombre = Console.ReadLine();
                            arbolito.agregar_nodo(elemento, nombre);
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            if (!arbolito.estavacio())
                            {
                                Console.WriteLine();
                                arbolito.InOrder(arbolito.Raiz);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                                Console.WriteLine();
                            }

                        }
                        break;
                    case 3:
                        {
                            if (!arbolito.estavacio())
                            {
                                Console.WriteLine();
                                arbolito.PreOrder(arbolito.Raiz);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        {
                            if (!arbolito.estavacio())
                            {
                                Console.WriteLine();
                                arbolito.PostOrder(arbolito.Raiz);
                                Console.WriteLine();    
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (opcion <= 6);
        }
    }
}
