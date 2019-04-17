using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA_KOSTKI_v2
{
    public partial class MainBoard : Form
    {


        public MainBoard(string nauka)
        {

            InitializeComponent();
            button16.Select();
            if (nauka == "TAK")
            {
                toolTip1.Active = true;
                rad_TAK.BackColor = Color.Orange;
                rad_TAK.Enabled = false;
            }
            else if (nauka == "NIE")
            {
                toolTip1.Active = false;
                rad_NIE.BackColor = Color.Orange;
                rad_NIE.Enabled = false;
            }
            else if (nauka == "TEST")
            {
                toolTip1.Active = false;
                rad_NIE.BackColor = Color.Orange;
                rad_NIE.Enabled = false;

            }

            TBnauka.Text = nauka;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)  // PRZYPISANIE KLAWISZA
        {
            if (pictureBox1.Visible == true)
            {
                if (keyData == (Keys.Q))
                {

                    button16.BackColor = Color.Yellow;
                    button31.BackColor = Color.BurlyWood;
                    button31.Enabled = false;
                    button16.Select();
                    button16.PerformClick();
                    button31.Enabled = true;
                    return true;
                }
            }
            else
            {
                if (keyData == (Keys.Q))
                {
                    button20.BackColor = Color.Yellow;
                    button27.BackColor = Color.BurlyWood;
                    button27.Enabled = false;
                    button20.Select();
                    button20.PerformClick();
                    button27.Enabled = true;
                    return true;
                }
            }
            if (pictureBox1.Visible == true)
            {
                if (keyData == (Keys.W))
                {
                    button31.BackColor = Color.Yellow;
                    button16.BackColor = Color.BurlyWood;
                    button16.Enabled = false;
                    button31.Select();
                    button31.PerformClick();
                    button16.Enabled = true;
                    return true;
                }
            }
            else
            {
                if (keyData == (Keys.W))
                {
                    button27.BackColor = Color.Yellow;
                    button20.BackColor = Color.BurlyWood;
                    button20.Enabled = false;
                    button27.Select();
                    button27.PerformClick();
                    button20.Enabled = true;
                    return true;
                }
            }
            if (pictureBox1.Visible == true)
            {
                if (keyData == (Keys.A))
                {
                    button_zbieraj.BackColor = Color.Yellow;
                    but_p_niezebrane.BackColor = Color.BurlyWood;
                    button_zbierzWszystkie.BackColor = Color.BurlyWood;
                    button_zbieraj.Select();
                    button_zbieraj.PerformClick();
                    return true;
                }
            }
            else
            {
                if (keyData == (Keys.A))
                {
                    but_zbieraj2.BackColor = Color.Yellow;
                    p_niezebrane2.BackColor = Color.BurlyWood;
                    but_zbierz_pozostale2.BackColor = Color.BurlyWood;
                    but_zbieraj2.Select();
                    but_zbieraj2.PerformClick();
                    return true;
                }
            }
            if (pictureBox1.Visible == true)
            {
                if (keyData == (Keys.S))
                {
                    but_p_niezebrane.BackColor = Color.Yellow;
                    button_zbieraj.BackColor = Color.BurlyWood;
                    button_zbierzWszystkie.BackColor = Color.BurlyWood;
                    button_zbieraj.Enabled = false;
                    button_zbierzWszystkie.Enabled = false;
                    but_p_niezebrane.Select();
                    but_p_niezebrane.PerformClick();
                    button_zbieraj.Enabled = true;
                    button_zbierzWszystkie.Enabled = true;

                    return true;
                }
            }
            else
            {
                if (keyData == (Keys.S))
                {
                    p_niezebrane2.BackColor = Color.Yellow;
                    but_zbieraj2.BackColor = Color.BurlyWood;
                    but_zbierz_pozostale2.BackColor = Color.BurlyWood;
                    but_zbieraj2.Enabled = false;
                    but_zbierz_pozostale2.Enabled = false;
                    p_niezebrane2.Select();
                    p_niezebrane2.PerformClick();
                    but_zbieraj2.Enabled = true;
                    but_zbierz_pozostale2.Enabled = true;
                    return true;
                }
            }
            if (pictureBox1.Visible == true)
            {
                if (keyData == (Keys.Z))
                {
                    button_zbierzWszystkie.BackColor = Color.Yellow;
                    button_zbieraj.BackColor = Color.BurlyWood;
                    but_p_niezebrane.BackColor = Color.BurlyWood;
                    button_zbierzWszystkie.Select();
                    button_zbierzWszystkie.PerformClick();
                    return true;
                }
            }
            else
            {
                if (keyData == (Keys.Z))
                {
                    but_zbierz_pozostale2.BackColor = Color.Yellow;
                    but_zbieraj2.BackColor = Color.BurlyWood;
                    p_niezebrane2.BackColor = Color.BurlyWood;
                    but_zbierz_pozostale2.Select();
                    but_zbierz_pozostale2.PerformClick();
                    return true;
                }
            }
            if (pictureBox1.Visible == true)
            {
                if (button13.Enabled == true)
                {
                    if (keyData == (Keys.X))
                    {
                        button13.BackColor = Color.Yellow;
                        button13.Select();
                        button13.PerformClick();
                        return true;
                    }
                }

            }
            else
            {
                if (ZAKONCZ_2.Enabled == true)
                {
                    if (keyData == (Keys.X))
                    {
                        ZAKONCZ_2.BackColor = Color.Yellow;
                        ZAKONCZ_2.Select();
                        ZAKONCZ_2.PerformClick();
                        return true;
                    }
                }
            }


            if (this.ActiveControl.Name == "button16")
            {
                if ((keyData == (Keys.Up)) || (keyData == (Keys.Down)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button31.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button16.BackColor = Color.Yellow;
                    button16.PerformClick();
                    return true;
                }


            }
            if (this.ActiveControl.Name == "button31")
            {
                if ((keyData == (Keys.Up)) || (keyData == (Keys.Down)) || (keyData == (Keys.Right)))
                {
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    button16.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button31.BackColor = Color.Yellow;
                    button31.PerformClick();

                    return true;
                }
            }
            if (this.ActiveControl.Name == "button_zbieraj")
            {
                if ((keyData == (Keys.Left)) || (keyData == (Keys.Up)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button_zbierzWszystkie.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    but_p_niezebrane.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button_zbieraj.BackColor = Color.Yellow;
                    button_zbieraj.PerformClick();
                    return true;
                }

            }
            if (this.ActiveControl.Name == "but_p_niezebrane")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Up)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button_zbierzWszystkie.Select();
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    button_zbieraj.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    but_p_niezebrane.BackColor = Color.Yellow;
                    but_p_niezebrane.PerformClick();
                    return true;
                }

            }
            if (this.ActiveControl.Name == "button_zbierzWszystkie")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button_zbieraj.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button_zbierzWszystkie.BackColor = Color.Yellow;
                    button_zbierzWszystkie.PerformClick();
                    return true;
                }

            }

            if ((this.ActiveControl.Name == "button13") && (button6.Enabled == false))
            {
                if ((keyData == (Keys.Down)) || (keyData == (Keys.Right)))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {

                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    if (ULEPSZENIA_MANA1.Enabled == true)
                    {
                        ULEPSZENIA_MANA1.Select();
                    }
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button13.BackColor = Color.Yellow;
                    button13.PerformClick();
                    return true;
                }

            }

            if ((this.ActiveControl.Name == "button13") && (button6.Enabled == true))
            {
                if ((keyData == (Keys.Down)) || (keyData == (Keys.Right)))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button6.Select();
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    if (ULEPSZENIA_MANA1.Enabled == true)
                    {
                        ULEPSZENIA_MANA1.Select();
                    }
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button13.BackColor = Color.Yellow;
                    button13.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "ULEPSZENIA_MANA1")
            {
                if ((keyData == (Keys.Down)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button13.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    ULEPSZENIA_MANA1.BackColor = Color.Yellow;
                    ULEPSZENIA_MANA1.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button3")
            {
                if (keyData == (Keys.Right))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button22.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button4.Select();
                        return true;
                    }
                    else
                    {
                        button6.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button9.Select();
                        return true;
                    }
                    else
                    {
                        button9.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    button3.BackColor = Color.Yellow;
                    button3.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button9")
            {
                if (keyData == (Keys.Right))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button22.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button3.Select();
                        return true;
                    }
                    else
                    {
                        button3.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button4.Select();
                        return true;
                    }
                    else
                    {
                        button4.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    button9.BackColor = Color.Yellow;
                    button9.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button4")
            {
                if (keyData == (Keys.Right))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button22.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button9.Select();
                        return true;
                    }
                    else
                    {
                        button9.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button3.Select();
                        return true;
                    }
                    else
                    {
                        button5.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    button4.BackColor = Color.Yellow;
                    button4.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button5")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button4.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button6.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button5.BackColor = Color.Yellow;
                    button5.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button6")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button5.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button13.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button6.BackColor = Color.Yellow;
                    button6.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button20")
            {
                if ((keyData == (Keys.Up)) || (keyData == (Keys.Down)))
                {
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button27.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button20.BackColor = Color.Yellow;
                    button20.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button27")
            {
                if ((keyData == (Keys.Up)) || (keyData == (Keys.Down)))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    button20.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button27.BackColor = Color.Yellow;
                    button27.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "but_zbieraj2") //GO
            {
                if ((keyData == (Keys.Left)) || (keyData == (Keys.Up)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    but_zbierz_pozostale2.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    p_niezebrane2.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    but_zbieraj2.BackColor = Color.Yellow;
                    but_zbieraj2.PerformClick();
                    return true;
                }

            }
            if (this.ActiveControl.Name == "p_niezebrane2")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Up)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    but_zbierz_pozostale2.Select();
                    return true;
                }
                if (keyData == (Keys.Left))
                {
                    but_zbieraj2.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    p_niezebrane2.BackColor = Color.Yellow;
                    p_niezebrane2.PerformClick();
                    return true;
                }

            }
            if (this.ActiveControl.Name == "but_zbierz_pozostale2")
            {
                if ((keyData == (Keys.Right)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    but_zbieraj2.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    but_zbierz_pozostale2.BackColor = Color.Yellow;
                    but_zbierz_pozostale2.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button22")
            {
                if (keyData == (Keys.Right))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        return true;
                    }
                    else
                    {
                        button8.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Left))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button3.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Up))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button21.Select();
                        return true;
                    }
                    else
                    {
                        button2.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button21.Select();
                        return true;
                    }
                    else
                    {
                        button21.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    button22.BackColor = Color.Yellow;
                    button22.PerformClick();
                    return true;
                }

            }

            if (this.ActiveControl.Name == "button21")
            {
                if (keyData == (Keys.Right))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        return true;
                    }
                    else
                    {
                        button8.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Left))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button3.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Up))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button22.Select();
                        return true;
                    }
                    else
                    {
                        button22.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    if (ActiveControl.Text == "50%")
                    {
                        button22.Select();
                        return true;
                    }
                    else
                    {
                        button18.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    button21.BackColor = Color.Yellow;
                    button21.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button18")
            {
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    if (button17.Enabled == true)
                    {
                        button17.Select();
                        return true;
                    }
                    else
                    {
                        button1.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Up))
                {
                    button21.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button18.BackColor = Color.Yellow;
                    button18.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button17")
            {
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button1.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button18.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button17.BackColor = Color.Yellow;
                    button17.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button1")
            {
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button2.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    if (button17.Enabled == true)
                    {
                        button17.Select();
                        return true;
                    }
                    else
                    {
                        button18.Select();
                        return true;
                    }


                }
                if (keyData == (Keys.Enter))
                {
                    button1.BackColor = Color.Yellow;
                    button1.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button2")
            {
                if (keyData == (Keys.Left))
                {
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    ZAKONCZ_2.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button1.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button2.BackColor = Color.Yellow;
                    button2.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button8")
            {
                if (keyData == (Keys.Left))
                {
                    button22.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button11.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    BUDUJ.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button8.BackColor = Color.Yellow;
                    button8.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button11")
            {
                if (keyData == (Keys.Left))
                {
                    button22.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button7.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button11.BackColor = Color.Yellow;
                    button11.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "button7")
            {
                if (keyData == (Keys.Left))
                {
                    button2.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    BUDUJ.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button11.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    button7.BackColor = Color.Yellow;
                    button7.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "BUDUJ")
            {
                if (keyData == (Keys.Left))
                {
                    button2.Select();
                    return true;
                }
                if (keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button8.Select();
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button7.Select();
                    return true;
                }
                if (keyData == (Keys.Enter))
                {
                    BUDUJ.BackColor = Color.Yellow;
                    BUDUJ.PerformClick();
                    return true;
                }
            }

            if (this.ActiveControl.Name == "ZAKONCZ_2")
            {
                if (keyData == (Keys.Left))
                {
                    if (ULEPSZENIA_MANA2.Enabled == true)
                    {
                        ULEPSZENIA_MANA2.Select();
                        return true;
                    }

                }
                if (keyData == (Keys.Right))
                {
                    if (button2.Enabled == true)
                    {
                        BUDUJ.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Down))
                {
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    if (button2.Enabled == true)
                    {
                        button2.Select();
                        return true;
                    }
                    else
                    {
                        return true;
                    }

                }
                if (keyData == (Keys.Enter))
                {
                    ZAKONCZ_2.BackColor = Color.Yellow;
                    ZAKONCZ_2.PerformClick();
                    return true;
                }
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }


        decimal[] zasoby1 = new decimal[6];
        decimal[] ulepszenia1 = new decimal[18];
        decimal drwale_akacja;
        decimal drwale_zurzyte;
        decimal przyrost_n_drwali;
        decimal drewno;
        decimal technologia_farmy;
        decimal ul_las_1;
        decimal ul_las_2;
        decimal ul_las_3;
        decimal ul_las_4;
        decimal ul_las_5;
        decimal ul_las_6;
        decimal ul_las_7;
        decimal ul_las_8;
        decimal ul_las_9;
        decimal ul_las_10;
        decimal ul_las_11;
        decimal ul_las_12;
        decimal ul_las_13;
        decimal ul_las_14;
        decimal ul_las_15;
        decimal ul_las_16;
        decimal ul_las_17;
        decimal ul_las_18;
        decimal ul_las_19;
        decimal ul_las_20;
        decimal ul_las_21;
        decimal ul_las_22;
        decimal ul_las_23;
        decimal budowla_ile_zbudowano;
        decimal budowla_ile_trzeba_zbudowac;
        int rozmiar_kostek = 40;
        int ile_jedzenia_zebrano_w_sumie;




        public void PORAZKA() // PORAZKA
        {
            Hide();
            LossGame form3 = new LossGame();
            form3.Show();

        }



        /* public void RANKING()
        {
            PICTURE_WIN.Visible = true;
            
            this.PICTURE_WIN.Location = new System.Drawing.Point(50, 50);
            this.PICTURE_WIN.Name = "PICTURE_WIN";
            this.PICTURE_WIN.Size = new System.Drawing.Size(260, 320);

            decimal value = decimal.Parse(textBox43.Text);
            value = Math.Floor(value / 1000);

            switch (value)
            {
                case 1:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN1;
                    break;

                case 2:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN2;
                    break;
                case 3:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN3;
                    break;
                case 4:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN4;
                    break;
                case 5:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 6:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 7:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 8:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 9:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 10:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 11:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
                case 12:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;


                default:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN1;
                    break;
            }
        }
        */

        public void Info() // INFO
        {
            MessageBox.Show("Brak zasobów");
        }





        public void KONIEC_RUNDY() // KONIEC RUNDY
        {
            TB_RUNDA.Text = (int.Parse(TB_RUNDA.Text) + 1).ToString();

            if (int.Parse(TB_RUNDA.Text) <= 50)
            {
                ustaw_początek_rundy();
            }


            if (int.Parse(TB_RUNDA.Text) < 51)
            {
                if (int.Parse(textBox10.Text) < 100)
                {
                    using (var newFrm = new NewDay(TB_RUNDA.Text, TB_U6.Text, TB_U12.Text, TB_U9.Text, textBox29.Text))
                    {
                        newFrm.ShowDialog();  // execution of Form1 stops until Form2 is closed
                    }
                    groupBox1.Visible = true;
                }
            }
        }

        public void Pobierz_all()
        {
            pobierz_tablice_zasoby1();
            pobierz_tablice_ulepszenia1();
            pobierz_dane_las();
        }

        public void wypluj_all()
        {
            wypluj_dane_las();
            wypluj_tablice_ulepszenia1();
            wypluj_tablice_zasoby1();
        }


        public void ustaw_początek_rundy()
        {
            TB1.Text = TB_U6.Text;
            ULEPSZENIA_MANA1.Enabled = false;
            ULEPSZENIA_MANA2.Enabled = false;
            but_p_niezebrane.Enabled = false;
            p_niezebrane2.Enabled = false;


            TB3.Text = (int.Parse(TB3.Text) + int.Parse(TB_U9.Text)).ToString();


            textBox24.Text = TB_U12.Text;
            textBox10.Text = (int.Parse(textBox10.Text) + (int.Parse(textBox29.Text))).ToString();
            //TB3.Text = (int.Parse(TB3.Text) + (int.Parse(textBox29.Text))).ToString();
            textBox23.Text = "0";
            TB2.Text = "0";
            //  textBox31.Text = TB_RUNDA.Text;


            int value = int.Parse(TB_RUNDA.Text);
            switch (value)
            {
                case 10:
                    MessageBox.Show("O Panie ! Minęło już 10 dni, jak idą postępy ?");
                    break;

                case 25:
                    MessageBox.Show("Panie minęło już 25 dni, czy to oznacza że połowa budowli powinna być już skończona ?");
                    break;
                case 40:
                    MessageBox.Show("Panie minęło już 40 dni nie pozostało już nic innego jak wziąć się w końcu do roboty !");
                    break;
                case 50:
                    MessageBox.Show("Panie dziś mija 50 dzień, lepiej skończmy dziś tą budowę bo w nocy możemy spodziewać się ataku smoka !");
                    break;



                default:

                    break;
            }

        }



        public void pobierz_tablice_zasoby1()
        {
            for (int i = 1; i < zasoby1.Length + 1; i++)
            {
                var txts = this.Controls.Find("TB" + i, true);
                foreach (TextBox ustaw_txt in txts)
                    zasoby1[i - 1] = int.Parse(ustaw_txt.Text);
            }
        }

        public void pobierz_tablice_ulepszenia1()
        {
            for (int i = 0; i < ulepszenia1.Length; i++)
            {
                var txts = this.Controls.Find("TB_U" + i, true);
                foreach (TextBox ustaw_txt2 in txts)
                    ulepszenia1[i] = decimal.Parse(ustaw_txt2.Text);
            }
        }

        public void pobierz_dane_las()
        {
            drwale_akacja = Convert.ToDecimal(textBox24.Text);
            drwale_zurzyte = Convert.ToDecimal(textBox23.Text);
            przyrost_n_drwali = Convert.ToDecimal(textBox22.Text);
            drewno = Convert.ToDecimal(textBox19.Text);
            technologia_farmy = Convert.ToDecimal(textBox8.Text);
            ul_las_1 = Convert.ToDecimal(textBox15.Text);
            ul_las_2 = Convert.ToDecimal(textBox14.Text);
            ul_las_3 = Convert.ToDecimal(textBox13.Text);
            ul_las_4 = Convert.ToDecimal(textBox18.Text);
            ul_las_5 = Convert.ToDecimal(textBox12.Text);
            ul_las_6 = Convert.ToDecimal(textBox11.Text);
            ul_las_7 = Convert.ToDecimal(textBox6.Text);
            ul_las_8 = Convert.ToDecimal(textBox5.Text);
            ul_las_9 = Convert.ToDecimal(textBox3.Text);
            ul_las_10 = Convert.ToInt32(textBox4.Text);
            ul_las_11 = Convert.ToInt32(textBox2.Text);
            ul_las_12 = Convert.ToInt32(textBox1.Text);
            ul_las_13 = Convert.ToDecimal(textBox20.Text);
            ul_las_14 = Convert.ToDecimal(textBox17.Text);
            ul_las_15 = Convert.ToDecimal(textBox16.Text);
            ul_las_16 = Convert.ToInt32(textBox26.Text);
            ul_las_17 = Convert.ToInt32(textBox25.Text);
            ul_las_18 = Convert.ToInt32(textBox21.Text);
            ul_las_19 = Convert.ToInt32(textBox29.Text);
            ul_las_20 = Convert.ToInt32(textBox28.Text);
            ul_las_21 = Convert.ToInt32(textBox27.Text);
            ul_las_22 = Convert.ToInt32(textBox10.Text);
            ul_las_23 = Convert.ToInt32(textBox9.Text);
            budowla_ile_zbudowano = Convert.ToInt32(textBox10.Text);
            budowla_ile_trzeba_zbudowac = Convert.ToInt32(textBox9.Text);
        }


        public void wypluj_tablice_zasoby1()
        {
            for (int i = 1; i < zasoby1.Length + 1; i++)
            {
                var txts = this.Controls.Find("TB" + i, true);
                foreach (TextBox ustaw_txt in txts)
                    ustaw_txt.Text = zasoby1[i - 1].ToString();
            }
        }


        public void wypluj_tablice_ulepszenia1()
        {
            for (int i = 0; i < ulepszenia1.Length; i++)
            {
                var txts = this.Controls.Find("TB_U" + i, true);
                foreach (TextBox ustaw_txt in txts)
                    ustaw_txt.Text = ulepszenia1[i].ToString();
            }
        }

        public void wypluj_dane_las()
        {
            textBox24.Text = drwale_akacja.ToString();
            textBox23.Text = drwale_zurzyte.ToString();
            textBox22.Text = przyrost_n_drwali.ToString();
            textBox19.Text = drewno.ToString();
            textBox8.Text = technologia_farmy.ToString();
            textBox15.Text = ul_las_1.ToString();
            textBox14.Text = ul_las_2.ToString();
            textBox13.Text = ul_las_3.ToString();
            textBox18.Text = ul_las_4.ToString();
            textBox12.Text = ul_las_5.ToString();
            textBox11.Text = ul_las_6.ToString();
            textBox6.Text = ul_las_7.ToString();
            textBox5.Text = ul_las_8.ToString();
            textBox3.Text = ul_las_9.ToString();
            textBox4.Text = ul_las_10.ToString();
            textBox2.Text = ul_las_11.ToString();
            textBox1.Text = ul_las_12.ToString();
            textBox20.Text = ul_las_13.ToString();
            textBox17.Text = ul_las_14.ToString();
            textBox16.Text = ul_las_15.ToString();
            textBox26.Text = ul_las_16.ToString();
            textBox25.Text = ul_las_17.ToString();
            textBox21.Text = ul_las_18.ToString();
            textBox29.Text = ul_las_19.ToString();
            textBox28.Text = ul_las_20.ToString();
            textBox27.Text = ul_las_21.ToString();
            textBox10.Text = ul_las_22.ToString();
            textBox9.Text = ul_las_23.ToString();

            textBox10.Text = budowla_ile_zbudowano.ToString();
            textBox9.Text = budowla_ile_trzeba_zbudowac.ToString();
        }


        public void Rzuć_kostki() // RZUĆ KOSTKI
        {
            flowLayoutPanel1.SuspendLayout();
            pobierz_tablice_zasoby1();
            pobierz_tablice_ulepszenia1();

            flowLayoutPanel1.Controls.Clear();
            decimal[] kostki1 = new decimal[int.Parse(TB_U0.Text)];
            Random rnd = new Random();


            for (int i = 0; i < ulepszenia1[0]; i++)
            {
                kostki1[i] = rnd.Next(1, int.Parse(TB_U3.Text) + 1);
            }

            Array.Sort(kostki1);
            Array.Reverse(kostki1);

            for (int i = 0; i < ulepszenia1[0]; i++)
            {

                Button btn = new Button();

                btn.Name = "btn" + i;
                btn.Size = new Size(rozmiar_kostek, rozmiar_kostek);

                btn.Text = kostki1[i].ToString();

                if (i < zasoby1[0])
                {
                    btn.BackColor = Color.GreenYellow;
                    TB_ile_do_zebrania.Text = (int.Parse(TB_ile_do_zebrania.Text) + (int.Parse(btn.Text) * int.Parse(TB_MNOZNIK_JEDZENIA.Text))).ToString();

                }
                else
                {
                    btn.BackColor = Color.Red;
                }



                btn.Click += Zbieraj_jedzenie;

                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.Controls.Add(btn);

                wypluj_tablice_zasoby1();
                wypluj_tablice_ulepszenia1();
                flowLayoutPanel1.ResumeLayout();
            }
        }



        public void Rzuć_kostki2()
        {
            pobierz_dane_las();
            flowLayoutPanel2.Controls.Clear();
            decimal[] kostki2 = new decimal[int.Parse(textBox15.Text)];

            Random rnd = new Random();

            for (int i = 0; i < ul_las_1; i++)
            {
                kostki2[i] = rnd.Next(1, int.Parse(textBox18.Text) + 1);
            }

            Array.Sort(kostki2);
            Array.Reverse(kostki2);

            for (int i = 0; i < ul_las_1; i++)
            {

                Button btnlas = new Button();
                btnlas.Text = kostki2[i].ToString();

                if (i < drwale_akacja)
                {
                    btnlas.BackColor = Color.GreenYellow;

                    TB_ILE_Drewna.Text = (int.Parse(TB_ILE_Drewna.Text) + (int.Parse(btnlas.Text) * int.Parse(textBox8.Text))).ToString();
                }
                else
                {
                    btnlas.BackColor = Color.Red;
                }


                btnlas.Name = "btnlas" + i;
                btnlas.Size = new Size(rozmiar_kostek, rozmiar_kostek);

                btnlas.Click += zbieraj_drewno; ;

                flowLayoutPanel2.Controls.Add(btnlas);
            }
        }

        private void zbieraj_drewno(object sender, EventArgs e) //KLIKNIECIE KOSTKI DREWNO
        {

        }

        private void Zbieraj_jedzenie(object sender, EventArgs e) //KLIKNIECIE KOSTKI JEDZENIE
        {

        }


        private void button11_Click(object sender, EventArgs e) // BUTTON PRZERZUĆ WSZYSTKIE
        {

        }

        private void button7_Click(object sender, EventArgs e) //BUTTON ZBIERZ WSZYSTKIE
        {
            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));

            pobierz_tablice_zasoby1();
            pobierz_tablice_ulepszenia1();
            button_zbieraj.BackColor = Color.BurlyWood;
            int suma_wszystkich = 0;
            int suma_do_zebrania = 0;
            int element = 0;
            int element2 = 0;
            int ile_pustych = 0;
            int ile_pełnych = 0;
            int ile_do_zebrania = 0;

            if (zasoby1[0] == 0)
            {
                Info();

                button13.Enabled = true;
                button13.Select();

            }
            else
            {

                button_zbieraj.Enabled = false;
                button_zbierzWszystkie.Enabled = false;
                but_p_niezebrane.Enabled = false;
                button13.Enabled = true;
                Button btn = (Button)sender;


                for (int i = 0; i < ulepszenia1[0]; i++)
                {

                    var txts = this.Controls.Find("btn" + i, true);
                    foreach (Button ustaw_txt in txts)

                        if (Convert.ToInt32(ustaw_txt.Text) == 0)
                        {
                            ile_pustych = ile_pustych + 1;
                        }

                        else
                        {
                            ile_pełnych = ile_pełnych + 1;
                            element = Convert.ToInt32(ustaw_txt.Text);
                            suma_wszystkich = suma_wszystkich + element;
                        }

                }

                button13.Select();
                ile_do_zebrania = Convert.ToInt32(zasoby1[0]);


                if (ile_pełnych != 0)
                {

                    for (int i = 0; i < ulepszenia1[0]; i++)
                    {
                        var txts = this.Controls.Find("btn" + i, true);
                        foreach (Button ustaw_txt in txts)



                            if (ustaw_txt.Text == "0")
                            {
                                //  MessageBox.Show("omijamy ! (+ i)" + i);
                            }
                            else
                            {

                                if (i < zasoby1[0] + zasoby1[1])
                                {

                                    element2 = Convert.ToInt32(ustaw_txt.Text);
                                    suma_do_zebrania = suma_do_zebrania + element2;

                                    ustaw_txt.Text = "0";
                                    ustaw_txt.BackColor = Color.Gray;
                                }
                                else
                                {

                                }

                            }

                    }
                    button13.Select();
                    if (zasoby1[0] < ulepszenia1[0])
                    {
                        zasoby1[1] = zasoby1[1] + zasoby1[0];
                        zasoby1[0] = 0;
                    }
                    else
                    {
                        zasoby1[1] = zasoby1[1] + ulepszenia1[0] - ile_pustych;
                        zasoby1[0] = zasoby1[0] - ulepszenia1[0] + ile_pustych;
                    }
                    but_p_niezebrane.BackColor = Color.BurlyWood;

                    button_zbierzWszystkie.BackColor = Color.Orange;
                    button13.BackColor = Color.LightGray;

                    MessageBox.Show("Zebrano jedzenia: " + suma_do_zebrania * int.Parse(TB_MNOZNIK_JEDZENIA.Text));
                    button13.Select();
                    ULEPSZENIA_MANA1.Enabled = true;
                    ULEPSZENIA_MANA1.BackColor = Color.BurlyWood;
                    if (int.Parse(TB3.Text) >= 5)
                    {
                        ULEPSZENIA_MANA1.ForeColor = Color.RoyalBlue;
                    }
                    TB_ile_do_zebrania.Text = "0";
                    ile_jedzenia_zebrano_w_sumie = ile_jedzenia_zebrano_w_sumie + suma_do_zebrania * int.Parse(TB_MNOZNIK_JEDZENIA.Text);

                    zasoby1[5] = zasoby1[5] + (suma_do_zebrania * int.Parse(TB_MNOZNIK_JEDZENIA.Text));
                    wypluj_tablice_zasoby1();
                    wypluj_tablice_ulepszenia1();

                    GB_Z1.Enabled = true;
                    flowLayoutPanel1.Visible = false;
                    GB_PRACA.Visible = false;

                }
                else
                {
                    MessageBox.Show("wszystkie pola są juz zebrane");
                }
            }
            GB_PRACA.Enabled = false;
            button13.Select();
        }



        private void button12_Click(object sender, EventArgs e) // PRZERZUĆ NIEZEBRANE

        {
            pobierz_tablice_zasoby1();

            if (zasoby1[2] - 1 < 0)
            {
                Info();
            }
            else
            {

                Button btn = (Button)sender;
                int ile_trzeba_przerzucic = 0;
                int zebrane = 0;


                for (int i = 0; i < ulepszenia1[0]; i++)
                {
                    var txts = this.Controls.Find("btn" + i, true);
                    foreach (Button ustaw_txt in txts)
                        if (ustaw_txt.Text == "0")
                        {
                            zebrane = zebrane + 1;
                        }
                        else
                        {
                            ile_trzeba_przerzucic = ile_trzeba_przerzucic + 1;
                        }
                }


                flowLayoutPanel1.Controls.Clear();                                       // RZUĆ KOSTKI
                decimal[] kostki1 = new decimal[ile_trzeba_przerzucic];
                Random rnd = new Random();


                for (int i = 0; i < ile_trzeba_przerzucic; i++)
                {
                    kostki1[i] = rnd.Next(1, int.Parse(TB_U3.Text) + 1);
                }

                Array.Sort(kostki1);
                Array.Reverse(kostki1);


                for (int i = 0; i < ulepszenia1[0]; i++)
                {
                    Button btn2 = new Button();

                    if (i < zebrane)
                    {
                        btn2.Text = "0";
                        btn2.BackColor = Color.Gray;
                    }
                    else if (i < zebrane + zasoby1[0])
                    {
                        btn2.Text = kostki1[i - zebrane].ToString();
                        TB_na.Text = (int.Parse(TB_na.Text) + kostki1[i - zebrane]).ToString();
                        TB_ile_do_zebrania.Text = (int.Parse(TB_na.Text) * int.Parse(TB_MNOZNIK_JEDZENIA.Text)).ToString();


                        btn2.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        btn2.Text = kostki1[i - zebrane].ToString();
                        btn2.BackColor = Color.Red;
                    }

                    btn2.Name = "btn" + i;

                    btn2.Size = new Size(rozmiar_kostek, rozmiar_kostek);
                    btn2.Click += Zbieraj_jedzenie;

                    flowLayoutPanel1.Controls.Add(btn2);

                }
                zasoby1[2] = zasoby1[2] - 1;
                wypluj_tablice_zasoby1();
                TB_na.Text = "0";
            }

        }

        private void button10_Click(object sender, EventArgs e) // ZAKOŃCZ
        {
            tableLayoutPanel2.Enabled = false;

            GB_PRACA.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            button13.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) // ULEPSZENIA
        {
            GB_PRACA.Visible = false;

            tableLayoutPanel2.Enabled = true;
        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) // ZAKONCZ
        {

            ULEPSZENIA_MANA1.BackColor = Color.LightGray;
            button13.BackColor = Color.LightGray;
            ULEPSZENIA_MANA1.Enabled = false;

            SuspendLayout();
            ZebranoFarma.Value = 0;
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();

            if (int.Parse(TB_RUNDA.Text) == 51)
            {
                PORAZKA();
            }

            else
            {
                Pobierz_all();
                if (ulepszenia1[12] > 0)
                {

                    pictureBox3.Visible = true;
                    GB_LAS.Visible = true;
                    GB_LAS_AKCJA.Visible = true;
                    tableLayoutPanel1.Visible = true;
                    GB_Z2.Visible = true;
                    GB_ZASOBY_LAS.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    flowLayoutPanel1.Visible = false;


                    GB_LAS_AKCJA.Enabled = true;
                    GB_ZASOBY_LAS.Enabled = true;
                    GB3.Enabled = false;
                    groupBox1.Enabled = false;
                    tableLayoutPanel2.Enabled = false;

                    button13.Enabled = false;
                    ZAKONCZ_2.Enabled = false;
                    GB_LAS.Enabled = true;
                    drwale_akacja = przyrost_n_drwali;

                    wypluj_dane_las();
                    button20.Select();


                }
                else
                {
                    if (int.Parse(TB_RUNDA.Text) == 50)
                    {
                        PORAZKA();
                    }
                    else
                    {

                        flowLayoutPanel1.Visible = false;

                        GB_PRACA.Visible = false;
                        tableLayoutPanel2.Enabled = false;

                        button13.Enabled = false;


                        ZAKONCZ_2.Enabled = false;
                        flowLayoutPanel1.Controls.Clear();
                        button16.Select();


                        but_p_niezebrane.Enabled = true;
                        button_zbierzWszystkie.Enabled = true;
                        button_zbieraj.Enabled = true;

                        KONIEC_RUNDY();
                    }
                }
            }
            button13.BackColor = Color.LightGray;
            tableLayoutPanel2.ResumeLayout();
            tableLayoutPanel1.ResumeLayout();
            ResumeLayout();
        }



        private void button3_Click(object sender, EventArgs e) //LVL UP1
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();

            if (button3.Text == "50%")
            {
                button22.Select();
                ulepszenia1[1] = ulepszenia1[1] - Math.Floor(ulepszenia1[1] / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;

                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }

            else
            {


                if (zasoby1[5] - ulepszenia1[1] < 0)
                {
                    Info();
                }
                else
                {
                    zasoby1[5] = zasoby1[5] - ulepszenia1[1];
                    ulepszenia1[0] = ulepszenia1[0] + 1;
                    ulepszenia1[1] = ulepszenia1[1] + ulepszenia1[2];

                    wypluj_tablice_ulepszenia1();
                    wypluj_tablice_zasoby1();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // LVL UP2
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();

            if (button4.Text == "50%")
            {
                button22.Select();
                ulepszenia1[7] = ulepszenia1[7] - Math.Floor(ulepszenia1[7] / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;

                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }

            else
            {
                if (zasoby1[5] - ulepszenia1[7] < 0)
                {
                    Info();
                }
                else
                {
                    if (TB_U6.Text == TB_U0.Text)
                    {
                        MessageBox.Show("Nie możesz mieć więcej chłopów niż kostek");
                    }
                    else
                    {
                        zasoby1[5] = zasoby1[5] - ulepszenia1[7];
                        ulepszenia1[6] = ulepszenia1[6] + 1;
                        ulepszenia1[7] = ulepszenia1[7] + ulepszenia1[8];

                        wypluj_tablice_ulepszenia1();
                        wypluj_tablice_zasoby1();

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //LVL UP3
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();

            if (button6.Text == "50%")
            {
                button22.Select();
                ulepszenia1[10] = ulepszenia1[10] - Math.Floor(ulepszenia1[10] / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;
                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }

            else
            {
                if (zasoby1[5] - ulepszenia1[10] < 0)
                {
                    Info();
                }
                else
                {
                    zasoby1[5] = zasoby1[5] - ulepszenia1[10];
                    ulepszenia1[9] = ulepszenia1[9] + 1;
                    ulepszenia1[10] = ulepszenia1[10] + ulepszenia1[11];

                    wypluj_tablice_ulepszenia1();
                    wypluj_tablice_zasoby1();
                }
            }

        }

        private void button6_Click(object sender, EventArgs e) // LVL UP4
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();
            pobierz_dane_las();

            if (zasoby1[5] - ulepszenia1[13] < 0)
            {
                Info();
            }
            else
            {

                if (TB_U12.Text == textBox15.Text)
                {
                    MessageBox.Show("Nie możesz mieć więcej drwali niż kostek w lesie");
                }

                else
                {
                    zasoby1[5] = zasoby1[5] - ulepszenia1[13];
                    ulepszenia1[12] = ulepszenia1[12] + 1;
                    przyrost_n_drwali = przyrost_n_drwali + 1;
                    ulepszenia1[13] = ulepszenia1[13] + ulepszenia1[14];

                    wypluj_tablice_ulepszenia1();
                    wypluj_tablice_zasoby1();
                    wypluj_dane_las();
                }

            }
        }

        private void button9_Click(object sender, EventArgs e) //LVL5
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();

            if (button9.Text == "50%")
            {
                button22.Select();
                ulepszenia1[4] = ulepszenia1[4] - Math.Floor(ulepszenia1[4] / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;


                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }
            else
            {



                if (zasoby1[5] - ulepszenia1[4] < 0)
                {
                    Info();
                }
                else
                {
                    zasoby1[5] = zasoby1[5] - ulepszenia1[4];
                    ulepszenia1[3] = ulepszenia1[3] + 1;
                    ulepszenia1[4] = ulepszenia1[4] + ulepszenia1[5];

                    wypluj_tablice_ulepszenia1();
                    wypluj_tablice_zasoby1();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e) // ULEPSZENIA
        {
            tableLayoutPanel2.SuspendLayout();
            TB_klawisz.Text = (int.Parse(TB_klawisz.Text) + 1).ToString();

            GB_PRACA.Visible = false;
            GB_Z1.Enabled = true;

            groupBox1.Visible = false;
            tableLayoutPanel2.Enabled = true;
            button13.Enabled = true;
            button3.Select();
            tableLayoutPanel2.ResumeLayout();

        }

        private void button14_Click_1(object sender, EventArgs e) // ZBIERAJ POJEDYNCZO
        {
            pobierz_tablice_zasoby1();
            pobierz_tablice_ulepszenia1();
            int roznica_ch_min_k;
            roznica_ch_min_k = Convert.ToInt32(ulepszenia1[6]) - Convert.ToInt32(ulepszenia1[0]);

            if (zasoby1[0] == 0)
            {
                Info();
                button13.Enabled = true;
            }
            else
            {

                but_p_niezebrane.Enabled = true;
                Button btn = (Button)sender;

                for (int i = 0; i < ulepszenia1[0]; i++)
                {
                    var txts = this.Controls.Find("btn" + i, true);
                    foreach (Button ustaw_txt in txts)

                        if (ustaw_txt.Text == "0")
                        {

                        }
                        else
                        {
                            flowLayoutPanel1.ResumeLayout();
                            ZebranoFarma.Value = ZebranoFarma.Value + ((int.Parse(ustaw_txt.Text)) * int.Parse(TB_MNOZNIK_JEDZENIA.Text));
                            zasoby1[0] = zasoby1[0] - 1;
                            zasoby1[1] = zasoby1[1] + 1;
                            zasoby1[5] = zasoby1[5] + (int.Parse(ustaw_txt.Text)) * int.Parse(TB_MNOZNIK_JEDZENIA.Text);
                            TB_ile_do_zebrania.Text = (int.Parse(TB_ile_do_zebrania.Text) - (int.Parse(ustaw_txt.Text) * int.Parse(TB_MNOZNIK_JEDZENIA.Text))).ToString();
                            ile_jedzenia_zebrano_w_sumie = ile_jedzenia_zebrano_w_sumie + (int.Parse(ustaw_txt.Text)) * int.Parse(TB_MNOZNIK_JEDZENIA.Text);
                            ustaw_txt.Text = "0";
                            ustaw_txt.BackColor = Color.Gray;

                            goto End;
                        }

                }
                End:;

                wypluj_tablice_ulepszenia1();
                wypluj_tablice_zasoby1();

                pobierz_tablice_ulepszenia1();
                pobierz_tablice_zasoby1();

                if (zasoby1[0] == 0)
                {
                    MessageBox.Show("Zebrano jedzenia: " + ZebranoFarma.Value);
                    button_zbierzWszystkie.Enabled = false;
                    but_p_niezebrane.Enabled = false;
                    button_zbieraj.Enabled = false;
                    button13.Enabled = true;
                    button13.Select();
                    GB_Z1.Enabled = true;
                    GB_PRACA.Enabled = false;
                    GB_PRACA.Visible = false;
                    flowLayoutPanel1.Visible = false;
                    ULEPSZENIA_MANA1.Enabled = true;
                    ULEPSZENIA_MANA1.BackColor = Color.BurlyWood;
                    if (int.Parse(TB3.Text) >= 5)
                    {
                        ULEPSZENIA_MANA1.ForeColor = Color.RoyalBlue;
                    }



                    //  GB_PRACA.BackgroundImage = Properties.Resources.wood_txt1;
                    //  GB3.BackgroundImage = Properties.Resources.wood_txt1;
                    //  GB_Z1.BackgroundImage = Properties.Resources.wood_txt2;
                    button6.BackColor = Color.LightGray;
                    button13.Select();

                }
                /*   else if ((roznica_ch_min_k == zasoby1[0]) && (ulepszenia1[0] == zasoby1[0] + zasoby1[0]))

                   {
                       button_zbierzWszystkie.Enabled = false;
                       but_p_niezebrane.Enabled = false;
                       button_zbieraj.Enabled = false;
                       button13.Enabled = true;
                       button13.Select();
                   */



                wypluj_tablice_ulepszenia1();
                wypluj_tablice_zasoby1();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.SuspendLayout();
            NOWA_GRA();
            TB6.Text = (int.Parse(TB6.Text) - 1).ToString();
            TB6.Text = (int.Parse(TB6.Text) + 1).ToString();
            textBox19.Text = (int.Parse(textBox19.Text) - 1).ToString();
            textBox19.Text = (int.Parse(textBox19.Text) + 1).ToString();

            tableLayoutPanel2.ResumeLayout();
        }

        private void button10_Click_1(object sender, EventArgs e) //CHEAT
        {
            pobierz_tablice_ulepszenia1();
            pobierz_tablice_zasoby1();
            pobierz_dane_las();

            zasoby1[5] = 1000;
            drewno = 1000;


            wypluj_tablice_ulepszenia1();
            wypluj_tablice_zasoby1();
            wypluj_dane_las();

        }

        private void button20_Click(object sender, EventArgs e) // PRACA LAS
        {
            button27.BackColor = Color.SaddleBrown;
            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));
            flowLayoutPanel2.SuspendLayout();
            GB_LAS_AKCJA.Visible = false;
            GB_LAS_PRACA.Enabled = true;
            GB_LAS_PRACA.Visible = true;


            //this.GB_LAS_AKCJA.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            //this.GB_LAS_PRACA.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
            //this.GB_LAS.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;



            flowLayoutPanel2.Visible = true;

            pobierz_dane_las();


            Rzuć_kostki2();

            but_zbierz_pozostale2.Enabled = true;
            p_niezebrane2.Enabled = true;
            but_zbieraj2.Enabled = true;
            wypluj_dane_las();
            but_zbieraj2.Select();
            flowLayoutPanel2.ResumeLayout();
        }

        private void GB_LAS_AKCJA_Enter(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e) // ULEPSZENIA LAS
        {




            tableLayoutPanel1.SuspendLayout();
            MARKET.Visible = true;
            GB_LAS_BUDUJ.Visible = true;
            tableLayoutPanel1.Enabled = true;
            ZAKONCZ_2.Enabled = true;
            GB_LAS_BUDUJ.Enabled = true;

            // this.GB_LAS_AKCJA.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            // this.GB_LAS_BUDUJ.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
            // this.tableLayoutPanel1.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;

            //  this.MARKET.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
            //  this.GB_Z2.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
            GB_Z2.Enabled = true;


            GB_LAS_AKCJA.Visible = false;
            GB_LAS.Enabled = false;
            MARKET.Enabled = true;
            GB_LAS_BUDUJ.Enabled = true;

            button22.Select();
            tableLayoutPanel1.ResumeLayout();
            // button3.BackColor = Color.LightGray;
            // button9.BackColor = Color.LightGray;
            // button4.BackColor = Color.LightGray;

        }


        private void ZAKONCZ_2_Click(object sender, EventArgs e) // ZAKOŃCZ 2
        {
            tableLayoutPanel1.SuspendLayout();
            ZAKONCZ_2.BackColor = Color.LightGray;
            ULEPSZENIA_MANA2.BackColor = Color.LightGray;
            button17.Enabled = true;
            ZebranoLas.Value = 0;
            button8.BackColor = Color.LightGray;
            button7.BackColor = Color.LightGray;
            button11.BackColor = Color.LightGray;
            button13.BackColor = Color.LightGray;
            BUDUJ.BackColor = Color.LightGray;

            //this.groupBox1.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            // this.GB_Z2.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            // this.GB_LAS_BUDUJ.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            //  this.MARKET.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            //  this.tableLayoutPanel1.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
            GB_Z2.Enabled = false;
            button17.Visible = true;
            tableLayoutPanel1.Enabled = false;
            ZAKONCZ_2.Enabled = false;
            GB_LAS_BUDUJ.Enabled = false;
            ULEPSZENIA_MANA2.Enabled = false;

            GB_LAS.Enabled = false;
            GB_LAS_PRACA.Visible = false;
            MARKET.Enabled = false;
            GB_LAS_BUDUJ.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

            flowLayoutPanel2.Visible = false;






            flowLayoutPanel2.Controls.Clear();

            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            GB3.Enabled = true;
            GB_PRACA.Visible = false;
            tableLayoutPanel2.Enabled = false;

            button13.Enabled = false;
            but_p_niezebrane.Enabled = true;
            button_zbierzWszystkie.Enabled = true;
            button_zbieraj.Enabled = true;
            GB_LAS_AKCJA.Enabled = false;
            button16.Select();

            if (int.Parse(textBox10.Text) >= 100)
            {
                //GB_ZASOBY_LAS.Visible = false;
                //GB1.Visible = false;
                //GB3.Visible = false;
                //GB_LAS.Visible = false;
                //GB_ZASOBY_LAS.Visible = false;
                //tableLayoutPanel2.Visible = false;
                //tableLayoutPanel1.Visible = false;
                //GB_LAS_BUDUJ.Visible = false;
                //MARKET.Visible = false;
                //button13.Visible = false;
                //ZAKONCZ_2.Visible = false;
                //GB3.Visible = false;
                //GB_PRACA.Visible = false;
                //tableLayoutPanel1.Visible = false;
                //MARKET.Visible = false;
                //  this.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.WIN_DS3;





                MessageBox.Show("GRATULACJE BUDOWLA ZOSTAŁA UKOŃCZONA !!!!" + Environment.NewLine + "LUD CZUJE SIĘ BEZPIECZNIE I TERAZ CAŁA OSADA SZYKUJE HUCZNĄ UCZTĘ NA TWOJĄ CZEŚĆ !!!!" + Environment.NewLine + "GRATULACJE !!!!");

                Hide();
                WinGame zwyciestwo = new WinGame(TB_RUNDA.Text, TB6.Text, textBox19.Text, TBnauka.Text);
                zwyciestwo.Show();

                /*groupBox_Punktacja.Visible = true;
                textBox34.Text = (50 - int.Parse(TB_RUNDA.Text)).ToString();
                textBox36.Text = (int.Parse(textBox34.Text) * 1000).ToString();

                textBox37.Text = int.Parse(TB6.Text).ToString(); // JEDZENIE
                textBox41.Text = int.Parse(TB6.Text).ToString();

                textBox38.Text = int.Parse(textBox19.Text).ToString();
                textBox42.Text = (int.Parse(textBox19.Text)*10).ToString();

                textBox43.Text = (int.Parse(textBox36.Text) + int.Parse(textBox41.Text) + int.Parse(textBox42.Text)).ToString();
                RANKING();
                MessageBox.Show("TWOJ WYNIK TO: " + textBox43.Text + Environment.NewLine + Environment.NewLine + "ZAPISZ GO SOBIE I ZASTANÓW SIĘ CZY DASZ RADĘ GO POPRAWIĆ ? ");
                Application.Restart();
                */
            }

            if (int.Parse(TB_RUNDA.Text) >= 50)
            {
                // MessageBox.Show("{ serio porazka ?}");
                PORAZKA();
            }

            KONIEC_RUNDY();
            tableLayoutPanel1.ResumeLayout();
        }



        private void button1_Click(object sender, EventArgs e) // ZBIERAJ 2
        {

            flowLayoutPanel2.SuspendLayout();
            pobierz_dane_las();
            int roznica_ch_min_k;
            roznica_ch_min_k = Convert.ToInt32(ul_las_7) - Convert.ToInt32(drwale_akacja);

            if (drwale_akacja == 0)
            {
                Info();
                ZAKONCZ_2.Enabled = true;
                ZAKONCZ_2.Select();
            }
            else
            {

                p_niezebrane2.Enabled = true;
                Button btnlas = (Button)sender;

                for (int i = 0; i < ul_las_1; i++)
                {
                    var txts = this.Controls.Find("btnlas" + i, true);
                    foreach (Button ustaw_txt in txts)

                        if (ustaw_txt.Text == "0")
                        {

                        }
                        else
                        {
                            ZebranoLas.Value = ZebranoLas.Value + (int.Parse(ustaw_txt.Text) * int.Parse(textBox8.Text));

                            drwale_akacja = drwale_akacja - 1;
                            drwale_zurzyte = drwale_zurzyte + 1;
                            drewno = drewno + (int.Parse(ustaw_txt.Text) * int.Parse(textBox8.Text));
                            TB_ILE_Drewna.Text = (int.Parse(TB_ILE_Drewna.Text) - (int.Parse(ustaw_txt.Text) * int.Parse(textBox8.Text))).ToString();
                            ustaw_txt.Text = "0";
                            ustaw_txt.BackColor = Color.Gray;
                            goto End;
                        }

                }
                End:;
                flowLayoutPanel2.ResumeLayout();

                wypluj_dane_las();

                pobierz_dane_las();

                if (drwale_akacja == 0)
                {
                    MessageBox.Show("Zebrano jedzenia: " + ZebranoLas.Value);
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));
                    but_zbierz_pozostale2.Enabled = false;
                    p_niezebrane2.Enabled = false;
                    but_zbieraj2.Enabled = false;
                    ZAKONCZ_2.Enabled = true;
                    ULEPSZENIA_MANA2.Enabled = true;
                    if (int.Parse(TB3.Text) >= 10)
                    {
                        ULEPSZENIA_MANA2.ForeColor = Color.RoyalBlue;
                    }


                    //   this.GB_LAS_PRACA.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
                    //   this.GB_LAS.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
                    //   this.GB_Z2.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
                    GB_LAS_PRACA.Enabled = false;
                    GB_LAS_PRACA.Visible = false;
                    GB_Z2.Enabled = true;
                    flowLayoutPanel2.Visible = false;
                    ZAKONCZ_2.Select();
                    flowLayoutPanel2.ResumeLayout();

                }
                else if ((roznica_ch_min_k == zasoby1[0]) && (ulepszenia1[0] == zasoby1[0] + zasoby1[0]))

                {
                    but_zbierz_pozostale2.Enabled = false;
                    p_niezebrane2.Enabled = false;
                    but_zbieraj2.Enabled = false;
                    ZAKONCZ_2.Enabled = true;
                    //  ULEPSZENIA_MANA2.Enabled = true;
                    GB_LAS_PRACA.Visible = false;
                    flowLayoutPanel2.Visible = false;
                    ZAKONCZ_2.Select();
                    flowLayoutPanel2.ResumeLayout();
                }
                wypluj_dane_las();
                flowLayoutPanel2.ResumeLayout();
            }
        }

        private void p_niezebrane2_Click(object sender, EventArgs e) // PRZERZUĆ NIEZEBRANE 2
        {

            pobierz_tablice_zasoby1();
            pobierz_dane_las();

            if (zasoby1[2] - 2 < 0)
            {
                Info();
            }
            else
            {


                Button btnlas = (Button)sender;
                int ile_trzeba_przerzucic = 0;
                int zebrane = 0;


                for (int i = 0; i < ul_las_1; i++)
                {
                    var txts = this.Controls.Find("btnlas" + i, true);
                    foreach (Button ustaw_txt in txts)
                        if (ustaw_txt.Text == "0")
                        {
                            zebrane = zebrane + 1;
                        }
                        else
                        {
                            ile_trzeba_przerzucic = ile_trzeba_przerzucic + 1;
                        }
                }




                flowLayoutPanel2.Controls.Clear();                                       // RZUĆ KOSTKI
                decimal[] kostki2 = new decimal[ile_trzeba_przerzucic];
                Random rnd = new Random();


                for (int i = 0; i < ile_trzeba_przerzucic; i++)
                {
                    kostki2[i] = rnd.Next(1, int.Parse(textBox18.Text) + 1);
                }

                Array.Sort(kostki2);
                Array.Reverse(kostki2);


                for (int i = 0; i < ul_las_1; i++)
                {
                    Button btnlas2 = new Button();



                    if (i < zebrane)
                    {
                        btnlas2.Text = "0";
                        btnlas2.BackColor = Color.Gray;
                    }
                    else if (i < zebrane + drwale_akacja)
                    {
                        btnlas2.Text = kostki2[i - zebrane].ToString();
                        btnlas2.BackColor = Color.GreenYellow;


                        TB_na2.Text = (int.Parse(TB_na2.Text) + kostki2[i - zebrane]).ToString();
                        TB_ILE_Drewna.Text = (int.Parse(TB_na2.Text) * int.Parse(textBox8.Text)).ToString();



                    }
                    else
                    {
                        btnlas2.Text = kostki2[i - zebrane].ToString();
                        btnlas2.BackColor = Color.Red;
                    }

                    btnlas2.Name = "btnlas" + i;

                    btnlas2.Size = new Size(rozmiar_kostek, rozmiar_kostek);


                    flowLayoutPanel2.Controls.Add(btnlas2);


                }
                zasoby1[2] = zasoby1[2] - 2;
                wypluj_tablice_zasoby1();
                wypluj_dane_las();
                TB_na2.Text = "0";
            }
        }

        private void but_zbierz_pozostale2_Click(object sender, EventArgs e) // ZBIERZ POZOSTAŁE 2
        {
            but_zbieraj2.BackColor = Color.BurlyWood;
            pobierz_tablice_zasoby1();
            pobierz_tablice_ulepszenia1();
            pobierz_dane_las();

            int suma_wszystkich = 0;
            int suma_do_zebrania = 0;
            int element = 0;
            int element2 = 0;
            int ile_pustych = 0;
            int ile_pełnych = 0;
            int ile_do_zebrania = 0;

            if (drwale_akacja == 0)
            {
                Info();
                button13.Enabled = true;
            }
            else
            {

                but_zbieraj2.Enabled = false;
                but_zbierz_pozostale2.Enabled = false;
                p_niezebrane2.Enabled = false;
                ZAKONCZ_2.Enabled = true;
                Button btnlas = (Button)sender;


                for (int i = 0; i < ul_las_1; i++)
                {

                    var txts = this.Controls.Find("btnlas" + i, true);
                    foreach (Button ustaw_txt in txts)

                        if (Convert.ToInt32(ustaw_txt.Text) == 0)
                        {
                            ile_pustych = ile_pustych + 1;
                        }

                        else
                        {
                            ile_pełnych = ile_pełnych + 1;
                            element = Convert.ToInt32(ustaw_txt.Text);
                            suma_wszystkich = suma_wszystkich + element;
                        }
                }

                ile_do_zebrania = Convert.ToInt32(drwale_akacja);

                //   MessageBox.Show("ile pustych" + ile_pustych);
                //  MessageBox.Show("ile pełnych" + ile_pełnych);
                //   MessageBox.Show("suma_wszystkich" + suma_wszystkich);
                //  MessageBox.Show("do zebrania" + ile_do_zebrania);


                if (ile_pełnych != 0)
                {

                    for (int i = 0; i < ul_las_1; i++)
                    {
                        var txts = this.Controls.Find("btnlas" + i, true);
                        foreach (Button ustaw_txt in txts)



                            if (ustaw_txt.Text == "0")
                            {
                                //  MessageBox.Show("omijamy ! (+ i)" + i);
                            }
                            else
                            {

                                if (i < drwale_akacja + drwale_zurzyte)
                                {

                                    element2 = Convert.ToInt32(ustaw_txt.Text);
                                    suma_do_zebrania = suma_do_zebrania + element2;
                                    //   MessageBox.Show("zasoby" + zasoby1[0]);
                                    //   MessageBox.Show("zbieramy! (+ i)" + i);
                                    ustaw_txt.Text = "0";
                                    ustaw_txt.BackColor = Color.Gray;
                                }
                                else
                                {
                                    //   MessageBox.Show("koniec zbierania ! (i> niz zasoby)" + i);
                                }

                            }
                    }

                    if (drwale_akacja < ul_las_1)
                    {
                        drwale_zurzyte = drwale_zurzyte + drwale_akacja;
                        drwale_akacja = 0;
                    }
                    else
                    {
                        drwale_zurzyte = drwale_zurzyte + ul_las_1 - ile_pustych;
                        drwale_akacja = drwale_akacja - ul_las_1 + ile_pustych;
                    }

                    p_niezebrane2.BackColor = Color.BurlyWood;
                    but_zbierz_pozostale2.BackColor = Color.Orange;
                    ZAKONCZ_2.BackColor = Color.LightGray;
                    MessageBox.Show("Zebrano drewna: :" + suma_do_zebrania * int.Parse(textBox8.Text));
                    TB_ILE_Drewna.Text = "0";

                    drewno = drewno + (suma_do_zebrania * int.Parse(textBox8.Text));
                    wypluj_tablice_zasoby1();
                    wypluj_tablice_ulepszenia1();
                    wypluj_dane_las();
                    //  this.GB_LAS_PRACA.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
                    //  this.GB_LAS.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt1;
                    //  this.GB_Z2.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
                    GB_LAS_PRACA.Enabled = false;
                    GB_LAS_PRACA.Visible = false;
                    GB_Z2.Enabled = true;
                    flowLayoutPanel2.Visible = false;

                }
                else
                {
                    MessageBox.Show("wszystkie pola są juz zebrane");
                }
                ULEPSZENIA_MANA2.Enabled = true;
                if (int.Parse(TB3.Text) >= 10)
                {
                    ULEPSZENIA_MANA2.ForeColor = Color.RoyalBlue;
                }
                ZAKONCZ_2.Select();
            }
        }

        private void button22_Click(object sender, EventArgs e) // ULEPSZENIA LAS 1
        {
            pobierz_dane_las();

            if (button22.Text == "50%")
            {
                button22.Select();
                ul_las_2 = ul_las_2 - Math.Floor(ul_las_2 / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;


                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }

            else
            {


                if (drewno - ul_las_2 < 0)
                {
                    Info();
                }
                else
                {
                    drewno = drewno - ul_las_2;
                    ul_las_1 = ul_las_1 + 1;
                    ul_las_2 = ul_las_2 + ul_las_3;

                    wypluj_dane_las();

                    if (int.Parse(textBox14.Text) <= int.Parse(textBox19.Text))
                    {
                        textBox14.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        textBox14.BackColor = Color.LightPink;
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e) // ULEPSZENIA LAS 2
        {
            pobierz_dane_las();

            if (button21.Text == "50%")
            {
                button22.Select();
                ul_las_5 = ul_las_5 - Math.Floor(ul_las_5 / 2);
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                button3.Text = "KUP";
                button4.Text = "KUP";
                button5.Text = "KUP";
                button9.Text = "KUP";
                button22.Text = "KUP";
                button21.Text = "KUP";

                button3.ForeColor = Color.SaddleBrown;
                button4.ForeColor = Color.SaddleBrown;
                button5.ForeColor = Color.SaddleBrown;
                button9.ForeColor = Color.SaddleBrown;
                button22.ForeColor = Color.SaddleBrown;
                button21.ForeColor = Color.SaddleBrown;

                button5.Enabled = true;
                button6.Enabled = true;
                button18.Enabled = true;
                button17.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                tableLayoutPanel2.Enabled = false;
                tableLayoutPanel1.Enabled = true;


                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;
                ZAKONCZ_2.Enabled = true;
            }

            else
            {

                if (drewno - ul_las_5 < 0)
                {
                    Info();
                }
                else
                {


                    textBox19.Text = (int.Parse(textBox19.Text) + 1).ToString();
                    textBox19.Text = (int.Parse(textBox19.Text) - 1).ToString();

                    drewno = drewno - ul_las_5;
                    ul_las_4 = ul_las_4 + 1;
                    ul_las_5 = ul_las_5 + ul_las_6;

                    wypluj_dane_las();

                    if (int.Parse(textBox12.Text) <= int.Parse(textBox19.Text))
                    {
                        textBox12.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        textBox12.BackColor = Color.LightPink;
                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // ULEPSZENIA LAS 3
        {
            pobierz_dane_las();
            pobierz_tablice_zasoby1();

            if (drewno - ul_las_8 < 0)
            {
                Info();
            }
            else
            {
                drewno = drewno - ul_las_8;
                ul_las_7 = ul_las_7 + 1;
                ul_las_8 = ul_las_8 + ul_las_9;




                TB_MNOZNIK_JEDZENIA.Text = (int.Parse(TB_MNOZNIK_JEDZENIA.Text) + 1).ToString();

                wypluj_dane_las();
                wypluj_tablice_zasoby1();

                if (int.Parse(textBox5.Text) <= int.Parse(textBox19.Text))
                {
                    textBox5.BackColor = Color.LimeGreen;
                }
                else
                {
                    textBox5.BackColor = Color.LightPink;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e) // ULEPSZENIA LAS 4
        {
            pobierz_dane_las();


            if (drewno - ul_las_11 < 0)
            {
                Info();
            }
            else
            {
                drewno = drewno - ul_las_11;
                ul_las_10 = ul_las_10 + 1;
                ul_las_11 = ul_las_11 + ul_las_12;

                technologia_farmy = technologia_farmy + 1;

                wypluj_dane_las();

                if (int.Parse(textBox2.Text) <= int.Parse(textBox19.Text))
                {
                    textBox2.BackColor = Color.LimeGreen;
                }
                else
                {
                    textBox2.BackColor = Color.LightPink;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e) // ULEPSZENIA LAS 4
        {
            pobierz_dane_las();

            if (drewno - ul_las_14 < 0)
            {
                Info();
            }
            else
            {
                MessageBox.Show("WSKAŻ KTÓRĄ CENE OBINIŻYĆ");

                tableLayoutPanel2.Enabled = true;
                tableLayoutPanel1.Enabled = true;


                MARKET.Enabled = false;
                GB_LAS_BUDUJ.Enabled = false;
                ZAKONCZ_2.Enabled = false;

                button5.Enabled = false;
                button6.Enabled = false;
                button18.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button13.BackColor = Color.LightGray;



                button3.Text = "50%";
                button4.Text = "50%";
                button9.Text = "50%";
                button22.Text = "50%";
                button21.Text = "50%";


                button3.ForeColor = Color.Red;
                button4.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                button22.ForeColor = Color.Red;
                button21.ForeColor = Color.Red;

                button3.Select();


                drewno = drewno - ul_las_14;
                ul_las_13 = ul_las_13 + 1;
                ul_las_14 = ul_las_14 + ul_las_15;

                wypluj_dane_las();

                if (int.Parse(textBox17.Text) <= int.Parse(textBox19.Text))
                {
                    textBox17.BackColor = Color.LimeGreen;
                }
                else
                {
                    textBox17.BackColor = Color.LightPink;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e) // ULEPSZENIA LAS 5
        {
            pobierz_dane_las();
            int level_market = int.Parse(textBox30.Text);

            if (drewno - ul_las_17 < 0)
            {
                Info();
            }
            else
            {
                MessageBox.Show("Działa tylko raz na rundę !");
                button17.Enabled = false;
                button8.Select();
                level_market = level_market + 1;
                drewno = drewno - ul_las_17;
                ul_las_16 = ul_las_16 + 1;
                ul_las_17 = ul_las_17 + ul_las_18;

                textBox30.Text = level_market.ToString();
                wypluj_dane_las();

                if (int.Parse(textBox25.Text) <= int.Parse(textBox19.Text))
                {
                    textBox25.BackColor = Color.LimeGreen;
                }
                else
                {
                    textBox25.BackColor = Color.LightPink;
                }
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e) // POSTĘP BUDOWY
        {
            pobierz_dane_las();

            if (drewno - ul_las_20 < 0)
            {
                Info();
            }
            else
            {
                drewno = drewno - ul_las_20;
                ul_las_19 = ul_las_19 + 1;
                ul_las_20 = ul_las_20 + ul_las_21;

                wypluj_dane_las();

                if (int.Parse(textBox28.Text) <= int.Parse(textBox19.Text))
                {
                    textBox28.BackColor = Color.LimeGreen;
                }
                else
                {
                    textBox28.BackColor = Color.LightPink;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) // ZAMIEŃ RAZ
        {
            int market_jedzenie = int.Parse(textBox31.Text);
            int market_drewno = int.Parse(textBox30.Text);

            pobierz_dane_las();
            pobierz_tablice_zasoby1();

            if (zasoby1[5] - market_jedzenie < 0)
            {
                Info();
            }

            else
            {


                zasoby1[5] = zasoby1[5] - market_jedzenie;
                drewno = drewno + market_drewno;

                wypluj_dane_las();
                wypluj_tablice_zasoby1();
                textBox30.Text = market_drewno.ToString();
                textBox31.Text = market_jedzenie.ToString();
            }

        }

        private void button11_Click_1(object sender, EventArgs e) // ZAMIEŃ WSZYSTKO
        {

            decimal market_jedzenie = decimal.Parse(textBox31.Text);
            decimal market_drewno = decimal.Parse(textBox30.Text);
            decimal ile_razy = Math.Floor(zasoby1[5] / market_jedzenie);
            decimal wymiana_jedzenia = market_jedzenie * ile_razy;
            decimal wymiana_drewna = market_drewno * ile_razy;

            pobierz_dane_las();
            pobierz_tablice_zasoby1();

            if (zasoby1[5] - market_jedzenie < 0)
            {
                Info();
            }

            else
            {

                if (MessageBox.Show("WYMIANA :" + wymiana_jedzenia + " JEDZENIA NA :" + wymiana_drewna + " DREWNA", "MARKET", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    zasoby1[5] = zasoby1[5] - (market_jedzenie * ile_razy);
                    drewno = drewno + (market_drewno * ile_razy);

                    wypluj_dane_las();
                    wypluj_tablice_zasoby1();
                    textBox30.Text = market_drewno.ToString();
                    textBox31.Text = market_jedzenie.ToString();
                }

            }


        }

        private void BUDUJ_Click(object sender, EventArgs e)
        {

            if (int.Parse(textBox19.Text) - 10 < 0) //  DREWNO
            {
                Info();
            }
            else
            {
                textBox19.Text = (int.Parse(textBox19.Text) - 10).ToString();
                textBox10.Text = (int.Parse(textBox10.Text) + 1).ToString(); // BUDOWA

                //if (textBox10.Text == "100")
                //{
                //    MessageBox.Show("GRATULACJE BUDOWLA ZOSTAŁA UKOŃCZONA !!!!" + Environment.NewLine + "LUD CZUJE SIĘ BEZPIECZNIE I TERAZ CAŁA OSADA SZYKUJE HUCZNĄ UCZTĘ NA TWOJĄ CZEŚĆ !!!!" + Environment.NewLine + "GRATULACJE !!!!");

                //    Hide();
                //    Form4 zwyciestwo = new Form4(TB_RUNDA.Text, TB6.Text, textBox19.Text, TBnauka.Text);
                //    zwyciestwo.Show();



                //    // this.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.WIN_DS3;




                //    /* groupBox_Punktacja.Visible = true;
                //    textBox34.Text = (50 - int.Parse(TB_RUNDA.Text)).ToString();
                //    textBox36.Text = (int.Parse(textBox34.Text) * 1000).ToString();

                //    textBox37.Text = int.Parse(TB6.Text).ToString(); // JEDZENIE
                //    textBox41.Text = int.Parse(TB6.Text).ToString();

                //    textBox38.Text = int.Parse(textBox19.Text).ToString();
                //    textBox42.Text = (int.Parse(textBox19.Text) * 10).ToString();










                //    textBox43.Text = (int.Parse(textBox36.Text) + int.Parse(textBox41.Text) + int.Parse(textBox42.Text)).ToString();
                //    RANKING();
                //    MessageBox.Show("TWOJ WYNIK TO: " + textBox43.Text + Environment.NewLine + Environment.NewLine + "ZAPISZ GO SOBIE I ZASTANÓW SIĘ CZY DASZ RADĘ GO POPRAWIĆ ? ");
                //    MessageBox.Show("KONIEC GRY");
                //    Application.Restart();

                //    */

                //}








            }

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.SaddleBrown;
            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(100));
            flowLayoutPanel1.SuspendLayout();

            groupBox1.Visible = false;




            GB_PRACA.Enabled = true;

            button_zbierzWszystkie.Enabled = true;
            but_p_niezebrane.Enabled = true;
            button_zbieraj.Enabled = true;


            //   GB_PRACA.BackgroundImage = Properties.Resources.wood_txt2;
            //  GB3.BackgroundImage = Properties.Resources.wood_txt2;
            // groupBox1.BackgroundImage = Properties.Resources.wood_txt1;

            TB_klawisz.Text = "10";
            Rzuć_kostki();
            GB_PRACA.Visible = true;
            button_zbieraj.Select();
            flowLayoutPanel1.ResumeLayout();

            TB_klawisz.Text = (int.Parse(TB_klawisz.Text) + 1).ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            groupBox_Nowa_gra.Visible = true;
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            MainBoard form1 = new MainBoard("oko");

            NOWA_GRA();

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NOWA_GRA()
        {
            /*
             GB1.BackgroundImage = Properties.Resources.wood_txt1;

             GB_ULEPSZENIA_FARMY.BackgroundImage = Properties.Resources.wood_txt1;
             GB3.BackgroundImage = Properties.Resources.wood_txt1;
             GB_PRACA.BackgroundImage = Properties.Resources.wood_txt1;
             GB_LAS_ULEPSZENIA.BackgroundImage = Properties.Resources.wood_txt1;
             GB_LAS_BUDUJ.BackgroundImage = Properties.Resources.wood_txt1;
             GB_LAS.BackgroundImage = Properties.Resources.wood_txt1;
             GB_ZASOBY_LAS.BackgroundImage = Properties.Resources.wood_txt1;
             GB_LAS_PRACA.BackgroundImage = Properties.Resources.wood_txt1;
             GB_LAS_AKCJA.BackgroundImage = Properties.Resources.wood_txt1;
             groupBox1.BackgroundImage = Properties.Resources.wood_txt1;
             MARKET.BackgroundImage = Properties.Resources.wood_txt1;
             GB_Z1.BackgroundImage = Properties.Resources.wood_txt1;
             GB_Z2.BackgroundImage = Properties.Resources.wood_txt1;


             this.groupBox1.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
             pictureBox6.Visible = true;
             pictureBox5.Visible = true;
             label24.Visible = true;
             label3.Visible = true;
             TB_RUNDA.Visible = true;
             TB3.Visible = true;

             GB_Z1.Visible = true;
             GB_Z2.Visible = true;



             GB1.Visible = true;
             GB3.Visible = true;
             GB_LAS.Visible = true;



             GB_ZASOBY_LAS.Visible = true;
             GB_ULEPSZENIA_FARMY.Visible = true;
             GB_LAS_ULEPSZENIA.Visible = true;
             GB_LAS_BUDUJ.Visible = true;
             MARKET.Visible = true;
             button13.Visible = true;
             ZAKONCZ_2.Visible = true;
             pictureBox4.Visible = true;

             this.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.aa1;
             this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             */

            if (TBnauka.Text == "TEST")
            {

                TB6.Text = (Properties.Settings.Default["ZM1"]).ToString();
                TB_U1.Text = (Properties.Settings.Default["ZM2"]).ToString();
                TB_U2.Text = (Properties.Settings.Default["ZM3"]).ToString();
                textBox14.Text = (Properties.Settings.Default["ZM4"]).ToString();
                textBox13.Text = (Properties.Settings.Default["ZM5"]).ToString();
                TB_U4.Text = (Properties.Settings.Default["ZM6"]).ToString();
                TB_U5.Text = (Properties.Settings.Default["ZM7"]).ToString();
                textBox12.Text = (Properties.Settings.Default["ZM8"]).ToString();
                textBox11.Text = (Properties.Settings.Default["ZM9"]).ToString();
                TB_U7.Text = (Properties.Settings.Default["ZM10"]).ToString();
                TB_U8.Text = (Properties.Settings.Default["ZM11"]).ToString();
                textBox17.Text = (Properties.Settings.Default["ZM12"]).ToString();
                textBox16.Text = (Properties.Settings.Default["ZM13"]).ToString();
                TB_U10.Text = (Properties.Settings.Default["ZM14"]).ToString();
                TB_U11.Text = (Properties.Settings.Default["ZM15"]).ToString();
                textBox25.Text = (Properties.Settings.Default["ZM16"]).ToString();
                textBox21.Text = (Properties.Settings.Default["ZM17"]).ToString();
                TB_U13.Text = (Properties.Settings.Default["ZM18"]).ToString();
                TB_U14.Text = (Properties.Settings.Default["ZM19"]).ToString();
                textBox5.Text = (Properties.Settings.Default["ZM20"]).ToString();
                textBox3.Text = (Properties.Settings.Default["ZM21"]).ToString();
                textBox2.Text = (Properties.Settings.Default["ZM22"]).ToString();
                textBox1.Text = (Properties.Settings.Default["ZM23"]).ToString();
                textBox31.Text = (Properties.Settings.Default["ZM24"]).ToString();
                textBox28.Text = (Properties.Settings.Default["ZM25"]).ToString();
                textBox27.Text = (Properties.Settings.Default["ZM26"]).ToString();

                label58.Visible = true;

                //label5.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();
                //label5.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();
                //label5.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();


                MessageBox.Show("JESTEŚ W TRYBIE - 'WŁASNY SCENARIUSZ' - TWÓJ WYNIK KOŃCOWY NIE ZOSTANIE ZAPISANY DO TABLICY REKORDÓW");



                TB6.Text = (Properties.Settings.Default["ZM1"]).ToString();
            }
            else
            {
                MessageBox.Show("WITAJ NASZ NOWY WŁADCO" + Environment.NewLine + Environment.NewLine + "POKIERUJ MĄDRZE NASZĄ OSADĄ " + Environment.NewLine + "TWÓJ LUD ŻYJE W STRACHU PRZED ATAKIEM SMOKA (CHODZĄ PLOTKI ŻE SMOK ZAATAKUJE ZA 50 DNI)" + Environment.NewLine + "MUSISZ ZEBRAĆ JAK NAJWIĘCEJ ZASOBÓW ABY ZBUDOWAĆ WIEŻĘ STRZELNICZĄ TAK SZYBKO JAK TYLKO JEST TO MOŻLIWE " + Environment.NewLine + "TYLKO WTEDY LUD ODZYSKA SPOKÓJ " + Environment.NewLine + Environment.NewLine + "POWODZENIA !");
            }


        }


        private void button19_Click(object sender, EventArgs e) // NOWA GRA
        {
            SuspendLayout();

            NOWA_GRA();

            ResumeLayout();


        }

        private void button15_Click(object sender, EventArgs e)
        {


            GB1.Visible = true;
            GB3.Visible = true;
            GB_LAS.Visible = true;

            GB_ZASOBY_LAS.Visible = true;
            tableLayoutPanel2.Visible = true;
            tableLayoutPanel1.Visible = true;
            GB_LAS_BUDUJ.Visible = true;
            MARKET.Visible = true;
            button13.Visible = true;
            ZAKONCZ_2.Visible = true;
            GB3.Visible = true;
            GB3.Enabled = true;
            GB_PRACA.Visible = true;
            GB_PRACA.Enabled = false;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.Enabled = false;
            MARKET.Enabled = true;
            GB_LAS_BUDUJ.Enabled = true;
            button13.Enabled = false;
            ZAKONCZ_2.Enabled = false;
            groupBox1.Enabled = true;
            button16.Enabled = false;
            button31.Enabled = false;

            GB_PRACA.Enabled = true;
            button_zbieraj.Enabled = false;
            but_p_niezebrane.Enabled = false;
            button_zbierzWszystkie.Enabled = false;
            button3.Enabled = false;
            button9.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            button22.Enabled = false;
            button21.Enabled = false;
            button18.Enabled = false;
            button17.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            button8.Enabled = false;
            button11.Enabled = false;
            button7.Enabled = false;
            BUDUJ.Enabled = false;



            pictureBox4.Visible = false;

            tableLayoutPanel1.Enabled = true;



            MessageBox.Show("Rozejrzyj się troche po osadzie a wszystkiego sie dowiesz");



            tableLayoutPanel2.Enabled = true;

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("oko");
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {
            MessageBox.Show("oko");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NIE MARTW SIĘ ŻE NADAL NIE MASZ POJĘCIA OCO KAMAN, WSZYSTKO WYJDZIE W PRANIU :)");
            Application.Restart();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

            GB_PRACA.Visible = false;
            groupBox1.Visible = false;
            tableLayoutPanel2.Enabled = true;
            button13.Enabled = true;
            button3.Select();

            button_zbierzWszystkie.Enabled = false;
            but_p_niezebrane.Enabled = false;
            button_zbieraj.Enabled = false;
            button13.Enabled = true;
            button13.Select();
        }

        private void ULEPSZENIA_MANA1_Click(object sender, EventArgs e)
        {
            pobierz_tablice_zasoby1();

            if (zasoby1[2] - 5 < 0)
            {
                Info();
                ULEPSZENIA_MANA1.Enabled = false;
                ULEPSZENIA_MANA1.BackColor = Color.LightGray;
                button13.Select();
            }
            else
            {
                // this.tableLayoutPanel2.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;
                zasoby1[2] = zasoby1[2] - 5;
                GB_PRACA.Visible = false;
                groupBox1.Visible = false;
                tableLayoutPanel2.Enabled = true;
                button13.Enabled = true;
                button3.Select();
                ULEPSZENIA_MANA1.ForeColor = Color.Gray;
                ULEPSZENIA_MANA1.BackColor = Color.LightGray;
                ULEPSZENIA_MANA1.Enabled = false;
            }
            wypluj_tablice_zasoby1();
        }

        private void ULEPSZENIA_MANA2_Click(object sender, EventArgs e)
        {
            pobierz_tablice_zasoby1();
            if (zasoby1[2] - 10 < 0)
            {
                Info();
                ULEPSZENIA_MANA2.ForeColor = Color.Gray;
                ULEPSZENIA_MANA2.BackColor = Color.LightGray;
                ULEPSZENIA_MANA2.Enabled = false;

                ZAKONCZ_2.Select();

            }
            else
            {
                ULEPSZENIA_MANA2.ForeColor = Color.Gray;
                ULEPSZENIA_MANA2.BackColor = Color.LightGray;
                ULEPSZENIA_MANA2.Enabled = false;
                zasoby1[2] = zasoby1[2] - 10;
                tableLayoutPanel1.Enabled = true;
                ZAKONCZ_2.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;

                GB_LAS_AKCJA.Visible = false;
                GB_LAS.Enabled = false;
                MARKET.Enabled = true;
                GB_LAS_BUDUJ.Enabled = true;

                button22.Select();
            }
            wypluj_tablice_zasoby1();
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void button16_MouseHover(object sender, EventArgs e) // NAJECHANIE - PRACA
        {
            button16.Select();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Rozejrzyj się troche po osadzie a wszystkiego sie dowiesz");

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toolTip1.Active = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toolTip1.Active = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
        }

        private void button23_Click_2(object sender, EventArgs e)
        {
        }

        private void button24_Click_1(object sender, EventArgs e)
        {


        }

        //int wylacznik = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            TB6.BackColor = Color.Gold;
            textBox19.BackColor = Color.Gold;
            TB_U0.BackColor = Color.Moccasin;
            TB_U3.BackColor = Color.Moccasin;
            TB_U6.BackColor = Color.Moccasin;
            TB_U9.BackColor = Color.Moccasin;
            TB_U12.BackColor = Color.Moccasin;
            textBox15.BackColor = Color.Moccasin;
            textBox18.BackColor = Color.Moccasin;
            textBox20.BackColor = Color.Moccasin;
            textBox26.BackColor = Color.Moccasin;
            textBox6.BackColor = Color.Moccasin;
            textBox4.BackColor = Color.Moccasin;
            textBox29.BackColor = Color.Moccasin;
            TB_RUNDA.BackColor = Color.Moccasin;
            TB3.BackColor = Color.Moccasin;
            textBox10.BackColor = Color.Yellow;


            timer1.Stop();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("PORAŻKA !!!" + Environment.NewLine + "KONIEC GRY");
            Application.Restart();

        }

        private void button24_Click_2(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            //  this.groupBox1.BackgroundImage = global::GRA_KOSTKI_v2.Properties.Resources.wood_txt2;

            GB3.Visible = true;
            button16.Enabled = true;
            button31.Enabled = true;

            if (ulepszenia1[12] > 0)
            {

                pobierz_tablice_ulepszenia1();
                pobierz_tablice_zasoby1();
                pobierz_dane_las();
                drwale_zurzyte = 0;
                TB_RUNDA.Text = (Convert.ToInt32(TB_RUNDA.Text) + 1).ToString();
                int ktora_runda = int.Parse(TB_RUNDA.Text);


                int market_jedzenie = int.Parse(textBox31.Text);
                market_jedzenie = market_jedzenie + 1;
                textBox31.Text = market_jedzenie.ToString();






                zasoby1[0] = ulepszenia1[6];
                zasoby1[1] = 0;
                zasoby1[2] = zasoby1[2] + ulepszenia1[9];

                wypluj_tablice_zasoby1();
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();
                flowLayoutPanel1.Controls.Clear();




                pobierz_dane_las();
                drwale_akacja = przyrost_n_drwali;
                wypluj_dane_las();
                wypluj_tablice_ulepszenia1();
                wypluj_dane_las();

                textBox10.Text = (int.Parse(textBox10.Text) + int.Parse(textBox29.Text)).ToString();








            }
            else
            {
                pobierz_tablice_ulepszenia1();
                pobierz_tablice_zasoby1();
                TB_RUNDA.Text = (Convert.ToInt32(TB_RUNDA.Text) + 1).ToString();
                int ktora_runda = int.Parse(TB_RUNDA.Text);
                int market_jedzenie = int.Parse(textBox31.Text);
                market_jedzenie = market_jedzenie + 1;
                textBox31.Text = market_jedzenie.ToString();



                zasoby1[0] = ulepszenia1[6];
                zasoby1[1] = 0;
                zasoby1[2] = zasoby1[2] + ulepszenia1[9];

                wypluj_tablice_zasoby1();
                wypluj_tablice_ulepszenia1();



                pobierz_dane_las();
                drwale_akacja = przyrost_n_drwali;

                wypluj_dane_las();
                wypluj_tablice_ulepszenia1();







            }

            int value = int.Parse(TB_RUNDA.Text);

            switch (value)
            {
                case 10:
                    MessageBox.Show("O Panie ! Minęło już 10 dni, jak idą postępy ?");
                    break;

                case 25:
                    MessageBox.Show("Panie minęło już 25 dni, czy to oznacza że połowa budowli powinna być już skończona ?");
                    break;
                case 40:
                    MessageBox.Show("Panie minęło już 40 dni nie pozostało już nic innego jak wziąć się w końcu do roboty !");
                    break;
                case 50:
                    MessageBox.Show("Panie dziś mija 50 dzień, lepiej skończmy dziś tą budowę bo w nocy możemy spodziewać się ataku smoka !");
                    break;



                default:

                    break;
            }

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click_1(object sender, EventArgs e)
        {

        }

        private void GB_LAS_PRACA_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_ILE_Drewna_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click_2(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();


        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "tak")
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = false;
                }

            }
            else if (textBox7.Text == "nie")
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = true;
                }

            }

        }

        private void button14_Click_3(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz zrestartować gre ?", "RESTART", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainBoard dominik1 = new MainBoard("NIE");
                Close();
                dominik1.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            groupBox_Nowa_gra.Visible = false;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz wrócić do MENU GŁÓWNEGO ?" + Environment.NewLine + " (stan gry nie zostanie zapisany)", "POWRÓT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainMenu dominik2 = new MainMenu();
                Hide();
                dominik2.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }


        private void button16_Enter(object sender, EventArgs e)
        {
            TB_klawisz.Text = "1";

            button16.BackColor = Color.Orange;
            button31.BackColor = Color.BurlyWood;
        }

        private void button31_Enter(object sender, EventArgs e)
        {
            TB_klawisz.Text = "2";

            button31.BackColor = Color.Orange;
            button16.BackColor = Color.BurlyWood;
        }

        private void button16_KeyUp(object sender, KeyEventArgs e)
        {
            button16.BackColor = Color.Orange;
        }

        private void button31_KeyUp(object sender, KeyEventArgs e)
        {
            button31.BackColor = Color.Orange;
        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            button31.Select();
        }

        private void button_zbieraj_Enter(object sender, EventArgs e)
        {
            button_zbieraj.BackColor = Color.BurlyWood;
            but_p_niezebrane.BackColor = Color.BurlyWood;
            button_zbierzWszystkie.BackColor = Color.BurlyWood;

            ActiveControl.BackColor = Color.Orange;

        }

        private void button_zbieraj_MouseHover(object sender, EventArgs e)
        {
            button_zbieraj.Select();
        }

        private void but_p_niezebrane_MouseHover(object sender, EventArgs e)
        {
            but_p_niezebrane.Select();
        }

        private void button_zbierzWszystkie_MouseHover(object sender, EventArgs e)
        {
            button_zbierzWszystkie.Select();
        }

        private void button_zbieraj_KeyUp(object sender, KeyEventArgs e)
        {
            ActiveControl.BackColor = Color.Orange;
        }

        private void button_zbieraj_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void ULEPSZENIA_MANA1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Enter(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Enabled == true)
            {
                button22.BackColor = Color.BurlyWood;
                button21.BackColor = Color.BurlyWood;
            }




            button3.BackColor = Color.BurlyWood;
            button4.BackColor = Color.BurlyWood;
            button5.BackColor = Color.BurlyWood;
            button6.BackColor = Color.BurlyWood;
            button9.BackColor = Color.BurlyWood;
            if (button3.Text == "KUP")
            {
                button13.BackColor = Color.BurlyWood;
            }


            ActiveControl.BackColor = Color.Orange;

        }

        private void button27_Enter(object sender, EventArgs e)
        {
            button20.BackColor = Color.BurlyWood;
            button27.BackColor = Color.BurlyWood;
            ActiveControl.BackColor = Color.Orange;
        }

        private void button20_KeyUp(object sender, KeyEventArgs e)
        {
            ActiveControl.BackColor = Color.Orange;
        }

        private void but_zbieraj2_Enter(object sender, EventArgs e)
        {
            but_zbieraj2.BackColor = Color.BurlyWood;
            p_niezebrane2.BackColor = Color.BurlyWood;
            but_zbierz_pozostale2.BackColor = Color.BurlyWood;
            ActiveControl.BackColor = Color.Orange;

        }

        private void but_zbieraj2_KeyUp(object sender, KeyEventArgs e)
        {
            ActiveControl.BackColor = Color.Orange;
        }

        private void ULEPSZENIA_MANA2_Enter(object sender, EventArgs e)
        {
            ZAKONCZ_2.BackColor = Color.BurlyWood;

            if (tableLayoutPanel1.Enabled == true)
            {
                button2.BackColor = Color.BurlyWood;
            }

            if (ULEPSZENIA_MANA2.Enabled == true)
            {
                ULEPSZENIA_MANA2.BackColor = Color.BurlyWood;
            }

            ActiveControl.BackColor = Color.Orange;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Enabled == true)
            {


                button22.BackColor = Color.BurlyWood;
                button21.BackColor = Color.BurlyWood;
                button18.BackColor = Color.BurlyWood;
                button17.BackColor = Color.BurlyWood;
                button1.BackColor = Color.BurlyWood;
                button2.BackColor = Color.BurlyWood;
                button8.BackColor = Color.BurlyWood;
                button11.BackColor = Color.BurlyWood;
                button7.BackColor = Color.BurlyWood;
                BUDUJ.BackColor = Color.BurlyWood;
                ZAKONCZ_2.BackColor = Color.BurlyWood;
                //  ULEPSZENIA_MANA2.BackColor = Color.BurlyWood;

                ActiveControl.BackColor = Color.Orange;
            }
        }

        private void button8_FontChanged(object sender, EventArgs e)
        {

        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            ActiveControl.BackColor = Color.Orange;
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB6_TextChanged(object sender, EventArgs e)
        {
            if ((GB_PRACA.Enabled == true) && (GB_PRACA.Visible == true))
            {
                TB6.BackColor = Color.Chartreuse;
            }
            else if (ActiveControl.Name == "button8")
            {
                TB6.BackColor = Color.Red;
            }
            else if (groupBox1.Visible == true)
            {
            }
            else
            {
                TB6.BackColor = Color.Red;
            }

            if (int.Parse(TB6.Text) >= int.Parse(TB_U1.Text))
            {
                TB_U1.BackColor = Color.LimeGreen;
            }
            if (int.Parse(TB6.Text) >= int.Parse(TB_U4.Text))
            {
                TB_U4.BackColor = Color.LimeGreen;
            }
            if (int.Parse(TB6.Text) >= int.Parse(TB_U7.Text))
            {
                TB_U7.BackColor = Color.LimeGreen;
            }
            if (int.Parse(TB6.Text) >= int.Parse(TB_U10.Text))
            {
                TB_U10.BackColor = Color.LimeGreen;
            }
            if (int.Parse(TB6.Text) >= int.Parse(TB_U13.Text))
            {
                TB_U13.BackColor = Color.LimeGreen;
            }
            if (int.Parse(TB6.Text) < int.Parse(TB_U1.Text))
            {
                TB_U1.BackColor = Color.LightPink;
            }
            if (int.Parse(TB6.Text) < int.Parse(TB_U4.Text))
            {
                TB_U4.BackColor = Color.LightPink;
            }
            if (int.Parse(TB6.Text) < int.Parse(TB_U7.Text))
            {
                TB_U7.BackColor = Color.LightPink;
            }
            if (int.Parse(TB6.Text) < int.Parse(TB_U10.Text))
            {
                TB_U10.BackColor = Color.LightPink;
            }
            if (int.Parse(TB6.Text) < int.Parse(TB_U13.Text))
            {
                TB_U13.BackColor = Color.LightPink;
            }


            timer1.Start();

        }

        private void TB_U0_TextChanged(object sender, EventArgs e)
        {
            TB_U0.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB_U3_TextChanged(object sender, EventArgs e)
        {
            TB_U3.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB_U6_TextChanged(object sender, EventArgs e)
        {
            TB_U6.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB_U9_TextChanged(object sender, EventArgs e)
        {
            TB_U9.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB_U12_TextChanged(object sender, EventArgs e)
        {
            TB_U12.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox15.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox18.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            textBox26.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            textBox29.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB_RUNDA_TextChanged(object sender, EventArgs e)
        {
            TB_RUNDA.BackColor = Color.Yellow;
            timer1.Start();
        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {
            if (but_p_niezebrane.Enabled == true || p_niezebrane2.Enabled == true || ULEPSZENIA_MANA1.Enabled == true || ULEPSZENIA_MANA2.Enabled == true)
            {
                TB3.BackColor = Color.Red;
            }
            else
            {
                TB3.BackColor = Color.Chartreuse;
            }


            if (int.Parse(TB3.Text) < 1)
            {
                but_p_niezebrane.ForeColor = Color.Gray;
            }
            else
            {
                but_p_niezebrane.ForeColor = Color.RoyalBlue;
            }


            if (int.Parse(TB3.Text) < 2)
            {
                p_niezebrane2.ForeColor = Color.Gray;
            }
            else
            {
                p_niezebrane2.ForeColor = Color.RoyalBlue;
            }


            if (int.Parse(TB3.Text) < 5)
            {
                ULEPSZENIA_MANA1.ForeColor = Color.Gray;
            }
            else
            {
                ULEPSZENIA_MANA1.ForeColor = Color.RoyalBlue;
            }

            if (int.Parse(TB3.Text) < 10)
            {
                ULEPSZENIA_MANA2.ForeColor = Color.Gray;
            }
            else
            {
                ULEPSZENIA_MANA2.ForeColor = Color.RoyalBlue;
            }

            timer1.Start();
        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void button3_EnabledChanged_1(object sender, EventArgs e)
        {
            if (tableLayoutPanel2.Enabled == false)
            {
                button3.BackColor = Color.LightGray;
                button9.BackColor = Color.LightGray;
                button4.BackColor = Color.LightGray;
                button5.BackColor = Color.LightGray;
                button6.BackColor = Color.LightGray;
            }
            else
            {
                button3.BackColor = Color.BurlyWood;
                button9.BackColor = Color.BurlyWood;
                button4.BackColor = Color.BurlyWood;
                button5.BackColor = Color.BurlyWood;
                button6.BackColor = Color.BurlyWood;

            }
        }

        private void ULEPSZENIA_MANA1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void ULEPSZENIA_MANA2_EnabledChanged(object sender, EventArgs e)
        {
            //if (GB_Z2.Enabled == false)
            //{
            //    ZAKONCZ_2.BackColor = Color.LightGray;
            //    ULEPSZENIA_MANA2.BackColor = Color.LightGray;
            //}
            //else
            //{
            //    if (int.Parse(TB3.Text) >= 10)
            //    {
            //        ULEPSZENIA_MANA2.BackColor = Color.LightSkyBlue;
            //    }
            //    else
            //    {
            //        ULEPSZENIA_MANA2.BackColor = Color.BurlyWood;
            //    }
            //    ZAKONCZ_2.BackColor = Color.BurlyWood;
            //    ULEPSZENIA_MANA2.BackColor = Color.BurlyWood;
            //}
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {


            if (((GB_LAS_PRACA.Visible == true) || (ActiveControl.Name == "button8")) || (ActiveControl.Name == "button11"))
            {
                textBox19.BackColor = Color.Chartreuse;
            }
            if (!(((GB_LAS_PRACA.Visible == true) || (ActiveControl.Name == "button8")) || (ActiveControl.Name == "button11")))
            {
                textBox19.BackColor = Color.Red;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox14.Text))
            {
                textBox14.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox12.Text))
            {
                textBox12.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox17.Text))
            {
                textBox17.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox25.Text))
            {
                textBox25.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox5.Text))
            {
                textBox5.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox2.Text))
            {
                textBox2.BackColor = Color.LimeGreen;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox14.Text))
            {
                textBox14.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox12.Text))
            {
                textBox12.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox17.Text))
            {
                textBox17.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox25.Text))
            {
                textBox25.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox5.Text))
            {
                textBox5.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox2.Text))
            {
                textBox2.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) < int.Parse(textBox28.Text))
            {
                textBox28.BackColor = Color.LightPink;
            }
            if (int.Parse(textBox19.Text) >= int.Parse(textBox28.Text))
            {
                textBox28.BackColor = Color.LimeGreen;
            }


            timer1.Start();
        }

        private void button22_EnabledChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Enabled == false)
            {
                button22.BackColor = Color.LightGray;
                button21.BackColor = Color.LightGray;
                button18.BackColor = Color.LightGray;
                button17.BackColor = Color.LightGray;
                button1.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
            }
            else
            {
                button22.BackColor = Color.BurlyWood;
                button21.BackColor = Color.BurlyWood;
                button18.BackColor = Color.BurlyWood;
                button17.BackColor = Color.BurlyWood;
                button1.BackColor = Color.BurlyWood;
                button2.BackColor = Color.BurlyWood;

            }
        }

        private void button22_Enter(object sender, EventArgs e)
        {
            if (tableLayoutPanel2.Enabled == true)
            {
                button3.BackColor = Color.BurlyWood;
                button9.BackColor = Color.BurlyWood;
                button4.BackColor = Color.BurlyWood;
            }
            button22.BackColor = Color.BurlyWood;
            button8.BackColor = Color.BurlyWood;
            button11.BackColor = Color.BurlyWood;
            button7.BackColor = Color.BurlyWood;
            BUDUJ.BackColor = Color.BurlyWood;
            button21.BackColor = Color.BurlyWood;
            button18.BackColor = Color.BurlyWood;
            button17.BackColor = Color.BurlyWood;
            button1.BackColor = Color.BurlyWood;
            button2.BackColor = Color.BurlyWood;
            //  ULEPSZENIA_MANA2.BackColor = Color.BurlyWood;
            ZAKONCZ_2.BackColor = Color.BurlyWood;

            ActiveControl.BackColor = Color.Orange;
        }



        private void button15_Click_2(object sender, EventArgs e) // READ ONLY
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).ReadOnly = false;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);

            MessageBox.Show("ODBLOKOWANO MOŻLIWOŚĆ WPISYWANIA PARAMETRÓW");

        }

        private void button23_Click_3(object sender, EventArgs e) // ZABLOKUJ
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        (control as TextBox).ReadOnly = true;
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);

            MessageBox.Show("ZABLOKOWANO MOŻLIWOŚĆ WPISYWANIA PARAMETRÓW");
        }

        private void button13_Enter(object sender, EventArgs e)
        {
            if (ULEPSZENIA_MANA1.Enabled == true)
            {
                ULEPSZENIA_MANA1.BackColor = Color.BurlyWood;
            }

            if (button6.Enabled == true)
            {
                button6.BackColor = Color.BurlyWood;
            }

            ActiveControl.BackColor = Color.Orange;

        }

        private void ULEPSZENIA_MANA1_Enter_1(object sender, EventArgs e)
        {
            ULEPSZENIA_MANA1.BackColor = Color.Orange;
            button13.BackColor = Color.BurlyWood;
        }

        private void GB_PRACA_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.Chartreuse;
            timer1.Start();

            if (int.Parse(textBox10.Text) >= 100)
            {
                MessageBox.Show("GRATULACJE BUDOWLA ZOSTAŁA UKOŃCZONA !!!!" + Environment.NewLine + "LUD CZUJE SIĘ BEZPIECZNIE I TERAZ CAŁA OSADA SZYKUJE HUCZNĄ UCZTĘ NA TWOJĄ CZEŚĆ !!!!" + Environment.NewLine + "GRATULACJE !!!!");

                Hide();
                WinGame zwyciestwo = new WinGame(TB_RUNDA.Text, TB6.Text, textBox19.Text, TBnauka.Text);
                zwyciestwo.Show();
            }
        }

        private void rad_TAK_Click(object sender, EventArgs e)
        {
            rad_TAK.BackColor = Color.Orange;
            rad_NIE.BackColor = Color.BurlyWood;
            rad_NIE.Enabled = true;
            rad_TAK.Enabled = false;
            toolTip1.Active = true;
        }

        private void rad_NIE_Click(object sender, EventArgs e)
        {
            rad_NIE.BackColor = Color.Orange;
            rad_TAK.BackColor = Color.BurlyWood;
            rad_NIE.Enabled = false;
            rad_TAK.Enabled = true;
            toolTip1.Active = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            groupBox_Nowa_gra.Visible = true;
            button19.Select();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int klikMana = 0;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            klikMana = klikMana + 1;
            if (klikMana > 5)
            {
                MessageBox.Show("Odblokowałeś tajemną opcję - możesz zmieniać parametry gry w trakcie ! ");
                groupBox3.Visible = true;
            }
        }
    }
}





