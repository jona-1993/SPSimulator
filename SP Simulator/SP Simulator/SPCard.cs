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
                    description = "Le volcanor est un magicien extraordinaire\nqui peut commander sans limite les forces\n de la terre et du feu.<<Avec sa magie,\nles autres se retrouvent six pieds sous terre.>>\nRésistance à la phobie des dragons de 30%\nVitesse de déplacement +2";
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
                    description = "";
                    break;
                case "Ninja":
                    description = "";
                    break;
                case "Croisé":
                    description = "";
                    break;
                case "Bersek":
                    description = "";
                    break;
                case "Gladiateur":
                    description = "";
                    break;
                case "Renégat":
                    description = "";
                    break;
                case "Ranger":
                    description = "";
                    break;
                case "Assassin":
                    description = "";
                    break;
                case "Destructeur":
                    description = "";
                    break;
                case "Garde-chasse":
                    description = "";
                    break;
                case "Canonnier de feu":
                    description = "";
                    break;
                case "Eclaireur":
                    description = "";
                    break;
                case "Chasseur de démons":
                    description = "";
                    break;
                case "Ange vengeur":
                    description = "";
                    break;
                case "Drakenfer":
                    description = "";
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
        /*
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            //throw new NotImplementedException();

            if ((((SPCard)obj).niveau + ((SPCard)obj).grade) == (this.niveau + this.grade))
            {
                return base.Equals(obj);
            }
            else
                return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }*/
    }
}
