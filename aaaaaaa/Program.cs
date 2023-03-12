using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaZapa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Catálogo de zapatos
            string[,] catalogo = new string[4, 4] {
          {"Deportivo","Adidas", "42", "15%"},
          {"Casual","nike", "40", "25%"},
          {"Formal","Santoni", "38", "15%"},
          {"Botas","Grenson", "44", "35%"}
    };  

            // Tiendas de calzado
            string[] tiendas = new string[] { "Tienda 1", "Tienda 2", "Tienda 3" };

            // Mostrar lista de tiendas
            Console.WriteLine("Bienvenido ");
            Console.WriteLine("Seleccione una tienda:");
            for (int i = 0; i < tiendas.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, tiendas[i]);
            }

            // Obtener selección de tienda del usuario
            int tiendaSeleccionada = int.Parse(Console.ReadLine()) - 1;

            // Mostrar catálogo de zapatos de la tienda seleccionada
            Console.WriteLine("Catálogo de zapatos para {0}:", tiendas[tiendaSeleccionada]);
            Console.WriteLine("Estilo\tMarca\tTalla\tDescuento");
            for (int i = 0; i < catalogo.GetLength(0); i++)
            {
                Console.WriteLine("{0} \t{1}\t{2}\t{3}", catalogo[i, 0], catalogo[i, 1], catalogo[i, 2], catalogo[i, 3]);
            }

            // Obtener selección de zapato del usuario
            Console.WriteLine("Seleccione un zapato:");
            int zapatoSeleccionado = int.Parse(Console.ReadLine()) - 1;


            // Mostrar mensaje de compra exitosa
            Console.WriteLine("Ha comprado un par de zapatos {0} {1} talla {2} con descuento del {3} en {4}. ¡Gracias por su compra!", catalogo[zapatoSeleccionado, 0], catalogo[zapatoSeleccionado, 1], catalogo[zapatoSeleccionado, 2], catalogo[zapatoSeleccionado, 3], tiendas[tiendaSeleccionada]);
            Console.ReadKey();
        }
    }

}