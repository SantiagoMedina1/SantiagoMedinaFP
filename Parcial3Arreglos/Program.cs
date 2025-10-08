namespace Parcial3Arreglos
{
    using System;

    class Programa
    {
        static void Main()
        {
            string[] departamentos = { "Marketing", "Contabilidad", "Recursos_Humanos", "Distribución", "Ingeniería", "Investigación" };
            string[] conceptos = { "Salarios", "Suministros", "Mobiliario", "Equipamiento", "Otros" };

            double[,] gastos = new double[6, 5];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    double valor;
                    do
                    {
                        Console.WriteLine("Ingrese el gasto de" + departamentos[i] + "en" + conceptos[j] + ":");
                        valor = double.Parse(Console.ReadLine());
                        if (valor < 0)
                        {
                            Console.WriteLine("Error: el valor debe ser positivo. Intente de nuevo.");
                        }
                    } while (valor < 0);

                    gastos[i, j] = valor;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz de gastos");

            Console.WriteLine("Departamentos y gastos:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(departamentos[i] + ":");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("  " + conceptos[j] + ": " + gastos[i, j]);
                }
                Console.WriteLine();
            }

            //a) Suma de gastos por departamento:
            Console.WriteLine("Total por apartamento:");
            for (int i = 0; i < 6; i++)
            {
                double sumaDepto = 0;
                for (int j = 0; j < 5; j++)
                {
                    sumaDepto += gastos[i, j];
                }
                Console.WriteLine(departamentos[i] + ": " + sumaDepto);
            }

            // b) Suma de gastos por concepto:
            Console.WriteLine();
            Console.WriteLine("Total por concepto:");
            for (int j = 0; j < 5; j++)
            {
                double sumaConcepto = 0;
                for (int i = 0; i < 6; i++)
                {
                    sumaConcepto += gastos[i, j];
                }
                Console.WriteLine(conceptos[j] + ": " + sumaConcepto);
            }

            // c) Gasto total del año
            double totalAnual = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    totalAnual += gastos[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Gasto total del año:" + totalAnual);

            // d) Vector de gastos (otros):
            Console.WriteLine();
            Console.WriteLine("Gasto en (otros) por departamento:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(departamentos[i] + ": " + gastos[i, 4]);
            }

            // e) Mayor gasto registrado
            double mayor = gastos[0, 0];
            string deptoMayor = departamentos[0];
            string conceptoMayor = conceptos[0];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (gastos[i, j] > mayor)
                    {
                        mayor = gastos[i, j];
                        deptoMayor = departamentos[i];
                        conceptoMayor = conceptos[j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Gasto mayro registrado:");
            Console.WriteLine("Valor: " + mayor);
            Console.WriteLine("Departamento: " + deptoMayor);
            Console.WriteLine("Concepto: " + conceptoMayor);
        }
    }
}