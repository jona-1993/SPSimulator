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
    public partial class SPUpgrade : Form
    {
        public int status = 1;
        public int gain = 0;
        private SPCard carte;

        public SPUpgrade()
        {
            InitializeComponent();
        }

        public SPUpgrade(SPCard card)
        {
            InitializeComponent();

            if(card.grade < 5)
            {
                if (card.generation == 1)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.AmeVerte;
                }
                else if(card.generation == 2)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.PeauDragon;
                }
            }
            else if(card.grade < 10)
            {
                if (card.generation == 1)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.AmeRouge;
                }
                else if (card.generation == 2)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.SangDragon;
                }
            }
            else if(card.grade < 15)
            {
                if (card.generation == 1)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.AmeBleue;
                }
                else if (card.generation == 2)
                {
                    SpecialItemPB.BackgroundImage = SP_Simulator.Properties.Resources.CoeurDragon;
                }
            }

            switch(card.grade)
            {
                case 0:
                    PlumesLabel.Text = "3 p";
                    PLLabel.Text = "1 p";
                    SpecialItemLabel.Text = "2 p";
                    OrLabel.Text = "200.000";
                    SuccessLabel.Text = "80%";
                    EchecLabel.Text = "20%";
                    DestrLabel.Text = "0%";
                    break;
                case 1:
                    PlumesLabel.Text = "5 p";
                    PLLabel.Text = "3 p";
                    SpecialItemLabel.Text = "4 p";
                    OrLabel.Text = "200.000";
                    SuccessLabel.Text = "75%";
                    EchecLabel.Text = "25%";
                    DestrLabel.Text = "0%";
                    break;
                case 2:
                    PlumesLabel.Text = "8 p";
                    PLLabel.Text = "5 p";
                    SpecialItemLabel.Text = "6 p";
                    OrLabel.Text = "200.000";
                    SuccessLabel.Text = "70%";
                    EchecLabel.Text = "25%";
                    DestrLabel.Text = "5%";
                    break;
                case 3:
                    PlumesLabel.Text = "10 p";
                    PLLabel.Text = "7 p";
                    SpecialItemLabel.Text = "8 p";
                    OrLabel.Text = "200.000";
                    SuccessLabel.Text = "60%";
                    EchecLabel.Text = "30%";
                    DestrLabel.Text = "10%";
                    break;
                case 4:
                    PlumesLabel.Text = "15 p";
                    PLLabel.Text = "10 p";
                    SpecialItemLabel.Text = "10 p";
                    OrLabel.Text = "200.000";
                    SuccessLabel.Text = "50%";
                    EchecLabel.Text = "35%";
                    DestrLabel.Text = "15%";
                    break;
                case 5:
                    PlumesLabel.Text = "20 p";
                    PLLabel.Text = "12 p";
                    SpecialItemLabel.Text = "1 p";
                    OrLabel.Text = "500.000";
                    SuccessLabel.Text = "40%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "20%";
                    break;
                case 6:
                    PlumesLabel.Text = "25 p";
                    PLLabel.Text = "14 p";
                    SpecialItemLabel.Text = "2 p";
                    OrLabel.Text = "500.000";
                    SuccessLabel.Text = "35%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "25%";
                    break;
                case 7:
                    PlumesLabel.Text = "30 p";
                    PLLabel.Text = "16 p";
                    SpecialItemLabel.Text = "3 p";
                    OrLabel.Text = "500.000";
                    SuccessLabel.Text = "30%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "30%";
                    break;
                case 8:
                    PlumesLabel.Text = "35 p";
                    PLLabel.Text = "18 p";
                    SpecialItemLabel.Text = "5 p";
                    OrLabel.Text = "500.000";
                    SuccessLabel.Text = "25%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "35%";
                    break;
                case 9:
                    PlumesLabel.Text = "40 p";
                    PLLabel.Text = "20 p";
                    SpecialItemLabel.Text = "5 p";
                    OrLabel.Text = "500.000";
                    SuccessLabel.Text = "20%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "40%";
                    break;
                case 10:
                    PlumesLabel.Text = "45 p";
                    PLLabel.Text = "22 p";
                    SpecialItemLabel.Text = "1 p";
                    OrLabel.Text = "1.000.000";
                    SuccessLabel.Text = "10%";
                    EchecLabel.Text = "45%";
                    DestrLabel.Text = "45%";
                    break;
                case 11:
                    PlumesLabel.Text = "50 p";
                    PLLabel.Text = "24 p";
                    SpecialItemLabel.Text = "2 p";
                    OrLabel.Text = "1.000.000";
                    SuccessLabel.Text = "7%";
                    EchecLabel.Text = "43%";
                    DestrLabel.Text = "50%";
                    break;
                case 12:
                    PlumesLabel.Text = "55 p";
                    PLLabel.Text = "26 p";
                    SpecialItemLabel.Text = "3 p";
                    OrLabel.Text = "1.000.000";
                    SuccessLabel.Text = "5%";
                    EchecLabel.Text = "40%";
                    DestrLabel.Text = "55%";
                    break;
                case 13:
                    PlumesLabel.Text = "60 p";
                    PLLabel.Text = "28 p";
                    SpecialItemLabel.Text = "4 p";
                    OrLabel.Text = "1.000.000";
                    SuccessLabel.Text = "3%";
                    EchecLabel.Text = "37%";
                    DestrLabel.Text = "60%";
                    break;
                case 14:
                    PlumesLabel.Text = "70 p";
                    PLLabel.Text = "30 p";
                    SpecialItemLabel.Text = "5 p";
                    OrLabel.Text = "1.000.000";
                    SuccessLabel.Text = "1%";
                    EchecLabel.Text = "29%";
                    DestrLabel.Text = "70%";
                    break;
                default:
                    PlumesLabel.Text = "INF p";
                    PLLabel.Text = "INF p";
                    SpecialItemLabel.Text = "INF p";
                    OrLabel.Text = "INF";
                    SuccessLabel.Text = "-%";
                    EchecLabel.Text = "-%";
                    DestrLabel.Text = "-%";
                    break;
            }

            carte = card;
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

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SPUpgrade_Load(object sender, EventArgs e)
        {

        }

        private void AmeliorerButton_Click(object sender, EventArgs e)
        {
            if (CheatButton.Text == "Triche OFF")
            {
                Random rand = new Random();

                int random_int = rand.Next(1, 100);

                switch (carte.grade)
                {
                    case 0:
                        if (random_int <= 80)
                        {
                            status = 2;
                            gain = 5;
                        }
                        break;
                    case 1:
                        if (random_int <= 75)
                        {
                            status = 2;
                            gain = 5;
                        }
                        break;
                    case 2:
                        if (random_int <= 70)
                        {
                            status = 2;
                            gain = 5;
                        }
                        else if (random_int <= 75)
                        {
                            status = 0;
                        }
                        break;
                    case 3:
                        if (random_int <= 60)
                        {
                            status = 2;
                            gain = 5;
                        }
                        else if (random_int <= 70)
                        {
                            status = 0;
                        }
                        break;
                    case 4:
                        if (random_int <= 50)
                        {
                            status = 2;
                            gain = 8;
                        }
                        else if (random_int <= 65)
                        {
                            status = 0;
                        }
                        break;
                    case 5:
                        if (random_int <= 40)
                        {
                            status = 2;
                            gain = 8;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 6:
                        if (random_int <= 35)
                        {
                            status = 2;
                            gain = 10;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 7:
                        if (random_int <= 30)
                        {
                            status = 2;
                            gain = 10;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 8:
                        if (random_int <= 25)
                        {
                            status = 2;
                            gain = 12;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 9:
                        if (random_int <= 20)
                        {
                            status = 2;
                            gain = 12;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 10:
                        if (random_int <= 10)
                        {
                            status = 2;
                            gain = 15;
                        }
                        else if (random_int <= 55)
                        {
                            status = 0;
                        }
                        break;
                    case 11:
                        if (random_int <= 7)
                        {
                            status = 2;
                            gain = 15;
                        }
                        else if (random_int <= 57)
                        {
                            status = 0;
                        }
                        break;
                    case 12:
                        if (random_int <= 5)
                        {
                            status = 2;
                            gain = 18;
                        }
                        else if (random_int <= 60)
                        {
                            status = 0;
                        }
                        break;
                    case 13:
                        if (random_int <= 3)
                        {
                            status = 2;
                            gain = 20;
                        }
                        else if (random_int <= 63)
                        {
                            status = 0;
                        }
                        break;
                    case 14:
                        if (random_int <= 1)
                        {
                            status = 2;
                            gain = 25;
                        }
                        else if (random_int <= 71)
                        {
                            status = 0;
                        }
                        break;
                    default:
                        status = 3;
                        break;
                }
            }
            else
            {
                if (carte.grade != 15)
                {
                    status = 2;

                   if(carte.grade < 4)
                    {
                        gain = 5;
                    }
                   else if(carte.grade < 6)
                    {
                        gain = 8;
                    }
                    else if (carte.grade < 8)
                    {
                        gain = 10;
                    }
                    else if (carte.grade < 10)
                    {
                        gain = 12;
                    }
                    else if (carte.grade < 12)
                    {
                        gain = 15;
                    }
                    else if (carte.grade == 12)
                    {
                        gain = 18;
                    }
                    else if (carte.grade == 13)
                    {
                        gain = 20;
                    }
                    else if (carte.grade == 14)
                    {
                        gain = 25;
                    }

                }
                else
                {
                    status = 3;
                }
            }
           
            Close();
        }

        private void CheatButton_Click(object sender, EventArgs e)
        {
            if (CheatButton.Text == "Triche OFF")
            {
                CheatButton.Text = "Triche ON";
            }
            else
            {
                CheatButton.Text = "Triche OFF";
            }
        }

        private void DowngradeButton_Click(object sender, EventArgs e)
        {
            if (carte.grade != 0)
            {
                status = -1;

                if (carte.grade < 5)
                {
                    gain = -5;
                }
                else if (carte.grade < 7)
                {
                    gain = -8;
                }
                else if (carte.grade < 9)
                {
                    gain = -10;
                }
                else if (carte.grade < 11)
                {
                    gain = -12;
                }
                else if (carte.grade < 13)
                {
                    gain = -15;
                }
                else if (carte.grade == 13)
                {
                    gain = -18;
                }
                else if (carte.grade == 14)
                {
                    gain = -20;
                }
                else if (carte.grade == 15)
                {
                    gain = -25;
                }

                Close();
            }
        }
    }
}
