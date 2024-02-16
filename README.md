# SGKATA
Projet c# pour mettre en place un distributeur automatique de boisson chaude :

1 - Avant de développer cette application, il y a lieu de s'intérogger sur un certain nombre d'aspects :

 a - Quel type d'application : Console, Web ou Desktop ?
 b - Doit-on nécessairement disposer d'une connexion à internet pour la faire fonctionner ou est-ce une application autonome ?
 c - Comment doit-on stocker les données ?
 
 
2 - Pour répondre à ces questions :

 a - Une application Web nécessiterait une connexion à internet donc cela induirait des coups d'exploitation supplémentaires chaque mois.
 Une application Console ? Oui mais la difficulté réside dans le commment permettre à l'utilisateur de sélectionner la boisson par celles 
 proposées. Une application Desktop (WinForm) serait la plus raisonnable : 
	-	Ne nécessite pas de connexion internet (pas de coût d'exploitation)
	-   Elle autonome (installation unique 
	-   Possibilité d'utilisation des composants Controls pour faire des listes, ....
 Notre application serait donc développer sur c# ( WinForm .net core) 
 
 b - Elle sera donc une application autonome ne nécessitant pas de connxion à internet.
 c - Afin de faciliter le déploiement et l'utilisation, les recettes ainsi que les ingrédients seront stockées dans un système de base de données pourra être mise en place pour rendre perenne son exploitation
 sql server. 
 
 How to run the application :
 
 1 - First, you need sql server Express with MSSMS.
 2 - Second, within MSSMS, create a database named SG. 
 3 - Third, create the two tables with Recette.sql and Ingredient.sql files provided with the solution
 4 - Fourth, open appsettings.json file located in (SG.Kata\bin\Debug\netcoreapp3.1)  and modify the 
 connectingString source to indicate the appropriate server : [XXXXX]. 
 5 - Select SG.Kata as stard project and run
 
 Next, will write the Tests project ... and developp interfaces for adding recette and Ingredient. 
 
 
 
