using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toodet_Dotskin
{
    public partial class Registreerimine : Form
    {
        public Registreerimine()
        {
            InitializeComponent();
        }

        private void registration_button_Click(object sender, EventArgs e)
        {

            bool isOmanik;
            if (namebox.Text!=null)
            {

                if(rollbox.Text=="Omanik")
                {
                    isOmanik= true;
                }
                else
                {
                    isOmanik= false;
                }
                string nimi=namebox.Text;
                Kaasa kasa = new Kaasa(nimi, isOmanik);




                
                kasa.ShowDialog();
                

            }
        }
    }
}
