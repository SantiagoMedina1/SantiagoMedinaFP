namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que generea y suma los primeros 5 números enteros

            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador = acumulador + contador;

            } while (contador < 5);

            Console.WriteLine("La suma de los cinco primeros números enteros es: " + acumulador);

            /*17. Algortimo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
             * Y así sucesivamente hasta que el usuario ya no desee continuar generamdo tablas de multiplicar.*/

            int contador = 1;
            int numero = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un número para calcular su tabla de multiplicar:");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);


                Console.WriteLine("Ingrese un número para calcular su tabla de multiplicar: s:sí , n=no");
                numero = int.Parse(Console.ReadLine().ToLower();

            } while (respuesta == "$");
        }    
    }
}

