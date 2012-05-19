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

//Implemented by Töre Serter
//

namespace PersonalManagementSystem
{
    public partial class PersonelForm : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\pms.mdf;Integrated Security=True;User Instance=True";
        
        public string sessionUserID;
        public PersonelForm()
        {
            InitializeComponent();
        }
        
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connstring);
            try
            {
                
                baglanti.Open();
                if (baglanti.State.ToString() == "Open")
                {
                    toolStripProgressBar1.Value = 100;
                    toolStripStatusLabel1.Text = "Connected to database succesfully";
                    toolStripStatusLabel1.ForeColor = Color.Green;
                }

                SqlCommand komut = new SqlCommand("Select * from Kisisel_Bilgiler Where PersonelID='" + sessionUserID + "'", baglanti);
                SqlCommand komut2 = new SqlCommand("select * from Kisisel_Bilgiler inner join Departman on Kisisel_Bilgiler.DepartmanID=Departman.id where PersonelID=" + sessionUserID, baglanti);
                SqlCommand komut3 = new SqlCommand("select * from Kisisel_Bilgiler inner join KanGrubu  on Kisisel_Bilgiler.KanGrubu=KanGrubu.id where PersonelID=" + sessionUserID, baglanti);
                SqlCommand komut4 = new SqlCommand("select * from Kisisel_Bilgiler inner join Unvan on Kisisel_Bilgiler.Unvan=Unvan.id where PersonelID=" + sessionUserID, baglanti);
                SqlCommand komut5 = new SqlCommand("select * from Kisisel_Bilgiler inner join Tip on Kisisel_Bilgiler.Tip=Tip.id where PersonelID=" + sessionUserID, baglanti);
                SqlCommand komut6 = new SqlCommand("select * from Kisisel_Bilgiler inner join Bolumler on Kisisel_Bilgiler.BolumID=Bolumler.id where PersonelID=" + sessionUserID, baglanti);
                SqlCommand komut7 = new SqlCommand("Select * from Kisisel_Bilgiler inner join Dersler on Kisisel_Bilgiler.PersonelID=Dersler.id where PersonelID=" + sessionUserID, baglanti);

                SqlDataReader alinan_veri = komut.ExecuteReader();
                alinan_veri.Read();

                NameTextBox.Text = alinan_veri["Ad"].ToString();
                SurnameTextBox.Text = alinan_veri["Soyad"].ToString();
                TcNoTextBox.Text = alinan_veri["TcKimlikNo"].ToString();
                if (alinan_veri["Cinsiyet"].ToString().TrimEnd() == "Male")
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;
                homePhone.Text = alinan_veri["Ev_Tel_No"].ToString();
                mobilePhone.Text = alinan_veri["Cep_No"].ToString();
                address.Text = alinan_veri["Adres"].ToString();
                BloodComboBox.SelectedIndex = Convert.ToInt16(alinan_veri["KanGrubu"]) - 1;
                InsRegisterNo.Text = alinan_veri["KurumSicilNo"].ToString();
                dateLabel.Text = alinan_veri["IseGirisTarihi"].ToString();
                alinan_veri.Close();
                /////
                alinan_veri = komut4.ExecuteReader();
                alinan_veri.Read();
                titleLabel.Text = alinan_veri["Unvani"].ToString();
                alinan_veri.Close();
                /////
                alinan_veri = komut5.ExecuteReader();
                alinan_veri.Read();
                typeLabel.Text = alinan_veri["Gorevi"].ToString();
                alinan_veri.Close();
                /////
                alinan_veri = komut2.ExecuteReader();
                alinan_veri.Read();
                facultyLabel.Text = alinan_veri["Fakulte"].ToString();
                alinan_veri.Close();
                /////
                alinan_veri = komut6.ExecuteReader();
                alinan_veri.Read();
                bolumLabel.Text = alinan_veri["BolumAdi"].ToString();
                alinan_veri.Close();
                /////
                alinan_veri = komut7.ExecuteReader();
                alinan_veri.Read();
                while (alinan_veri.Read())
                {
                    courseLabel.Text = alinan_veri["DersAdi"].ToString() + "\n" + courseLabel.Text;// bu kısım ile komut7 kısmı daha tam olmadı db de problemler var
                }
                alinan_veri.Close();
                
                
                baglanti.Close();
                //Welcome username codes ends------------------------------
            }
            catch
            {
                toolStripStatusLabel1.Text = ("Couldn't connect to database. Please verify that you have installed SQL Server 2008 R2");
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }
        private void bindValues()
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OnaylaButton.Visible = true;
            NameTextBox.Enabled = true;
            SurnameTextBox.Enabled = true;
            //TcNoTextBox.Enabled = true;
            BloodComboBox.Enabled = true;
            homePhone.Enabled = true;
            mobilePhone.Enabled = true;
            address.Enabled = true;
            UpdateButton.Visible = false;
            radioFemale.Enabled = true;
            radioMale.Enabled = true;
        }

        private void OnaylaButton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connstring);
           
            try
            {
                baglanti.Open();
                
                string gender;
                if (radioMale.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";
                string insertPersonal = String.Format("UPDATE Kisisel_Bilgiler SET Ad='{0}', Soyad='{1}', Cinsiyet='{2}', KanGrubu='{3}', Ev_Tel_No='{4}', Cep_No='{5}', Adres='{6}' WHERE PersonelID='{7}'",
                    NameTextBox.Text,
                    SurnameTextBox.Text,
                    gender,
                    BloodComboBox.SelectedIndex + 1,//bu comboboxtaki sırayı veritabanına paralel yaptım id ler uyussun diye 1 ekledim(index 0dan baslıyo ya hani)
                    homePhone.Text,
                    mobilePhone.Text,
                    address.Text,
                    sessionUserID
                    );
                SqlCommand komutInsertPersonal = new SqlCommand(insertPersonal, baglanti);
                komutInsertPersonal.ExecuteNonQuery();
                //////
                OnaylaButton.Visible = false;
                UpdateButton.Visible = true;
                NameTextBox.Enabled = false;
                SurnameTextBox.Enabled = false;
                BloodComboBox.Enabled = false;
                homePhone.Enabled = false;
                mobilePhone.Enabled = false;
                address.Enabled = false;
                radioFemale.Enabled = false;
                radioMale.Enabled = false;
                MessageBox.Show("Succesfully updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("There is an error occured");
            }
            finally { baglanti.Close(); }
            
        }



    }
}
