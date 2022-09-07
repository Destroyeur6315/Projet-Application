using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Specialized;

namespace Modele
{
    public class Manager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Composant ComposantAdmin { get; set; }

        public Dictionary<Caracteristique, string> Dicocarac
        {
            get => dicocarac;
            set
            {
                if(dicocarac != value)
                {
                    dicocarac = value;
                    OnPropertyChanged(nameof(Dicocarac));
                }
            }
        }
        private Dictionary<Caracteristique, string> dicocarac = new Dictionary<Caracteristique, string>();

        public KeyValuePair<Caracteristique, string> CaracteristiqueSelectionne
        {
            get => caracteristiqueSelectionne;
            set
            {
                if(caracteristiqueSelectionne.Key != value.Key)
                {
                    caracteristiqueSelectionne = value;
                    OnPropertyChanged(nameof(CaracteristiqueSelectionne));
                }
            }
        }
        private KeyValuePair<Caracteristique, string> caracteristiqueSelectionne;

        public string Nom
        {
            get => nom;
            set
            {
                if(nom != value)
                {
                    nom = value;
                    OnPropertyChanged(nameof(Nom));
                }
            }
        }
        private string nom;


        public Array MyEnumArray
        {
            get => myEnumArray;
            set
            {
                if (myEnumArray != value)
                {
                    myEnumArray = value;
                    OnPropertyChanged(nameof(MyEnumArray));
                }
            }
        }
        private Array myEnumArray;

        public string Str
        {
            get => str;
            set
            {
                if(str != value)
                {
                    str= value;
                    OnPropertyChanged(nameof(Str));
                }
            }
        }
        private string str;


        public IReadOnlyDictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> ComposantPrincipaux
        {
            get;
            private set;
        }
        /// <summary>
        /// Dictionnaire de composant Principaux
        /// </summary>
        private Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> composantPrincipaux = new Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>>();


        public ReadOnlyCollection<ComposantOptionnel> ComposantOptionnel
        {
            get;
            private set;
        }
        /// <summary>
        /// Liste qui contiendra l'ensemble des composants optionnels
        /// </summary>
        private List<ComposantOptionnel> composantOptionnels = new List<ComposantOptionnel>();


        /// <summary>
        /// Dépendance vers le gestionnaire de Persistance/base de données
        /// </summary>
        public IdbManager DataBase { get; set; }


        /// <summary>
        /// Permet d'encapsuler la liste
        /// </summary>
        public List<WishList> ListDesFavoris
        {
            get => listDesFavoris;
            set
            {
                if (listDesFavoris != value)
                {
                    listDesFavoris = value;
                    OnPropertyChanged(nameof(ListDesFavoris));
                }
                else
                {
                    listDesFavoris = value;
                }
            }
        }
        /// <summary>
        /// liste des favori : contient toutes les wishlists mis en favori
        /// </summary>
        private List<WishList> listDesFavoris;


        /// <summary>
        /// Composant que l'utilisateur sélectionne pour voir les caractéristiques et l'ajouter si il le souhaite
        /// </summary>
        public Composant ComposantSelectionne
        {
            get => composantSelectionnee;
            set
            {
                if(composantSelectionnee != value)
                {
                    composantSelectionnee = value;
                    OnPropertyChanged(nameof(ComposantSelectionne));
                }
            }
        }
        private Composant composantSelectionnee;

        /// <summary>
        /// Nom de la wishlist dont on veut modifier le nom
        /// </summary>
        public string NomWishlistAmodifier;
           

        /// <summary>
        /// Liste qui contient les composants à afficher 
        /// </summary>
        public List<Composant> CompoAffiche
        {
            get => compoAffiche;
            set
            {
                if (compoAffiche != value)
                {
                    compoAffiche = value;
                    OnPropertyChanged(nameof(compoAffiche));
                }
            }
        }
        private List<Composant> compoAffiche  = new List<Composant>();


        public WishList Listecourante
        {
            get => listecourante;
            set
            {
                if (listecourante != value)
                {
                    listecourante = value;
                    OnPropertyChanged(nameof(Listecourante));
                }
            }
        }
        /// <summary>
        /// Liste que l'utilisateur peut modifier
        /// </summary>
        public WishList listecourante;


        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        /// <summary>
        /// Constructeur d'un manageur
        /// </summary>
        /// <param name="dataBase">le manager qui gère la persistance</param>
        public Manager(IdbManager dataBase)
        {
            DataBase = dataBase;

            ComposantPrincipaux = new ReadOnlyDictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>>(composantPrincipaux);

            ComposantOptionnel = new ReadOnlyCollection<ComposantOptionnel>(composantOptionnels);

            listecourante = new WishList();

            listDesFavoris = new List<WishList>();
        }


        /// <summary>
        /// Fonction qui sauvegarde les donnee des composant principaux dans un fichier (délégué au gestionnnaire de persistance)
        /// </summary>
        public void SauvegardeDonneeComposant()
        {
            DataBase.SauvegardeDonneeComposant(composantPrincipaux, ListDesFavoris, composantOptionnels);
        }

        /// <summary>
        /// Fonction qui récupère les données des composant principaux dans un fichier (délégué au gestionnnaire de persistance)
        /// </summary>
        public void ChargeDonneesComposant()
        {
            var data = DataBase.ChargeDonneesComposant();

            foreach (KeyValuePair<TypeDeComposantPrincipale, List<ComposantPrincipale>> kvp in data.CompoPrincRetrieve)
            {
                composantPrincipaux[kvp.Key] = new List<ComposantPrincipale>();
                composantPrincipaux[kvp.Key].AddRange(kvp.Value);
            }


            ComposantPrincipaux = new ReadOnlyDictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>>(composantPrincipaux);

            if(data.CompoOptRetrieve != null)
            {
                composantOptionnels.AddRange(data.CompoOptRetrieve);

            }

            if (data.WishListRetrieve != null)
            {
                ListDesFavoris.AddRange(data.WishListRetrieve);
            }

        }


        /// <summary>
        /// Fonction qui vérifie si un composant principale est déja dans la liste courante : si oui, retourne false, sinon true
        /// </summary>
        /// <param name="typecomposant">le type de composant que l'on cherche a trouver</param>
        /// <returns></returns>
        public bool verifComposantExistant(TypeDeComposantPrincipale typecomposant)
        {
            if (typecomposant == TypeDeComposantPrincipale.Inconnu) return false;

            //utilisation d'une requète LINQ pour trouver si un type de composant se trouve dans la config
            var composant = listecourante.Config.ListComposants.Where(c => c.TypeDeComposant == typecomposant);

            if (composant.Any()) return true;

            return false;
        }


        /// <summary>;
        /// Fonction qui gère la compatibilité des cartes mère avec un composant passé en paramètre (retourne un booléen : si le type de composant n'existe pas dans la liste courante
        /// retourne false, sinon true
        /// </summary>
        /// <param name="typecomposant">Le type de composant dont on veut vérifier la compatibilité</param>
        /// <param name="carac">La caractéristique qui doit être en commun entre le composant et la carte mère</param>
        /// <param name="CarteMerefinal">Liste qui contiendra tout les composants qui sont compatible avec la carte mère de la config</param>
        /// <param name="configSansCompatibilite">Booléen qui permet de savoir si le type de composant recherché existe dans la liste courante</param>
        /// <returns></returns>
        public bool CompatibilitePourCarteMere(TypeDeComposantPrincipale typecomposant, Caracteristique carac, List<ComposantPrincipale> CarteMerefinal, bool configSansCompatibilite)
        {
            IEnumerable<ComposantPrincipale> composant = Listecourante.Config.ListComposants.Where(p => p.TypeDeComposant == typecomposant);
            if (composant.Any())
            {
                ComposantPrincipale premierComposant = composant.First();
                IEnumerable<ComposantPrincipale> CarteMere = ComposantPrincipaux[TypeDeComposantPrincipale.Carte_mere].Where(Cm => Cm.LesCaracteristiques[carac] == premierComposant.LesCaracteristiques[carac]);

                List<ComposantPrincipale> CarteMereTemporelle = new List<ComposantPrincipale>();

                if (configSansCompatibilite)
                {
                    CarteMerefinal.AddRange(CarteMere);
                }
                else
                {
                    foreach (ComposantPrincipale compo in CarteMerefinal)
                    {
                        if (CarteMere.Contains(compo))
                        {
                            CarteMereTemporelle.Add(compo);
                        }
                    }
                    CarteMerefinal.Clear();
                    CarteMerefinal.AddRange(CarteMereTemporelle);
                }

                configSansCompatibilite = false;
            }

            return configSansCompatibilite;
        }


        /// <summary>
        /// Fonctionq qui gère la compatibililté entre un type de composant passé en paramètre et la carte mère de la liste courante
        /// </summary>
        /// <param name="typecomposant">Le type de composant dont on doit gérer la compatibilité avec la carte mère</param>
        /// <param name="carac">La caractéristique qui doit être en commun entre le type de composant recherché et la carte mère</param>
        public void CompatibiliteComposantVersCarteMere(TypeDeComposantPrincipale typecomposant, Caracteristique carac)
        {
            List<Composant> CompoAfficheTmp = new List<Composant>();

            IEnumerable<ComposantPrincipale> composant = Listecourante.Config.ListComposants.Where(p => p.TypeDeComposant == TypeDeComposantPrincipale.Carte_mere);
            if (composant.Any())
            {
                ComposantPrincipale premierCompo = composant.First();
                IEnumerable<ComposantPrincipale> compo = ComposantPrincipaux[typecomposant].Where(Cm => Cm.LesCaracteristiques[carac] == premierCompo.LesCaracteristiques[carac]);

                CompoAfficheTmp.AddRange(compo);
                compoAffiche = CompoAfficheTmp;
            }
            else
            {
                CompoAfficheTmp.AddRange(ComposantPrincipaux[typecomposant]);
                compoAffiche = CompoAfficheTmp;
            }
        }


        /// <summary>
        /// Fontion qui gère toutes les compatibilités entre les différents composants de la liste courante 
        /// </summary>
        /// <param name="TypeCompo">Type de composant dont on veut faire la compatibilité</param>
        public void Compatibilite(TypeDeComposantPrincipale TypeCompo)
        {
            compoAffiche = new List<Composant>();
            List<Composant> CompoAfficheTmp = new List<Composant>();

            if (Listecourante.Config.ListComposants.Count != 0)
            {
                switch (TypeCompo)
                {
                    case TypeDeComposantPrincipale.Carte_mere: //compatibilité lors du choix de la carte mère

                        // vrai si il n'y a aucun composant dans la liste courante qui doit avoir une compatibilité avec la carte mère
                        bool configSansCompatibilite = true;

                        // liste qui contiendra l'ensemble des cartes mères compatibles avec les composants de la liste courante
                        List<ComposantPrincipale> CarteMerefinal = new List<ComposantPrincipale>();
                        
                        // compatibilité entre carte mère et processeur
                        configSansCompatibilite = CompatibilitePourCarteMere(TypeDeComposantPrincipale.Processeur, Caracteristique.Socket, CarteMerefinal, configSansCompatibilite);

                        // compatibilité entre carte mère et mémoire vive
                        configSansCompatibilite = CompatibilitePourCarteMere(TypeDeComposantPrincipale.Memoire_vive, Caracteristique.TypeDeMemoire, CarteMerefinal, configSansCompatibilite);

                        // compatibilité entre carte mère et carte graphique
                        configSansCompatibilite = CompatibilitePourCarteMere(TypeDeComposantPrincipale.Carte_graphique, Caracteristique.Slots, CarteMerefinal, configSansCompatibilite);

                        // compatibilité entre carte mère et boitier
                        configSansCompatibilite = CompatibilitePourCarteMere(TypeDeComposantPrincipale.Boitier, Caracteristique.Format, CarteMerefinal, configSansCompatibilite);

                        if (configSansCompatibilite)
                        {
                            // aucune compatibilité à faire donc affiche toute les cartes mères
                            CompoAfficheTmp.AddRange(ComposantPrincipaux[TypeCompo]);
                            compoAffiche = CompoAfficheTmp;
                        }
                        else
                        {
                            // une ou plusieurs compatibilités à faire : affiche donc que les cartes mères compatibles
                            CompoAfficheTmp.AddRange(CarteMerefinal);
                            compoAffiche = CompoAfficheTmp;
                        }

                        break;

                    case TypeDeComposantPrincipale.Memoire_vive: //compatibilité lors du choix de la mémoire vive

                        CompatibiliteComposantVersCarteMere(TypeDeComposantPrincipale.Memoire_vive, Caracteristique.TypeDeMemoire);
                        break;

                    case TypeDeComposantPrincipale.Processeur: //compatibilité lors du choix du processeur

                        CompatibiliteComposantVersCarteMere(TypeDeComposantPrincipale.Processeur, Caracteristique.Socket);
                        break;

                    case TypeDeComposantPrincipale.Carte_graphique: //compatibilité lors du choix de la Carte graphique

                        CompatibiliteComposantVersCarteMere(TypeDeComposantPrincipale.Carte_graphique, Caracteristique.Slots);
                        break;

                    case TypeDeComposantPrincipale.Boitier: //compatibilité lors du choix du boitier

                        CompatibiliteComposantVersCarteMere(TypeDeComposantPrincipale.Boitier, Caracteristique.Format);
                        break;

                    case TypeDeComposantPrincipale.Alimentation: //compatibilité lors du choix de l'alimentation

                        // contiens la valeur de la caractéristique consommation
                        string consommation;

                        // le total de la consommation de la config 
                        int totalConsommation = 0;

                        // booléen pour savoir si la config possède des composants utilisant l'alimentation
                        bool configSansConsommation = true;

                        // calculer la consommation totale de la config
                        foreach (ComposantPrincipale compo in listecourante.Config.ListComposants)
                        {
                            if (compo.LesCaracteristiques.ContainsKey(Caracteristique.Consommation))
                            {
                                consommation = compo.LesCaracteristiques[Caracteristique.Consommation];

                                // transforme la consommation : string en int pour pouvoir l'additionner
                                int nb = transformerStringEnInt(consommation);

                                totalConsommation += nb;
                                configSansConsommation = false;

                            }
                        }

                        if (configSansConsommation)
                        {
                            CompoAfficheTmp.AddRange(ComposantPrincipaux[TypeCompo]);
                            compoAffiche = CompoAfficheTmp;
                            break;
                        }

                        IEnumerable<ComposantPrincipale> alimentation = ComposantPrincipaux[TypeDeComposantPrincipale.Alimentation];

                        foreach (ComposantPrincipale aliment in alimentation)
                        {
                            consommation = aliment.LesCaracteristiques[Caracteristique.Puissance];

                            // transforme la puissance de l'alimentation: string -> int 
                            int nb = transformerStringEnInt(consommation);

                            // si la capacité de l'alimentation est plus grande que la somme des consommations de la config, on la rajoute dans la liste à afficher
                            if (totalConsommation <= nb)
                            {
                                CompoAfficheTmp.Add(aliment);
                            }
                            compoAffiche = CompoAfficheTmp;
                        }

                        break;

                    default:
                        CompoAfficheTmp.AddRange(ComposantPrincipaux[TypeCompo]);
                        compoAffiche = CompoAfficheTmp;
                        break;
                }

                return;
            }


            CompoAfficheTmp.AddRange(ComposantPrincipaux[TypeCompo]);
            compoAffiche = CompoAfficheTmp;
        }




        /// <summary>
        /// Transforme le string passé en paramètre en int
        /// </summary>
        /// <param name="consommation"></param>
        /// <returns></returns>
        public int transformerStringEnInt(string consommation)
        {
            int nb = 0;
            int tailleMot = consommation.Length;

            foreach (char str in consommation)
            {
                switch (str)
                {
                    case '0':
                        break;
                    case '1':
                        nb += (int)(1 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '2':
                        nb += (int)(2 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '3':
                        nb += (int)(3 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '4':
                        nb += (int)(4 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '5':
                        nb += (int)(5 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '6':
                        nb += (int)(6 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '7':
                        nb += (int)(7 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '8':
                        nb += (int)(8 * Math.Pow(10, tailleMot - 1));

                        break;

                    case '9':
                        nb += (int)(9 * Math.Pow(10, tailleMot - 1));

                        break;

                    default:
                        Console.WriteLine("echec");

                        break;
                }

                tailleMot--;

            }

            return nb;
        }


      


        /// <summary>
        /// Fonction qui change le nom d'une wishList en favoris 
        /// (en crée une nouvelle, identique à l'ancienne, avec le nouveau nom et l'ajoute dans les Favoris, l'ancienne est supprimée des favoris)
        /// </summary>
        /// <param name="ancienNom">Le nom de la WishList à modifier</param>
        /// <param name="nouveauNom">Le nouveau nom de la WishList</param>
        /// <returns></returns>
        public bool ChangeWishListName(string ancienNom, string nouveauNom)
        {
            // check si les paramètres sont null
            if (ancienNom == null || nouveauNom == null) return false;

            if (listDesFavoris.Count <= 0) return false;

            // Si le nouveau nom existe déjà, il n'y a pas de renommage
            // (2 wishlist sont égales si elles ont le même nom : il ne faut pas de doublon dans les favoris)
            foreach (var liste in ListDesFavoris)
            {
                if (liste.Nom == nouveauNom) return false;
            }

            foreach (var liste in ListDesFavoris)
            {
                if (liste.Nom == ancienNom)
                {
                    // supprime la wishlist qu'on veut modifier le nom
                    if (! listDesFavoris.Remove(liste)) return false;

                    List<ComposantPrincipale> tmpListe = new List<ComposantPrincipale>();
                    tmpListe.AddRange(liste.Config.ListComposants);
                    Config tmpConfig = new Config(tmpListe);
                    List<ComposantOptionnel> tmpListeOptionnel = new List<ComposantOptionnel>();
                    tmpListeOptionnel.AddRange(liste.ListComposantOptionnel);

                    // wishlist et liste de wishlist temporelle
                    WishList newWishList = new WishList(nouveauNom, tmpConfig, tmpListeOptionnel);
                    List<WishList> listetemporelle = new List<WishList>();

                    listetemporelle.AddRange(listDesFavoris);
                    listetemporelle.Add(newWishList);

                    ListDesFavoris = listetemporelle;

                    SauvegardeDonneeComposant();

                    return true;

                }
            }
            return false;
        }

        /// <summary>
        /// Fonction qui ajoute un composant principal a la liste courante
        /// </summary>
        /// <param name="composantToAdd">le composant a ajouter</param>
        /// <returns></returns>
        public bool AddComposantPrincipal(ComposantPrincipale composantToAdd)
        {
            // check for bugs (voir pour les returns)
            if (composantToAdd == null) return false;

            List<ComposantPrincipale> tmp = new List<ComposantPrincipale>();
            tmp.AddRange(Listecourante.Config.ListComposants);

            // Vérifie si le composant à ajouter n'est pas déjà dans la liste
            if (tmp.Contains(composantToAdd)) return false;

            // ajoute le nouveau composant dans la liste temporaire
            tmp.Add(composantToAdd);

            Config newconfig = new Config(tmp);


            List<ComposantOptionnel> composantOptionnel = new List<ComposantOptionnel>();
            composantOptionnel.AddRange(Listecourante.ListComposantOptionnel);

            WishList newWishList = new(Listecourante.Nom, newconfig, composantOptionnel);

            Listecourante = newWishList;

            return true;
        }

        /// <summary>
        /// Fonction qui ajoute un composant optinnel à la liste courante
        /// </summary>
        /// <param name="composoantToAdd"></param>
        /// <returns></returns>
        public bool AddComposantOptionnel(ComposantOptionnel composoantToAdd)
        {
            if (composoantToAdd == null) return false;

            List<ComposantOptionnel> tmpOptionnel = new List<ComposantOptionnel>();
            tmpOptionnel.AddRange(Listecourante.ListComposantOptionnel);

            // regarde si le composant à ajouter est déjà dans la liste des composants optionnels
            if (tmpOptionnel.Contains(composoantToAdd)) return false;

            List<ComposantPrincipale> tmpPrincipale = new List<ComposantPrincipale>();

            // ajoute les composants de l'ancienne config dans une liste temporaire
            tmpPrincipale.AddRange(Listecourante.Config.ListComposants);

            Config newconfig = new Config(tmpPrincipale);

            tmpOptionnel.Add(composoantToAdd);

            WishList newWishList = new WishList(Listecourante.Nom, newconfig, tmpOptionnel);

            Listecourante = newWishList;

            return true;
        }


        /// <summary>
        /// Fonction supprime un composant principale à la liste courante
        /// </summary>
        /// <param name="composantToDelete">Le composant a enlever</param>
        /// <returns></returns>
        public bool DeleteComposantPrinicpal(ComposantPrincipale composantToDelete)
        {
            if (composantToDelete == null) return false;

            List<ComposantPrincipale> tmp = new List<ComposantPrincipale>();

            // ajoute les composants de l'ancienne config dans une liste temporaire
            tmp.AddRange(Listecourante.Config.ListComposants);

            if (!tmp.Contains(composantToDelete)) return false;

            tmp.Remove(composantToDelete);

            Config newconfig = new Config(tmp);

            List<ComposantOptionnel> composantOptionnel = new List<ComposantOptionnel>();

            composantOptionnel.AddRange(Listecourante.ListComposantOptionnel);

            WishList newWishList = new WishList(Listecourante.Nom, newconfig, composantOptionnel);

            Listecourante = newWishList;

            return true;
        }

        /// <summary>
        /// Fonction supprime un composant optionnel de la liste courante
        /// </summary>
        /// <param name="composantToDelete">le commposant optionnel à supprimer</param>
        /// <returns></returns>
        public bool DeleteComposantOptionnel(ComposantOptionnel composantToDelete)
        {
            if (composantToDelete == null) return false;

            List<ComposantOptionnel> tmpOptionnel = new List<ComposantOptionnel>();

            tmpOptionnel.AddRange(Listecourante.ListComposantOptionnel);

            // vérifie si le composant a supprimer n'est pas dans la liste courante
            if (!tmpOptionnel.Contains(composantToDelete)) return false;
            tmpOptionnel.Remove(composantToDelete);

            List<ComposantPrincipale> tmp = new List<ComposantPrincipale>();
            tmp.AddRange(Listecourante.Config.ListComposants);

            Config newconfig = new Config(tmp);

            WishList newWishList = new WishList(Listecourante.Nom, newconfig, tmpOptionnel);

            Listecourante = newWishList;

            return true;
        }

        /// <summary>
        /// Fonction qui ajoute la liste courante au favori (clean la liste courante après)
        /// </summary>
        /// <returns></returns>
        public bool AddUneListeAuxFavoris()
        {
            // check null
            if (Listecourante == null) return false;

            // le test ne marche pas ! à debug
            if ((Listecourante.Config.ListComposants.Count == 0) && (Listecourante.ListComposantOptionnel.Count == 0)) return false;

            List<ComposantPrincipale> listeprincipale = new List<ComposantPrincipale>();

            if (listDesFavoris.Count != 0)
            {
                // check in listFavoris if the list is already inside
                foreach (var liste in listDesFavoris)
                {
                    if (liste.Equals(Listecourante)) 
                    {
                        listDesFavoris.Remove(liste);
                        break;
                    }
                }
            }

            List<WishList> listetemporelle = new List<WishList>();
            listetemporelle.AddRange(listDesFavoris);
            listetemporelle.Add(Listecourante);

            ListDesFavoris = listetemporelle;
            Listecourante = new WishList(); 

            SauvegardeDonneeComposant();

            return true;
        }

        /// <summary>
        /// Fonction qui supprime une wishList des favoris
        /// </summary>
        /// <param name="nomListeToDelete">Nom de la wishlist à supprimer</param>
        /// <returns></returns>
        public bool DeleteUneListeDesFavoris(string nomListeToDelete)
        {
            // check null
            if (nomListeToDelete == null) return false;

            List<WishList> listetemporelle2 = new List<WishList>();
            listetemporelle2.AddRange(listDesFavoris);

            foreach (var i in listetemporelle2)
            {
                if (i.Nom == nomListeToDelete)
                {
                    listetemporelle2.Remove(i);
                    break;
                }
            }

            ListDesFavoris = listetemporelle2;

            SauvegardeDonneeComposant();

            return false;
        }

        /// <summary>
        /// Fonction qui met une liste des favoris en liste courante pour pouvoir la modifier  
        /// </summary>
        /// <param name="nom">Nom de la liste que l'on veut modifier</param>
        public bool ModifierUnelisteDesfavoris(string nom)
        {
            if (nom == null) return false;

            foreach (var liste in ListDesFavoris)
            {
                if (liste.Nom == nom)
                {
                    List<ComposantPrincipale> composantPrincipale = new List<ComposantPrincipale>();
                    composantPrincipale.AddRange(liste.Config.ListComposants);

                    Config tmpConfig = new Config(composantPrincipale);

                    List<ComposantOptionnel> composantOptionnels = new List<ComposantOptionnel>();
                    composantOptionnels.AddRange(liste.ListComposantOptionnel);

                    Listecourante = new WishList(liste.Nom, tmpConfig, composantOptionnels);
                    return true;
                }
            }

            return false;
        }
    }
}
