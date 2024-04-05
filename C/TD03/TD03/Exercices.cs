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
        Nombre(95);
    }

    static void TD03_ex1(string chaine)
    {
        // Exercice 1 : Premier et Dernier Caractère CORRECTION
        try
        {
            char first = chaine[0];
            char last = chaine[chaine.Length -1];
            Console.WriteLine($"Le premier caractère est : {first} et le dernier est {last}");
        }
        catch (Exception)
        {
            Console.WriteLine("Attention, ta chaîne de caractère ne doit pas être null");
        }
    }

    static int CountOccurence(int[] array, int number)
    // CORRECTION
    {
        int count = 0;
        foreach (var element in array)
        {
            if (element == number)
            {
                count++;
            }
        }

        return count;
    }

    static void Nombre(int monNombre)
    {
        try
        {
        if (monNombre > 0)
        {
            Console.WriteLine("Le nombre est positif");
        }
        else if (monNombre < 0)
        {
            Console.WriteLine("Le nombre est negatif");
        }
        else
        {
            Console.WriteLine("Le nombre est nul");
        } 
        }
        catch (Exception)
        {
            Console.WriteLine(" Attention, vous devez entrer un nombre entier !");
        }
    }
}