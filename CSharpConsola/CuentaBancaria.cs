using System;
namespace CSharpConsola
{
    public class CuentaBancaria
    {
        private double balance;

        public double Balance{
            get { return balance; }
            set {
                if (value > 0) { balance = value; }
                else { balance = 0; }

            }
        }

    }
}
