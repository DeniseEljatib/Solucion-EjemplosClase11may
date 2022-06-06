using System;
using System.Collections.Generic;

namespace EjemploClase11may
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }


            Plato p = new Plato();

            p.Id = 1;
            p.Nombre = "Milanesa";
            p.Descripcion = "La Mila famosa con fritas";

            List<Plato> listaPlatos = new List<Plato>();


            Plato pp = new Plato();
            pp.Id = 2;
            pp.Nombre = "Ensalada";
            pp.Descripcion = "La ensalada mixta";


            listaPlatos.Add(p);
            listaPlatos.Add(pp);

            foreach (var item in listaPlatos)
            {
                Console.WriteLine($"Id {item.Id} tiene el nombre {item.Nombre} y la descri {item.Descripcion}");
            }

        }
    }
}
