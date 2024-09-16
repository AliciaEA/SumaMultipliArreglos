using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDadosEj1.models
{
    internal class Dado
    {
        private static Random rand = new Random();
        /*
    Se utiliza una única instancia de Random como static para evitar la reinicialización frecuente.
    Al crear varias instancias de Random en un corto período de tiempo, es posible que se inicialicen
    con la misma semilla (basada en el tiempo del sistema), lo que provoca que generen los mismos valores
    aleatorios y afecten negativamente la distribución de los resultados. Al declararlo static, se garantiza
    que ambos dados utilicen el mismo generador aleatorio, lo que produce una distribución más precisa y
    evita que algunas sumas aparezcan 0 veces.
    */

        public int Lanzar()
        {
            return rand.Next(1, 7); // Devuelve un numero aleatorio entre 1 y 6
        }
    }


}
