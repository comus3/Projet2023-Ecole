# Readme - Projet .NET MAUI "School Manager"

## Description du Projet

Bienvenue dans le projet "School Manager" ! Ce projet s'inspire de l'exercice du laboratoire 2 et vise à créer une interface MAUI pour gérer divers aspects liés à la gestion scolaire. Les fonctionnalités principales du projet sont les suivantes :

1. **Création d'Étudiants:** Permet de créer de nouveaux étudiants.
2. **Création d'Enseignants:** Permet de créer de nouveaux enseignants.
3. **Création d'Activités:** Permet de créer de nouvelles activités.
4. **Création d'Évaluations:** Permet d'ajouter des évaluations pour un cours spécifique attribué à un étudiant, incluant une cote ou une appréciation.
5. **Bulletin:** Permet d'afficher le bulletin des étudiants.

## Fonctionnalité Additionnelle

En plus des fonctionnalités de base, une fonctionnalité supplémentaire a été ajoutée :

- **Rollback des Backups:** La possibilité de faire un rollback des sauvegardes précédentes pour restaurer les données à un état antérieur.

## Sauvegarde des Données

Les données du projet "School Manager" sont sauvegardées sous forme d'un fichier JSON au moment de l'arrêt du programme et sont chargées à l'exécution du programme suivant. Cette approche garantit la persistance des données entre les sessions d'utilisation.

## Comment ça Fonctionne

Lorsque vous fermez l'application, un processus de sauvegarde est déclenché pour enregistrer l'état actuel des données dans un fichier JSON. Ce fichier contiendra toutes les informations nécessaires sur les étudiants, enseignants, activités, évaluations, et autres données pertinentes.

Lorsque vous démarrez à nouveau l'application, le programme vérifie la présence du fichier JSON de sauvegarde. Si le fichier est trouvé, les données sont chargées à partir de ce fichier, restaurant ainsi l'état précédent de l'application.
Si vous souhaitez revenir en arriere vous en avez la possibilité
Enfin, il est possible de sauvegarder manuellement a tout moment.

Pour utiliser l'application il est possible que le programme ne trouve pas le dossier backup. Pour regleer le probleme il faut aller dans le fichier appServices et corriger le directory path ou dans certains cas creer un dossier backup si il ne s'est pas créé tout seul.

## Manipulation des Fichiers JSON

La manipulation des fichiers JSON est réalisée de manière sécurisée, en utilisant les fonctionnalités fournies par les bibliothèques NewtonSoft.Json. 

## Principes SOLID

L’un des 5 principes SOLID est le "Liskov Substitution Principle", il stipule qu’un type devrait toujours pouvoir être remplacé par son sous type sans que ça n’affecte la cohérence du code.
Si on prend le code "Etudiant.cs", il s’agit de l’implémentation d’une sous classe Etudiant de la classe Personne. On peut utiliser un objet de la classe "Etudiant" partout où un objet de la classe "Person" est attendu sans que cela n’affecte le code.      
On le voit avec la méthode "DisplayName()" de la classe "Person" dans la méthode Bulletin()" de la classe "Etudiant", la méthode peut directement être appelée sur un objet "Etudiant".

Un autre principe SOLID, c’est celui de la responsabilité Unique (Single Responsability Principle). Il stipule que chaque classe et méthode à une responsabilité unique, une seule raison de changée.
Si on prend le fichier "AppServices.cs", on a différentes méthodes qui sont appelées pour effectuer des opérations spécifiques et chacune d’elle à une responsabilité bien définie. On a par exemple,
1.    La méthode "LoadData" qui est responsable du chargement des données à partir d’un fichier JSON pour qu’elles soient initialisées dans l’application.
2.    La méthode "SaveChanges" qui est responsable de récupérer les données actuelles et de les sauvegarder dans un fichier JSON
3.    La méthode "generateBackupList" qui est responsable de générer une liste des noms de fichier de sauvegardes disponible

Pour le point 1) la methode LoadData ne s'occupe pas de faire toutes les opérations pour load mais de call certaines methodes et donc ne fait que une seule chose
Pour le point 2) la methode SaveChanges va call une serie de methodes et donc ne doit pas faire toutes les operations pour Save
Pour le point 3) la methode generateBackupList ne fait que une chose: trouver tous les noms de backups

## Diagrammes UML

![Diagramme de classe Backend](Backend.png)
![Diagramme des classes de modeles](Models.png)


NBP: toutes les classes des modeles sont des classes dynamiques et possèdent toutes des propriétés pour chaque attribut et un UID. Les attributs étants des objets sont en fait les UIDs des objets correscpondants

