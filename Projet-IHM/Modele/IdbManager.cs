using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public interface IdbManager
    {
        /// <summary>
        /// Fonction qui sauvegarde les composants principaux dans un fichier 
        /// </summary>
        /// <param name="listComposants"></param>
        void SauvegardeDonneeComposant(Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> composantPrincipaux, List<WishList> WishListASave, List<ComposantOptionnel> CompoOptASave);


        /// <summary>
        /// Fonction qui récupère les composants principaux enregistrés dans un fichier 
        /// </summary>
        /// <param name="listComposants"></param>
        (Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> CompoPrincRetrieve, List<WishList> WishListRetrieve, List<ComposantOptionnel> CompoOptRetrieve) ChargeDonneesComposant();


    }
}
