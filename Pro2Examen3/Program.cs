using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pro2Examen3.Classes;

namespace Pro2Examen3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[] { 5, 2, 4, 1, 3 }; //aqui van los numeros que se quieren ordenar

            int n = arreglo.Count(); //iteraciones, si se agregan mas numeros al arreglo se aumenta el numero

            GenericsInsert<int> g1 = new GenericsInsert<int>();

            g1.insertionSort(arreglo, n);

            Console.ReadKey();
        }
    }
}
