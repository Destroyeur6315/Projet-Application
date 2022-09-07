using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class ComposantOptionnel : Composant, IEquatable<ComposantOptionnel>
    {
        /// <summary>
        /// le type du composant
        /// </summary>
        [DataMember]
        public TypeDeComposantOptionnel TypeDeComposant { get; private set; }

        /// <summary>
        /// constructeur 
        /// </summary>
        /// <param name="designation">la désignation du produit</param>
        /// <param name="marque"> marque de ce produit</param>
        /// <param name="modele">le modele de ce produit</param>
        /// <param name="prix">le prix de ce produit</param>
        /// <param name="siteAchat">le site d'achat où l'on peut trouver ce produit</param>
        /// <param name="dateCreation">la date où le produit est mis sur le marché</param>
        /// <param name="typeDeComposant">le type du composant optionnel </param>
        /// <param name="dicoCaracPhysique">un dictionnaire qui contient toute les caractéristiques physiques du produit</param>
        /// <param name="dicoCarac">un dictionnaire qui contient toute les caractéristiques du produit</param>
        public ComposantOptionnel(string designation, string marque, string modele, float prix, string siteAchat, DateTime dateCreation, TypeDeComposantOptionnel typeDeComposant, Dictionary<CaracteristiquePhysique, int> dicoCaracPhysique, Dictionary<Caracteristique, string> dicoCarac, string image = null)
            : base(designation, marque, modele, prix, siteAchat, dateCreation, dicoCaracPhysique, dicoCarac, image)
        {
            TypeDeComposant = typeDeComposant;
        }

        public override string ToString()
        {
            return base.ToString() + $"le type du composant optionnel est : {TypeDeComposant}\n";
        }

        /// <summary>
        /// Récrit le protocole d'égalité 
        /// </summary>
        /// <param name="other">Le composant que l'on veut comparer</param>
        /// <returns></returns>        
        public bool Equals(ComposantOptionnel other)
        {
            return TypeDeComposant.Equals(other.TypeDeComposant) && Designation.Equals(other.Designation) && Marque.Equals(other.Marque) && Modele.Equals(other.Modele);
        }

        /// <summary>
        /// Cette fonction est appelé lorsqu'on appelle la fonction : Equals
        /// </summary>
        /// <param name="obj">L'objet que l'on veut comparer</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return false;
            if (GetType() != obj.GetType()) return false;

            return Equals(obj as ComposantOptionnel);
        }

        public override int GetHashCode()
        {
            return Marque.GetHashCode();
        }
    }
}
