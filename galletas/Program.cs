using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galletas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string galletas;
            int packs, caramelos;
            double precio, precioFinal;
            precio = 0;
            caramelos = 0;

            Console.WriteLine("Ingrese el tipo de galleta: ");
            galletas = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de packs de galleta: ");
            packs = int.Parse(Console.ReadLine());

            switch (galletas.ToLower())
            {
                case "charada":
                    precio = 3.80;
                    caramelos = 2 * packs;
                    break;
                case "picara":
                    precio = 3.90;
                    caramelos = packs;
                    break;
                case "soda":
                    precio = 2.40;
                    caramelos = packs;
                    break;
                case "margarita":
                    precio = 3.30;
                    caramelos = packs;
                    break;
                default:
                    Console.WriteLine("El tipo de galleta no es válido.");
                    return;
            }
            precioFinal = precio * packs;
            Console.WriteLine("El precio final a pagar es de : S/" + precioFinal);
            Console.WriteLine("Caramelos a obsequiar por la compra son: " + caramelos);
            Console.ReadKey();
        }
    }
}
