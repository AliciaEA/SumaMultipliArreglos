using SalarioContador.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioContador
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            try
            {
                int ventas = int.Parse(tbVentasBrutas.Text);
                Vendedor vendedor = new Vendedor(ventas);
                int salarioBase = vendedor.SalarioBase;

                tbVentasBrutas.Clear();

                empresa.ClasificarRangoSalario(vendedor);
                MessageBox.Show("Vendedor agregado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbSalario.Clear();


                tbSalario.Text = "$ " + vendedor.ObtenerSalario().ToString() ;

                lbRangos.Items.Clear();
                for (int rango = 0; rango < empresa.rangoSalario.Length; rango++)
                {

                    lbRangos.Items.Add($"Rango {rango + 1}, Salario > {salarioBase}: {empresa.rangoSalario[rango]}");
                    salarioBase += 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cuidado: {ex.Message}", "Cuidado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
