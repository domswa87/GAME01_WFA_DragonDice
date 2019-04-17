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
    public partial class MainMenu : Form
    {
      
        public MainMenu()
        {
            InitializeComponent();
            button19.Select();
         
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)  // PRZYPISANIE KLAWISZA
        {
            if (textBox1.Text == "1")
            {
                if (keyData == ((Keys.Right)) || (keyData == (Keys.Left)))
                {
                    return true;
                }
                if (keyData == (Keys.Down))
                {
                    button3.Select();
                    button19.BackColor = Color.BurlyWood;
                    button3.BackColor = Color.Orange;
                    return true;
                }
                if (keyData == (Keys.Up))
                {
                    button12.Select();
                    button12.BackColor = Color.Orange;
                    button19.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Enter)))
                {
                    button19.Select();
                    button19.BackColor = Color.Yellow;
                }
            }

            if (textBox1.Text == "2")
            {
                if (keyData == (Keys.Up))
                {
                    button3.Select();
                    button14.BackColor = Color.BurlyWood;
                    button3.BackColor = Color.Orange;
                    return true;
                }
                if ((keyData == (Keys.Down)))
                {
                    button14.BackColor = Color.BurlyWood;
                    if (textBox2.Text == "NIE")
                    {
                        rad_NIE.Select();
                        rad_NIE.BackColor = Color.Orange;
                        rad_TAK.BackColor = Color.BurlyWood;
                        return true;
                    }
                    else
                    {
                        rad_TAK.Select();
                        rad_TAK.BackColor = Color.Orange;
                        rad_NIE.BackColor = Color.BurlyWood;
                        return true;
                    }
                }
                if (keyData == ((Keys.Left)) || keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == ((Keys.Enter)))
                {
                    button14.BackColor = Color.Yellow;
                }
            }

            if (textBox1.Text == "3")
            {
                if (keyData == (Keys.Up))
                {
                    button14.Select();
                    button14.BackColor = Color.Orange;
                    if (textBox2.Text == "NIE")
                    {
                        rad_NIE.BackColor = Color.Orange;
                        rad_TAK.BackColor = Color.BurlyWood;
                    }
                    else
                    {
                        rad_TAK.BackColor = Color.Orange;
                        rad_NIE.BackColor = Color.BurlyWood;
                    }
                    return true;
                }


                if (keyData == (Keys.Down))
                {
                    button15.Select();
                    button15.BackColor = Color.Orange;


                    return true;
                }


                if (keyData == (Keys.Right))
                {
                    if (textBox2.Text == "NIE")
                    {
                        return true;
                    }
                    else
                    {
                        rad_NIE.Select();
                        rad_NIE.BackColor = Color.Orange;
                        rad_TAK.BackColor = Color.BurlyWood;
                        return true;
                    }
                }

                if (keyData == (Keys.Left))
                {
                    if (textBox2.Text == "TAK")
                    {
                        return true;
                    }
                    else
                    {
                        rad_TAK.Select();
                        rad_TAK.BackColor = Color.Orange;
                        rad_NIE.BackColor = Color.BurlyWood;
                        return true;
                    }
                }
            }

            if (textBox1.Text == "4")
            {
                if (keyData == ((Keys.Left)) || keyData == (Keys.Right))
                {
                    return true;
                }

                if (keyData == ((Keys.Down)))
                {
                    button2.Select();
                    button2.BackColor = Color.Orange;
                    button15.BackColor = Color.BurlyWood;
                    richTextBox1.Visible = false;
                    return true;
                }
                if (keyData == ((Keys.Up)))
                {
                    if (textBox2.Text == "NIE")
                    {
                        rad_NIE.Select();
                        rad_NIE.BackColor = Color.Orange;
                        button15.BackColor = Color.BurlyWood;
                        richTextBox1.Visible = false;

                    }
                    else
                    {
                        rad_TAK.Select();
                        rad_TAK.BackColor = Color.Orange;
                        button15.BackColor = Color.BurlyWood;
                        richTextBox1.Visible = false;

                    }
                    return true;
                }

                if (keyData == ((Keys.Enter)))
                {
                    button15.Select();
                    button15.BackColor = Color.Yellow;
                }

            }

            if (textBox1.Text == "5")
            {
                if (keyData == ((Keys.Left)) || keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == ((Keys.Down)))
                {
                    button19.Select();
                    button19.BackColor = Color.Orange;
                    button12.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Up)))
                {
                    button2.Select();

                    button2.BackColor = Color.Orange;
                    button12.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Enter)))
                {
                    button12.Select();
                    button12.BackColor = Color.Yellow;
                }
            }


            if (textBox1.Text == "6")
            {
                if (keyData == ((Keys.Left)) || keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == ((Keys.Down)))
                {
                    button14.Select();
                    button14.BackColor = Color.Orange;
                    button3.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Up)))
                {
                    button19.Select();

                    button19.BackColor = Color.Orange;
                    button3.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Enter)))
                {
                    button3.Select();
                    button3.BackColor = Color.Yellow;
                }
            }

            if (textBox1.Text == "7")
            {
                if (keyData == ((Keys.Left)) || keyData == (Keys.Right))
                {
                    return true;
                }
                if (keyData == ((Keys.Down)))
                {
                    button12.Select();
                    button12.BackColor = Color.Orange;
                    button2.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Up)))
                {
                    button15.Select();
                    button15.BackColor = Color.Orange;
                    button2.BackColor = Color.BurlyWood;
                    return true;
                }
                if (keyData == ((Keys.Enter)))
                {
                    button2.Select();
                    button2.BackColor = Color.Yellow;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void rad_TAK_Click(object sender, EventArgs e)
        {
            rad_TAK.BackColor = Color.Orange;
            rad_NIE.BackColor = Color.BurlyWood;
            textBox2.Text = "TAK";
        }

        private void rad_NIE_Click(object sender, EventArgs e)
        {
            rad_NIE.BackColor = Color.Orange;
            rad_TAK.BackColor = Color.BurlyWood;
            textBox2.Text = "NIE";
        }

        private void rad_TAK_MouseHover(object sender, EventArgs e)
        {
            if (rad_TAK.BackColor == Color.Orange)
            {
                rad_NIE.BackColor = Color.BurlyWood;
            }
            
        }

        private void rad_NIE_MouseHover(object sender, EventArgs e)
        {
            if (rad_NIE.BackColor == Color.Orange)
            {
                rad_TAK.BackColor = Color.BurlyWood;
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MainBoard dominik2 = new MainBoard(textBox2.Text);
            dominik2.Show();
            Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           label6.Text = (Properties.Settings.Default["REKORD_IMIE"]).ToString();
           label7.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Yellow;
            if (richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
            }
            else
            {
                richTextBox1.Visible = true;
            }
     
        }

      

        private void button19_Enter(object sender, EventArgs e)
        {
            button19.BackColor = Color.Orange;
            textBox1.Text = "1";
        }

        private void button14_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void rad_NIE_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            textBox2.Text = "NIE";
           
          
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = Color.BurlyWood;
            button14.Select();
            button15.BackColor = Color.BurlyWood;
            button12.BackColor = Color.BurlyWood;
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            button19.Select();
            button14.BackColor = Color.BurlyWood;
            button15.BackColor = Color.BurlyWood;
            button12.BackColor = Color.BurlyWood;
        }

        private void button15_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button12_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "3")
            {
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.Orange;
            }
            else
            {
                label1.ForeColor = Color.SaddleBrown;
                label1.BackColor = Color.BurlyWood;

            }
        }

        private void rad_NIE_EnabledChanged(object sender, EventArgs e)
        {
            if (rad_NIE.Enabled == false)
            {
                textBox2.Text = "NIE";
            }
            else
            {
                textBox2.Text = "TAK";
            }
            
        }

        private void rad_TAK_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "TAK";
            textBox1.Text = "3";
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button19.BackColor = Color.BurlyWood;
            button14.BackColor = Color.BurlyWood;
            button15.Select();
            button12.BackColor = Color.BurlyWood;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = Color.BurlyWood;
            button14.BackColor = Color.BurlyWood;
            button15.BackColor = Color.BurlyWood;
            button12.Select();
        }

  
        private void button15_KeyUp(object sender, KeyEventArgs e)
        {
            button15.BackColor = Color.Orange;
        }

        private void button12_KeyUp(object sender, KeyEventArgs e)
        {
            button12.BackColor = Color.Orange;
        }

        private void button14_KeyUp(object sender, KeyEventArgs e)
        {
            button14.BackColor = Color.Orange;
        }

        private void button19_KeyUp(object sender, KeyEventArgs e)
        {
            button19.BackColor = Color.Orange;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz skasować rekord ?" + Environment.NewLine + "(Brak rekordu wyłącza opcję 'WŁASNY SCENARIUSZ')", "KASUJ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                label7.Text = "0";
                label6.Text = "0";
                Properties.Settings.Default["REKORD_PUNKTY"] = label7.Text;
                Properties.Settings.Default.Save();

                Properties.Settings.Default["REKORD_IMIE"] = label6.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("SKASKOWANO REKORD");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label6.Text != "0")
            {
               
            SettingsForm dominik6 = new SettingsForm("0");
            dominik6.Show();

            Hide();

                // Visible = false;
            }
            else
            {
                MessageBox.Show("Ta opcja jest dostępna dopiero po pokonaniu smoka");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("dominik.swatek87@gmail.com");
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Select();
            button19.BackColor = Color.BurlyWood;
            button14.BackColor = Color.BurlyWood;
            button15.BackColor = Color.BurlyWood;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Select();
            button19.BackColor = Color.BurlyWood;
            button14.BackColor = Color.BurlyWood;
            button15.BackColor = Color.BurlyWood;
        }
    }
}
