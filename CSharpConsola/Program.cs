using System;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuentaUno = new CuentaBancaria();
            cuentaUno.Balance = 1000;

            CuentaBancariaKids cuentaDos = new CuentaBancariaKids();
            cuentaDos.Balance = 500;

            AgregarBalance(cuentaUno, 2500);
            AgregarBalance(cuentaUno, 1500);
            AgregarBalance(cuentaDos, 1000);
            AgregarBalance(cuentaDos, 1500);


           
        }

        static void AgregarBalance(ICuentaBancaria cuentaBancaria, double balance)
        {
            cuentaBancaria.agregarABalance(balance);
            if(balance < 2000){
                Console.WriteLine("Balance cuentaKids: " + cuentaBancaria.Balance);
            }
            else{
                Console.WriteLine("Balance cuenta: " + cuentaBancaria.Balance);
            }
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
