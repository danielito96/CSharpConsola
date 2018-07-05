using System;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuentaUno = new CuentaBancaria();
            cuentaUno.Balance = 2000;
            Console.WriteLine("Balance: " + cuentaUno.Balance);
        }


    }

    class Matematicas{

        public static int Suma(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Resta(int num1, int num2)
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
