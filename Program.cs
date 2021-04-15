using System;

namespace A892843.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salida = false;
            Empresa empresa = new Empresa();
            do
            {
                Console.WriteLine("Ingrese 1 para ingresar el stock inicial de los productos.");
                Console.WriteLine("Ingrese 2 para ingresar los pedidos de los productos.");
                Console.WriteLine("Ingrese 3 para ingresar las entregas de los productos.");
                Console.WriteLine("Ingrese 4 para mostrar el stock con el listado de los productos.");
                int valor = validacionMenu();
                if (valor == 1)
                {
                    empresa.ingresoCatalogo();
                }
                else if (valor == 2)
                {
                    empresa.ingresoPedidos();
                }
                else if (valor == 3)
                {
                    empresa.ingresoEntregas();
                }
                else if (valor == 4)
                {
                    empresa.mostrarListado();
                }
                else
                {
                    salida = true;
                }
            }
            while (!salida);
            



        static int validacionMenu()
            {
                int dato;
                bool ok = false;
                do
                {
                    string valor = Console.ReadLine();
                    ok = int.TryParse(valor, out dato);
                    if (!ok && (dato < 1 || dato >4))
                    {
                        Console.WriteLine("No ha ingresado un valor valido, por favor ingrese un valor valido");
                    }
                } while (!ok);
                return dato;
            }
        }
    }
}
    