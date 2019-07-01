﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBackend.Entity
{
    public class TelefonoProveedor
    {
        public int CodigoTelefono { get; set; }
        public String Numero { get; set; }
        public String Descripcion { get; set; }
        public int CodigoProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
