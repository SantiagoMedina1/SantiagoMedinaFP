namespace _9._ParcialCondicionalSantiagoMedina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sexo;
            int edad, ultimoDigito;
            string grupo;

            Console.WriteLine("Ingrese su sexo (m: masculino, f: femenino):");
            sexo = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último dígito de su documento (0-9):");
            ultimoDigito = int.Parse(Console.ReadLine());

           
            grupo = "D";

            
            if (sexo == "f" && (edad >= 16 && edad <= 20) && (ultimoDigito == 0 || ultimoDigito == 4 || ultimoDigito == 8))
            {
                grupo = "A";
            }
            else if (sexo == "m" && (edad >= 18 && edad <= 22) && (ultimoDigito == 1 || ultimoDigito == 5 || ultimoDigito == 9))
            {
                grupo = "A";
            }
            
            else if (sexo == "f" && (edad >= 21 && edad <= 25) && (ultimoDigito == 3 || ultimoDigito == 7))
            {
                grupo = "B";
            }
            else if (sexo == "m" && (edad >= 23 && edad <= 26) && (ultimoDigito == 2 || ultimoDigito == 6))
            {
                grupo = "B";
            }
            
            else if (edad == 15)
            {
                Console.WriteLine("¿Domina el idioma inglés? (si/no):");
                string ingles = Console.ReadLine().ToLower();

                if (ingles == "si")
                {
                    grupo = "C";
                }
                else
                {
                    grupo = "D"; 
                }
            }
            else
            {
                grupo = "D";
            }

            Console.WriteLine($"La persona pertenece al Grupo {grupo}");
        }
    }
}