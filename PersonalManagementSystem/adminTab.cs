using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PersonalManagementSystem
{
    //implemented and designed by Eren Erciyes
    public partial class adminTab : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\pms.mdf;Integrated Security=True;User Instance=True";
        int ID;
        public int searchID=0;//comes from searchForm 
        public bool closed = false;
        public adminTab()
        {
            
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void adminTab_Load(object sender, EventArgs e)
        {
            textBox1.Text = searchID.ToString();
            panel1.Visible = false;
            tabControl1.Visible = false;
            button3_Click(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ID = searchID;
            panel1.Visible = true;
            tabControl1.Visible =true;
            SqlConnection baglanti = new SqlConnection(connstring);
            SqlCommand komut = new SqlCommand("select * from Kisisel_Bilgiler where PersonelID=" +ID, baglanti);
            SqlCommand komut2 = new SqlCommand("select * from Kisisel_Bilgiler inner join Departman on Kisisel_Bilgiler.DepartmanID=Departman.id where PersonelID=" + ID, baglanti);
            SqlCommand komut3 = new SqlCommand("select * from Kisisel_Bilgiler inner join KanGrubu  on Kisisel_Bilgiler.KanGrubu=KanGrubu.id where PersonelID=" + ID, baglanti);
            SqlCommand komut4 = new SqlCommand("select * from Kisisel_Bilgiler inner join Unvan on Kisisel_Bilgiler.Unvan=Unvan.id where PersonelID=" + ID, baglanti);
            SqlCommand komut5 = new SqlCommand("select * from Kisisel_Bilgiler inner join Tip on Kisisel_Bilgiler.Tip=Tip.id where PersonelID=" + ID, baglanti);
            SqlCommand komut6 = new SqlCommand("select * from Kisisel_Bilgiler inner join Bolumler on Kisisel_Bilgiler.BolumID=Bolumler.id where PersonelID=" + ID, baglanti);
            SqlDataReader reader;
            baglanti.Open();
            reader = komut.ExecuteReader();

            while (reader.Read())
            {
                lblAdSoyad.Text="Name Surname : "+reader["Ad"].ToString().TrimEnd()+"  "+reader["Soyad"].ToString().TrimEnd();
                textBox9.Text = reader["TcKimlikNo"].ToString().TrimEnd();
                textBox10.Text = reader["Cinsiyet"].ToString().TrimEnd();
                textBox12.Text = reader["Ev_Tel_No"].ToString().TrimEnd();
                textBox13.Text = reader["Cep_No"].ToString().TrimEnd();
                textBox14.Text = reader["Adres"].ToString().TrimEnd();
                textBox4.Text = reader["IseGirisTarihi"].ToString().TrimEnd();
                textBox5.Text = reader["KurumSicilNo"].ToString().TrimEnd();
            }
            reader.Close();
            baglanti.Close();
            /// 
            baglanti.Open();

            reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                lblBirim.Text ="Faculty: "+ reader["Fakulte"].ToString().TrimEnd();

            }
            reader.Close();
            baglanti.Close();
            ///
            baglanti.Open();
            reader = komut3.ExecuteReader();
            while (reader.Read())
            {
                textBox11.Text = reader["Grup"].ToString().TrimEnd();

            }
            
            baglanti.Close();
            //
            baglanti.Open();
            reader = komut4.ExecuteReader();
            while (reader.Read()) 
            {
                textBox2.Text = reader["Unvani"].ToString().TrimEnd();

            }
            baglanti.Close();

            ///
            baglanti.Open();
            reader = komut5.ExecuteReader();
            while (reader.Read())
            {
                textBox3.Text = reader["Gorevi"].ToString().TrimEnd();

            }
            baglanti.Close();
            ///
            baglanti.Open();
            reader = komut6.ExecuteReader();
            while (reader.Read())
            {
                lblBolum.Text ="Department: " +reader["BolumAdi"].ToString().TrimEnd();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connstring);
            SqlCommand komut0 = new SqlCommand("select PersonelID from Kisisel_Bilgiler ", baglanti);
            SqlDataReader reader;
            baglanti.Open();
            reader = komut0.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["PersonelID"].ToString().TrimEnd());

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            closed = true;
        }

    }
}
