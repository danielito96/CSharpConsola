using System;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Matematicas.Suma(12,12);
            Console.ReadLine();
                            


           
        }

        static void AgregarBalance(ICuentaBancaria cuentaBancaria, double balance)
        {
            cuentaBancaria.agregarABalance(balance);

                Console.WriteLine("Balance cuenta: " + cuentaBancaria.Balance);

        }

    }

    class Matematicas{

        public static int Suma(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Suma(int[] valores)
        {
            int resultado = 0;
            foreach(int i in valores)
            {
                resultado += i;
            }
            return resultado;
        }

        public virtual int Resta(int num1, int num2)
        {

            return num1 - num2;
        }

        public static int Multiplicacion(int num1, int num2)
        {

            return num1 * num2;
        }

        public static int Division(int num1, int num2)
        {

            return num1 / num2;
        }
    }

    class Geometria : Matematicas
    {
        public static int AreaCuadrado(int lado){

            return Multiplicacion(lado, lado);
        }   

    }

}
