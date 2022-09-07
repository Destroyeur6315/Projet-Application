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
    /// représente une config qui contient une liste de Composants principaux
    /// </summary>
    /// 
    [DataContract]
    public class Config
    {
        /// <summary>
        /// Permet d'encapsuler la list: permet de la parcourir pour l'afficher sans pouvoir la modifier
        /// </summary>
        [DataMember]
        public ReadOnlyCollection<ComposantPrincipale> ListComposants
        {
            get;
            private set;
        }
        /// <summary>
        /// liste qui contiendra tout les composants principaux 
        /// </summary>
        private List<ComposantPrincipale> listComposants = new List<ComposantPrincipale>();

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">le nom de la config</param>
        /// <param name="composant">tout les composants principaux à mettre dans la liste</param>
        public Config(List<ComposantPrincipale> composant)
        { 
            listComposants.AddRange(composant);
            ListComposants = new ReadOnlyCollection<ComposantPrincipale>(listComposants);
        }

        public override string ToString()
        {
            return "test";
        }
    }
}
