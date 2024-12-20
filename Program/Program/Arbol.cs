using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Arbol
    {
      public  CNodo Raiz;
        public Arbol()
        {
            Raiz = null;

        }
        public void agregar_nodo(int dato, string nombre)
        {
            CNodo nuevo = new CNodo(dato, nombre);
            if (Raiz == null)
            {
                Raiz = nuevo;

            }
            else
            {
                CNodo Auxiliar = Raiz;
                CNodo Padre;
                while (true)
                {
                    Padre = Auxiliar;
                    if (dato < Auxiliar.dato)
                    {
                        Auxiliar = Auxiliar.hijoizq;
                        if (Auxiliar == null)
                        {
                            Padre.hijoizq = nuevo;
                            return;
                        }
                    }
                    else
                    {
                        Auxiliar = Auxiliar.hijoder;
                        if (Auxiliar == null)
                        {
                            Padre.hijoder = nuevo;
                            return;
                        }
                    }

                }
            }
        }
        public bool estavacio()
        {
            return Raiz == null;
        }
        public void InOrder(CNodo r)
        {
            if (r != null)
            {
                
                InOrder(r.hijoizq);
                Console.Write(r.dato + " , ");
                InOrder(r.hijoder);
                
            }
            
        }
        public void PreOrder(CNodo r)
        {
            if (r != null)
            {
                Console.Write(r.dato + " , ");
                PreOrder(r.hijoizq);
                PreOrder(r.hijoder);
            }
            


        }
        public void PostOrder(CNodo r)
        {
            if(r != null)
            {
                PostOrder(r.hijoizq);
                PostOrder(r.hijoder);
                Console.Write(r.dato + " , ");
            }
           
           
        }
    }

}
