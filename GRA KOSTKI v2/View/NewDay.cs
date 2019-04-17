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
    public partial class NewDay : Form
    {
        
       
        public NewDay(string runda, string chlopi, string drwale, string mana, string prace)
        {
            InitializeComponent();
            TB_Nowa_Runda.Text = runda;
            textBox45.Text = chlopi;
            textBox46.Text = drwale;
            textBox33.Text = mana;
            textBox44.Text = prace;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)  // PRZYPISANIE KLAWISZA
        {
            if (ActiveControl.Name=="button24")
            {
                if ((keyData == (Keys.Up)) || (keyData == (Keys.Down)) || (keyData == (Keys.Left)) || (keyData == (Keys.Right)))
                {
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    


    private void button24_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button24.Select();
        }
    }
}
