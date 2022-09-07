using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_IHM.FragmentDePage
{
    /// <summary>
    /// Logique d'interaction pour UC_GuideInstallation.xaml
    /// </summary>
    public partial class UC_GuideInstallation : UserControl
    {
        public UC_GuideInstallation()
        {
            InitializeComponent();
            Etape1.TexteEtape.Text = "Pour commencer, il faut monter le processeur dans la carte mère. Pour cela, décochez et soulevez la petite tige en fer à côté du processeur et passez-là de l’autre côté pour pouvoir ouvrir la protection.Placez ensuite le processeur dans l’emplacement réservé et refermez le cache en rabattant la tige en fer à sa position d’origine.Vous pouvez forcer un peu et la protection noire devrait s’enlever.";
            Etape1.NomEtape.Text = "Etape 1 : Monter le processeur dans la carte mère";

            Etape2.TexteEtape.Text = "Une fois le processeur en place, vous allez devoir placer le ventirad. La méthode de fixement peut varier d’un ventirad à un autre, il peut y avoir un support à viser ou il est parfois possible de le clipser. Un manuel contenant des schémas étape par étape vous sera fourni avec le ventirad, le mieux est de le suivre à la lettre. Faîte simplement attention au socket de votre processeur car souvent, le manuel du ventirad peut comporter plusieurs schémas dépendant du socket de votre processeur.";
            Etape2.NomEtape.Text = "Etape 2 : Placer le ventirad";

            Etape3.TexteEtape.Text = "Nous allons maintenant monter les barrettes de RAM. C’est très simple, vous devez simplement ouvrir le petit coche aux extrémités de l’emplacement de la mémoire puis enfoncer la barrette en forçant légèrement. Attention au sens avant de forcer et vérifiez bien que l’encoche située sur la mémoire vive est bien en face du coche de l’emplacement. En appuyant, les coches aux extrémités vont se refermer et la barrette de mémoire vive tiendra en place.";
            Etape3.NomEtape.Text = "Etape 3 : Placer la RAM";

            Etape4.TexteEtape.Text = "La carte mère est presque prête et nous finirons de la remplir avec la carte graphique par la suite du montage du PC. Nous pouvons maintenant la fixer au boîtier. Commencez par coucher le PC et ouvrir le côté de la tour. Repérez ensuite tous les fils présents dans le boîtier et pendant les prochaines étapes, attention à ne pas les bloquer. Repérez l’endroit de votre boîtier où doivent se trouver les périphériques (micro, USB, casque, …) et posez la carte mère pour s’assurer de l’emplacement. Vérifiez bien que tous les pas de vis (6 en général) sont alignés avec ceux du boîtier. Une fois que vous en êtes sûr, vous pouvez placer les entretoises dans les trous de la tour puis visser les vis qui sont fournies avec le boîtier et fixer la carte mère.";
            Etape4.NomEtape.Text = "Etape 4 : Fixer la carte mère dans le boîtier";

            Etape5.TexteEtape.Text = "Il est maintenant temps de finir de monter les composants sur la carte mère et d’y insérer la carte graphique. Commencez par enlever les bouts de plastiques qui se trouvent sur la carte graphique.Ensuite, posez la carte graphique sur l’emplacement PCI sans la fixer pour repérer le sens et surtout l’emplacement des ports de périphériques (HDMI, DVI, VGA, …) par rapport à la tour. Une fois que vous l’avez visualisé, vous pouvez enlever les plaques en fer se trouvant sur le boîtier qui bloquent la sortie des ports.Vous pouvez ensuite insérer la carte graphique et la fixer dans le l’emplacement PCI 1 puis visser au niveau de la barre de périphériques pour fixer le tout.";
            Etape5.NomEtape.Text = "Etape 5 : Placer la carte graphique";

            Etape6.TexteEtape.Text = "Nous allons pouvoir continuer le montage du PC et passer au placement de l’alimentation que dont nous effectueront les branchements juste ensuite. L’alimentation se place en bas de la tour avec le ventilateur orienté vers le sol et les fils vers l’intérieur de la tour. Posez la bien contre la paroi du boîtier et vous devriez avoir les pas de vis alignés entre le boîtier et l’alimentation. Pour finir, vissez le boîtier et l’alimentation ensemble.";
            Etape6.NomEtape.Text = "Etape 6 : Placer l’alimentation";

            Etape7.TexteEtape.Text = "Plusieurs câbles ressortent de l’alimentation. Repérez le câble ATX qui est un câble très large à 12 broches. Il va servir à alimenter la carte mère, branchez-le au connecteur alimentation. Un autre câble ressort de l’alimentation, avec « USB 3 » inscrit dessus. Il va se placer juste à côté du connecteur de l’alimentation de la carte mère.";
            Etape7.NomEtape.Text = "Etape 7 : Branchement de l’alimentation";

            Etape8.TexteEtape.Text = "Nous allons en profiter pour brancher les ventilateurs extérieurs de la tour à la carte mère. Repérez donc les câbles présents qui sont connectés ventilateurs du boîtier (excepté celui situé à l’avant du boitier, juste derrière l’emplacement des disques durs). Les connecteurs des ventilateurs sont des connecteurs à 3 broches et que vous allez brancher sur les ports « sys-fan » de la carte mère. Les ports « sys-fan » ont 4 broches mais cela est tout à fait normal, ne vous inquiétez pas.On va continuer en branchant le ventirad à la carte mère. Repérez le câble sortant du ventirad et branchez-le à l’emplacement « CPU fan »On va passer au branchement du panel frontal. Ce sont tous les câbles avec des petits embouts sortant de la face du boîtier. Une fois que vous les avez trouvés, rechercher l’emplacement de ceux-ci sur la carte mère, c’est un embranchement qui s’appelle « JPF1 ». Pour les brancher, référez-vous au schéma présent sur le manuel de votre boîtier, les branchements peuvent varier d’un boîtier à l’autre. Faîtes simplement attention au sens plus et moins lors du branchement.";
            Etape8.NomEtape.Text = "Etape 8 : Branchement ventilateurs et panel frontal";

            Etape9.TexteEtape.Text = "Si ce n’est pas déjà fait, ouvrez le panneau arrière du boîtier, cela va nous aider à brancher le disque dur. Ensuite, repérer l’emplacement du disque dur qui est situé à l’avant de la tour. La manière d’insérer le disque dur dans l’emplacement peut varier d’un boîtier à un autre mais c’est souvent assez intuitif. Si vous n’y arrivez pas, regardez rapidement dans le manuel du boîtier.Insérez-y le disque dur et passons au branchement de celui-ci. La première étape du branchement est de le brancher à l’alimentation. Vous allez devoir brancher le câble « SATA » qui vous est donné avec l’alimentation au disque dur et à le relier à l’alimentation si ce n’est pas déjà fait. Ensuite, nous allons brancher le disque dur à la carte mère. Récupérer le cable SATA, dont le port est plus petit que celui de l’alimentation, qui vous est donné avec votre carte mère et branchez le à la carte mère à l’emplacement « SATA1 » puis branchez-le à l’arrière du disque dur, à côté du premier câble.";
            Etape9.NomEtape.Text = "Etape 9 : Placement et branchement du disque dur";

            Etape10.TexteEtape.Text = "Nous avons maintenant fini de tout installer dans notre PC (à moins que vous ayez des composants supplémentaires comme une carte wi-fi que vous pouvez brancher sur un port PCI de la carte mère.) et nous allons devoir vérifier que tout fonctionne. Ne refermez pas encore le boîtier, car il nous reste une dernière étape après.";
            Etape10.NomEtape.Text = "Etape 10 : Vérifier que tout fonctionne";

            Etape11.TexteEtape.Text = "Tout fonctionne parfaitement mais nous devons nous assurer que l’air circule correctement dans le PC. Débranchez l’alimentation avant de manipuler les câbles.Le but est de rassembler les câbles et de les enrouler avec une lamelle de plastique qui vous est donnée avec le boîtier. Vous pouvez aussi les rassembler avec un fil de fer enroulé de plastique qui servaient à entourer les câbles de l’alimentation.Il n’y a pas vraiment de règle dans le rangement des câbles, faîtes de votre mieux pour avoir un maximum de place à l’intérieur du boîtier pour y faciliter le passage de l’air et la ventilation.";
            Etape11.NomEtape.Text = "Etape 11 : Ranger les câbles";

            Etape12.TexteEtape.Text = "Allumez le PC une dernière fois avant de refermer le boîtier pour vous assurer que vous n’avez rien débrancher malencontreusement lors du rangement des câbles. Si tout fonctionne, vous pouvez refermer le boîtier et passer à l’installation du système d’exploitation.";
            Etape12.NomEtape.Text = "Etape 12 : Allumer le PC";
        }
    }
}
