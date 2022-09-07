using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using Modele;

namespace Persistance
{
    /// <summary>
    /// Clase qui implémente les fonction de sauvegarde et de charge de données de l'interface IdbManager en travaillant avec du XML
    /// </summary>
    public class DataContractPersistance : IdbManager
    {
        /// <summary>
        /// Chemin relatif vers le fichier de sauvegarde
        /// </summary>
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        /// <summary>
        /// Désignation  du fichiers de sauvegarde
        /// </summary>
        public string FileNameP { get; set; } = "db.xml";


        /// <summary>
        /// Chemin relatif vers le fichier de sauvegarde
        /// </summary>
        public string FilePathOpt { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        /// <summary>
        /// Désignation  du fichiers de sauvegarde
        /// </summary>
        public string FileNameOpt { get; set; } = "opt.xml";



        /// <summary>
        /// Fonction qui sauvegarde les données dans le fichier
        /// </summary>
        /// <param name="composant"></param>
        public void SauvegardeDonneeComposant(Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> composantPrincipaux, List<WishList> WishListASave, List<ComposantOptionnel> CompoOptASave)
        {

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();

            data.CompoOpt.AddRange(CompoOptASave);
            data.Wishlist.AddRange(WishListASave);

            foreach (KeyValuePair<TypeDeComposantPrincipale, List<ComposantPrincipale>> kvp in composantPrincipaux)
            {
                data.CompoPrinc[kvp.Key] = new List<ComposantPrincipale>();
                data.CompoPrinc[kvp.Key].AddRange(kvp.Value);
            }

            Trace.WriteLine(data.CompoOpt.First());

            var serializer = new DataContractSerializer(typeof(DataToPersist), new DataContractSerializerSettings() { PreserveObjectReferences = true });

            using (Stream s = File.Create(Path.Combine(FilePath, FileNameP)))
            {
                serializer.WriteObject(s, data);
            }

        }



        /// <summary>
        /// Fonction qui récupère les données dans le fichier
        /// </summary>
        /// <param name="composant"></param>
        public (Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> CompoPrincRetrieve, List<WishList> WishListRetrieve, List<ComposantOptionnel> CompoOptRetrieve)  ChargeDonneesComposant()
        {
            if (!File.Exists(Path.Combine(FilePath, FileNameP)))
            {
                throw new FileNotFoundException("Le fichier renseigné n'existe pas");
            }

            var serializer = new DataContractSerializer(typeof(DataToPersist));

            DataToPersist data;

            using (Stream s = File.OpenRead(Path.Combine(FilePath, FileNameP)))
            {
                data = serializer.ReadObject(s) as DataToPersist;
            }

            return (data.CompoPrinc, data.Wishlist, data.CompoOpt);
        }
    }
}
