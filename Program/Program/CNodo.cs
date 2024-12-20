using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CNodo
    {
        public int dato;
        public string datoStr;
        public CNodo hijoizq;
        public CNodo hijoder;
        public CNodo(int d, string nom) { 
        this.dato = d;
            this.datoStr = nom;
            this.hijoder = null;
            this.hijoizq=null;
        }
        public string toString() {
            return datoStr + "Su dato es " + dato;
        }
    }


}

