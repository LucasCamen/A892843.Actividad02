using System;
using System.Collections.Generic;
using System.Text;

namespace A892843.Actividad02
{
    class Producto
    {
        public int NroProducto { get; set; }
        public int StockProducto { get; set; }

        public Producto(int nroProducto, int stockProducto)
        {
            NroProducto = nroProducto;
            StockProducto = stockProducto;

        }


        public void mostrarProducto()
        {
            Console.WriteLine($"codigo de producto: {NroProducto}, cantidad: {StockProducto}");
        }
    }
}
