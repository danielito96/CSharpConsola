using System;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroUno = int.Parse(Console.ReadLine());
            int numeroDos = int.Parse(Console.ReadLine());
            int resultado = Suma(numeroUno,numeroDos);
            Console.WriteLine("Resultado: " + resultado);
        }

        static int Suma(int num1, int num2){

            return num1 + num2;
        }
    }


}
