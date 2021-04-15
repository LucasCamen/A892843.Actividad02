using System;
using System.Collections.Generic;
using System.Text;

namespace A892843.Actividad02
{
    class Empresa
    {
        private List<Producto> productos;
        public Empresa()
        {
            productos = new List<Producto>();
        }
        public void ingresoCatalogo()
        {
            int codigo;
            int cantidad;
            bool salida = false;
            Producto producto;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto o -1 para finalizar");
                codigo = validacionCodigo();
                if (codigo != -1)
                {
                    cantidad = validacionCantidad();

                    producto = new Producto(codigo, cantidad);
                    productos.Add(producto);
                }
                else
                {
                    salida = true;
                }
            } while (!salida);
        }

        public void ingresoPedidos()
        {
            int codigo;
            int cantidad;
            bool salida = false;
            Producto producto;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto del pedido o -1 para finalizar");
                codigo = validacionCodigo();
                if (codigo != -1)
                {
                    producto = buscarCodigo(codigo);
                    cantidad = validacionCantidad();
                    if (producto.StockProducto > cantidad)
                    {
                        producto.StockProducto = - cantidad;
                    } else
                    {
                        Console.WriteLine("El producto ingresado no posee stock suficiente.");
                    }                    
                }
                else
                {
                    salida = true;
                }
            } while (!salida);
        }

        public void ingresoEntregas()
        {
            int codigo;
            int cantidad;
            bool salida = false;
            Producto producto;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto del pedido o -1 para finalizar");
                codigo = validacionCodigo();
                if (codigo != -1)
                {
                    producto = buscarCodigo(codigo);
                    cantidad = validacionCantidad();
                    producto.StockProducto =+ cantidad;
                    salida = true;
                }
            } while (!salida);
        }
        public Producto buscarCodigo(int codigo) 
        {
            
            int i = 0;
            bool salida = false;
            while (i < productos.Count && !salida)
            {
                if (productos[i].NroProducto == codigo)
                {
                    Producto producto = productos[i];
                    salida = true;
                } else
                {
                    i++;
                }
            }
            return producto;
        }
        //Sinceramente no se porque me da el error ahi, por eso no pude probar los codigos de ingresoPedidos() e ingresoEntregas()
        public void mostrarListado()
        {
            for (int i = 0; i < productos.Count; i++)
            {
                productos[i].mostrarProducto();
            }
        }


        public int validacionCodigo()
        {
            int dato1C;
            bool ok = false;
            do
            {
                string dato1 = Console.ReadLine();
                ok = int.TryParse(dato1, out dato1C);
                if (!ok)
                {
                    Console.WriteLine("No ha ingresado un valor valido, por favor ingrese un valor valido");
                }
            } while (!ok);
            return dato1C;
        }

        public int validacionCantidad()
        {
            int dato2C;
            bool ok2 = false;
            do
            {
                Console.WriteLine("Ingrese el stock inicial del producto:");
                string dato2 = Console.ReadLine();
                ok2 = int.TryParse(dato2, out dato2C);
                if (!ok2 || dato2C < 0)
                {
                    Console.WriteLine("No ha ingresado un valor valido, ingreselo nuevamente");
                }
            } while (!ok2 || dato2C < 0);
            return dato2C;
        }
    }
}

