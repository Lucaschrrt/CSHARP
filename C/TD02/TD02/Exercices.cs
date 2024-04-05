using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;

class Program
// La classe main est la classe principale de notre programme.
// Elle représente notre programme.
{
    static void Main(string[] args)
    {
        TD02_ex1();
    }

    static void TD02_ex1()
    {
        // Exercice 1 : Convertisseur de Température
        Console.WriteLine("Entrez la température que vous souhaitez convertir : ");
        double temp_celsius = Convert.ToDouble(Console.ReadLine());
        double temp_fahr = temp_celsius * 9 / 5 + 32;
        Console.WriteLine ($"En fahrenheit, la température {temp_celsius} degré celsius devient {temp_fahr} degré");
    }

    static void TD02_ex2()
    {
        // Exercice 2 : Calculateur de Moyenne
        Console.WriteLine("Saisissez 3 nombres : ");
        double val1 = Convert.ToDouble(Console.ReadLine());
        double val2 = Convert.ToDouble(Console.ReadLine());
        double val3 = Convert.ToDouble(Console.ReadLine());
        double moy = (val1 + val2 + val3) /3;
        Console.WriteLine($" La moyenne de ces 3 nombres est de : {moy}");
    }
    
    static void TD02_ex3()
    {
        // Exercice 3 : Nombre Pair ou Impair
        try
        {
            Console.Write("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            if (nombre % 2 != 0)
                {
                    Console.WriteLine("Le nombre est impair");
                }
            else
                {
                    Console.WriteLine("Le nombre est pair");
                }
        }
        catch (Exception)
        {
            Console.WriteLine("Format incorrect, veuillez entrer un nombre entier.");
        }
    }

    static void TD02_ex4()
    {
        // Exercice 4 : Multiple d'un Nombre
        try
        {
            Console.Write("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            int ent = 1;
            while (ent < 10)
            {
                Console.WriteLine(nombre*ent);
                ent++;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Attention le format utilisé est incorrect, veuillez entrer un nombre entier.");
        }
    }

    static void TD02_ex5()
    {
        // Exercice 5 : Somme des N Premiers Nombres
       try
       {
            Console.Write("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            int depart = 1;
            int arrivee = 0;
            int boucle = 10;
            while (arrivee != boucle)
            {
                arrivee++;
                int nv_nombre = nombre + depart;
                depart = nombre;
                nombre = nv_nombre;
                Console.WriteLine(nv_nombre);
            }
       }
       catch (FormatException)
       {
            Console.WriteLine("Attention le format utilisé est incorrect, veuillez entrer un nombre entier.");
       }
    }

}