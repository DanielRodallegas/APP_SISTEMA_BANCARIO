using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_SISTEMA_BANCARIO
{
    public class Cliente
    {

        private string nombre,apellido,curp;

        private cuenta[] cuentas;
        
        public Cliente(string nombre,string apellido,string curp,cuenta[] cuentas) 
        {
            this.nombre = nombre;        
            this.apellido = apellido;
            this.curp = curp;
            this.cuentas = cuentas;
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido 
        { get { return apellido; } 
          set { apellido = value; } 
        }

        public string Curp 
        { 
         get { return curp; } 
         set { apellido = value; } 
        }

        public double consultarSaldo() 
        {


            return 0;
        }







    }
}
