namespace TallerParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
            le permitirá al usuario, introducir tantas calificaciones como así desee, 
            en el momento en que seleccione que no desea continuar capturando 
            calificaciones, el algoritmo debe presentar el promedio de las 
            calificaciones capturadas previamente. */

            int contador = 0;
            int suma = 0;
            string respuesta = "s";

            while (respuesta == "s" || respuesta == "S")
            {
                Console.Write("Ingrese una calificación: ");
                int calificacion = int.Parse(Console.ReadLine());

                suma = suma + calificacion;
                contador = contador + 1;

                Console.Write("¿Desea ingresar otra calificación? (s/n): ");
                respuesta = Console.ReadLine();
            }

            int promedio = suma / contador;
            Console.WriteLine("El promedio es: " + promedio);


        }
    }
}
            /*2. Se requiere un algoritmo para mostrar por pantalla los divisores de un 
             número ingresado por teclado. 
             Tener en cuenta que dados dos números enteros a y b, se dice que b es 
             divisor de a si se cumple que al efectuar una división entera a/b el 
             residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
             una división de dos números. 
             Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
             2, 1 que son los divisores del número 6.*/