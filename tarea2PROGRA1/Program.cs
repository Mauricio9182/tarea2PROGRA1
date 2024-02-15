
/*using System;
class program 
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese un numero entero: ");
        int numeroEntero = int.Parse(Console.ReadLine());

        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);


        Console.WriteLine("El numero decimal es: " + numeroDecimal); 
    }

}*/


/*using System;
class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese un numero decimal: ");
        decimal numeroDecimal = decimal.Parse(Console.ReadLine());
        float numeroFlotante = Convert.ToSingle(numeroDecimal);
        Console.WriteLine("El numero flotante es: " + numeroFlotante);
    }
    }*/


/*using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero flotante: ");
        float numeroFlotante = float.Parse(Console.ReadLine());
        int numeroEntero = Convert.ToInt32(numeroFlotante);
        Console.WriteLine("El núumero entero es: " + numeroEntero);
    }
}*/


/*using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un caracter: ");
        char caracter = Console.ReadKey().KeyChar;
        int numeroEntero = (int)caracter;
        Console.WriteLine("El numero entero es: " + numeroEntero);
    }
}*/


/*using System;

class Program
{

    static void Main(string[] args)
    {

        char[] caracteres = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' };


        Console.WriteLine("Ingrese un número entero: ");
        int numeroEntero = int.Parse(Console.ReadLine());


        if (numeroEntero < 0 || numeroEntero > 10)
        {
            Console.WriteLine("Error: El número entero debe estar entre 0 y 10.");
            return;
        }

        char caracter = caracteres[numeroEntero];
        Console.WriteLine("El caracter es: {0}", caracter);
    }
}*/



