using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Simulator
{
    public partial class Form1 : Form
    {
        SPCard SPSelected;
        int SLAtk = 0, SLDef = 0, SLElem = 0, SLHp = 0, SLGen = 0;
        long pointsUtilisés = 0, pointsMax = 0, pointsLevel = 0, pointsGrade = 0, pointsRestant = 0, pointsUtilisésAtk = 0, pointsUtilisésDef = 0, pointsUtilisésElem = 0, pointsUtilisésHp = 0;
        System.Windows.Forms.Timer foc = new System.Windows.Forms.Timer();
        private Process pDocked;

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void Activation(object sender, EventArgs e)
        {
            this.Activate();
        }
        public Form1()
        {
            
            InitializeComponent();
            

            this.TopMost = true;
            try 
            {
                pDocked = Process.GetProcessesByName("NostaleClientX").First();
                Thread.Sleep(5000);
                
                SetParent(pDocked.MainWindowHandle, Process.GetCurrentProcess().Handle); // L'appli doit avoir les droits !
                
                foc.Tick += Activation;
                foc.Interval = 2000;
                foc.Start();
            }
            catch (Exception)
            {

            }


            MessagesPanel.Visible = false;

            DescLabel.Text = "Développeur: C. Jonathan\n\nVersion: 18.6.18 (Bêta)\n\nCopyright: (" + DateTime.Now.Year + ") Tous droits réservés.";

            Grade80plusTB.Visible = false;

            this.Focus();
            this.BringToFront();
            this.TopMost = true;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //this.Bounds = Screen.PrimaryScreen.Bounds;


            #region CBAddSP
            ChoixCB.Items.Add(new SPCard("Pyjama", 0, 0, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Costume de Poule", 0, 0, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Jajamaru", 8, 0, 0, 3, 1));
            ChoixCB.Items.Add(new SPCard("Pirate", 0, 0, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Mage du feu", 17, 0, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Mage sacré", 4, 4, 4, 16, 1));
            ChoixCB.Items.Add(new SPCard("Mage de glace", 2, 17, 1, 1, 1));
            ChoixCB.Items.Add(new SPCard("Mage ténébreux", 2, 1, 0, 16, 1));
            ChoixCB.Items.Add(new SPCard("Volcanor", 17, 4, 0, 6, 2));
            ChoixCB.Items.Add(new SPCard("Sa Majesté des marées", 5, 16, 6, 2, 2));
            ChoixCB.Items.Add(new SPCard("Devin", 5, 2, 5, 17, 2));
            ChoixCB.Items.Add(new SPCard("Archimage", 5, 5, 15, 6, 2));
            ChoixCB.Items.Add(new SPCard("Guerrier", 4, 13, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Ninja", 3, 11, 8, 0, 1));
            ChoixCB.Items.Add(new SPCard("Croisé", 3, 2, 5, 13, 1));
            ChoixCB.Items.Add(new SPCard("Bersek", 3, 2, 1, 15, 1));
            ChoixCB.Items.Add(new SPCard("Gladiateur", 15, 4, 0, 4, 2));
            ChoixCB.Items.Add(new SPCard("Renégat", 2, 2, 12, 12, 2));
            ChoixCB.Items.Add(new SPCard("Ranger", 0, 9, 10, 0, 1));
            ChoixCB.Items.Add(new SPCard("Assassin", 3, 3, 0, 16, 1));
            ChoixCB.Items.Add(new SPCard("Destructeur", 14, 5, 0, 0, 1));
            ChoixCB.Items.Add(new SPCard("Garde-chasse", 2, 4, 13, 1, 1));
            ChoixCB.Items.Add(new SPCard("Canonnier de feu", 17, 2, 2, 4, 2));
            ChoixCB.Items.Add(new SPCard("Eclaireur", 5, 14, 5, 3, 2));
            ChoixCB.Items.Add(new SPCard("Chasseur de démons", 4, 3, 6, 16, 2));
            ChoixCB.Items.Add(new SPCard("Ange vengeur", 3, 4, 18, 2, 2));
            #endregion

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

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChoixSPLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChoixCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ChoixCB.SelectedText != "Sélection")
            {
                SPSelected = new SPCard((SPCard)ChoixCB.SelectedItem);

                SPLabel.Text = SPSelected.ToString();
                LvLabel.Text = SPSelected.niveau.ToString();
                LumiereLabel.Text = SPSelected.resLumiere.ToString();
                ObscureLabel.Text = SPSelected.resObscure.ToString();
                FeuLabel.Text = SPSelected.resFeu.ToString();
                EauLabel.Text = SPSelected.resEau.ToString();
                GradeLabel.Text = "+0";

                #region SwitchConfigSP
                switch(SPSelected.ToString())
                {
                    case "Pyjama": SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.Pyjama;
                        break;
                    case "Costume de Poule": SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.Poule;
                        break;
                    case "Jajamaru":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.Jajamaru;
                        break;
                    case "Pirate":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.Pirate;
                        break;
                    case "Mage du feu":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP1;
                        break;
                    case "Mage sacré":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP2;
                        break;
                    case "Mage de glace":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP3;
                        break;
                    case "Mage ténébreux":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP4;
                        break;
                    case "Volcanor":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP5;
                        break;
                    case "Sa Majesté des marées":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP6;
                        break;
                    case "Devin":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP7;
                        break;
                    case "Archimage":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.MageSP8;
                        break;
                    case "Guerrier":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP1;
                        break;
                    case "Ninja":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP2;
                        break;
                    case "Croisé":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP3;
                        break;
                    case "Bersek":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP4;
                        break;
                    case "Gladiateur":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP5;
                        break;
                    case "Renégat":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.EscriSP8;
                        break;
                    case "Ranger":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP1;
                        break;
                    case "Assassin":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP2;
                        break;
                    case "Destructeur":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP3;
                        break;
                    case "Garde-chasse":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP4;
                        break;
                    case "Canonnier de feu":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP5;
                        break;
                    case "Eclaireur":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP6;
                        break;
                    case "Chasseur de démons":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP7;
                        break;
                    case "Ange vengeur":
                        SPPictureBox.BackgroundImage = SP_Simulator.Properties.Resources.ArcherSP8;
                        break;
                    default: SPPictureBox.BackgroundImage = null;
                        break;
                }
                #endregion

                DescLabel.Text = SPSelected.description;

                PtsLabel.Text = "" + 0;
                pointsGrade = 0;
                pointsLevel = 0;
                pointsRestant = 0;
                GradeLabel.Text = "+" + SPSelected.grade;
                
                AtkLabel.Text = "" + (SLGen + SLAtk);
                DefLabel.Text = "" + (SLGen + SLDef);
                ElemLabel.Text = "" + (SLGen + SLElem);
                HPLabel.Text = "" + (SLGen + SLHp);

                AmelioLabel.Text = "+0";

                AmelioAtkLabel.Text = "+" + SPSelected.bonusAttaque;
                AmelioDefLabel.Text = "+" + SPSelected.bonusDefense;
                AmelioElemLabel.Text = "+" + SPSelected.bonusElement;
                AmelioHpLabel.Text = "+" + SPSelected.bonusHp;

                AmelioResObsLabel.Text = "+" + SPSelected.bonusResObscure;
                AmelioResLumLabel.Text = "+" + SPSelected.bonusResLumiere;
                AmelioResFeuLabel.Text = "+" + SPSelected.bonusResFeu;
                AmelioResEauLabel.Text = "+" + SPSelected.bonusResEau;
               
            }
        }

        private void UPButton_Click(object sender, EventArgs e)
        {
            if (SPSelected != null)
            {
                ConfigSPPanel.Visible = true;

                LevelTB.Text = SPSelected.niveau.ToString();
                LevelTB.Visible = true;

                AtkTB.Text = SPSelected.attaque.ToString();
                DefTB.Text = SPSelected.defense.ToString();
                ElemTB.Text = SPSelected.element.ToString();
                HpTB.Text = SPSelected.hp.ToString();
                BonusAtkTB.Text = SPSelected.bonusAttaque.ToString();
                BonusDefTB.Text = SPSelected.bonusDefense.ToString();
                BonusElemTB.Text = SPSelected.bonusElement.ToString();
                BonusHpTB.Text = SPSelected.bonusHp.ToString();
                BonusResEauTB.Text = SPSelected.bonusResEau.ToString();
                BonusResFeuTB.Text = SPSelected.bonusResFeu.ToString();
                BonusResLumTB.Text = SPSelected.bonusResLumiere.ToString();
                BonusResObsTB.Text = SPSelected.bonusResObscure.ToString();

                SLAtkTB.Text = SLAtk.ToString();
                SLDefTB.Text = SLDef.ToString();
                SLElemTB.Text = SLElem.ToString();
                SLHpTB.Text = SLHp.ToString();
                SLGenTB.Text = SLGen.ToString();

                pointsMax = (pointsGrade + pointsLevel);

                PointsMaxLabel.Text = "/" + pointsMax;

                PointsConsoTB.Text = "" + ((pointsGrade + pointsLevel) - pointsUtilisés);

                if(int.Parse(AmelioLabel.Text.Substring(1)) >= 80)
                {
                    Grade80plusTB.Visible = true;
                }
            }
            else
            {
                MessageLabel.Text = "Sélectionnez une SP\navant toute chose !";
                MessagesPanel.Visible = true;
                NotifyTimer.Start();
            }
        }

        private void BonusAtkTB_TextChanged(object sender, EventArgs e)
        {

            if (BonusAtkTB.Text == "")
            {
                BonusAtkTB.Text = "0";
            }

            try
            { 
                //if(int.Parse(BonusAtkTB.Text) < 0 || int.Parse(BonusAtkTB.Text) > 100)
                if(int.Parse(BonusAtkTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusAtkTB.Text = "0";
                }

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2) 
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) 
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }

                

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusDefTB_TextChanged(object sender, EventArgs e)
        {

            if (BonusDefTB.Text == "")
            {
                BonusDefTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusDefTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusDefTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusElemTB_TextChanged(object sender, EventArgs e)
        {

            if (BonusElemTB.Text == "")
            {
                BonusElemTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusElemTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusElemTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusHpTB_TextChanged(object sender, EventArgs e)
        {

            if (BonusHpTB.Text == "")
            {
                BonusHpTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusHpTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusHpTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void SLAtkTB_TextChanged(object sender, EventArgs e)
        {
            if (SLAtkTB.Text == "")
            {
                SLAtkTB.Text = "0";
            }

            try
            {
                if (int.Parse(SLAtkTB.Text) < 0 || int.Parse(SLAtkTB.Text) > 100)
                {
                    SLAtkTB.Text = "0";
                }

                ResultAtkLabel.Text = "+" + CountAtk(long.Parse(AtkTB.Text) + long.Parse(SLAtkTB.Text) + long.Parse(SLGenTB.Text));

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";


        }

        private void SLDefTB_TextChanged(object sender, EventArgs e)
        {
            if (SLDefTB.Text == "")
            {
                SLDefTB.Text = "0";
            }

            try
            {
                if (int.Parse(SLDefTB.Text) < 0 || int.Parse(SLDefTB.Text) > 100)
                {
                    SLDefTB.Text = "0";
                }

                ResultDefLabel.Text = "+" + CountDef(long.Parse(DefTB.Text) + long.Parse(SLDefTB.Text) + long.Parse(SLGenTB.Text));

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";

        }

        private void SLElemTB_TextChanged(object sender, EventArgs e)
        {
            if (SLElemTB.Text == "")
            {
                SLElemTB.Text = "0";
            }

            try
            {
                if (int.Parse(SLElemTB.Text) < 0 || int.Parse(SLElemTB.Text) > 100)
                {
                    SLElemTB.Text = "0";
                }

                ResultElemLabel.Text = "+" + CountElem(long.Parse(ElemTB.Text) + long.Parse(SLElemTB.Text) + long.Parse(SLGenTB.Text));

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";


        }

        private void SLHpTB_TextChanged(object sender, EventArgs e)
        {
            if (SLHpTB.Text == "")
            {
                SLHpTB.Text = "0";
            }

            try
            {
                if (int.Parse(SLHpTB.Text) < 0 || int.Parse(SLHpTB.Text) > 100)
                {
                    SLHpTB.Text = "0";
                }
                ResultHpLabel.Text = "+" + CountHp(long.Parse(HpTB.Text) + long.Parse(SLHpTB.Text) + long.Parse(SLGenTB.Text));
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";


        }

        private void BonusResFeuTB_TextChanged(object sender, EventArgs e)
        {
            if (BonusResFeuTB.Text == "")
            {
                BonusResFeuTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusResFeuTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusResFeuTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusResEauTB_TextChanged(object sender, EventArgs e)
        {
            if (BonusResEauTB.Text == "")
            {
                BonusResEauTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusResEauTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusResEauTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusResLumTB_TextChanged(object sender, EventArgs e)
        {
            if (BonusResLumTB.Text == "")
            {
                BonusResLumTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusResLumTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusResLumTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void BonusResObsTB_TextChanged(object sender, EventArgs e)
        {
            if (BonusResObsTB.Text == "")
            {
                BonusResObsTB.Text = "0";
            }

            try
            {
                if (int.Parse(BonusResObsTB.Text) < 0 || (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) > 200)
                {
                    BonusResObsTB.Text = "0";
                }

                //AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 60))
                {
                    AmelioLabel.Text = "+" + (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) < 80))
                {
                    AmelioLabel.Text = "+" + ((((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 60) / 2)
                        + ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text))
                        - (((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) - 59))) + 1);

                    Grade80plusTB.Visible = false;

                    Grade80plusTB.ForeColor = Color.Black;
                }
                else if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text) >= 80))
                {
                    Grade80plusTB.Visible = true;
                    Grade80plusTB.ForeColor = Color.Black;

                }

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void SLGenTB_TextChanged(object sender, EventArgs e)
        {
            if (SLGenTB.Text == "")
            {
                SLGenTB.Text = "0";
            }

            try
            {
                if (int.Parse(SLGenTB.Text) < 0 || int.Parse(SLGenTB.Text) > 100)
                {
                    SLGenTB.Text = "0";
                }

                ResultAtkLabel.Text = "+" + CountAtk(long.Parse(AtkTB.Text) + long.Parse(SLAtkTB.Text) + long.Parse(SLGenTB.Text));
                ResultDefLabel.Text = "+" + CountDef(long.Parse(DefTB.Text) + long.Parse(SLDefTB.Text) + long.Parse(SLGenTB.Text));
                ResultElemLabel.Text = "+" + CountElem(long.Parse(ElemTB.Text) + long.Parse(SLElemTB.Text) + long.Parse(SLGenTB.Text));
                ResultHpLabel.Text = "+" + CountHp(long.Parse(HpTB.Text) + long.Parse(SLHpTB.Text) + long.Parse(SLGenTB.Text));

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (sender is int)
                LevelTB.Text = sender.ToString();
            else
                LevelTB.Text = "1";
            AtkTB.Text = "0";
            DefTB.Text = "0";
            ElemTB.Text = "0";
            HpTB.Text = "0";
            BonusResEauTB.Text = "0";
            BonusResFeuTB.Text = "0";
            BonusResObsTB.Text = "0";
            BonusResLumTB.Text = "0";
            BonusAtkTB.Text = "0";
            BonusDefTB.Text = "0";
            BonusElemTB.Text = "0";
            BonusHpTB.Text = "0";
            SLAtkTB.Text = "0";
            SLDefTB.Text = "0";
            SLElemTB.Text = "0";
            SLHpTB.Text = "0";
            SLGenTB.Text = "0";

            RepartirButton_Click(null, null);

        }

        private void AtkTB_TextChanged(object sender, EventArgs e)
        {

            if (AtkTB.Text == "")
            {
                AtkTB.Text = "0";
            }

            try
            {
                if (int.Parse(AtkTB.Text) >= 0 && int.Parse(AtkTB.Text) <= 100)
                {
                    pointsUtilisésAtk = CountPointAtk(int.Parse(AtkTB.Text));//((pointsGrade + pointsLevel) - pointsUtilisés) - CountPoint(int.Parse(AtkTB.Text));

                    PointsConsoTB.Text = "" + (((pointsGrade + pointsLevel)) - (pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp));

                    pointsUtilisés = pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp;

                    ResultAtkLabel.Text = "+" + CountAtk(long.Parse(AtkTB.Text) + long.Parse(SLAtkTB.Text) + long.Parse(SLGenTB.Text));

                }
                else
                {
                    AtkTB.Text = "0";
                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void DefTB_TextChanged(object sender, EventArgs e)
        {
            if (DefTB.Text == "")
            {
                DefTB.Text = "0";
            }

            try
            {
                if (int.Parse(DefTB.Text) >= 0 && int.Parse(DefTB.Text) <= 100)
                {
                    pointsUtilisésDef = CountPointDef(int.Parse(DefTB.Text));//((pointsGrade + pointsLevel) - pointsUtilisés) - CountPoint(int.Parse(DefTB.Text));

                    PointsConsoTB.Text = "" + (((pointsGrade + pointsLevel)) - (pointsUtilisésDef + pointsUtilisésAtk + pointsUtilisésElem + pointsUtilisésHp));

                    pointsUtilisés = pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp;

                    ResultDefLabel.Text = "+" + CountDef(long.Parse(DefTB.Text) + long.Parse(SLDefTB.Text) + long.Parse(SLGenTB.Text));
                }
                else
                {
                    DefTB.Text = "0";
                }

            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void ElemTB_TextChanged(object sender, EventArgs e)
        {
            if (ElemTB.Text == "")
            {
                ElemTB.Text = "0";
            }

            try
            {
                if (int.Parse(ElemTB.Text) >= 0 && int.Parse(ElemTB.Text) <= 100)
                {
                    pointsUtilisésElem = CountPointElem(int.Parse(ElemTB.Text));//((pointsGrade + pointsLevel) - pointsUtilisés) - CountPoint(int.Parse(ElemTB.Text));

                    PointsConsoTB.Text = "" + (((pointsGrade + pointsLevel)) - (pointsUtilisésElem + pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésHp));

                    pointsUtilisés = pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp;

                    ResultElemLabel.Text = "+" + CountElem(long.Parse(ElemTB.Text) + long.Parse(SLElemTB.Text) + long.Parse(SLGenTB.Text));
                }
                else
                {
                    ElemTB.Text = "0";
                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void HpTB_TextChanged(object sender, EventArgs e)
        {
            if (HpTB.Text == "")
            {
                HpTB.Text = "0";
            }
            try
            {
                if (int.Parse(HpTB.Text) >= 0 && int.Parse(HpTB.Text) <= 100)
                {
                   

                    pointsUtilisésHp = CountPointHp(int.Parse(HpTB.Text));//((pointsGrade + pointsLevel) - pointsUtilisés) - CountPoint(int.Parse(HpTB.Text));

                    PointsConsoTB.Text = "" + (((pointsGrade + pointsLevel)) - (pointsUtilisésHp + pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem));

                    pointsUtilisés = pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp;

                    ResultHpLabel.Text = "+" + CountHp(long.Parse(HpTB.Text) + long.Parse(SLHpTB.Text) + long.Parse(SLGenTB.Text));
                }
                else
                {
                    HpTB.Text = "0";
                }
            }
            catch (System.FormatException) { }

            CheckPotentielLabel.Text = "NOT READY";
        }

        private int CountPointAtk(int nbpoints)
        {
            int temp = nbpoints;
            int compteur = 0;

            if(temp >= 10)
            {
                temp -= 10;
                compteur += 10;

                if(temp >= 9)
                {
                    temp -= 9;
                    compteur += (9 * 2);

                    if(temp >= 20)
                    {
                        temp -= 20;
                        compteur += (20 * 3);

                        if(temp >= 20)
                        {
                            temp -= 20;
                            compteur += (20 * 4);

                            if (temp >= 20)
                            {
                                temp -= 20;
                                compteur += (20 * 5);

                                if (temp >= 11)
                                {
                                    temp -= 11;
                                    compteur += (11 * 6);

                                    if(temp >= 7)
                                    {
                                        temp -= 7;
                                        compteur += (7 * 7);

                                        if(temp >= 1)
                                        {
                                            temp -= 1;
                                            compteur += (1 * 8);

                                            if(temp >= 1)
                                            {
                                                temp -= 1;
                                                compteur += (1 * 9);

                                                if (temp >= 1)
                                                {
                                                    temp -= 1;
                                                    compteur += (1 * 10);
                                                }
                                                else
                                                {
                                                    if ((temp * 10) >= 0)
                                                    {
                                                        compteur += (temp * 10);
                                                        temp = 0;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if ((temp * 9) >= 0)
                                                {
                                                    compteur += (temp * 9);
                                                    temp = 0;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ((temp * 8) >= 0)
                                            {
                                                compteur += (temp * 8);
                                                temp = 0;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if ((temp * 7) >= 0)
                                        {
                                            compteur += (temp * 7);
                                            temp = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((temp * 6) >= 0)
                                    {
                                        compteur += (temp * 6);
                                        temp = 0;
                                    }
                                }
                            }
                            else
                            {
                                if ((temp * 5) >= 0)
                                {
                                    compteur += (temp * 5);
                                    temp = 0;
                                }
                            }
                        }
                        else
                        {
                            if ((temp * 4) >= 0)
                            {
                                compteur += (temp * 4);
                                temp = 0;
                            }
                        }
                    }
                    else
                    {
                        if ((temp * 3) >= 0)
                        {
                            compteur += (temp * 3);
                            temp = 0;
                        }
                    }
                }
                else
                {
                    if((temp * 2) >= 0)
                    {
                        compteur += (temp * 2);
                        temp = 0;
                    }
                   
                }

            }
            else
            {
                compteur += temp;
                temp = 0;
            }

            pointsRestant = temp;

            return compteur;
        }

        private int CountPointDef(int nbpoints)
        {
            int temp = nbpoints;

            if(temp <= 10)
            {
                return temp;
            }
            else if(temp <= 29)
            {
                return 10 + ((temp - 10) * 2);
            }
            else if (temp <= 40)
            {
                return 10 + 38 + ((temp - 29) * 3);
            }
            else if (temp <= 60)
            {
                return 10 + 38 + 33 + ((temp - 40) * 4);
            }
            else if (temp <= 75)
            {
                return 10 + 38 + 33 + 80 + ((temp - 60) * 5);
            }
            else if (temp <= 84)
            {
                return 10 + 38 + 33 + 80 + 75 +((temp - 75) * 6);
            }
            else if (temp <= 94)
            {
                return 10 + 38 + 33 + 80 + 75 + 54 + ((temp - 84) * 7);
            }
            else if (temp <= 99)
            {
                return 10 + 38 + 33 + 80 + 75 + 54 + 70 + ((temp - 94) * 8);
            }
            else if (temp == 100)
            {
                return 410;
            }

            return -1;
        }

        private int CountPointElem(int nbpoints)
        {
            int temp = nbpoints;

            if (temp <= 20)
            {
                return temp;
            }
            else if (temp <= 30)
            {
                return 20 + ((temp - 20) * 2);
            }
            else if (temp <= 40)
            {
                return 20 + 20 + ((temp - 30) * 3);
            }
            else if (temp <= 50)
            {
                return 20 + 20 + 30 + ((temp - 40) * 4);
            }
            else if (temp <= 70)
            {
                return 20 + 20 + 30 + 40 + ((temp - 50) * 5);
            }
            else if (temp <= 80)
            {
                return 20 + 20 + 30 + 40 + 100 + ((temp - 70) * 6);
            }
            else if (temp <= 100)
            {
                return 20 + 20 + 30 + 40 + 100 + 60 + ((temp - 80) * 7);
            }
           

            return -1;
        }

        private void PotentielButton_Click(object sender, EventArgs e)
        {
            if (CheckPotentielLabel.Text == "READY")
            {
                PotentielGUI win = new PotentielGUI(SPSelected, SLAtk, SLDef, SLElem, SLHp, SLGen, CountAtk(long.Parse(AtkTB.Text) + long.Parse(SLAtkTB.Text) + long.Parse(SLGenTB.Text)), CountDef(long.Parse(DefTB.Text) + long.Parse(SLDefTB.Text) + long.Parse(SLGenTB.Text)), CountElem(long.Parse(ElemTB.Text) + long.Parse(SLElemTB.Text) + long.Parse(SLGenTB.Text)), CountHp(long.Parse(HpTB.Text) + long.Parse(SLHpTB.Text) + long.Parse(SLGenTB.Text)));

                win.ShowDialog();
            }
        }

        private void Grade80plusTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(Grade80plusTB.Text) > 79 && int.Parse(Grade80plusTB.Text) <= 100)
                {
                    Grade80plusTB.ForeColor = Color.Black;
                }
                else
                {
                    Grade80plusTB.ForeColor = Color.Red;
                }
            }
            catch(FormatException) { Grade80plusTB.Text = "80"; }
            catch (ArgumentException) { }
            catch (OverflowException) { }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private int CountPointHp(int nbpoints)
        {
            int temp = nbpoints;

            if (temp <= 10)
            {
                return temp;
            }
            else if (temp <= 30)
            {
                return 10 + ((temp - 10) * 2);
            }
            else if (temp <= 50)
            {
                return 10 + 40 + ((temp - 30) * 3);
            }
            else if (temp <= 60)
            {
                return 10 + 40 + 60 + ((temp - 50) * 4);
            }
            else if (temp <= 70)
            {
                return 10 + 40 + 60 + 40 + ((temp - 60) * 5);
            }
            else if (temp <= 80)
            {
                return 10 + 40 + 60 + 40 + 50 + ((temp - 70) * 6);
            }
            else if (temp <= 90)
            {
                return 10 + 40 + 60 + 40 + 50 + 60 + ((temp - 80) * 7);
            }
            else if (temp <= 100)
            {
                return 10 + 40 + 60 + 40 + 50 + 60 + 70 + ((temp - 90) * 8);
            }

            return -1;
        }



        private long CountAtk(long nbpoints)
        {
            long temp = nbpoints;
            
            if (temp <= 10)
            {
                return temp * 5;
            }
            else if (temp <= 20)
            {
                return 50 + ((temp - 10) * 6);
            }
            else if (temp <= 30)
            {
                return 110 + ((temp - 20) * 7);
            }
            else if (temp <= 40)
            {
                return 180 + ((temp - 30) * 8);
            }
            else if (temp <= 50)
            {
                return 260 + ((temp - 40) * 9);
            }
            else if (temp <= 60)
            {
                return 350 + ((temp - 50) * 10);
            }
            else if(temp == 70)
            {
                return 450 + ((temp - 60) * 11);
            }
            else if (temp <= 80)
            {
                return 560 + ((temp - 70) * 13);
            }
            else if (temp <= 90)
            {
                return 690 + ((temp - 80) * 14);
            }
            else if (temp <= 94)
            {
                return 830 + ((temp - 93) * 15);
            }
            else if (temp == 95)
            {
                return 906;
            }
            else if (temp == 96)
            {
                return 923;
            }
            else if (temp == 97)
            {
                return 940;
            }
            else if (temp == 98)
            {
                return 960;
            }
            else if (temp == 99)
            {
                return 980;
            }
            else if (temp == 100)
            {
                return 1000;
            }
            
                return 1000 + (temp - 100);
            
        }

        private long CountDef(long nbpoints)
        {
            long temp = nbpoints;

            if (temp <= 10)
            {
                return temp;
            }
            else if(temp <= 20)
            {
                return 10 + ((temp - 10)*2);
            }
            else if(temp <= 30)
            {
                return 30 + ((temp - 20) * 3);
            }
            else if(temp <= 40)
            {
                return 60 +((temp - 30) * 4);
            }
            else if (temp <= 50)
            {
                return 100 + ((temp - 40) * 5);
            }
            else if (temp <= 60)
            {
                return 150 +((temp - 50) * 6);
            }
            else if (temp <= 70)
            {
                return 210 + ((temp - 60) * 7);
            }
            else if (temp <= 80)
            {
                return 280 + ((temp - 70) * 8);
            }
            else if (temp <= 90)
            {
                return 360 + ((temp - 80) * 9);
            }
            else if (temp <= 100)
            {
                return 450 + ((temp - 90) * 10);
            }
            else
            {
                return 550 + (temp - 100);
            }

        }

        private long CountHp(long nbpoints)
        {
            long temp = nbpoints;


            if (temp <= 50)
            {
                return temp;
            }
            else if(temp <= 100)
            {
                return 50 + ((temp - 50) * 2);
            }
            else
            {
                return 150 + (temp - 100);
            }
            
        }

        private long CountElem(long nbpoints)
        {
            long temp = nbpoints;

            if (temp <= 50)
            {
                return temp;
            }
            else if (temp <= 100)
            {
                return 50 + ((temp - 50) * 2);
            }
            else
            {
                return 150 + (temp - 100);
            }

        }

        private void NotifyTimer_Tick(object sender, EventArgs e)
        {
            NotifyTimer.Stop();
            MessagesPanel.Visible = false;
        }

        private void UpgradeSPButton_MouseHover(object sender, EventArgs e)
        {
            MessageLabel.Text = "Vous permet d'upgrader\nvotre SP !";
            MessagesPanel.Visible = true;
            NotifyTimer.Start();
        }

        private void LevelTB_TextChanged(object sender, EventArgs e)
        {

            if (LevelTB.Text == "")
            {
                LevelTB.Text = "1";
            }

            try
            {
                if (int.Parse(LevelTB.Text) > 0 && int.Parse(LevelTB.Text) < 100)
                {
                    if (int.Parse(LevelTB.Text) > 20)
                    {
                        if (int.Parse(LevelTB.Text) < 100)
                        {
                            pointsLevel = (int.Parse(LevelTB.Text) - 20) * 3;
                        }
                        else
                        {
                            LevelTB.Text = "";
                        }
                    }
                    else
                    {
                        pointsLevel = 0;
                    }
                }
                else
                {
                    LevelTB.Text = "1";
                }
            }
            catch (System.FormatException) { }
            PointsMaxLabel.Text = "/" + (pointsLevel + pointsGrade).ToString();
            //PointsConsoTB.Text = "" + ((pointsLevel + pointsGrade) - pointsRestant);

            PointsConsoTB.Text = "" + (((pointsGrade + pointsLevel)) - (pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem + pointsUtilisésHp));

            CheckPotentielLabel.Text = "NOT READY";
        }

        private void UpgradeSPButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (SPSelected != null)
            {
                if (ConfigSPPanel.Visible == false)
                {
                    SPUpgrade win = new SPUpgrade(SPSelected);

                    win.ShowDialog();

                    switch (win.status)
                    {
                        case 3:
                            MessageLabel.Text = "Votre SP est à son\nmaximum !";
                            break;
                        case 2:
                            MessageLabel.Text = "Votre SP a été modifiée !";
                            SPSelected.points = win.CheatGain.Value;
                            SPSelected.grade = win.CheatUpgrade.Value;
                            pointsGrade = win.CheatGain.Value;
                            PtsLabel.Text = pointsGrade.ToString();
                            GradeLabel.Text = "+" + win.CheatUpgrade.Value.ToString();
                            DeleteButton_Click(SPSelected.niveau, null);
                            break;
                        case 1:
                            MessageLabel.Text = "Echec !";
                            break;
                        case 0:
                            MessageLabel.Text = "Votre SP est détruite !";
                            break;
                        case -1:
                            SPSelected.grade -= 1;
                            GradeLabel.Text = "+" + SPSelected.grade;
                            MessageLabel.Text = "Votre SP a régressé !";
                            break;
                    }

                    if (win.CheatUpgrade == null)
                    {
                        SPSelected.points += win.gain;

                        pointsGrade += win.gain;

                        PtsLabel.Text = (int.Parse(PtsLabel.Text) + win.gain).ToString();
                    }

                    MessagesPanel.Visible = true;

                    NotifyTimer.Start();
                }
            }
            else
            {
                MessageLabel.Text = "Sélectionnez une SP\navant toute chose !";
                MessagesPanel.Visible = true;
                NotifyTimer.Start();
            }
        }

        private void FermerConfigButton_Click(object sender, EventArgs e)
        {
            ConfigSPPanel.Visible = false;
            LevelTB.Visible = false;
            Grade80plusTB.Visible = false;

            AtkTB.BackColor = SystemColors.HotTrack;
            DefTB.BackColor = SystemColors.HotTrack;
            ElemTB.BackColor = SystemColors.HotTrack;
            HpTB.BackColor = SystemColors.HotTrack;
        }

        private void RepartirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(LevelTB.Text) > 0 && int.Parse(LevelTB.Text) <= 100)
                {
                    
                    SPSelected.niveau = int.Parse(LevelTB.Text);
                    LvLabel.Text = SPSelected.niveau.ToString();

                    if ((int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text)) <= 200)
                    {

                        if (Grade80plusTB.ForeColor != Color.Red)
                        {
                            int amel = (int.Parse(BonusAtkTB.Text) + int.Parse(BonusDefTB.Text) + int.Parse(BonusElemTB.Text) + int.Parse(BonusHpTB.Text) + int.Parse(BonusResEauTB.Text) + int.Parse(BonusResFeuTB.Text) + int.Parse(BonusResLumTB.Text) + int.Parse(BonusResObsTB.Text));
                            AmelioLabel.Text = "+" + amel.ToString();
                            
                            SPSelected.bonusAttaque = int.Parse(BonusAtkTB.Text);
                            SPSelected.bonusDefense = int.Parse(BonusDefTB.Text);
                            SPSelected.bonusElement = int.Parse(BonusElemTB.Text);
                            SPSelected.bonusHp = int.Parse(BonusHpTB.Text);
                            SPSelected.bonusResEau = int.Parse(BonusResEauTB.Text);
                            SPSelected.bonusResFeu = int.Parse(BonusResFeuTB.Text);
                            SPSelected.bonusResLumiere = int.Parse(BonusResLumTB.Text);
                            SPSelected.bonusResObscure = int.Parse(BonusResObsTB.Text);

                            AmelioAtkLabel.Text = "+" + BonusAtkTB.Text;
                            AmelioDefLabel.Text = "+" + BonusDefTB.Text;
                            AmelioElemLabel.Text = "+" + BonusElemTB.Text;
                            AmelioHpLabel.Text = "+" + BonusHpTB.Text;
                            AmelioResEauLabel.Text = "+" + BonusResEauTB.Text;
                            AmelioResFeuLabel.Text = "+" + BonusResFeuTB.Text;
                            AmelioResLumLabel.Text = "+" + BonusResLumTB.Text;
                            AmelioResObsLabel.Text = "+" + BonusResObsTB.Text;

                            if (Grade80plusTB.Visible == true)
                            {
                                AmelioLabel.Text = "+" + Grade80plusTB.Text;

                                //Grade80plusTB.Visible = false;
                            }
                        }

                        //if((((pointsGrade + pointsLevel) - pointsUtilisés) - (pointsUtilisésHp + pointsUtilisésAtk + pointsUtilisésDef + pointsUtilisésElem)) > 0)
                        if (int.Parse(PointsConsoTB.Text) >= 0)
                        {
                            SPSelected.attaque = int.Parse(AtkTB.Text);
                            SPSelected.defense = int.Parse(DefTB.Text);
                            SPSelected.element = int.Parse(ElemTB.Text);
                            SPSelected.hp = int.Parse(HpTB.Text);


                            PtsLabel.Text = "" + ((pointsGrade + pointsLevel) - pointsUtilisés);

                            CheckPotentielLabel.Text = "READY";


                            AtkTB.BackColor = SystemColors.HotTrack;
                            DefTB.BackColor = SystemColors.HotTrack;
                            ElemTB.BackColor = SystemColors.HotTrack;
                            HpTB.BackColor = SystemColors.HotTrack;
                        }
                        else
                        {
                            AtkTB.BackColor = Color.Red;
                            DefTB.BackColor = Color.Red;
                            ElemTB.BackColor = Color.Red;
                            HpTB.BackColor = Color.Red;
                        }

                        SLAtk = int.Parse(SLAtkTB.Text);
                        SLDef = int.Parse(SLDefTB.Text);
                        SLElem = int.Parse(SLElemTB.Text);
                        SLHp = int.Parse(SLHpTB.Text);
                        SLGen = int.Parse(SLGenTB.Text);

                        AtkLabel.Text = "" + (SLAtk + SLGen + SPSelected.attaque);
                        DefLabel.Text = "" + (SLDef + SLGen + SPSelected.defense);
                        ElemLabel.Text = "" + (SLElem + SLGen + SPSelected.element);
                        HPLabel.Text = "" + (SLHp + SLGen + SPSelected.hp);

                            
                    }

                    
                    
                    
                }
            }
            catch (System.FormatException) { }

            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LevelTB.Text = SPSelected.niveau.ToString();

            AtkTB.Text = SPSelected.attaque.ToString();
            DefTB.Text = SPSelected.defense.ToString();
            ElemTB.Text = SPSelected.element.ToString();
            HpTB.Text = SPSelected.hp.ToString();
            BonusAtkTB.Text = SPSelected.bonusAttaque.ToString();
            BonusDefTB.Text = SPSelected.bonusDefense.ToString();
            BonusElemTB.Text = SPSelected.bonusElement.ToString();
            BonusHpTB.Text = SPSelected.bonusHp.ToString();
            BonusResEauTB.Text = SPSelected.bonusResEau.ToString();
            BonusResFeuTB.Text = SPSelected.bonusResFeu.ToString();
            BonusResLumTB.Text = SPSelected.bonusResLumiere.ToString();
            BonusResObsTB.Text = SPSelected.bonusResObscure.ToString();

            SLAtkTB.Text = SLAtk.ToString();
            SLDefTB.Text = SLDef.ToString();
            SLElemTB.Text = SLElem.ToString();
            SLHpTB.Text = SLHp.ToString();
            SLGenTB.Text = SLGen.ToString();

            AtkTB.BackColor = SystemColors.HotTrack;
            DefTB.BackColor = SystemColors.HotTrack;
            ElemTB.BackColor = SystemColors.HotTrack;
            HpTB.BackColor = SystemColors.HotTrack;
        }
    }
}
