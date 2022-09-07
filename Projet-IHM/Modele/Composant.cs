using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class Composant : Produit
    {
        /// <summary>
        /// fonction qui permet de parcourir le dico avec une bonne encapsulation (que le lire avec foreach)
        /// </summary>
        
        [DataMember]
        public ReadOnlyDictionary<Caracteristique, string> LesCaracteristiques
        {
            get;
            private set;
        }

        /// <summary>
        /// dictionnaire qui contiendra toute les caractéristiques du produit
        /// </summary>
        /// 
        
        private Dictionary<Caracteristique, string> lesCaracteristiques = new Dictionary<Caracteristique, string>();

        [DataMember]
        public string ImagePath { get; private set; }

        /// <summary>
        /// Constructeur d'un composant
        /// </summary>
        /// <param name="designation">la désignation du produit</param>
        /// <param name="marque"> marque de ce produit</param>
        /// <param name="modele">le modele de ce produit</param>
        /// <param name="prix">le prix de ce produit</param>
        /// <param name="siteAchat">le site d'achat où l'on peut trouver ce produit</param>
        /// <param name="dateCreation">la date où le produit est mis sur le marché</param>
        /// <param name="dicoCaracPhysique">un dictionnaire qui contient toute les caractéristiques physiques du produit</param>
        /// <param name="dicoCarac">un dictionnaire qui contient toute les caractéristiques du produit</param>
        public Composant(string designation, string marque, string modele, float prix, string siteAchat, DateTime dateCreation, Dictionary<CaracteristiquePhysique, int> dicoCaracPhysique, Dictionary<Caracteristique, string> dicoCarac, string image)
            : base(designation, marque, modele, prix, siteAchat, dateCreation, dicoCaracPhysique)
         {
            LesCaracteristiques = new ReadOnlyDictionary<Caracteristique, string>(lesCaracteristiques);

            ImagePath = image;

            // permet d'ajouter les caractéristiques et les valeurs au dictionnaire
            if(dicoCarac != null) // gérer l'erreur lorsque le dico est null (lorsque le 2éme constructeur est appelé)
            {
                foreach (var item in dicoCarac)
                {
                    lesCaracteristiques[item.Key] = item.Value;
                }

            } 
         }

        public Composant()
            : base(null, null, null, 0, null, DateTime.Now, null)
        {
        }

        /// <summary>
        /// Affichage des attributs de la classe composant (utile pour verifier l'héritage)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
