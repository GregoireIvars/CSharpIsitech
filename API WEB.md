

API = interface , c'est ce que on expose au web , connecter à une BDD ;

Les application web communique en json ou XML .

La raison principal : Standardisation du langage sur le web ( afin de faciliter les echanges)

Faire une API reviens à créer de l'information et envoyer de l'information 

SI on nous parle de API en géneral on nous parle de frontEnd , BackEnd et fullStack .

Notre but est d'utiliser DOtNet afin de générer une API Web 

Forecast = prévision 

Curl est un utilitaire pour faire des requeste HTTP depuis un terminal 


Afin de controler le trajet de notre HTTP on emploie un controleur d'api 
#### Les standard : 
Les code http  : 
- 100 = continue 
- 101 Switching protocols 
- 102 Processing 
- 103 Early Hints
- 200 Ok
- 201 Created 
- 202 accepted
- 203 Non-Authoritative
- 
etc voir (Cat):[https://httpcats.com/] 



Le client = navigateur internet 
nous = le serveur 

#### Les mot clé dans HTPP :

- Post
- Get 
- Delete
et Bien d'autre 


### les besoin : 

Api web présentation logique metier 

But d'avoir une architecture 
Dossier entité 

Fonctionener entity FrameCorp 
Qu'est ce qu'un ORM

Grace a ce dernier via les classes C# on créé notre BDD
La générer 

Mettre a jour auto notre table 


Crud mettre dans le même 

Expliquer a quoi sert notre application dans un readME

	Template Swagger 

Postman , imsomnia ??



Docker = est une version simplifier de virtualiser les machines 

Comprend juste les outils necessaire sur le moment 


### Création de notre API via Dotnet 

 ##### Dans notre invite de commande ; 
 Ce mettre sur le dossier qui va stocker votre API 
- cd +  "Lien vers votre dossier "
- dotnet new "nom de notre api "

 ###### Sur notre IDE 
 Ouvrir le dossier de votre API
 Ensuite 
Ouvrir le terminal de votre IDE
- dotnet run 


#### Création d'un controleur : 

SI on veut ajouté un controleur 

Créé une  class qui hérite de controleurBase 

Route 



### A quoi sert globalement une API ? 

Une api va nous permettre de faire le lien par exemple entre une application web et mobile 
Quand on modifie notre identifiant sur le web alors l'api vien actualiser sur notre appli mobile 

On vien connecter notre jeu à notre api et ce dernier nous reli a notre BDD 



#### Base de donnée


Quand on emploie autre chose que du get 
Il va falloir 


Cast conversion de type implicite explicite 

Instruction : methode 