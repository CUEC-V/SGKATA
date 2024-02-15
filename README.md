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
 c - Afin de faciliter le déploiement et l'utilisation, les recettes ainsi que les ingrédients seront stockées en mémoire dans un premier temps.
 Ensuite, un système de base de données pourra être mise en place pour rendre perenne son exploitation.
 