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
    public partial class SettingsForm : Form
    {
        public SettingsForm(string tekst)
        {
            InitializeComponent();
            label1.Text = tekst;
            if (label1.Text == "koniec")
            {

            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                button2.Visible = false;
            }

        }

       

        private void button10_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e) // START
        {
            try
            {
                int.Parse(TB1.Text);
                int.Parse(TB2.Text);
                int.Parse(TB3.Text);
                int.Parse(TB4.Text);
                int.Parse(TB5.Text);
                int.Parse(TB6.Text);
                int.Parse(TB7.Text);
                int.Parse(TB8.Text);
                int.Parse(TB9.Text);
                int.Parse(TB10.Text);
                int.Parse(TB11.Text);
                int.Parse(TB12.Text);
                int.Parse(TB13.Text);
                int.Parse(TB14.Text);
                int.Parse(TB15.Text);
                int.Parse(TB16.Text);
                int.Parse(TB17.Text);
                int.Parse(TB18.Text);
                int.Parse(TB19.Text);
                int.Parse(TB20.Text);
                int.Parse(TB21.Text);
                int.Parse(TB22.Text);
                int.Parse(TB23.Text);
                int.Parse(TB24.Text);
                int.Parse(TB25.Text);
                int.Parse(TB26.Text);
            }

            catch
            {
                MessageBox.Show("BŁĄD - wpisane wartości muszą być liczbą");
                ActiveControl.Text = "0";
                return;
            }
            





           /* bool zmTry1 = true;
            bool zmTry2 = true;
            bool zmTry3 = true;
            bool zmTry4 = true; 
            bool zmTry5 = true; 
            bool zmTry6 = true; 
            bool zmTry7 = true; 
            bool zmTry8 = true; 
            bool zmTry9 = true; 
            bool zmTry10 = true; 
            bool zmTry11 = true; 
            bool zmTry12 = true; 
            bool zmTry13 = true; 
            bool zmTry14 = true; 
            bool zmTry15 = true; 
            bool zmTry16 = true; 
            bool zmTry17 = true; 
            bool zmTry18 = true; 
            bool zmTry19 = true; 
            bool zmTry20 = true; 
            bool zmTry21 = true; 
            bool zmTry22 = true; 
            bool zmTry23 = true; 
            bool zmTry24 = true; 
            bool zmTry25 = true; 
            bool zmTry26 = true; 



            bool.TryParse(TB1.Text, out zmTry1);
            bool.TryParse(TB2.Text, out zmTry2);
            bool.TryParse(TB3.Text, out zmTry3);
            bool.TryParse(TB4.Text, out zmTry4);
            bool.TryParse(TB5.Text, out zmTry5);
            bool.TryParse(TB6.Text, out zmTry6);
            bool.TryParse(TB7.Text, out zmTry7);
            bool.TryParse(TB8.Text, out zmTry8);
            bool.TryParse(TB9.Text, out zmTry9);
            bool.TryParse(TB10.Text, out zmTry10);
            bool.TryParse(TB11.Text, out zmTry11);
            bool.TryParse(TB12.Text, out zmTry12);
            bool.TryParse(TB13.Text, out zmTry13);
            bool.TryParse(TB14.Text, out zmTry14);
            bool.TryParse(TB15.Text, out zmTry15);
            bool.TryParse(TB16.Text, out zmTry16);
            bool.TryParse(TB17.Text, out zmTry17);
            bool.TryParse(TB18.Text, out zmTry18);
            bool.TryParse(TB19.Text, out zmTry19);
            bool.TryParse(TB20.Text, out zmTry20);
            bool.TryParse(TB21.Text, out zmTry21);
            bool.TryParse(TB22.Text, out zmTry22);
            bool.TryParse(TB23.Text, out zmTry23);
            bool.TryParse(TB24.Text, out zmTry24);
            bool.TryParse(TB25.Text, out zmTry25);
            bool.TryParse(TB26.Text, out zmTry26);

            if (((zmTry1 && zmTry2 && zmTry3 && zmTry4 && zmTry5 && zmTry6 && zmTry7 && zmTry8 && zmTry9 && zmTry10 && zmTry11 && zmTry12 && zmTry13 && zmTry14 && zmTry15 && zmTry16 && zmTry17 && zmTry18 && zmTry19 && zmTry20 && zmTry21 && zmTry22 && zmTry23 && zmTry24 && zmTry25 && zmTry26) == true))
            {
                MessageBox.Show("BŁĄD - wpisane wartości nie są liczbami całkowitymi");
            }
            else
            {
            */

                Properties.Settings.Default["ZM1"] = TB1.Text;
                Properties.Settings.Default["ZM2"] = TB2.Text;
                Properties.Settings.Default["ZM3"] = TB3.Text;
                Properties.Settings.Default["ZM4"] = TB4.Text;
                Properties.Settings.Default["ZM5"] = TB5.Text;
                Properties.Settings.Default["ZM6"] = TB6.Text;
                Properties.Settings.Default["ZM7"] = TB7.Text;
                Properties.Settings.Default["ZM8"] = TB8.Text;
                Properties.Settings.Default["ZM9"] = TB9.Text;
                Properties.Settings.Default["ZM10"] = TB10.Text;
                Properties.Settings.Default["ZM11"] = TB11.Text;
                Properties.Settings.Default["ZM12"] = TB12.Text;
                Properties.Settings.Default["ZM13"] = TB13.Text;
                Properties.Settings.Default["ZM14"] = TB14.Text;
                Properties.Settings.Default["ZM15"] = TB15.Text;
                Properties.Settings.Default["ZM16"] = TB16.Text;
                Properties.Settings.Default["ZM17"] = TB17.Text;
                Properties.Settings.Default["ZM18"] = TB18.Text;
                Properties.Settings.Default["ZM19"] = TB19.Text;
                Properties.Settings.Default["ZM20"] = TB20.Text;
                Properties.Settings.Default["ZM21"] = TB21.Text;
                Properties.Settings.Default["ZM22"] = TB22.Text;
                Properties.Settings.Default["ZM23"] = TB23.Text;
                Properties.Settings.Default["ZM24"] = TB24.Text;
                Properties.Settings.Default["ZM25"] = TB25.Text;
                Properties.Settings.Default["ZM26"] = TB26.Text;


                Properties.Settings.Default.Save();

                
                Hide();
                MainBoard dominik2 = new MainBoard("TEST");
                dominik2.Show();
                Visible = false;
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) // PRZYWRÓĆ DOMYŚLNE
        {

            TB1.Text = "15";
            TB2.Text = "2";
            TB3.Text = "2";
            TB4.Text = "1";
            TB5.Text = "1";
            TB6.Text = "3";
            TB7.Text = "3";
            TB8.Text = "1";
            TB9.Text = "1";
            TB10.Text = "6";
            TB11.Text = "6";
            TB12.Text = "1";
            TB13.Text = "3";
            TB14.Text = "10";
            TB15.Text = "10";
            TB16.Text = "1";
            TB17.Text = "2";
            TB18.Text = "50";
            TB19.Text = "10";
            TB20.Text = "30";
            TB21.Text = "30";
            TB22.Text = "50";
            TB23.Text = "100";
            TB24.Text = "25";
            TB25.Text = "1";
            TB26.Text = "5";


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            TB1.Text = (Properties.Settings.Default["ZM1"]).ToString();
            TB2.Text = (Properties.Settings.Default["ZM2"]).ToString();
            TB3.Text = (Properties.Settings.Default["ZM3"]).ToString();
            TB4.Text = (Properties.Settings.Default["ZM4"]).ToString();
            TB5.Text = (Properties.Settings.Default["ZM5"]).ToString();
            TB6.Text = (Properties.Settings.Default["ZM6"]).ToString();
            TB7.Text = (Properties.Settings.Default["ZM7"]).ToString();
            TB8.Text = (Properties.Settings.Default["ZM8"]).ToString();
            TB9.Text = (Properties.Settings.Default["ZM9"]).ToString();
            TB10.Text = (Properties.Settings.Default["ZM10"]).ToString();
            TB11.Text = (Properties.Settings.Default["ZM11"]).ToString();
            TB12.Text = (Properties.Settings.Default["ZM12"]).ToString();
            TB13.Text = (Properties.Settings.Default["ZM13"]).ToString();
            TB14.Text = (Properties.Settings.Default["ZM14"]).ToString();
            TB15.Text = (Properties.Settings.Default["ZM15"]).ToString();
            TB16.Text = (Properties.Settings.Default["ZM16"]).ToString();
            TB17.Text = (Properties.Settings.Default["ZM17"]).ToString();
            TB18.Text = (Properties.Settings.Default["ZM18"]).ToString();
            TB19.Text = (Properties.Settings.Default["ZM19"]).ToString();
            TB20.Text = (Properties.Settings.Default["ZM20"]).ToString();
            TB21.Text = (Properties.Settings.Default["ZM21"]).ToString();
            TB22.Text = (Properties.Settings.Default["ZM22"]).ToString();
            TB23.Text = (Properties.Settings.Default["ZM23"]).ToString();
            TB24.Text = (Properties.Settings.Default["ZM24"]).ToString();
            TB25.Text = (Properties.Settings.Default["ZM25"]).ToString();
            TB26.Text = (Properties.Settings.Default["ZM26"]).ToString();
           





            if (label1.Text == "koniec")
            {

                button1.Visible = false;
               // button19.Visible = false;
                button10.Visible = false;
                button8.Visible = false;
                
              

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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                int.Parse(TB1.Text);
                int.Parse(TB2.Text);
                int.Parse(TB3.Text);
                int.Parse(TB4.Text);
                int.Parse(TB5.Text);
                int.Parse(TB6.Text);
                int.Parse(TB7.Text);
                int.Parse(TB8.Text);
                int.Parse(TB9.Text);
                int.Parse(TB10.Text);
                int.Parse(TB11.Text);
                int.Parse(TB12.Text);
                int.Parse(TB13.Text);
                int.Parse(TB14.Text);
                int.Parse(TB15.Text);
                int.Parse(TB16.Text);
                int.Parse(TB17.Text);
                int.Parse(TB18.Text);
                int.Parse(TB19.Text);
                int.Parse(TB20.Text);
                int.Parse(TB21.Text);
                int.Parse(TB22.Text);
                int.Parse(TB23.Text);
                int.Parse(TB24.Text);
                int.Parse(TB25.Text);
                int.Parse(TB26.Text);

        
                if (ActiveControl is TextBox)
                {
                    if ((int.Parse(ActiveControl.Text) > 100) || (int.Parse(ActiveControl.Text) < 0))
                    {
                        MessageBox.Show("Należy wpisać liczbę z przedziału: 0-100");
                        ActiveControl.Text = "0";
                    }
                    return;
                }
                
            
            }

            catch
            {
                    MessageBox.Show("BŁĄD - wpisane wartości muszą być liczbą");
                    ActiveControl.Text = "0";
                    return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ZAKOŃCZ GRE I WRÓĆ DO MENU GŁÓWNEGO", "POWRÓT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();

                MainMenu dominik2 = new MainMenu();
                Hide();
                dominik2.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
