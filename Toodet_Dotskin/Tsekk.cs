using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics;

namespace Toodet_Dotskin
{
    public partial class Tsekk : Form
    {

        string path,nimi;
        public Tsekk(string filePath , string nim)
        {

            InitializeComponent();


            DateTime aeg = DateTime.Now;

            aeglbl.Text = aeg.ToString();


            path = filePath;

            nimi = nim;

            button1Fail.Text = nimi;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }
    }
}
