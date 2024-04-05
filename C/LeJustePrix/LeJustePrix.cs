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
        LeJustePrix();
    }

    static void LeJustePrix()

    /* PSEUDO CODE : Juste Prix
    Initialisation et déclaration d'une nouvelle variable aléatoire
    Déclaration et attribution de toutes les variables nécessaires à la réalisation du jeu :
        Variable qui va être incrémenter de 1 à chaque saisie d'une valeur
        Variable dans lequel est stocké le nombre aléatoire à deviner
        Variable qui détermine le nombre maximum d'essai et arrête le jeu lorsque son nombre d'essai dépasse cette valeur
    Création d'une boucle dans lequel le joueur va rentrer et sortir uniquement si il a décider de quitter le jeu ou lorsqu'il a trouvé le Juste Prix.
    Tant qu'il n'a pas trouvé le nombre aléatoire ET si il reste encore des essais ALORS
        Lui demander de saisir une valeur (Tout ce qui est nombre entier ou la lettre "q" sinon le programme arrête le jeu en lui renvoyant une phrase)
        Comparer la valeur entrée avec le nombre aléatoire et renvoyer si c'est plus ou moins
        Incrémenter de 1 à la variable le nombre d'essai qu'il a effectué
        Lui renvoyer le nombre d'essai effectué
        Lui renvoyer le nombre d'essai restant
        Si il a rentré la valeur "q" ALORS
            Arrêter complètement le jeu avec une phrase de fin en lui annonçant le nombre aléatoire à deviner
        Si il a trouvé le nombre aléatoire ALORS
            Renvoyer une phrase de félicitation qui retourne son nombre d'essai effectué grâce à la variable correspondante
    */
    {
        {
            Random random = new Random();                // Déclaration d'une variable random qui sera affectée par un nombre aléatoire choisi.  
            int random_number = random.Next(0, 10001);      // Déclaration de la variable qui va stocker le nombre aléatoire à deviner entre 0 et 10.000
            int essais = 20;                               // Déclaration de la variable qui va être soustraite à chaque essai du joueur et sera utilisé pour montrer le nombre d'essai si le joueur devne le nombre
            Console.WriteLine("Bienvenue au Juste Prix ! Un nombre entier aléatoire entre 0 et 100 va être généré, tentez de le retrouver. Bonne Chance !");    // Affichage de la phrase d'introduction au programme sans que pour l'instant le joueur puisse entrer un nombre
            while (essais != 0)                             // Créatoin de la boucle qui s'arrêtera soit lorsque le joueur trouvera le Juste Prix ou soit qu'il n'a plus d'essais
            {
                Console.WriteLine($"Il reste {essais} essais. Entrez un nombre : ");    // On remarque au joueur son nombre d'essai qui lui reste puis est invité à retenter sa chance
                string? input = Console.ReadLine();                 //  On définit le type de variable que le joueur a rentré en chaine de caractères (string)
                if (input == "q")                                     // On vérifie avant de transformer ce que le joueur vient de tapper en nombre entier, si il n'a pas saisi "q" synonyme de fin de jeu
                    {
                        Console.WriteLine($"Vous avez décidé de quitter le jeu, à une prochaine fois ! (Le nombre était {random_number}, c'était franchement pas dur)");    // On indique au joueur qu'il a saisi "q" synonyme de fin de jeu et donc cette phrase sera affichée
                        break;                                          // Commande permettant de stopper la boucle actuelle et de quitter le jeu
                    }
                else if (int.TryParse(input, out int tentative))          //  On vérifie si ce que le joueur a rentré peut être convertit en nombre entier (int)
                {

                    essais--;                                          // La variable est soustraite de 1 à chaque essai, c'est grâce à cette ligne que la boucle s'arrêtera au bout des 20 essais.

                    if (tentative < 0 | tentative > 10000)                // On vérifie si le joueur a compris les règles et si il a rentrer un nombre entre 0 et 100 comme introduit dans la phrase d'introduction en amont
                    {
                        Console.WriteLine($"Le nombre rentré n'est pas valide, le nombre doit être compris entre 0 et 10000"); // La phrase en question qui remarque au joueur de son erreur mais n'est pas compté comme un essai dans le jeu 
                    }
                    else if (tentative < random_number)                 // On vérifie si le joueur a rentré un nombre inférieur au Juste Prix
                    {
                        Console.WriteLine($"C'est plus !");          // On prévient le joueur qu'il est en dessous du nombre aléatoire
                    }
                    else if (tentative > random_number)                 // On vérifie si le joueur a rentré un nombre suppérieur au Juste Prix
                    {
                        Console.WriteLine($"C'est moins !");         // On prévient le joueur qu'il est au dessus du nombre aléatoire
                    }
                    else   
                    {
                        Console.WriteLine($"Félicitations !!! Vous avez trouvé le Juste Prix en {20 - essais} essais ! C'était bien le nombre {random_number} ! ");
                        break;                                          // On arrête la boucle avec "break" en indiquant au joueur qu'il a bien trouvé le Juste Prix et on montre son nombre d'essai qu'il a effectué
                    }
                }  
                else
                {
                    Console.WriteLine($"Vous devez rentrer un nombre entier valide compris entre 0 et 10000 !");  // On remarque au joueur qu'il a rentré autre chose qu'un nombre entier et il est informé puis la boucle reprend
                }
            }
            if (essais == 0)    // On vérifie si son nombre d'essai est dépassé et donc si sa variable correspondante est égale à 0
            {
                Console.WriteLine($"Perdu ! Vous n'avez pas trouvé le nombre {random_number} en 20 essais... Réessayez !");  // On remarque au joueur qu'il a épuisé tous ses essais donc qu'il a perdu le jeu. Le jeu s'arrête et est informé du Juste Prix qu'il n'a pas réussi à trouver       
            }  
        }  
    } 
}