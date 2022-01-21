# Ticketing - Documentation
Application Windows Form en C#. Projet dans le cadre du modules "Projet C#" de 3ème année, 2ème trimestre
>Version : **1.0** \
>GitHub : **https://github.com/YFanha/ProjCsharp**
# 1 - Description de l'application <a name="description"></a>
Application Windows de ticketing. Cette application permet à des utilisateurs authentifiés d'ajouter des tickets pour que leur problème soit résolu au plus vite. Les techniciens peuvent eux, voir tous les tickets, les modifiers (Description, état, catégorie).

# 2 - Organistation <a name="organisation"></a>
## 2.1 - Développeurs <a name="developpeur"></a>
> - **Yann Fanha** - Yann.FANHA-DIAS@cpnv.ch
>   - *Développeur back-end, modélisation et gestion de la base de données*
> - **Simon Cuany** - Simon.CUANY@cpnv.ch
>   - *Développeur front-end*
> - **Sven Volery** - Sven.VOLERY@cpnv.ch
>   - *Développeur front-end*

## 2.2 - Gestion de projet  <a name="gestiondeprojet"></a>
Nous avons utilisé l'application ``Notion`` pour la gestion de projet et nos journaux de travail. Nous l'avons également utilisé pour rédiger le cahier des charges. La gestion de projet était légére, le but étant de nous concentrer sur la réalisation du projet.
> - Lien du notion : https://fanha.notion.site/Projet-C-Application-de-gestion-de-ticket-b0f3245a593e42f79fc77246d4b942e1

## 2.3 - Planification  <a name="planification"></a>
### **Sprint 1** 
```
Rédaction Cahier des charges, Création des vues, modélisation de la base de données, création du BL de base (classe de User, tickets), de la connexion à la base de données. et du login

Date de début  : Mardi 16 Novembre 2021
Date de fin : Jeudi 16 Décembre 2021
```
### **Sprint 2**
```
Implémentation du BL dans les vues, création de l'ajout, de la modification et de la suppression des tickets.

Date de début  : Vendredi 17 Décembre 2021
Date de fin : Jeudi 20 Janvier 2022
```
#### **Sprint 3**
```
Rédaction du dossier de projet avec manuel d'installation/utilisation et préparation de la présentation

Date de début  : Vendredi 21 Janvier 2021
Date de fin : Lundi 24 Janvier 2022
```

# 3 - Conception
## 3.3 - Matériel et logiciel utilisé
### **Matériel**
> - Poste du CPNV, tournant sur Windows 10 Éducation
> - Ordinateur personnel de chacun
### **Logiciel**
> - **Visual Studio Code** - Pour le développement, la compilation et le débogage
> - **Notion** - Pour la gestion de projet (sprint, tâche, journaux de travail)
> - **GitHub** - Pour la gestion des versions des fichiers
> - **MySQL Workbench** - Pour la modèlisation de la base de données et la création du script depuis le MLD
> - **VMware Workstation** - Pour la création d'une machine virtuelle tournant sur Debian 10 pour hébérger la base de données avec MySQL comme SGBD
> - **HeidiSQL** - Pour l'administration de la base de données (vue des données, ajout/suppression de données)

## 3.4 - Langugage, Framework, librairie