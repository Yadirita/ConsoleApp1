using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Jerarquia
{
    public class Vehiculo
    {
        private String _identificacion;
        private int _numeroDeMinutos;


        public void setIdentificacion(String identificacion)
        {
          if(identificacion.Trim().Length > 1)
            {
              this._identificacion = identificacion;
            }
          else 
            {
                this._identificacion = "vacia";
            }
        }

        public void setNumeroDeMinutos(int numeroMinutos) 
        {
            if (numeroMinutos > 0)
            {
                this._numeroDeMinutos = numeroMinutos;
            }
            else
            {
                this._numeroDeMinutos = 1;
            }
        }

        public double dameImporte()
        {
            return this._numeroDeMinutos * 0.08;  
        }
    }
}
