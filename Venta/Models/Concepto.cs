﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Venta.Models
{
    public partial class Concepto
    {
        public long Id { get; set; }
        public long IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public long IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Ventum IdVentaNavigation { get; set; }
    }
}
