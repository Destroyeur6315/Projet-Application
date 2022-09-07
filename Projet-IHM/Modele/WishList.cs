using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    /// <summary>
    /// représente la Wish list qui contiendra une config et des composants optionnels
    /// </summary>
    [DataContract]
    public class WishList : IEquatable<WishList>, IComparable<WishList>, IComparable
    {
        /// <summary>
        /// attribut static qui compte le nombre d'instances de cette classe
        /// </summary>
        //public static string NbObjet { get; set; } = 1;

        public string NbObjet = DateTime.Now.Ticks.ToString();
        

        /// <summary>
        /// Id d'une wihslist
        /// </summary>
        [DataMember]
        public string Id { get; private set; }

        /// <summary>
        /// nom de la WishList
        /// </summary>
        /// 
        [DataMember]
        public string Nom { get; private set; }

        /// <summary>
        /// une config qui contient tout les composants principaux
        /// </summary>
        /// 
        [DataMember]
        public Config Config { get; private set; }

        /// <summary>
        /// Permet d'encapsuler la list: permet de la parcourir pour l'afficher sans pouvoir la modifier
        /// </summary>
        ///

        [DataMember]

        public ReadOnlyCollection<ComposantOptionnel> ListComposantOptionnel
        {
            get;
            private set;
        }

        /// <summary>
        /// liste qui contient tout les composants optionnels
        /// </summary>
        private List<ComposantOptionnel> listComposantOptionnel = new List<ComposantOptionnel>();

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom de la WishList</param>
        /// <param name="config">une config qui contient tout les composants principaux</param>
        /// <param name="composantOptionnel"> tableau qui contiendra tout les composants optionnels à mettre dans la liste</param>
        public WishList(string nom, Config config, List<ComposantOptionnel> composantOptionnel)
        {
            Nom = nom;
            Config = config;
            ListComposantOptionnel = new ReadOnlyCollection<ComposantOptionnel>(listComposantOptionnel);
            listComposantOptionnel.AddRange(composantOptionnel);
            Id = NbObjet;
        }

        public WishList()
        {
            Id = NbObjet;
            Nom = "Config_" + Id;
            List<ComposantPrincipale> tmp = new List<ComposantPrincipale>();
            Config = new Config(tmp);
            ListComposantOptionnel = new ReadOnlyCollection<ComposantOptionnel>(listComposantOptionnel);
        }

        public override string ToString()
        {
            return $"Le nom de la config est : {Nom}";
        }

        public bool Equals(WishList other)
        {
            // deux whisList sont identiques si elles ont le même nom
            return Nom.Equals(other.Nom);
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false; // erreur içi

            return Equals(obj as WishList);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }

        public int CompareTo(WishList other)
        {
            return Id.CompareTo(other.Id);
        }

        int IComparable.CompareTo(object obj)
        {
            if (!(obj is WishList))
            {
                throw new ArgumentException("Argument is not a WishList");
            }
            WishList other = obj as WishList;
            return this.CompareTo(other);
        }

        public static bool operator <(WishList left, WishList right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(WishList left, WishList right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(WishList left, WishList right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(WishList left, WishList right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
