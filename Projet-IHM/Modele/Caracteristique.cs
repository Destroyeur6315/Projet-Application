using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public enum Caracteristique
    {
        [EnumMember]
        Inconnu = 0,
        [EnumMember]
        Frequence = 1,
        [EnumMember]
        NbCoeur = 2,
        [EnumMember]
        Frequence_modeTurbo = 3,
        [EnumMember]
        Capacite = 4,
        [EnumMember]
        TypeDeMemoire = 5,
        [EnumMember]
        LedRGB = 6,
        [EnumMember]
        GoRam = 7,
        [EnumMember]
        Socket = 8,
        [EnumMember]
        Format = 9, 
        [EnumMember]
        Consommation = 10,
        [EnumMember]
        Slots = 11,
        [EnumMember]
        Puissance = 12,
        [EnumMember]
        Debit_transfert = 13,
        [EnumMember]
        Niveau_Sonore = 14,
        [EnumMember]
        Connectiques = 15,
        [EnumMember]
        VitesseRotation = 16,
        [EnumMember]
        TailleCache = 17,
        [EnumMember]
        VitesseEcriture = 18,
        [EnumMember]
        VitesseLecture = 19,
        [EnumMember]
        CNA = 20,
        [EnumMember]
        CAN = 21,
        [EnumMember]
        Bluetooth = 22,
    }
}
