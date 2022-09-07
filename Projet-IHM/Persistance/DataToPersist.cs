using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    [DataContract]
    class DataToPersist
    {
        [DataMember]
        public Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>> CompoPrinc { get; set; } = new Dictionary<TypeDeComposantPrincipale, List<ComposantPrincipale>>();
        [DataMember]
        public List<WishList> Wishlist { get; set; } = new List<WishList>();
        [DataMember]
        public List<ComposantOptionnel> CompoOpt { get; set; } = new List<ComposantOptionnel>();
    }
}
