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

namespace Toodet_Dotskin
{
    public partial class Tsekk : Form
    {

        string path;
        public Tsekk(string filePath , string nim)
        {

            InitializeComponent();


            DateTime aeg = DateTime.Now;

            labelAeg.Text = aeg.ToString();


            path = filePath;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }
    }
}
