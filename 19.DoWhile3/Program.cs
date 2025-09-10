namespace _19.DoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, 
            además se desea saber cuántos son mayores de edad y cuántos no.*/

            int cantidadEstudiantes = 0;
            int edad = 0;
            int genero = 0;
            int cantidadHombres = 0;
            int cantidadMujeres = 0;

            do
            {
                Console.WriteLine($"Estudiante {cantidadEstudiantes}:");
                Console.WriteLine("Ingrese su edad:");
                edad=int.Parse( Console.ReadLine() );
                Console.WriteLine("Ingrese su genero");
                Console.WriteLine("1.Hombre     2.Mujer");
                genero = int .Parse( Console.ReadLine() );

                if (genero)
                {

                }

            } 
        }
    }
}
