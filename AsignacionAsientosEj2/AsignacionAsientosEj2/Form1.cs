using AsignacionAsientosEj2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionAsientosEj2
{
    public partial class Form1 : Form
    {
        Avion avion = new Avion();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int opcion = -1, inicio, final; // Declaracion de variables

            if (avion.AvionLleno()) //Primero checamos que el avion no este lleno
            {
                Limpiar();
                MessageBox.Show("El avion esta lleno, El siguiente vuelo sale en 3 horas", "Ups!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Verificamos que se haya seleccionado una seccion
                opcion = cmbSeccion.SelectedIndex;
                if (opcion != -1)
                {
                    inicio = opcion == 0 ? 0 : 5;
                    final = opcion == 0 ? 5 : 10;

                    Limpiar();
                    AsignarAsiento(inicio, final);
                }
                else
                {
                    throw new Exception("Seleccione una seccion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ups!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        public void AsignarAsiento(int inicio, int final)
        {
            int index;
            if ((index = avion.AsignarAsiento(inicio, final)) != -1)
            {
                avion.asientos[index].Asignar();
                tbAsiento.Text += avion.asientos[index].ImprimirPase();
            }
            else
            {
                MessageBox.Show("No hay asientos disponibles en la seccion seleccionada", "Ups!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult result = MessageBox.Show("Hay Asientos Disponibles en la otra seccion, ¿Deseas ser asignado a la otra seccion?",
                    "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    inicio = inicio == 0 ? 5 : 0;
                    final = final == 5 ? 10 : 5;

                    index = avion.AsignarAsiento(inicio, final);
                    avion.asientos[index].Asignar();
                    tbAsiento.Text += avion.asientos[index].ImprimirPase();
                }
                else
                {
                    MessageBox.Show("El siguiente vuelo sale en 3 horas", "Ups!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
        public void Limpiar()
        {
            tbAsiento.Text = "";
            cmbSeccion.SelectedIndex = -1;
        }



    }
}
