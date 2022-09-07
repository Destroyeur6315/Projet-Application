using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class ComposantPrincipale : Composant,  IEquatable<ComposantPrincipale>
    {
        /// <summary>
        /// le type du composant
        /// </summary>
        /// 
        [DataMember]
        public TypeDeComposantPrincipale TypeDeComposant { get; private set; }

        /// <summary>
        /// constructeur 
        /// </summary>
        /// <param name="designation">la désignation du produit</param>
        /// <param name="marque"> marque de ce produit</param>
        /// <param name="modele">le modele de ce produit</param>
        /// <param name="prix">le prix de ce produit</param>
        /// <param name="siteAchat">le site d'achat où l'on peut trouver ce produit</param>
        /// <param name="dateCreation">la date où le produit est mis sur le marché</param>
        /// <param name="typeDeComposant">le type du composant principale</param>
        /// <param name="dicoCaracPhysique">un dictionnaire qui contient toute les caractéristiques physiques du produit</param>
        /// <param name="dicoCarac">un dictionnaire qui contient toute les caractéristiques du produit</param>
        public ComposantPrincipale(string designation, string marque, string modele, float prix, string siteAchat, DateTime dateCreation, TypeDeComposantPrincipale typeDeComposant, Dictionary<CaracteristiquePhysique, int> dicoCaracPhysique, Dictionary<Caracteristique, string> dicoCarac, string image = null)
            : base(designation, marque, modele, prix, siteAchat, dateCreation, dicoCaracPhysique, dicoCarac, image)
        {
            TypeDeComposant = typeDeComposant;
        }

        public ComposantPrincipale()
            : base(null, null, null, 0, null, DateTime.Now, null, null, null)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"le type du composant principale est : {TypeDeComposant}\n";
        }

        /// <summary>
        /// Récrit le protocole d'égalité 
        /// </summary>
        /// <param name="other">Le composant que l'on veut comparer</param>
        /// <returns></returns>        
        public bool Equals(ComposantPrincipale other)
        {
            // Deux composants principaux sont identiques si ils ont en commun : le type de composant, la désignation, la marque et le modéle
            // Je pense que c'est suffisant (à voir entre nous)
            return TypeDeComposant.Equals(other.TypeDeComposant) && Designation.Equals(other.Designation) && Marque.Equals(other.Marque) && Modele.Equals(other.Modele);
        }

        /// <summary>
        /// Cette fonction est appelé lorsqu'on appelle la fonction : Equals
        /// </summary>
        /// <param name="obj">L'objet que l'on veut comparer</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // check null
            if(ReferenceEquals(obj, null)) return false;

            // check reference equality
            if (ReferenceEquals(obj, this)) return false;

            // check types (utile si héritage)
            if (GetType() != obj.GetType()) return false;

            // si toute les conditons ne sont pas valide : on utilse le Equals juste au dessus
            return Equals(obj as ComposantPrincipale);
        }

        // pas vraiment utile pour les listes (les dictionnaires utilisent le GetHashCode) 
        // mais conseillé de le récrire
        public override int GetHashCode()
        {
            return Marque.GetHashCode(); 
        }
    }
}
