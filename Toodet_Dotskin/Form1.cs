using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toodet_Dotskin
{
    public partial class Form1 : Form
    {
        SqlConnection connect=new SqlConnection(@"Data Source=HP-CZC2349HTM;Initial Catalog=ABtoode;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaKategooriaD();
            lisa_kat_butt.Click += Lisa_Kat_btn_click;
            //button_lisa.Click += Lisa_Toode_btn_click;


        }



        public void NaitaKategooriaD()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus from Kategooriatabel", connect);
            DataTable dt_kat= new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach(DataRow item in dt_kat.Rows )
            {
                Kat_box.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();    
        }
        public void Lisa_Kat_btn_click(object sender, EventArgs e)
        {
            command=new SqlCommand("insert into Kategooriatabel(Kategooria_nimetus) values(@kat)",connect);
            connect.Open();
            command.Parameters.AddWithValue("@kat", Kat_box.Text);
            command.ExecuteNonQuery();
            connect.Close();
            Kat_box.Items.Clear();
            NaitaKategooriaD();
        }
        //public void Lisa_Toode_btn_click(object sender, EventArgs e)
        //{
        //    if (textBox_hind.Text.Trim() != string.Empty && textBox_toode.Text.Trim() != string.Empty && textBox_kogus.Text.Trim() != string.Empty)
        //    {
        //        try
        //        {



        //        command = new SqlCommand("insert into Toodetabel(ToodeNimetus,Kogus,Hind,Kategooriat) values(@tod_nim,@kogus,@hind,@kat)", connect);
        //        connect.Open();
        //        command.Parameters.AddWithValue("@tod_nim", textBox_toode.Text);

        //        command.Parameters.AddWithValue("@kogus", textBox_kogus.Text);

        //        command.Parameters.AddWithValue("@hind", textBox_hind.Text);

        //        command.Parameters.AddWithValue("@kat", Kat_box.Text);
        //        command.ExecuteNonQuery();
        //        connect.Close();
        //        Kat_box.Items.Clear();
        //        textBox_toode.Clear();
        //        textBox_hind.Clear();
        //        textBox_kogus.Clear();
        //        InitializeComponent();
        //        NaitaAndmed();
        //        }
        //        catch (Exception)
        //        {

        //            MessageBox.Show("Andmebaasiga viga!");
        //        }
        //    }


        //}


        private void Kat_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_hind.Text.Trim() != string.Empty && textBox_toode.Text.Trim() != string.Empty && textBox_kogus.Text.Trim() != string.Empty&&Kat_box.SelectedItem!=null)
            {
                try
                {



                    command = new SqlCommand("insert into Toodetabel(ToodeNimetus,Kogus,Hind,Pilt,Kategooriat) values(@tod_nim,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@tod_nim", textBox_toode.Text);

                    command.Parameters.AddWithValue("@kogus", textBox_kogus.Text);

                    command.Parameters.AddWithValue("@hind", textBox_hind.Text);

                    command.Parameters.AddWithValue("@pilt", textBox_hind.Text+".jpg");

                    command.Parameters.AddWithValue("@kat", Kat_box.SelectedIndex+1);//id?!!!!!!!!!!!
                    command.ExecuteNonQuery();
                    connect.Close();

                    NaitaAndmed();
                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }

        private void button_Kustuta_Click(object sender, EventArgs e)
        {

        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode= new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetabel", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;
            connect.Close();

        }
    }
}
