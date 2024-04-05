Definition "Algorithme" : série d'instructions qui permet d'aboutir à la même solution finale.

# Titre 1
## Titre 2
### Titre 3
#### Titre 4
##### Titre 5

`Code`

```csharp
int test = 0;
```

~~Barré~~ 
*Italique*
**Gras**
***Gras et italique***

---

***Avertissement et Erreur***
---
On peut executer la commande suivante `dotnet build` pour permettre de vérifier la fiabilité de notre code. Cette commande va nous renvoyer le nombre **d'avertissement** et le nombre **d'erreur**.

Un **avertissement** n'est pas une erreur et n'empêche pas l'execution du programme. Elle fait simplement remarquer qu'une variable n'est pas utilisée par exemple.

Cependant, une **erreur** va empêcher l'execution du programme à cause d'une erreur de langage présent dans le programme à un certain endroit. Il faut donc régler toutes les erreurs retrouvées pour que l'execution de la commande puisse s'executer.

***La Table ASCII***
---
La Table ASCII (American Standard Code for Information Interchange) 



```csharp
const double PI = 3.14;
PI = 3.15; // Erreur
```
```csharp
// Les conditions 
        int age = 18;
        bool hasDrivingLicence = true;
        bool isEmancipated = true;
        if (age >= 18 && hasDrivingLicence | isEmancipated);
        {
            Console.WriteLine("Vous pouvez conduire");
        }
        else if (age >= 18 && !hasDrivingLicence);
        {
            Console.WriteLine("Vous ne pouvez pas conduire");
        }
        else
        {
            Console.WriteLine("Vous ne pouvez pas conduire");
        }
    }
```
```csharp
// Les opérateurs arithmétiques
        // + - * / % 
        int x = 10 % 3;
        int y = 10 / 3;
        float z = 10 / 3.0f; // Rajouter un "f" après le 3 va considérer que c'est un double pour le compilateur
        float a = 10 / (float) 3.0; // Ceci est un cast explicite
        Console.WriteLine(x); // 1
        Console.WriteLine(y); // 1
        Console.WriteLine(z); // 1
        Console.WriteLine(a); // 1
```
***Opérateurs booléens***
---
&& = et

| = ou

!variable = Non

i++ = i+1

***Les Boucles***
---
En C#, il existe 3 façons d'effectuer une boucle : 

- **for** :
```csharp

```

- **while** :
```csharp
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}
```

- **do while** :
```csharp
do
{
    Console.WriteLine(x);
    x++;
}   while (x < 10);
```

***Les Tableaux***
---

Un tableau est une structure de données qui permet de stocker plusieurs ...

```csharp
// type[] <nom du tableau> <type de retour> <nom de la methode> (<parametres>)

int[] tab = new int[5];

string[] joursDeLaSemaine = ["Lundi", "Mardi", "Mercredi", "Jeudi","Vendredi"];

Console.WriteLine(joursDeLaSemaine[0]);    
```



- Méthode `Substring` :
```csharp
string maChaine = "lorem ipsum";
string sousChaine = maChaine.Substring(0, 5);
Console.WriteLine(sousChaine);
// La console va renvoyer : lorem 
```

- Méthode `Replace` :
```csharp
string texte = "Bonjour tout le monde!";
string nv_texte = texte.Replace("Bonjour", "Au revoir");
Console.WriteLine(nv_texte);
// La console va renvoyer : "Au revoir le monde!"
```

- Méthodes `ToUpper` et `ToLower` :
```csharp


// La console va renvoyer :  
```
# Les Exercices
## TD-01

- **Exercice 1**
```csharp
static void T01ex1()
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
```
---
- **Exercice 2**
```csharp

```
---
- **Exercice 3**
```csharp

```
---
- **Exercice 4**
```csharp

```
---
- **Exercice 5**
```csharp

```

## TD-02

- **Exercice 1**
```csharp
int temp = 21;
int temperature = temp * 9 / 5 + 32;
Console.WriteLine temperature;
```
---
- **Exercice 2**
```csharp
static void T02ex2()
    {
        // Exercice 2 : Calculateur de Moyenne
        double val1 = 24.0;
        double val2 = 14.3;
        double val3 = 5.7;
        double moy_temp = val1 + val2 + val3;
        double moy = moy_temp /3;
        Console.WriteLine(moy);
    }
```
---
- **Exercice 3**
```csharp
static void T02ex3()
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
        catch (FormatException)
        {
            Console.WriteLine("Format incorrect, veuillez entrer un nombre entier.");
        }
    }
```
---
- **Exercice 4**
```csharp
static void T02ex4()
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
```
---
- **Exercice 5**
```csharp
static void T02ex5()
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
```

# JEU N°1 : Le Juste Prix
```csharp
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
            Renvoyer une phrase de félicitation accompagnée de son nombre d'essai effectué grâce à la variable correspondante
    */
    {
        {
            Random random = new Random();                // Déclaration d'une variable random qui sera affectée par un nombre aléatoire choisi.  
            int random_number = random.Next(0, 100);      // Déclaration de la variable qui va stocker le nombre aléatoire à deviner entre 0 et 10.000
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

                    if (tentative < 0 | tentative > 1000)                // On vérifie si le joueur a compris les règles et si il a rentrer un nombre entre 0 et 100 comme introduit dans la phrase d'introduction en amont
                    {
                        Console.WriteLine($"Le nombre rentré n'est pas valide, le nombre doit être compris entre 0 et 1000"); // La phrase en question qui remarque au joueur de son erreur mais n'est pas compté comme un essai dans le jeu 
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
                        Console.WriteLine($"Félicitation !!! Vous avez trouvé le Juste Prix en {20 - essais} essais ! C'était bien le nombre {random_number} ! ");
                        break;                                          // On arrête la boucle avec "break" en indiquant au joueur qu'il a bien trouvé le Juste Prix et on montre son nombre d'essai qu'il a effectué
                    }
                }
                else if (essais == 0)    // On vérifie si son nombre d'essai est dépassé et donc si sa variable correspondante est égale à 0
                {
                    Console.WriteLine($"Perdu ! Vous n'avez pas trouvé le nombre {random_number} en 20 essais... Réessayez !");  // On remarque au joueur qu'il a épuisé tous ses essais donc qu'il a perdu le jeu. Le jeu s'arrête et est informé du Juste Prix qu'il n'a pas réussi à trouver       
                }   
                else
                {
                    Console.WriteLine($"Vous devez rentrer un nombre entier valide compris entre 0 et 1000 !");  // On remarque au joueur qu'il a rentré autre chose qu'un nombre entier et il est informé puis la boucle reprend
                }
            } 
        }
        
    }
```

# JEU N°2 : Le Pendu
```csharp

```
