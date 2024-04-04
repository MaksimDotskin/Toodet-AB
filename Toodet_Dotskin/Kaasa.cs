using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toodet_Dotskin
{
    public partial class Kaasa : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\Toodet-AB\Toodet_Dotskin\AppData\Toodet_DB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_toode, adapter_kategooria, adapter_pilt;
        SqlCommand command;
        OpenFileDialog open;
        SaveFileDialog save;
        int Id;
        DataGridViewComboBoxColumn combo_kat;
        string extension = null;
        bool isOmanik;
        int summa;
        int kasutajaId;
        List<string> katNimetusList;



        string nimi;
        public Kaasa(string Nimi, bool IsOmanik,int kasId)
        {



            InitializeComponent();
            nimi = Nimi;
            isOmanik = IsOmanik;
            kasutajaId= kasId;

            lblTervitamine.Text = "Tere, " + Nimi;
            lblSumma.Text = "0";


            Kat_box.Text = "Valitage kategooriat";



           


            if (isOmanik)
            {
                btnToode.Visible = true;
            }
            else
            {
                btnToode.Visible = false;

            }
            NaitaAndmed();
            calculateSum();
            NaitaBoonused(kasutajaId);





        }
        public void calculateSum()
        {
            summa = 0;

            foreach (string item in listBoxOstukorv.Items)
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand("SELECT Hind FROM Toodetabel WHERE ToodeNimetus = @item", connect);
                command1.Parameters.AddWithValue("@item", item);
                SqlDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    int n;
                    if (int.TryParse(reader["Hind"].ToString(), out n))
                    {
                        summa += n;
                    }
                }

                reader.Close();
                connect.Close();
            }

    
            if (listBoonused.SelectedItem != null)
            {
                int selectedBoonusPercent = (int)listBoonused.SelectedItem;
                double bonusAmount = (double)summa * selectedBoonusPercent / 100;
                summa -= (int)bonusAmount;
            }

            lblSumma.Text = summa.ToString();
        }









        public void NaitaAndmed()
            {
                connect.Open();

                SqlCommand command1 = new SqlCommand("SELECT Kategooria_nimetus FROM Kategooriatabel", connect);
                SqlDataReader reader = command1.ExecuteReader();
                katNimetusList = new List<string>();
                // Чтение результатов запроса
                while (reader.Read())
                {
                    // Получение значения из столбца "ToodeNimetus" и добавление его в список
                    string katNimetus = reader["Kategooria_nimetus"].ToString();
                    katNimetusList.Add(katNimetus);
                }

                reader.Close();
                connect.Close();


                foreach (string item in katNimetusList)
                {
                    Kat_box.Items.Add(item);
                }


            }

                //connect.Open();
                //List<string> toodeNimetusList = new List<string>();

                //// Создание команды для выполнения запроса
                //SqlCommand command = new SqlCommand("SELECT ToodeNimetus FROM Toodetabel where Kategooriat=@katId", connect);
                //command.Parameters.AddWithValue("@katId", );


                //while (reader.Read())
                //{
                //    // Получение значения из столбца "ToodeNimetus" и добавление его в список
                //    string toodeNimetus = reader["ToodeNimetus"].ToString();
                //    toodeNimetusList.Add(toodeNimetus);

                //}

                //reader.Close();

                //connect.Close();

                //foreach (string item in toodeNimetusList)
                //{
                //    listBoxToodet.Items.Add(item);
                //}







            

            private void pictureBox_Toode_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                listBoxOstukorv.BeginUpdate();
                foreach (object Item in listBoxToodet.SelectedItems)
                {
                    listBoxOstukorv.Items.Add(Item);
                }
                listBoxOstukorv.EndUpdate();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

        private void Kat_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            List<string> toodeNimetusList = new List<string>();

            int id = Kat_box.SelectedIndex + 1;
            // Создание команды для выполнения запроса
            SqlCommand command = new SqlCommand("SELECT ToodeNimetus,Kogus FROM Toodetabel where Kategooriat=" + id, connect);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string toodeNimetus = reader["ToodeNimetus"].ToString();
                int kogus = (int)reader["Kogus"];
                if (kogus > 0)
                {
                    toodeNimetusList.Add(toodeNimetus);
                }
            }

            reader.Close();
            connect.Close();

            listBoxToodet.Items.Clear();

            foreach (string item in toodeNimetusList)
            {
                listBoxToodet.Items.Add(item);
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
            {
          
                
                listBoxOstukorv.Items.RemoveAt(listBoxOstukorv.SelectedIndex);
      
            }

            private void Kaasa_Load(object sender, EventArgs e)
            {

            }

        private void buttonArvuta_Click(object sender, EventArgs e)
        {
            calculateSum();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBoxToodet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxToodet.SelectedItem != null) // Проверяем, выбран ли какой-то элемент
            {
                connect.Open();
                SqlCommand command1 = new SqlCommand("SELECT Hind,Kogus FROM Toodetabel WHERE ToodeNimetus = @item", connect);
                command1.Parameters.AddWithValue("@item", listBoxToodet.SelectedItem.ToString()); // Преобразуем выбранный элемент в строку и передаем его как параметр
                SqlDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    int n;
                    if (int.TryParse(reader["Hind"].ToString(), out n))
                    {
                        labelHind.Text = n.ToString();
                        labelKogus2.Text = reader["Kogus"].ToString();

                    }
                }

                reader.Close();
                connect.Close();
            }
        }
        public void NaitaBoonused(int kasutajaId)
        {
            connect.Open();

            SqlCommand command1 = new SqlCommand("SELECT boonus FROM kliendidTabel WHERE kasutajaId=@id", connect);
            command1.Parameters.AddWithValue("@id", kasutajaId);
            SqlDataReader reader = command1.ExecuteReader();
            List<int> listBoonused1 = new List<int>();

            while (reader.Read())
            {
                int boonus = reader.GetInt32(reader.GetOrdinal("boonus"));
                listBoonused1.Add(boonus);
            }

            reader.Close();
            connect.Close();

            listBoonused.Items.Clear();

            foreach (int item in listBoonused1)
            {
                listBoonused.Items.Add(item);
            }
            
        }


        private void btnMaksma_Click(object sender, EventArgs e)
        {




            // Проходим по каждому товару в корзине
            foreach (var item in listBoxOstukorv.Items)
            {
                // Удаляем товар из базы данных и передаем его название и количество
                RemoveProductFromDatabase(item.ToString(), 1); // Здесь предполагается, что удаляется одна единица товара
            }

            listBoxOstukorv.Items.Clear();
        }
       

        private void RemoveProductFromDatabase(string productName, int quantity)
        {
            connect.Open();

            // Создаем команду для удаления товара из базы данных по его названию и количеству
            SqlCommand command = new SqlCommand("UPDATE Toodetabel SET Kogus = Kogus - @quantity WHERE ToodeNimetus = @productName", connect);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@productName", productName);

            // Выполняем команду
            command.ExecuteNonQuery();

            connect.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Kasutajad kas = new Kasutajad();
            kas.ShowDialog();
        }

        private void listBoonused_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSum();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }
        }
    }
