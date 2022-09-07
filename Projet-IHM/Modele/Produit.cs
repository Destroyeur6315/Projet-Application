using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modele
{
    /// <summary>
    /// représente un Produit 
    /// </summary>
    /// 

    [DataContract]
    public class Produit
    {
        /// <summary>
        /// la désignation du produit
        /// </summary>
        /// 
        [DataMember]
        public string Designation { get; protected set; }

        /// <summary>
        /// la marque de ce produit
        /// </summary>
        /// 
        [DataMember]
        public string Marque { get; protected set; }

        /// <summary>
        /// le prix de ce produit
        /// </summary>
        /// 
        [DataMember]
        public float Prix { get; protected set; } // à voir si on le met ?

        /// <summary>
        /// le modele de ce produit
        /// </summary>
        /// 
        [DataMember]
        public string Modele { get; protected set; }

        /// <summary>
        /// le site d'achat où l'on peut trouver ce produit
        /// </summary>
        /// 
        [DataMember]
        public string SiteAchat { get; protected set; }

        /// <summary>
        /// la date où le produit est mis sur le marché
        /// </summary>
        /// 
        [DataMember]
        public DateTime DateCreation { get; protected set; }

        /// <summary>
        /// fonction qui permet de parcourir le dico (avec foreach par ex) des caractéristique sans pouvoir modifier les données (bonne encapsulation)
        /// </summary>
        [DataMember]
        public ReadOnlyDictionary<CaracteristiquePhysique, int> LesCaracteristiquesPhysiques
        {
            get;
            protected set;
        }

        /// <summary>
        /// dictionnaire qui contiendra toute les caractéristiques physiques du produit
        /// </summary>
        /// 
        protected Dictionary<CaracteristiquePhysique, int> lesCaracteristiquesPhysiques = new Dictionary<CaracteristiquePhysique, int>();

        /// <summary>
        /// constructeur 
        /// </summary
        /// <param name="designation">la désignation du produit</param>
        /// <param name="marque"> marque de ce produit</param>
        /// <param name="modele">le modele de ce produit</param>
        /// <param name="prix">le prix de ce produit</param>
        /// <param name="siteAchat">le site d'achat où l'on peut trouver ce produit</param>
        /// <param name="dateCreation">la date où le produit est mis sur le marché</param>
        /// <param name="dico">un dictionnaire qui contient toute les caractéristique physiques du produit</param>
        public Produit(string designation, string marque, string modele, float prix, string siteAchat, DateTime dateCreation, Dictionary<CaracteristiquePhysique, int> dico)
        {
            Designation = designation;
            Marque = marque;
            Prix = prix;
            Modele = modele;
            SiteAchat = siteAchat;
            DateCreation = dateCreation;
            LesCaracteristiquesPhysiques = new ReadOnlyDictionary<CaracteristiquePhysique, int>(lesCaracteristiquesPhysiques);
            
            // permet d'ajouter les caractéristiques physiques et les valeurs au dictionnaire
            if(dico != null) // gérer l'erreur lorsque le dico est null (lorsque le 2éme constructeur est appelé)
            {
                foreach (var item in dico)
                {
                    // check negatifs numbers
                    if(item.Value < 0) lesCaracteristiquesPhysiques[item.Key] = 0;

                    lesCaracteristiquesPhysiques[item.Key] = item.Value;
                }

            } 
            
        }

        /// <summary>
        /// autre constructeur sans le siet d'achat et sans la date de Création et sans aucune caractéristique (dico = null)
        /// </summary>
        /// <param name="designation">la désignation du produit</param>
        /// <param name="marque"> marque de ce produit</param>
        /// <param name="modele">le modele de ce produit</param>
        /// <param name="prix">le prix de ce produit</param
        public Produit(string designation, string marque, string modele, float prix)
            : this(designation, marque, modele, prix, null, DateTime.Now, null)
        {
        }

        public override string ToString()
        {
            string dateAchat = string.IsNullOrWhiteSpace(SiteAchat) ? "" : $"{SiteAchat}";
            return $"la designation : {Designation} \nle modele : {Modele} \nle prix : {Prix} \nla marque : {Marque} \nle site d'achat : {SiteAchat} \nla date de création : {DateCreation}\n";
        }

    }
}
