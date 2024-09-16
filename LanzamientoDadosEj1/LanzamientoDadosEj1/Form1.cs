using LanzamientoDadosEj1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Escriba un programa en C# que simule el tirar dos dados. El programa deberá utilizar rand para 
tirar el primer dado, y después volverá a utilizar rand para tirar el segundo. suma de los valores 
deberá entonces ser calculada. Nota: en vista de que cada dado puede mostrar un valor entero 
de 1 a 6, entonces la suma de los dos valores variara desde 2 hasta 12, siendo 7 la suma mas 
frecuente y 2 y 12 las menos frecuentes. En la figura 6.23 se muestran las 36 combinaciones 
posibles de los dos dados. Su programa deberá tirar 36,000 veces los dos dados. Utilice un 
arreglo de un subíndice para llevar cuenta del numero de veces que aparece cada suma posible. 
Imprima los resultados en un formato tabular. También determine si los totales son razonables, 
es decir existen seis formas de llegar a un 7, por lo que aproximadamente una sexta parte de 
todas las tiradas deberán ser 7.
 */


namespace LanzamientoDadosEj1
{
    public partial class Form1 : Form
    {
        SimulacionDados simulacion = new SimulacionDados();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            simulacion.SimularTiradas(36000);
            int[] frecuencias = simulacion.GetFrecuencias();
            
            // Limpiar los resultados anteriores 
            LimpiarElementos();

            // Encabezado del formato tabular
            // Asegurar que el DataGridView tenga las columnas configuradas
            if (dgvResultados.Columns.Count == 0)
            {
                dgvResultados.Columns.Add("Suma", "Suma");
                dgvResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            // Agregar los resultados de las sumas al DataGridView
            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvResultados.Rows.Add(i, frecuencias[i]);
            }

            // Comprobar si la suma 7 se aproxima al 16.67% de las tiradas
            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidad.Text = $"\nFrecuencia estimada de la suma 7: {frecuencias[7]} veces.\n";
            tbProb7.Text = $"\nProbabilidad estimada de la suma 7: {probabilidad7:P2} (Debe ser aprox. 16.67%)";
        }

        public void LimpiarElementos()
        {
            dgvResultados.Rows.Clear();
            tbProbabilidad.Clear();
            tbProb7.Clear();
        }
    }
}
