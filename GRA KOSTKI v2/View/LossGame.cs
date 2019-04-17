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
    public partial class LossGame : Form
    {
        public LossGame()
        {
            InitializeComponent();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult dialogResult = MessageBox.Show("KONIEC GRY", "Porazka", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                MainMenu form2_powrot = new MainMenu();
                Hide();
                form2_powrot.Show();
            }       
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
