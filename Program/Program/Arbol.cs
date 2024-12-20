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
        CNodo Raiz;
        public Arbol() {
            Raiz = null;

        }
        public void agregar_nodo(int dato, string nombre) { 
        CNodo nuevo = new CNodo(dato,nombre);
            if (Raiz == null) {
                Raiz = nuevo;

            }
            else
            {
                CNodo Auxiliar = Raiz;
                CNodo Padre;
                while (true) {
                Padre = Auxiliar;
                if (dato<Auxiliar.dato) {
                        Auxiliar = Auxiliar.hijoizq;
                        if (Auxiliar==null)
                        {
                            Padre.hijoizq = nuevo;
                            return;
                        }
                    }
                    else
                    {
                        Auxiliar = Auxiliar.hijoder;
                        if (Auxiliar == null) { 
                        Padre.hijoder=nuevo;
                            return;
                        }
                    }
                
                }
            }
        }
		
    }

}
