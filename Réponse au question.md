
## Question n°1 : 

```C#
short s = 400;

            byte b = (byte)s;
            Console.WriteLine(b);
```

Lors de notre conversion cela me retourne 144 

Je vais explique alors pourquoi : 

Tout d'abord notre variable short peut contenir entre -32 à 767
Byte lui peut contenir 0 , 255 ; 

Dans cette situation : Vu que le type source est plus grand que le type de destination,
Ce dernier va venir reduire le type source via l'abandon de ces bits "supplémentaire"
 d'ou pourquoi notre résultat juste au dessus vien nous retourne 144 

[Source](https://learn.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/numeric-conversions)



## Question n°2 

```C#
enum LesJoursDeLaSemaine
      {
          Lundi,
          Mardi,
          Mercredi,
          Jeudi,
          Vendredi,
          Samedi,
          Dimanche
      }
```

Nous permet de faire une liste afin d'énumérer des possibilité et de pouvoir les sélectionner bien distinquement.

## Question n°3 

```C#
 int[,] Tableau = new int[1, 2]; tableau en deux dimension 
 int[,,] Tabl = new int[3, 2,1]; tableau en trois dimension 

int[][] // jagged array 
```

La différence entre les deux premières syntaxes est assez simple: 
	La premières est un tableau deux dimension composé de 1 lignes et deux colonnes
	La deuxièmes est un tableau de trois dimensions 
	et le troisièmes est ce que on appel un jagged array 


#### Ma source 


[Source](https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/arrays/multidimensional-arrays)


## Question n°4  :

Citez un exemple concret de l'utilisation de clé private .

Dans le cas où l'on souhaite réglementer l'accès à nos données : 
Par exemple on à une classe employé qui elle contient le Mot de passe de l'employé .
On va passer cette dernière en private pour réglementer son utilisation que part de méthode 

## Question n°5 Qu'est ce qu'un ORM ?

Est une technique de programmation venant facilité l'accès au base de données en employant des "Objet" au lieu d'accéder directement à des données relationnelles.


#### Ma Source : 

[Source](https://www.base-de-donnees.com/orm/)


