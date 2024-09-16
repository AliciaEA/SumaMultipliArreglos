using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendedoresEj3.models;

namespace VendedoresEj3
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
            GuardarVenta();
            MostrarVentas();

        }

        public void GuardarVenta()
        {
            Venta venta;
            int vendedor, producto, valor;

            try
            {
                vendedor = Convert.ToInt32(cmbIdVendedor.SelectedItem);
                producto = Convert.ToInt32(cmbIdProducto.SelectedItem);
                if(Convert.ToInt32(tbValor.Text) < 0)
                {
                    throw new Exception("El valor de la venta no puede ser negativo");
                }
                valor = Convert.ToInt32(tbValor.Text);

                venta = new Venta(vendedor - 1, producto - 1, valor);

                empresa.AgregarVenta(venta);

                LimpiarDRegistro();

                MessageBox.Show("Venta guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MostrarVentas()
        {
            // Limpiar DataGridView para mostrar los resultados de la suma
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();

            AgregarColumnasPorVendedor();
            MostrarProductoyVendedor();
            MostrarTotalProducto();
            MostrarTotalVendedor();
        }

        public void AgregarColumnasPorVendedor()
        {
            // Agregar columnas para cada vendedor
            dgvVentas.Columns.Add("Producto", "Producto");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                dgvVentas.Columns.Add("Vendedor" + (vendedor + 1), "Vendedor " + (vendedor + 1));
            }
        }
        public void MostrarProductoyVendedor()
        {

            // Agregar filas con los productos y las ventas totales
            double[,] ventas = empresa.DisplayVentas();
            for (int producto = 0; producto < 5; producto++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvVentas);
                row.Cells[0].Value = producto + 1;
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    row.Cells[vendedor + 1].Value = ventas[producto, vendedor];
                }

                dgvVentas.Rows.Add(row);
            }
        }
        public void MostrarTotalProducto()
        {
            //Agregar Total Producto
            dgvVentas.Columns.Add(ToString(), "Total Producto $");
            for (int producto = 0; producto < 5; producto++)
            {
                double total = empresa.TotalVentasProducto(producto + 1);
                dgvVentas.Rows[producto].Cells[5].Value = total;
            }
        }
        public void MostrarTotalVendedor()
        {
            //Agregar Total Vendedor
            dgvVentas.Rows.Add("T. Vendedor $");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                double total = empresa.TotalVentasVendedor(vendedor + 1);
                dgvVentas.Rows[5].Cells[vendedor + 1].Value = total;
            }
        }

        public void LimpiarDRegistro()
        {
            cmbIdProducto.SelectedIndex = -1; // Deselect any selected item
            cmbIdVendedor.SelectedIndex = -1; // Deselect any selected item
            tbValor.Text = ""; // Clear the text box

        }
    }

}


