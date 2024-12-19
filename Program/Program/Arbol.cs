using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Arbol
    {
        private CNodo raiz;
        private CNodo trabajo;
        private int i = 0;
        public Arbol() { 
        raiz = new CNodo();

        }
        public CNodo Insertar(string Pdato, CNodo pNodo)
        {
            if (pNodo==null)//Si esta vacio
            {
                raiz= new CNodo();
                raiz.Dato = Pdato;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            if (pNodo.Hijo==null) // Se inserta como nuevo hijo.
            {
                CNodo temp = new CNodo();
                temp.Dato = Pdato;
                pNodo= temp;
                return temp;

            }
            else //Caso cuando el nodo es un hermando del hijo
            {
                trabajo = pNodo.Hijo;

                while (trabajo.Hermano!=null)
                {
                        trabajo= trabajo.Hermano;
                }
                CNodo temp = new CNodo();
                temp.Dato = Pdato;  
                trabajo.Hermano=temp;
                return temp;
            }
        }
		
    }

}
