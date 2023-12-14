using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Toodet_Dotskin
{
    public partial class Form1 : Form
    {
        SqlConnection connect=new SqlConnection(@"Data Source=HP-CZC2349HTM;Initial Catalog=ABtoode;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        OpenFileDialog open;
        SaveFileDialog save;
        int Id;
        DataGridViewComboBoxColumn combo_kat;

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
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                Kat_box.Items.Add(item["Kategooria_nimetus"]);
            }
            connect.Close();
        }
            //    Kat_box.Items.Clear();
            //    Kat_box.Text = "";
            //    connect.Open();
            //    adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooriatabel", connect);
            //    DataTable dt_kat = new DataTable();
            //    adapter_kategooria.Fill(dt_kat);
            //    foreach (DataRow item in dt_kat.Rows)
            //    {
            //        if (!Kat_box.Items.Contains(item["Kategooria_nimetus"]))
            //            Kat_box.Items.Add(item["Kategooria_nimetus"]);
            //        else
            //        {
            //            command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Id=@Id", connect);
            //            command.Parameters.AddWithValue("@Id", item["Id"]);
            //            command.ExecuteNonQuery();
            //        }
            //    }
            //    connect.Close();
            //}


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

                    command.Parameters.AddWithValue("@pilt", textBox_toode.Text+".jpg");

                    command.Parameters.AddWithValue("@kat", Kat_box.SelectedIndex+1);//id?!!!!!!!!!!!
                    command.ExecuteNonQuery();
                    connect.Close();

                    NaitaAndmed();

                    Eemalda();


                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }

        private void button_Kustuta_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() != string.Empty)
            {
                try
                {



                    command = new SqlCommand("delete from Toodetabel " +
                        "where Id=@id", connect);
                    connect.Open();


                    command.Parameters.AddWithValue("@id", textBox_id.Text);
                    command.ExecuteNonQuery();
                    connect.Close();

                    NaitaAndmed();
                    Eemalda();
                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Tühi Id!");
            }

        }

        private void button_Uuenda_Click(object sender, EventArgs e)
        {
            if (textBox_hind.Text.Trim() != string.Empty && textBox_toode.Text.Trim() != string.Empty && textBox_kogus.Text.Trim() != string.Empty && Kat_box.SelectedItem != null && textBox_id.Text.Trim() != string.Empty)
            {
                try
                {



                    command = new SqlCommand("update Toodetabel " +
                        "set ToodeNimetus = @tod_nim, Kogus = @kogus, Hind = @hind, Pilt= @pilt, Kategooriat = @kat " +
                        "where Id=@id", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@tod_nim", textBox_toode.Text);

                    command.Parameters.AddWithValue("@kogus", textBox_kogus.Text);

                    command.Parameters.AddWithValue("@hind", textBox_hind.Text);

                    command.Parameters.AddWithValue("@pilt", textBox_hind.Text + ".jpg");

                    command.Parameters.AddWithValue("@kat", Kat_box.SelectedIndex + 1);//id?!!!!!!!!!!!

                    command.Parameters.AddWithValue("@id", textBox_id.Text);
                    command.ExecuteNonQuery();
                    connect.Close();

                    NaitaAndmed();
                    Eemalda();
                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Tühjad väljad!");
            }
        }

        private void otsi_file_button_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\pictures";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            //FileInfo open_info = new FileInfo(@"C:\Users\opilane\Pictures\" + open.FileName);

            if (open.ShowDialog() == DialogResult.OK && textBox_toode.Text!=null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\Toodet_Dotskin\pildid\");
                save.FileName = textBox_toode.Text + Path.GetExtension(open.FileName);
                save.Filter = "pildid" + Path.GetExtension(open.FileName)+"|"+Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox_Toode.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud cancel");
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            textBox_toode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_kogus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_hind.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            try
            {
                pictureBox_Toode.Image = Image.FromFile(@"C:\Users\opilane\source\repos\Toodet_Dotskin\pildid\" + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Pilt puudub");

            }
            Kat_box.SelectedItem= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_eemalda_Click(object sender, EventArgs e)
        {
            Eemalda();
        }

        private void pictureBox_Toode_Click(object sender, EventArgs e)
        {

        }

        public void NaitaAndmed()
        {
            //connect.Open();
            //DataTable dt_toode= new DataTable();
            //adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetabel", connect);
            //adapter_toode.Fill(dt_toode);
            //dataGridView1.DataSource = dt_toode;
            //connect.Close();


            connect.Open();

            DataTable dt_toode = new DataTable();

            adapter_toode = new SqlDataAdapter("SELECT [Toodetabel].Id, [Toodetabel].ToodeNimetus, [Toodetabel].Kogus, [Toodetabel].Hind, [Toodetabel].Pilt, Kategooriatabel.Kategooria_nimetus FROM [Toodetabel] INNER JOIN Kategooriatabel on [Toodetabel].Kategooriat=Kategooriatabel.Id", connect);

            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooria";
            combo_kat.Name = "KategooriaColumn";
            combo_kat.DataPropertyName = "Kategooria";
            HashSet<string> uniqueCategories = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string category = item["Kategooria_nimetus"].ToString();
                if (!uniqueCategories.Contains(category))
                {
                    uniqueCategories.Add(category);
                    combo_kat.Items.Add(category);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
            dataGridView1.Columns["Kategooria_nimetus"].Visible = false;

            connect.Close();
            
        }
        public void Eemalda()
        {
            textBox_id.Clear();
            textBox_hind.Clear();

            textBox_kogus.Clear();
            textBox_toode.Clear();
            pictureBox_Toode.Image = Image.FromFile(@"C:\Users\opilane\pictures\main.jpg");
            Kat_box.Text = null;
        }
    }
}
