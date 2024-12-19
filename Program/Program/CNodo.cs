﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CNodo
    {
        private string dato;
        private CNodo hijo;
        private CNodo hermano;
        public string Dato { get => dato; set => dato = value; }
        public CNodo Hijo { get => hijo; set => hijo = value; }
        public CNodo Hermano { get => hermano; set => hermano = value; }

        public CNodo() {

            dato = "";
            hijo = null;
            hermano = null;
        }
    }


}

