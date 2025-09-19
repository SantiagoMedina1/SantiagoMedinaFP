namespace Parcial2CiclosSantiagoMedina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Don Alcides, un tendero, realiza la venta de 10 productos y necesita calcular el valor total de la venta aplicando el IVA correspondiente a cada uno de ellos 
            según las siguientes condiciones:

            Si el valor del producto es mayor a 10.000, se aplica un 15 % de IVA.
            Si el valor del producto es menor o igual a 5.000, se aplica un 19 % de IVA.

            El programa debe realizar lo siguiente:
            Solicitar por teclado el valor de cada uno de los 10 productos.
            Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
            Sumar los subtotales de los 10 productos.
            Mostrar en pantalla el valor total de la venta.*/

            int totalVenta = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese el valor del producto " + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                int subtotal = valor;

                if (valor > 10000)
                {
                    subtotal = valor + (valor * 15 / 100);
                }
                else if (valor <= 5000)
                {
                    subtotal = valor + (valor * 19 / 100);
                }

                totalVenta += subtotal;
            }

            Console.WriteLine("El valor total de la venta es: " + totalVenta);

        }
    }
}