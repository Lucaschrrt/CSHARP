using System;
using System.Collections.Generic;

class Program
{

    /* PSEUDO CODE : Le Pendu

    Déclaration de toutes les listes qui contiendra les valeurs pour chauqe difficulté
    Création d'une boucle où le joueur rentrera et resortira uniquement uniquement dès la fin de la partie
    Lancement du menu principal qui va demander au joueur de jouer ou quitter le jeu
    Création d'une boucle qui va bloquer le joueur si rentre autre chose que la valeur permettant de quitter le jeu ou y rentrer
        Si il rentre la valeur 'q' alors il quitte la boucle et donc le jeu et donc le programme
        Si il rentre la valeur 'o' alors il rentre dans une autre boucle qui le fera joueur au jeu
        Si il rentre autre chose alors il est informé qu'il doit rerentré une autre valeur car celle ci est incorrecte
    Dès qu'il a rentr la veleur 'o' pour jouer ALORS
        Lancement du menu du choix des options permettant de choisir la difficuté de son jeu entre facile moyen et difficile
            Si il rentre '1' alors la liste dans lequel le mot à deviner sera pioché fera partie de la liste des mots facile
            Si il rentre '2' alors la liste dans lequel le mot à deviner sera pioché fera partie de la liste des mots moyen
            Si il rentre '3' alors la liste dans lequel le mot à deviner sera pioché fera partie de la liste des mots difficile
            Si il rentre autre chose que ces 3 valeurs, alors il est invité à en rentrer une nouvelle entre les 3 valeurs précédentes
        Lorsque le choix de jouer au jeu et le choix de la difficulté choisie ALORS
            Choix aléatoire grâce à une variable random qui va piocher un mot présent au hasard dans la liste de la difficulté choisie correspondante
            Déclaration de toutes les variables nécessaires à la mis en marche du jeu comme :
                Son nombre d'essais restant
                Une variable qui sotckera le mot à deviner
                Une variable qui stockera autant d'underscores que de nombres de lettres dans le mot à deviner
                Une variable qui changera à chaque tentative du joueur dans le jeu
            SI la lettre qu'il a rentré est présente dans le mot à deviner ALORS
                Révélation de la ou les lettre(s) et de son ou ses emplacement(s) dans le mot à deviner
                On enlève autant d'underscores quede lettres présentes de la mot à deviner permettant de savoir le nombre de lettres restantes à deviner et où
            SI la lettre qu'il a rentré n'est pas présente dans le mot à deviner ALORS
                On soustrait d'1 la variable essai lui informant qu'il reste essais - 1 essais dans le jeu
            Ensuite

            SI à la fin de la boucle de son nombre d'essais il n'y a plus d'underscores dans la variable correspondante ALORS
                Un message de félicitations montré au joueur lui signifiant qu'il a gagné le jeu du pendu en tel nombre d'essais
            SI à la fin de la boucle de son nombre d'essais il reste des undersccores dans la variable correspondante ALORS
                Un messsage de fin du jeu est affiché indiquant au joueur qu'il a perdu la partie
        Création d'une boucle qui demande au joueur si il veut rejoueur au jeu ou non
        SI il rentre la valeur 'o' ALORS
            Le jeu se relance
        SI il rentre la valeur 'q' ALORS
            Le jeu se ferme
        SI il rentre autre chose ALORS
            Le joueur est informé de son erreur et est réinvité à rentré à nouveau une valeur  

    */

    static void Main(string[] args)
    {
        string[] list_mots_facile = { "code", "lancer", "notes", "lyon", "souris", "clavier", "dents", "lune", "loin", "jazz", "draps", "lit", "carte", "bruit", "avion", "train" }; // Déclaration d'un tableau de type chaîne de caractères qui contiendra tous les mots de la difficulté "facile" pour le jeu du pendu
        string[] list_mots_moyen = { "bateaux", "etudiant", "football", "olympique", "scorpion", "debutant", "brocante", "tourisme", "ascenseur", "avalanche" }; //  Déclaration d'un tableau de type chaîne de caractères qui contiendra tous les mots de la difficulté "moyen" pour le jeu du pendu
        string[] list_mots_difficile = { "apocalypse", "grenouille", "labyrinthes", "quadriceps", "baccalaureat", "sorcellerie", "metamorphose", "kaleidoscope" }; //  Déclaration d'un tableau de type chaîne de caractères qui contiendra tous les mots de la difficulté "difficile" pour le jeu du pendu
        List<string> dessin_pendu = new List<string> // Déclaration d'une liste de type chaîne de caractères qui contiendra les différentes étapes du pendu et son côté graphique
        {
            "   +---+\n   |   |\n   0   |\n  /|\\  |\n  / \\  |\n       |\n#########",    
            "   +---+\n   |   |\n   0   |\n  /|\\  |\n  / \\  |\n       |\n#########",    
            "   +---+\n   |   |\n   0   |\n  /|\\  |\n       |\n       |\n#########",
            "   +---+\n   |   |\n   0   |\n   |   |\n       |\n       |\n#########",
            "   +---+\n   |   |\n   0   |\n       |\n       |\n       |\n#########",
            "   +---+\n   |   |\n       |\n       |\n       |\n       |\n#########",
            "   +---+\n       |\n       |\n       |\n       |\n       |\n#########",
            "       |\n       |\n       |\n       |\n       |\n#########",
            "#########\n",
            "",
        };

        string menu_principal = @"
{==============================================================================================================================================================================================================================================}
{*                                                                                                          JEU DU PENDU                                                                                                                      *}
{*                                                                                                                                                                                                                                            *}
{*                                       Rentrez 'q' pour Quitter                                                                                                             Rentrez 'o' pour Jouer                                          *}
{*                                                                                                                                                                                                                                            *}
{==============================================================================================================================================================================================================================================}";

        // Déclaration d'une variable de type chaîne de caractère qui stockera comme valeurs le menu du choix de jouer ou non au jeu du pendu pour améliorer le côté graphique du jeu

        string menu_difficulte = @"
{==============================================================================================================================================================================================================================================}
{*                                                                                                   CHOISISSEZ LA DIFFICULTÉ                                                                                                                 *}
{*                                                                                                                                                                                                                                            *}
{*                                                                                                                                                                                                                                            *}
{*                    Rentrez '1' pour FACILE                                                         Rentrez '2' pour MOYEN                                                              Rentrez '3' pour DIFFICILE                          *}
{==============================================================================================================================================================================================================================================}";

        // Déclaration d'une variable de type chaîne de caractère qui stockera comme valeur le menu du choix de difficulté pour améliorer le côté graphique du jeu

        bool partie = true; //déclaratin d'une variable qui va déterminer si le joueur est dans le jeu ou non. Elle vaut "true" initialement
        while (partie) // Création de la boucle où le joueur sera durant toute la partie, il la quittera lorsque le booléen vaudra "false"
        {
            Console.WriteLine($"{menu_principal}"); // Affichage du menu principal
            string input = Console.ReadLine(); // Déclaration d'une variable de type chaîne de caractères "input" qui permettra de se déplacer dans le menu pour jouer ou quitter le jeu
            
            while (input != "q" && input != "o") // Création d'un boucle qui bloquera le joueur si il ne choisit ni le bouton affilier pour jouer 'o' ou le bouton affilié pour quitter 'q'
            {
                Console.WriteLine("Veuillez saisir soit 'q' pour quitter le jeu soit 'o' pour jouer au jeu du Pendu."); // Affichage dans la console de l'erreur du joueur
                input = Console.ReadLine(); // On va donc remettre à vide la variable et on déclarera ce que le joueur va rentrer dans le terminal
            }

            if (input == "q") // Première condition où "Si le joueur rentre la valeur 'q' soit Quitter le jeu "
            {
                Console.WriteLine("Vous avez décidé de quitter le jeu. À bientôt !"); // Message dans le terminal qui informe le joueur de sa décision et qu'il quittera le jeu après ce message
                return; // Sortie de la boucle et synonyme de fin du programme
            }
            else if (input == "o") // Deuxième condition où "Si le joueur rentre la valeur 'o' soit Jouer au jeu "
            {
                Console.WriteLine($"{menu_difficulte}"); // Affichage du menu du choix de difficulté 
                string input_difficult = Console.ReadLine(); // Déclaration d'une autre variable de type chaîne de caractères "input_difficult" qui permettra au joueur de se déplacer dans le menu du choix de la difficulté
                string[] list_mots; // Création d'une variable de type chaîne de caractères qui conservera la liste du niveau de difficulté que choisira le joueur

                while (input_difficult != "1" && input_difficult != "2" && input_difficult != "3") // Création d'une boucle comme pour lemenu principal où le joueur sera bloqué si il rentre autre chose que les 3 valeurs signifiant le choix des 3 différentes difficultés 
                {
                    Console.WriteLine("Attention ! Veuillez entrer soit '1', soit '2', soit '3' pour choisir le mode de difficulté"); // Message dans le terminal qui informe le joueur de son erreur 
                    input_difficult = Console.ReadLine(); // On va donc remettre la variable "input_difficult" à vide et on déclarera ce que le joueur va rentrer dans le terminal
                }

                if (input_difficult == "1") // Condtion n°1 si le joueur rentre la valeur '1'
                {
                    list_mots = list_mots_facile; // La variable "list_mots" contiendra la liste qui contient tous les mots du choix de difficulté "facile" déjà présent dans la liste "list_mots_facile"
                }
                else if (input_difficult == "2") // Condtion n°2 si le joueur rentre la valeur '2'
                {
                    list_mots = list_mots_moyen; // La variable "list_mots" contiendra la liste qui contient tous les mots du choix de difficulté "moyen" déjà présent dans la liste "list_mots_moyen"
                }
                else if (input_difficult == "3") // Condtion n°3 si le joueur rentre la valeur '3'
                {
                    list_mots = list_mots_difficile; // La variable "list_mots" contiendra la liste qui contient tous les mots du choix de difficulté "difficile" déjà présent dans la liste "list_mots_difficile"
                }
                else
                {
                    Console.WriteLine("Attention ! Veuillez entrer soit '1', soit '2', soit '3' pour choisir le mode de difficulté"); // Message d'erreur montrant l'erreur du type de rentré du joueur 
                    continue; // Continue la boucle
                }

                Random random = new Random(); // Déclaration d'une variable random "random"
                int index_mots = random.Next(0, list_mots.Length); // Déclaration d'une variable de type entier "index_mots" qui contiendra un index au hasard compris entre 0 et la longueur totale de la liste "list_mots"
                string mot_a_deviner = list_mots[index_mots]; // Déclaration d'une autre variable de type chaîne de caractères qui contiendra un mot au hasard présent dans la liste "list_mots" à l'index random compris entre 0 et la longueur de la liste
                int essais = dessin_pendu.Count - 1; // Déclaration d'une variable de type entier "essais" qui contiendra le nombre de valeur présente dans la liste "dessin_pendu" qui signifiera son nombre d'essais restant dans la partie
                string lettres_trouvees = new string('_', mot_a_deviner.Length); // Déclaration d'une variable de type chaîne de caractères qui contiendra que autant underscores qu'il y a de lettres dans la variable "mot_a_deviner"

                while (essais > 0 && lettres_trouvees.Contains('_')) // Création d'une boucle où le joueur sera bloqué le temps que son nombre d'essais restant est positif ET qu'il reste encore des lettres à trouver dans la variable "lettres_trouvees" soit le mot n'étant pas deviner complètement
                {
                    Console.WriteLine(dessin_pendu[essais]); // Affichage alors du pendu à l'index "essais" qui contient donc "le niveau 0" du pendu à l'initialisation de la partie
                    Console.WriteLine($"Il vous reste {essais} essais. Mot à deviner : {lettres_trouvees}"); // Affichage de la phrase qui informe le joueur de son nombre d'essais restant ainsi que de son nombre de lettres trouvées / lettres non trouvées
                    Console.Write("Entrez une lettre : "); // Affichage du message dans la console qui informe le joueur que c'est le moment pour lui de rentrer une lettre
                    char tentative = Console.ReadKey().KeyChar; // Déclaration d'une variable de type caractère qui contiendra ce que le joueur va rentrer dans la console synonyme de sa tentative d'essai au jeu
                    Console.WriteLine();

                    if (mot_a_deviner.Contains(tentative)) // Condition qui regarde si ce que le joueur a rentré dans la console est une lettre également présente dans le mot à deviner 
                    {
                        Console.WriteLine($"Oui, la lettre '{tentative}' est bien présente dans le mot mystère !"); // Affichage qui informe le joueur qu'il a bien trouvé une lettre et qu'elle est bien présente dans le mot à deviner
                        for (int element = 0; element < mot_a_deviner.Length; element++) // Création d'un boucle qui 
                        {
                            if (mot_a_deviner[element] == tentative) // Condition qui regarde si la valeur présente à l'index element du mot à deviner est égale à ce que le joueur a rentré comme valeur soit si la lettre qu'il a rentré est présente à l'emplacement element du mot à deviner
                            {
                                lettres_trouvees = lettres_trouvees.Substring(0, element) + tentative + lettres_trouvees.Substring(element + 1); // Si c'est le cas, alors on affiche la ou les lettre(s) que le joueur a trouvé à ou aux emplacement(s) exacte(s) dans le mot à deviner
                            }
                        }
                    }
                    else
                    {
                        essais--; // On décrémente de 1 à la variable essais synonyme de tentative échouée
                        Console.WriteLine($"Non, la lettre '{tentative}' n'est pas présente dans le mot mystère..."); // Affichage au joueur montrant que sa lettre n'est présente à aucun endroit dans le mot à deviner
                    }
                }

                if (!lettres_trouvees.Contains('_')) // Codition qui vérifie si la variable "lettres_trouvees" qui contient initialement autant d'underscore que de lettres présent dans le mot à deviner contient encore des underscores
                {
                    Console.WriteLine($"Félicitations !!! Vous avez trouvé le mot mystère qui était {mot_a_deviner} en {essais} essais !"); // Si la variable ne contient plus d'underscore, cela signifie que toutes les lettres ont été trouvées et que le joueur a gagné la partie
                }
                else
                {
                    Console.WriteLine($"Perdu ! Vous avez n'avez plus d'essais. Le mot mystère était : {mot_a_deviner}"); // Affichage au joueur qu'il reste encore des lettres à trouver malgré que son nombre de tentative est égale à 0 soit qu'il a perdu la partie
                }

                Console.WriteLine("Voulez-vous rejouer ? (o/q)"); // Sortie de la boucle de jeu et qui affiche au joueur si il souhaite refaire une partie ou quitter le jeu
                input = Console.ReadLine(); // Déclaration à la même valeur input qui contiendra comme valeur ce que le joueur va rentré dans le terminal 
            }

            while (input != "q" && input != "o") // Création d'une boucle qui vérifie si le joueur a rentré autre chose que la valeur 'o' signifiant Rejouer une partie ou 'q' signifiant Quitter la partie
            {
                Console.WriteLine("Valeur incorrecte. Voulez-vous rejouer au jeu du Pendu ? (o/q)"); // Affichage au joueur de son erreur et qui lui informe qu'il doit rentrer à nouveau une valeur 
                input = Console.ReadLine(); // Cette valeur sera stocké dan sla variable input qui va remonter au déut de la boucle et qui va vérifier si le joueur a rentrer 'o' ou 'q' 
            }
        }
    }
}
