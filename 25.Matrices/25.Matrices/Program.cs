namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2,2];
            string[,] nombres = new string[3,2];
            char[,] caracteres = new char[2,4];
            bool[,] banderas = new bool[2,5];
            object[,] objetos = new object[2,5];

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;
            
            Console.WriteLine($"Valor almacenado en la posicion con indices 1,0: {numeros[1,0]}");


            string[,] apellidos =
                {
                    {"Chica","Lopez","Álvarez" },
                    {"Patiño","Ciro","Botero" },
                    {"Duque","Carmona","Castaño"}
                };

            string[,] nombres = new string[3, 2];
            for (int i = 0; i<3 ; i++)
            {
               for (int j = 0; j < 2; j++)
               {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posición con índices {i}, {j}:");
                    nombres[i, j] = Console.ReadLine();
               }
            }

         

            for (int i = 0; i< nombres.GetLength(0); i++)
            {
                for (int j = 0; j < nombres.GetLength(1) ; j++)
                {
                    Console.WriteLine($"Nombre almacenado en la posición {i},{j}: {nombres[i,j]}");
                }
            }

            for (int i = 0; i < nombres.GetLength(0); i++)
            {
                for (int j = 0; j < nombres.GetLength(1); j++)
                {
                    Console.WriteLine($"{nombres[i,j]}  |");
                }
            }
            Console.WriteLine();
        }   

    }
}

