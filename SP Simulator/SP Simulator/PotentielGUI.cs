using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Simulator
{
    public partial class PotentielGUI : Form
    {
        int attaque = 0, precision = 0, esquive = 0, element = 0, hp = 0, mp = 0, chancecc = 0, degatscc = 0, alldef = 0, dimchancecc = 0, dimcc = 0, dimmagie = 0, allres = 0, ptsrest = 0, SLTotal = 0;

        private void PotentielLabel_Click(object sender, EventArgs e)
        {

        }

        long ptsmax = 0;
        System.Windows.Forms.Timer foc = new System.Windows.Forms.Timer();

        public PotentielGUI()
        {
            InitializeComponent();
        }

        void Activation(object sender, EventArgs e)
        {
            this.Activate();
        }

        public PotentielGUI(SPCard sp, int SLAtk, int SLDef, int SLElem, int SLHp, int SLGen, long PointAttaque, long PointDefense, long PointElement, long PointHp, int ptsres, long ptsmx)
        {
            InitializeComponent();

            this.TopMost = true;

            foc.Tick += Activation;
            foc.Interval = 2000;
            foc.Start();

            ptsrest = ptsres;

            ptsmax = ptsmx;

            SLTotal = SLAtk + SLDef + SLElem + SLHp + (SLGen * 4);

            SPNameLabel.Text = sp.nom;

            AttaqueLabel.Text = "Attaque: " + PointAttaque + " + " + (sp.bonusAttaque*10) + " = +" + (PointAttaque + (sp.bonusAttaque*10)) + " Points"; 

            DefenseLabel.Text = "Défense: " + PointDefense + " + " + (sp.bonusDefense*10) + " = +" + (PointDefense + (sp.bonusDefense*10)) + " Points"; 

            ElementLabel.Text = "Elément: " + PointElement + " Points"; 

            HpLabel.Text = "HP/MP: " + PointHp  + "%";

            ResFeuLabel.Text = "Résistance Feu: " + sp.resFeu + " + " + sp.bonusResFeu + " = +" + (sp.resFeu + sp.bonusResFeu) + "%";

            ResEauLabel.Text = "Résistance Eau: " + sp.resEau + " + " + sp.bonusResEau + " = +" + (sp.resEau + sp.bonusResEau) + "%";

            ResLumLabel.Text = "Résistance Lumière: " + sp.resLumiere + " + " + sp.bonusResLumiere + " = +" + (sp.resLumiere + sp.bonusResLumiere) + "%";

            ResObsLabel.Text = "Résistance Obscurité: " + sp.resObscure + " + " + sp.bonusResObscure + " = +" + (sp.resObscure + sp.bonusResObscure) + "%";

            if(sp.attaque + SLAtk + SLGen >= 1)
            {
                attaque += 5;

                if(sp.attaque + SLAtk + SLGen >= 10)
                {
                    precision += 10;

                    if(sp.attaque + SLAtk + SLGen >= 20)
                    {
                        chancecc += 2;

                        if(sp.attaque + SLAtk + SLGen >= 30)
                        {
                            precision += 10;
                            attaque += 5;

                            if(sp.attaque + SLAtk + SLGen >= 40)
                            {
                                degatscc += 10;
                                
                                if(sp.attaque + SLAtk + SLGen >= 50)
                                {
                                    hp += 200;
                                    mp += 200;

                                    if(sp.attaque + SLAtk + SLGen >= 60)
                                    {
                                        precision += 15;

                                        if(sp.attaque + SLAtk + SLGen >= 70)
                                        {
                                            precision += 15;
                                            attaque += 5;

                                            if(sp.attaque + SLAtk + SLGen >= 80)
                                            {
                                                chancecc += 3;

                                                if (sp.attaque + SLAtk + SLGen >= 90)
                                                {
                                                    degatscc += 20;

                                                    if (sp.attaque + SLAtk + SLGen >= 100)
                                                    {
                                                        precision += 20;
                                                        chancecc += 3;
                                                        degatscc += 20;
                                                        hp += 200;
                                                        mp += 200;
                                                        attaque += 5;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (sp.defense + SLDef + SLGen >= 10)
            {
                esquive += 5;

                if (sp.defense + SLDef + SLGen >= 20)
                {
                    dimcc += 2;

                    if (sp.defense + SLDef + SLGen >= 30)
                    {
                        hp += 100;

                        if (sp.defense + SLDef + SLGen >= 40)
                        {
                            dimcc += 2;

                            if (sp.defense + SLDef + SLGen >= 50)
                            {
                                esquive += 5;

                                if (sp.defense + SLDef + SLGen >= 60)
                                {
                                    hp += 200;

                                    if (sp.defense + SLDef + SLGen >= 70)
                                    {
                                        dimcc += 3;

                                        if (sp.defense + SLDef + SLGen >= 75)
                                        {
                                            allres += 2;

                                            if (sp.defense + SLDef + SLGen >= 80)
                                            {
                                                esquive += 10;
                                                dimcc += 3;
                                                if (sp.defense + SLDef + SLGen >= 90)
                                                {
                                                    allres += 3;
                                                    if (sp.defense + SLDef + SLGen >= 95)
                                                    {
                                                        hp += 300;
                                                        if (sp.defense + SLDef + SLGen >= 100)
                                                        {
                                                            esquive += 20;
                                                            allres += 5;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (sp.element + SLElem + SLGen >= 1)
            {
                element += 2;

                if (sp.element + SLElem + SLGen >= 10)
                {
                    mp += 100;

                    if (sp.element + SLElem + SLGen >= 20)
                    {
                        dimmagie += 5;

                        if (sp.element + SLElem + SLGen >= 30)
                        {
                            allres += 2;
                            element += 2;

                            if (sp.element + SLElem + SLGen >= 40)
                            {
                                mp += 100;

                                if (sp.element + SLElem + SLGen >= 50)
                                {
                                    dimmagie += 5;

                                    if (sp.element + SLElem + SLGen >= 60)
                                    {
                                        allres += 3;
                                        element += 2;

                                        if (sp.element + SLElem + SLGen >= 70)
                                        {
                                            mp += 100;

                                            if (sp.element + SLElem + SLGen >= 80)
                                            {
                                                dimmagie += 5;
                                                if (sp.element + SLElem + SLGen >= 90)
                                                {
                                                    element += 2;
                                                    allres += 4;
                                                    if (sp.element + SLElem + SLGen >= 100)
                                                    {
                                                        dimmagie += 5;
                                                        allres += 6;
                                                        mp += 200;
                                                        element += 2;

                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            if (sp.hp + SLHp + SLGen >= 5)
            {
                attaque += 5;

                if (sp.hp + SLHp + SLGen >= 10)
                {
                    attaque += 5;

                    if (sp.hp + SLHp + SLGen >= 15)
                    {
                        attaque += 5;

                        if (sp.hp + SLHp + SLGen >= 20)
                        {
                            attaque += 5;
                            alldef += 10;

                            if (sp.hp + SLHp + SLGen >= 25)
                            {
                                attaque += 5;

                                if (sp.hp + SLHp + SLGen >= 30)
                                {
                                    attaque += 5;

                                    if (sp.hp + SLHp + SLGen >= 35)
                                    {
                                        attaque += 5;

                                        if (sp.hp + SLHp + SLGen >= 40)
                                        {
                                            attaque += 5;
                                            alldef += 15;

                                            if (sp.hp + SLHp + SLGen >= 45)
                                            {
                                                attaque += 10;

                                                if (sp.hp + SLHp + SLGen >= 50)
                                                {
                                                    attaque += 10;
                                                    allres += 2;

                                                    if (sp.hp + SLHp + SLGen >= 55)
                                                    {
                                                        attaque += 10;

                                                        if (sp.hp + SLHp + SLGen >= 60)
                                                        {
                                                            attaque += 10;

                                                            if (sp.hp + SLHp + SLGen >= 65)
                                                            {
                                                                attaque += 10;

                                                                if (sp.hp + SLHp + SLGen >= 70)
                                                                {
                                                                    attaque += 10;
                                                                    alldef += 20;

                                                                    if (sp.hp + SLHp + SLGen >= 75)
                                                                    {
                                                                        attaque += 15;

                                                                        if (sp.hp + SLHp + SLGen >= 80)
                                                                        {
                                                                            attaque += 15;
                                                                            if (sp.hp + SLHp + SLGen >= 85)
                                                                            {
                                                                                attaque += 15;
                                                                                dimchancecc += 1;
                                                                                if (sp.hp + SLHp + SLGen >= 86)
                                                                                {
                                                                                    dimchancecc += 1;
                                                                                    if (sp.hp + SLHp + SLGen >= 87)
                                                                                    {
                                                                                        dimchancecc += 1;
                                                                                        if (sp.hp + SLHp + SLGen >= 88)
                                                                                        {
                                                                                            dimchancecc += 1;
                                                                                            if (sp.hp + SLHp + SLGen >= 90)
                                                                                            {
                                                                                                attaque += 15;
                                                                                                alldef += 25;
                                                                                                if (sp.hp + SLHp + SLGen >= 91)
                                                                                                {
                                                                                                    esquive += 2;
                                                                                                    if (sp.hp + SLHp + SLGen >= 92)
                                                                                                    {
                                                                                                        esquive += 2;
                                                                                                        if (sp.hp + SLHp + SLGen >= 93)
                                                                                                        {
                                                                                                            esquive += 2;
                                                                                                            if (sp.hp + SLHp + SLGen >= 94)
                                                                                                            {
                                                                                                                esquive += 2;
                                                                                                                if (sp.hp + SLHp + SLGen >= 95)
                                                                                                                {
                                                                                                                    attaque += 20;
                                                                                                                    esquive += 2;
                                                                                                                    if (sp.hp + SLHp + SLGen >= 96)
                                                                                                                    {
                                                                                                                        esquive += 2;
                                                                                                                        if (sp.hp + SLHp + SLGen >= 97)
                                                                                                                        {
                                                                                                                            esquive += 2;
                                                                                                                            if (sp.hp + SLHp + SLGen >= 98)
                                                                                                                            {
                                                                                                                                esquive += 2;
                                                                                                                                if (sp.hp + SLHp + SLGen >= 99)
                                                                                                                                {
                                                                                                                                    esquive += 2;
                                                                                                                                    if (sp.hp + SLHp + SLGen >= 100)
                                                                                                                                    {
                                                                                                                                        attaque += 20;
                                                                                                                                        alldef += 30;
                                                                                                                                        allres += 3;
                                                                                                                                        esquive += 2;
                                                                                                                                        dimchancecc += 1;
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            BonusAttaqueLabel.Text = "Attaque: +" + attaque + " Points";
            BonusPrecisionLabel.Text = "Précision: +" + precision + " Points";
            BonusEsquiveLabel.Text = "Esquive: +" + esquive + " Points";
            BonusElementLabel.Text = "Elément: +" + element + " Points";
            BonusHpLabel.Text = "HP: +" + (hp + (sp.bonusHp*100)) + " Points";
            BonusMpLabel.Text = "MP: +" + (mp + (sp.bonusHp * 100)) + " Points";
            BonusChanceCCLabel.Text = "Chance Critique: +" + chancecc + "%";
            BonusDegatsCCLabel.Text = "Dégats Critique: +" + degatscc + "%";
            BonusAllDefLabel.Text = "Toute Défense: +" + alldef + " Points";
            BonusDimChCCLabel.Text = "Red. Chance Crit.: -" + dimchancecc + "%";
            BonusDimDegatCCLabel.Text = "Red. Dégats Crit.: -" + dimcc + "%";
            BonusDimDegatsMagiques.Text = "Red. Dégats Mag.: -" + dimmagie + " Points";
            BonusToutElement.Text = "Toute Résistances: +" + allres + "%";
            BonusFéeLabel.Text = "Fée: +" + sp.bonusElement + "%";


            getPotentiel(sp);
        }




        private void PotentielGUI_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);


        }

        private void getPotentiel(SPCard sp)
        {
            if(ptsmax > 400)
                PotentielLabel.Text = BoiteAPotentiel(1);
            else if(ptsmax > 100)
                PotentielLabel.Text = BoiteAPotentiel(2);
            else
                PotentielLabel.Text = BoiteAPotentiel(3);

            if (sp.attaque >= 90)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(4);

            if (sp.defense >= 90)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(15);

            if (sp.hp >= 90)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(10);

            if (sp.element >= 90)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(5);

            if(sp.attaque >= 30 && sp.defense >= 30 && sp.element >= 30 && sp.hp >= 30)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(6);
            
            if(sp.grade < 10 || sp.niveau < 80)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(7);

            if(sp.grade == 15 && sp.niveau == 99 && ptsrest != 0)
                PotentielLabel.Text += "\n" + BoiteAPotentiel(8);

            if (sp.nom == "Mage ténébreux")
                PotentielLabel.Text += "\n" + BoiteAPotentiel(12);

            if (sp.nom == "Volcanor")
            {
                PotentielLabel.Text += "\n" + BoiteAPotentiel(11);
                if(sp.hp < 25)
                {
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(16);
                }
            }

            if (sp.nom == "Sa Majesté des marées")
                PotentielLabel.Text += "\n" + BoiteAPotentiel(11);

            if (sp.nom == "Devin")
            {
                PotentielLabel.Text += "\n" + BoiteAPotentiel(11);

                if (sp.hp < 40)
                {
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(16);
                }
            }

            if (sp.nom == "Archimage")
            {
                PotentielLabel.Text += "\n" + BoiteAPotentiel(11);
                if (sp.hp < 25)
                {
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(16);
                }
            }

            if((sp.resEau + sp.resFeu + sp.resLumiere + sp.resObscure + sp.bonusResEau + sp.bonusResFeu + sp.bonusResLumiere + sp.bonusResObscure + (allres * 4)) > 49)
            {
                PotentielLabel.Text += "\n" + BoiteAPotentiel(14);
            }

            int totalBonus = (sp.bonusAttaque + sp.bonusDefense + sp.bonusElement + sp.bonusHp + sp.bonusResEau + sp.bonusResFeu + sp.bonusResLumiere + sp.bonusResObscure);
            int moyenneBonus = totalBonus / 8;
            
            if (totalBonus != 0)
            {
                if (sp.bonusAttaque >= moyenneBonus && sp.bonusDefense >= moyenneBonus && sp.bonusElement >= moyenneBonus && sp.bonusHp >= moyenneBonus)
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(21);
                else
                {
                    if (sp.bonusDefense > moyenneBonus)
                        PotentielLabel.Text += "\n" + BoiteAPotentiel(17);

                    if (sp.bonusAttaque > moyenneBonus)
                        PotentielLabel.Text += "\n" + BoiteAPotentiel(18);

                    if (sp.bonusElement > moyenneBonus)
                        PotentielLabel.Text += "\n" + BoiteAPotentiel(19);

                    if (sp.bonusHp > moyenneBonus)
                        PotentielLabel.Text += "\n" + BoiteAPotentiel(20);
                }
                
                if((sp.bonusResEau + sp.bonusResFeu + sp.bonusResLumiere + sp.bonusResObscure) > moyenneBonus)
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(22);

                if (SLTotal < 20)
                    PotentielLabel.Text += "\n" + BoiteAPotentiel(9);
            }
            else
            {
                PotentielLabel.Text += "\n" + BoiteAPotentiel(23);
            }
        }

        private String BoiteAPotentiel(int choix)
        {
            switch(choix)
            {
                case 1:
                    return "- Cette SP est excellente!";
                case 2:
                    return "- Cette SP est dans la moyenne.";
                case 3:
                    return "- Cette SP n'est pas terrible...";
                case 4:
                    return "- On y voit un gros potentiel en PvP.";
                case 5:
                    return "- C'est parfait pour du PvE.\nVeillez a avoir des baisses de résistances sur vos armes.";
                case 6:
                    return "- C'est plutôt équilibré, vous pouvez\nl'utiliser pour toutes circonstances.";
                case 7:
                    return "- Il y a encore du boulot pour en faire une SP\nd'exception !";
                case 8:
                    return "- Vous devriez exploiter la totalité des points\nque vous avez brillament gagnés...";
                case 9:
                    return "- Quelques petites SL sur vos armes ne\nserai pas de refus ! ;)";
                case 10:
                    return "- Vous allez être un sacré bourrin avec vos HPs !";
                case 11:
                    return "- Vous aurez besoin d'une bonne arme principale.";
                case 12:
                    return "- Vous aurez besoin d'une bonne arme secondaire.";
                case 13:
                    return "- Vous aurez besoin d'une bonne armure.";
                case 14:
                    return "- Vous avez de bonnes résistances.";
                case 15:
                    return "- Vous avez une excellente défense.";
                case 16:
                    return "- Vous devriez booster un peu plus vos manas!";
                case 17:
                    return "- Vous semblez être dirigés vers une SP défensive!";
                case 18:
                    return "- Vous semblez être dirigés vers une SP PvP!";
                case 19:
                    return "- Vous semblez être dirigés vers une SP PvE!";
                case 20:
                    return "- Vous semblez être dirigés vers une SP endurante!";
                case 21:
                    return "- Vous semblez être dirigés vers une SP équilibrée!";
                case 22:
                    return "- Vous semblez être dirigés vers une SP résistante\naux éléments!";
                case 23:
                    return "- Vous devriez commencer à utiliser des\npierres d'améliorations!";

            }

            return null;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
