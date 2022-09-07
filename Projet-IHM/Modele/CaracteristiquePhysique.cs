using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public enum CaracteristiquePhysique
    {
        [EnumMember]
        Aucune = 0,
        [EnumMember]
        Largeur = 1,
        [EnumMember]
        Hauteur = 2,
        [EnumMember]
        Longueur = 3,
        [EnumMember]
        Poids = 4,
        [EnumMember]
        Connectiques = 5,
    }
}
