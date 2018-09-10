using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Simulator
{
    public class SPCard
    {
        public String nom;
        public int grade = 0, amelioration = 0, niveau = 1, points = 0; 
        public int attaque = 0, defense = 0, element = 0, hp = 0, resLumiere = 0, resObscure = 0, resFeu = 0, resEau = 0;
        public int bonusAttaque = 0, bonusDefense = 0, bonusElement = 0, bonusHp = 0, bonusResLumiere = 0, bonusResObscure = 0, bonusResFeu = 0, bonusResEau = 0;
        public int generation = 0;
        public string description;

        public SPCard(SPCard temp)
        {
            nom = temp.nom;
            resLumiere = temp.resLumiere;
            resObscure = temp.resObscure;
            resEau = temp.resEau;
            resFeu = temp.resFeu;
            generation = temp.generation;
            description = temp.description;
        }
        public SPCard(String name, int RFeu, int REau, int RLum, int RObs, int gen)
        {
            nom = name;
            resLumiere = RLum;
            resEau = REau;
            resFeu = RFeu;
            resObscure = RObs;
            generation = gen;

            switch (name)
            {
                case "Pyjama":
                    description = "Hé !! Profitons de la vie.\nPourquoi s'inquiéter? Profites-en\nsimplement.";
                    break;
                case "Costume de Poule":
                    description = "Vitesse de déplacement +2";
                    break;
                case "Jajamaru":
                    description = "Retour d'une légende !\nJajamaru débarque à Nostale\npour sauver la princesse Sakura !\n\nVitesse de déplacement +1";
                    break;
                case "Pirate":
                    description = "Tu peux désormais te transformer en\npirate !";
                    break;
                case "Mage du feu":
                    description = "Ces mages arborent le symbole de la\ndestruction et de la ruine.\nIls tiennent leur force destructrice des\npuissantes conjuration du Feu.";
                    break;
                case "Mage sacré":
                    description = "Le protecteur de la lumière, l'ordre et l'équilibre.\nCe magicien sage respecte la volonté d'Erenia.";
                    break;
                case "Mage de glace":
                    description = "En situation de danger, son coeur de\nglace gèle son corps et augmente ainsi la\nrésistance à l'élément Eau.\nIl maîtrise parfaitement le froids et le gèle.";
                    break;
                case "Mage ténébreux":
                    description = "Magicien maléfique utilisant la magie noire\nproscrite !\nOuvre les portes de la mort grâce aux\npouvoirs démoniaques !";
                    break;
                case "Volcanor":
                    description = "Le volcanor est un magicien extraordinaire\nqui peut commander sans limite les forces\n de la terre et du feu.<<Avec sa magie,\nles autres se retrouvent six pieds sous terre.>>\nRésistance à la phobie des dragons de 30% (Draco)\nVitesse de déplacement +2";
                    break;
                case "Sa Majesté des marées":
                    description = "Sa Majesté des marées règne sur les\nforces océaniques.\n<<Je tire ma force des abysses des mers.>>\n\nRésistance au froid augmenté de 10% ! (Glacerus)\nVitesse de déplacement +2";
                    break;
                case "Devin":
                    description = "Le Devin fait des recherches sur la magie\nobscure.\n<<Toute créature suivra mon chemin...\npeu importe où il mène.>>\n\nVitesse de déplacement +1";
                    break;
                case "Archimage":
                    description = "L'archimage a reçu la puissance divine\nconcentrée.\n<<Dieu dit: sois la lumière>>\n\nVitesse de déplacement +1";
                    break;
                case "Guerrier":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Feu.\nAvec le pouvoir de l'épée, tu domines le\nchamp de battaille. Les techniques de\ncombat enflammées de cet épéiste\naudacieux écrasent les puissants\nadversaires en attaque rapprochée.";
                    break;
                case "Ninja":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Eau.\nLes yeux de cet épéiste emplis de haine.\nQuiconque croise le chemin de ce\npuissant guerrier devra en découdre avec\nsa lame redoutable.\nVitesse de déplacement +1";
                    break;
                case "Croisé":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Lumière.\nLa volonté de fer et la foi de l'épéiste\nmaintiennent l'équilibre entre le bien et le\nmal. Contre ce défenseur de la justice, les\nforces du mal sont désarmées.";
                    break;
                case "Bersek":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Obscurité.\nEn faisant appel aux forces du mal, ce\nguerrier force son adversaire à battre en\nretraite de manière parfois déloyale.\nImpuissants face à lui, ses ennemis n'ont\nplusqu'à se plier à sa volonté.";
                    break;
                case "Gladiateur":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Feu.\nLe gladiateur est avant tout un spécialiste du\ncombat PvP (joueur contre joueur).\n<< Cher public, salue ton vaincueur! >>\nRésistance à la phobie des dragons de 30% (Draco)";
                    break;
                case "Moine pugnace":
                    description = "Le moine pugnace maitrise le maniement\nde la lance comme personne.\n<< Je nettoierai ce monde à la pointe de\nma lance. >>\nRésistance au froid augmenté de 10% ! (Glacerus)";
                    break;
                case "Mortifère":
                    description = "C'est le bras de la mort.\n<< Tout a une fin... d'une manière ou\nd'une autre... >>";
                    break;
                case "Renégat":
                    description = "Bouclier divin et gardien de Lumière\n<< Ma lame sera baignée de sang. >>\nVitesse de déplacement +1";
                    break;
                case "Ranger":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Eau.\nIl ouvre le combat par la pluie de\nflèches mortelles avec une rapidité telle\nque l'ennemi n'a même pas le temps de\nvoir l'attaque arriver.";
                    break;
                case "Assassin":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Obscurité.\nDerrière le masque se cache un terrible\nguerrier aussi sanguinaire que dangereux.\nSes adversaires ne devraient jamais le\nquitter des yeux.\nVitesse de déplacement +1";
                    break;
                case "Destructeur":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Feu.\nSa nature destructive perdra l'adversaire\nqui croisera la route de cet avanturier\nexplorateur. La rage brûlante qui l'anime\nsupprime ses ennemis sans pitié.";
                    break;
                case "Garde-chasse":
                    description = "Il s'agit de la carte de spécialiste de\nl'élément Lumière.\nSes connaisances et son instinct animal\nlui permettent de s'en sortir dans les\ncontrées les plus inhospitalières. Grâce à\nses forces bestiales, il se joue violemment\nde ses ennemis.";
                    break;
                case "Canonnier de feu":
                    description = "Il s'agit de la carte de spécialiste de l'élément Feu.\nLe cannonier de feu est le maître des armes à feu\nles plus impressionnantes.\n<< Mon canon est plus puissant que\nn'importe quelle magie. >>\nRésistance à la phobie des dragons de 30% (Draco)\nVitesse de déplacement +2";
                    break;
                case "Eclaireur":
                    description = "L'éclaireur est un as de l'arbalète et un\nexpert en mission de reconnaissance.\n<< Si tu te connais et tu connais\nencore mieux ton ennemi, tu peux\nremporter toutes les batailles. >>\nRésistance au froid augmenté de 10% ! (Glacerus)";
                    break;
                case "Chasseur de démons":
                    description = "Ce ranger a signé un pacte avec le diable\nen personne.\n<< J'ai moi-même vendu mon âme au\ndiable... Je détruirai tous les démons. >>\nVitesse de déplacement +1";
                    break;
                case "Ange vengeur":
                    description = "Membre de l'armée divine et gardien des\ncieux azurs\n<< Mon épée est la volonté de Dieu. >>\nVitesse de déplacement +2";
                    break;
                case "Drakenfer":
                    description = "Haetae libère ton caractère sauvage.\nLa puissance du feu et de la bête qui\nt'habite anéantit les ennemis.\nVitesse de déplacement +2";
                    break;
                default:
                    description = "";
                    break;
            }
        }

        public override string ToString()
        {
            return nom;
        }
        
    }
}
