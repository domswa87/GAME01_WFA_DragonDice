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
    public partial class WinGame : Form
    {
        public WinGame(string runda, string jedzenie, string drewno, string nauka)
        {
            InitializeComponent();


                string TB_RUNDA = runda;
                string TB6 = jedzenie;
                string textBox19 = drewno;

                textBox34.Text = (50 - int.Parse(TB_RUNDA)).ToString(); // RUNDA
                textBox36.Text = (int.Parse(textBox34.Text) * 1000).ToString();

                textBox37.Text = int.Parse(TB6).ToString(); // JEDZENIE
                textBox41.Text = int.Parse(TB6).ToString();

                textBox38.Text = int.Parse(textBox19).ToString(); // DREWNO
                textBox42.Text = (int.Parse(textBox19) * 5).ToString();

                textBox43.Text = (int.Parse(textBox36.Text) + int.Parse(textBox41.Text) + int.Parse(textBox42.Text)).ToString();

                label5.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();

            if (int.Parse(textBox43.Text) > int.Parse(label5.Text))
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                button2.Visible = true;
            }

            if (nauka == "TEST")
            {
                PICTURE_WIN.Visible = false;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                label7.Visible = true;
                button2.Visible = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(label7.Visible == true)
            {
                using (var newFrm7 = new SettingsForm("koniec"))
                {
                    newFrm7.ShowDialog();  // execution of Form1 stops until Form2 is closed
                }
            }

           


            label5.Text = (Properties.Settings.Default["REKORD_PUNKTY"]).ToString();

           

            label2.Text = textBox43.Text;
            decimal value = decimal.Parse(textBox43.Text);
            value = Math.Floor(value / 1000);
            switch (value)
            {
                case 0:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN0;
                    break;

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
                default:
                    this.PICTURE_WIN.Image = global::GRA_KOSTKI_v2.Properties.Resources.WIN5;
                    break;
            }

            if (label7.Visible == true)
            {
                Hide();
            }
            else
            {
                MessageBox.Show("TWOJ WYNIK TO: " + textBox43.Text + Environment.NewLine + Environment.NewLine + "CZY DASZ RADĘ GO POPRAWIĆ ? ");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // zapisz rekord
        {
            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("wpisz swoje imię - co najmniej 3 znaki");
            }
            else
            {
                label5.Text = label2.Text;
                Properties.Settings.Default["REKORD_IMIE"] = textBox1.Text;
                Properties.Settings.Default.Save();

                Properties.Settings.Default["REKORD_PUNKTY"] = label2.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("ZAPISANO REKORD");
                groupBox1.Visible = false;

                button2.Visible = true;
            }
        }

        private void PICTURE_WIN_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("KONIEC GRY");
            MainMenu menu = new MainMenu();
            menu.Show();
            Hide();
        }
    }
}
