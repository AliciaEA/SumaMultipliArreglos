using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class SimulacionDados
    {
        public int[] frecuencia; // Arreglo para almacenar la frecuencia de las sumas de los dados
        public Dado dado1;
        public Dado dado2;

        
        public SimulacionDados()
        {
            frecuencia = new int[13]; // Frecuencia con la que sale la suma (2-12  - El 1 deberia quedar en 0)
            dado1 = new Dado(); 
            dado2 = new Dado(); 
        }
        public void ReiniciarFrecuencias()
        {
            frecuencia = new int[13];  // Reinicializar el arreglo para las sumas (2-12)
        }
        public void SimularTiradas(int lanzamientos)
        {
            ReiniciarFrecuencias();
            for (int i = 0; i < lanzamientos; i++)
            {
                int suma = dado1.Lanzar() + dado2.Lanzar();
                frecuencia[suma]++;
            }
        }

        public int[] GetFrecuencias()
        {
            return frecuencia;
        }
    }
}
