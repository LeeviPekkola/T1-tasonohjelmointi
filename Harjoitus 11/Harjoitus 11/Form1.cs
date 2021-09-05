using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeitäBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
        }
        private void piirraNoppa(PictureBox Noppabox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch(noppa)
            {
                case 1:
                    Noppabox.Image = Properties.Resources.noppa1;
                    break;
                case 2:
                    Noppabox.Image = Properties.Resources.noppa2;
                    break;
                case 3:
                    Noppabox.Image = Properties.Resources.noppa3;
                    break;
                case 4:
                    Noppabox.Image = Properties.Resources.noppa4;
                    break;
                case 5:
                    Noppabox.Image = Properties.Resources.noppa5;
                    break;
                case 6:
                    Noppabox.Image = Properties.Resources.noppa6;
                    break;
            }
        }
    }
}
