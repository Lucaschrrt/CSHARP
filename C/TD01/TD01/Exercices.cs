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
        TD01_ex5();
    }

    static void TD01_ex1()
    {
        // Exercice 1 : Fonction de Recherche
        try
        {
            int [] tab = [4,9,24,56,91];
            Console.Write("Entrez un nombre que tu souhaites chercher dans le tableau : ");
            int recherche = Convert.ToInt32(Console.ReadLine());
            bool present = false;
            foreach (int element in tab)
            {
                if (element == recherche)
                {
                    present = true;
                }
            }
            if (present == true)
            {
                Console.WriteLine($"Le nombre {recherche} que tu as cherché se trouve bien dans le tableau !");
            }
            else
            {
                Console.WriteLine($"Le nombre {recherche} que tu as cherché ne se trouve pas dans le tableau");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Attention l'élément que tu cherches n'est pas un nombre !");
        }
    }

    static string TD01_ex2(string input)
    {
        // Exercice 2 : Phrase Inversée CORRECTION 
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        return reversed;
    }
        /* Tentative...
        string[] phrase = "Bonjour";
        string inverse_phrase = "";
        int temp = -1;
        foreach (int element in phrase[temp])
        {
            temp -= 1;
            inverse_phrase += phrase;
        }
        Console.WriteLine($"La phrase inversée ressemble à ça : {inverse_phrase}"); 
    }
        */

    int CountVowels(string chaine) // TD01_ex3
    {
        // Exercice 3 : Compter les voyelles CORRECTION 
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'è', 'é', 'ê', 'à', 'ù', 'â', 'î', 'ô', 'û' };
        int vowelsLength = vowels.Length;
        chaine = chaine.ToLower();
        int count = 0;

        for (int i = 0; i < chaine.Length; i++)
        {
            for (int y = 0; y < vowelsLength; y++)
            {
                if (vowels[y] == chaine[i])
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }

    static void TD01_ex4()
    {
        // Exercice 4 : Somme des Éléments d'un Tableau
        int[] tab = [];

        int somme_tab = 0;
        if (tab.Length > 0)
        {
            foreach (int element in tab)
            {
                somme_tab += element;
            }
            Console.WriteLine($"La somme de tous les éléments du tableau est de {somme_tab}");
        }
        Console.WriteLine($"Le tableau tab est vide, il ne peut y avoir cependant une valeur maximale");
    }

    static void TD01_ex5()
    {
        // Exercice 5 : Trouver le Maximum d'un Tableau
        int[] tab = [32,4,20,18];
        int maxi_tab = 0;
        if (tab.Length <= 0)
        {
            Console.WriteLine("Le tableau est vide, il n'y a donc pas de maximum à trouver");
        }
        else
        {
            foreach (int element in tab)
            {
                if (element > maxi_tab)
                {
                    maxi_tab = element;
                }
            }
            Console.WriteLine($"Le maximum de ce tableau est {maxi_tab}");
        }          
    }
}