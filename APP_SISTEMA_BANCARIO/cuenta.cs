using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_SISTEMA_BANCARIO
{
     public class cuenta
    {
        private int numeroCuenta;
        private double saldo;

        public cuenta(int numeroCuenta, double saldo) 
        { 
         this.saldo = saldo;

         this.numeroCuenta = numeroCuenta;
        }

        public double Saldo 
        { 
            get => saldo; 
        }

        public int NumeroCuenta 
        { 
            get => numeroCuenta; 
        }
        public void ingresarDinero(double cantidad) 
        { 
        
        }

        public void retirarDinero(double cantidad) 
        { 
              
        }


    }
}
