using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioContador.models
{
    internal class Vendedor
    {

        public int VentasBrutas { get; set; }
        public double Salario { get; set; }
        public int SalarioBase = 200;

        public Vendedor(int ventasBrutas)
        {
            VentasBrutas = ventasBrutas;
            CalcularSalario();
        }

        public void CalcularSalario()
        {
            Salario = SalarioBase + (VentasBrutas * 0.09);
        }

        public int ObtenerSalario()
        {
            return (int)Salario;
        }
    }
}
