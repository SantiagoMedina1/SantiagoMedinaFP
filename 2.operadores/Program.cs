namespace _2.operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numericos
            //Cmbio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");

            //Operadores aritmeticos

            int num5 = 3 + 5; //Suma
            int num6 = 100 - 26; //Resta
            int num7 = 4 * 2; //Producto
            //float num8 =(float) 5 / 3;//Division
            //float num8 = 5f / 3;
            //float num8 = 5 / 3f;
            float num8 = 5 / 3f; //Dibvisión
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;
            Console.WriteLine($"Suma: {num5}, resta: {num6}, Producto: {num7}, Division: {num8}, num9: {num9}, num10: {num10}");

            //Operadores incremento(++), decremento(--)
            num1++//num1 = num1 + 1; Incremento
            num2--;//num2 = num2 - 1; Decremento
            num3 += 5;//num3 = num3 +5;
            num4 -= 20;//num4 = num4 - 20;
            num5 *= 31;//num5 = num5 * 31;
            num7 /= num1;//num7 =num7 / num1;

            //Orden de evaluacion operadores aritméticos
            int num11 = 4 *

        }
    }
}
