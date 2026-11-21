# Portfolio

Site personnel réalisé avec ASP.NET Core MVC et Razor. Il comprend une page d’accueil, un CV, une page de contact et un catalogue de projets alimenté par un fichier JSON. Le catalogue contient des exemples de démonstration qui illustrent l’interface.

## Lancer en local

Installez le SDK .NET requis par [le fichier projet](Portfolio/Portfolio/Portfolio.csproj), puis exécutez cette commande depuis la racine du dépôt.

```sh
dotnet run --project Portfolio/Portfolio/Portfolio.csproj
```

Ouvrez l’adresse affichée dans le terminal. La route `/Project` donne accès au catalogue.
