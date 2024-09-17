using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioContador.models
{
    internal class Empresa
    {
        public int[] rangoSalario = new int[9];

        public void ClasificarRangoSalario(Vendedor vendedor)
        {
            int salarioVendedor = vendedor.ObtenerSalario();
            int salarioBase = vendedor.SalarioBase;

            if (salarioVendedor >= salarioBase)
            {
                for (int i = 0; i < 9; i++)
                {
                    int limiteInferior = i * 100 + 200;
                    int limiteSuperior = (i == 8) ? int.MaxValue : limiteInferior + 99;

                    if (salarioVendedor >= limiteInferior && salarioVendedor <= limiteSuperior)
                    {
                        rangoSalario[i]++;
                        break;
                    }
                }
            }
        }
    }


}
