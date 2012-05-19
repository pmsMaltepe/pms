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

//Designed by Tolgahan Buyukoz 
//Implemented by Yigit Can Bacakoglu.


namespace PersonalManagementSystem
{

    public partial class addPersonel : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\pms.mdf;Integrated Security=True;User Instance=True";
       
         int i=0;
         int bolumid ;
         int departmanID = 0;
         public bool closed = false;

        public addPersonel()
        {
            InitializeComponent();

            TitleComboBox.SelectedIndex = 0;
            TypeComboBox.SelectedIndex = 0;
            BloodComboBox.SelectedIndex = 0;
            
            
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DeptComboBox.Items.Clear();
            CourseComboBox.Items.Clear();
            DeptComboBox.Text = "";
            CourseComboBox.Text = "";

            switch (FacultyComboBox.SelectedIndex)
            {
                case 1:
                    departmanID = 3;
                    break;
                case 2:
                    departmanID = 6;
                    break;
                case 3:
                    departmanID = 10;
                    break;
                case 4:
                    departmanID = 4;
                    break;
                case 5:
                    departmanID = 1;
                    break;
                case 6:
                    departmanID = 9;
                    break;
                case 7:
                    departmanID = 5;
                    break;
                case 8:
                    departmanID = 2;
                    break;
                case 9:
                    departmanID = 8;
                    break;
            }
           
            SqlConnection baglanti = new SqlConnection(connstring);

            
            SqlCommand komut = new SqlCommand("select * from Bolumler where DepartmanID="+departmanID,baglanti);
            
            SqlDataReader reader;
            baglanti.Open();
           
            reader = komut.ExecuteReader();
            DeptComboBox.Items.Clear();
            while (reader.Read())
            {
                DeptComboBox.Items.Add(reader["BolumAdi"].ToString().TrimEnd());
               
            }
            reader.Close();
            baglanti.Close();
        }

        private void DeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseComboBox.Items.Clear(); 
            CourseComboBox.Text = "";
            SqlConnection baglanti = new SqlConnection(connstring);
            
            SqlCommand komut2 = new SqlCommand("select id from Bolumler where BolumAdi='"+DeptComboBox.Text+"'",baglanti);
            
            SqlDataReader reader;

            baglanti.Open();
            reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                bolumid = Convert.ToInt32(reader["id"]);

            }



            reader.Close();
            SqlCommand komut = new SqlCommand("select * from Dersler where BolumID=" +bolumid, baglanti);

            
           

            reader = komut.ExecuteReader();
            CourseComboBox.Items.Clear();
            while (reader.Read())
            {
                CourseComboBox.Items.Add(reader["DersAdi"].ToString().TrimEnd());
                
            }
            reader.Close();
            baglanti.Close(); 


        }
        private void textBosalt()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            TcNoTextBox.Clear();
            address.Clear();
            InsRegisterNo.Clear();
            homePhone.Clear();
            mobilePhone.Clear();
            BloodComboBox.SelectedIndex = 0;
            FacultyComboBox.SelectedIndex = 0;
            DeptComboBox.Items.Clear();
            CourseComboBox.Items.Clear();
        }

        private void textUp()
        {
            NameTextBox.Text = NameTextBox.Text.ToUpper();
            SurnameTextBox.Text = SurnameTextBox.Text.ToUpper();

            address.Text = address.Text.ToUpper();
            
            
 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            
            string gender;
            if(femaleRadio.Checked==true)
                gender="Female";
            else
                gender="Male";
            //////////////////////////////

            if (TcNoTextBox.Text.TrimEnd() == "" || NameTextBox.Text.TrimEnd() == "" || SurnameTextBox.Text.TrimEnd() == ""
                || DeptComboBox.Text.TrimEnd() == "" || CourseComboBox.Text.TrimEnd() == "")
            {
               //Controls the informations for no further error occure. 
            
                MessageBox.Show("You miss to enter some informations...");
            
            }


            else
            {

                 try
                {
                    textUp();
                    SqlConnection baglanti = new SqlConnection(connstring);


                    SqlCommand komut = new SqlCommand("select * from KanGrubu where Grup='" + BloodComboBox.Text + "'", baglanti);

                    SqlDataReader reader;
                    baglanti.Open();
                    reader = komut.ExecuteReader();
                    /////

                    int bloodType;


                    reader.Read();
                    bloodType = Convert.ToInt16(reader["id"]);
                    reader.Close();
                    baglanti.Close();

                    ////////

                    baglanti.Open();
                    int unvan;
                    SqlCommand komutUnvan = new SqlCommand("select * from Unvan where Unvani='" + TitleComboBox.Text + "'", baglanti);
                    reader = komutUnvan.ExecuteReader();
                    reader.Read();
                    unvan = Convert.ToInt16(reader["id"]);
                    reader.Close();
                    baglanti.Close();

                    /////////

                    baglanti.Open();
                    int tip;
                    SqlCommand komutTip = new SqlCommand("select * from Tip where Gorevi='" + TypeComboBox.Text + "'", baglanti);
                    reader = komutTip.ExecuteReader();
                    reader.Read();
                    tip = Convert.ToInt16(reader["id"]);
                    reader.Close();
                    baglanti.Close();

                    ///////////





                    baglanti.Open();

                     
                     // Akademik olmayanlar icin fakulte ve unvan kaydetmez.
                   /*  if (TypeComboBox.SelectedIndex == 1)
                     {*/

                         string insertPersonal
                             = "insert into Kisisel_Bilgiler" +
                             "(Ad,Soyad,TcKimlikNo,Cinsiyet,KanGrubu,KurumSicilNo,Unvan,Tip,IseGirisTarihi,DepartmanID,BolumID,Ev_Tel_No,Cep_No,Adres)" +
                             "values('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "','" + TcNoTextBox.Text + "','" + gender + "','" + bloodType.ToString() + "','" + InsRegisterNo.Text + "','" + unvan.ToString() + "','" + tip.ToString() + "','" + String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value) + "','" + departmanID.ToString() + "','" + bolumid.ToString() + "','" + homePhone.Text + "','" + mobilePhone.Text + "','" + address.Text + "')";
                    
                     

                         SqlCommand komutInsertPersonal = new SqlCommand(insertPersonal, baglanti);

                         komutInsertPersonal.ExecuteNonQuery();
                    /* }
                     else
                     {
                         string insertPersonalNonAcademic = "insert into Kisisel_Bilgiler" +
                        "(Ad,Soyad,TcKimlikNo,Cinsiyet,KanGrubu,KurumSicilNo,Tip,IseGirisTarihi,Ev_Tel_No,Cep_No,Adres)" +
                        "values('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "','" + TcNoTextBox.Text + "','" + gender + "','" + bloodType.ToString() + "','" + InsRegisterNo.Text + "','" + tip.ToString() + "','" + String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value) + "','" + homePhone.Text + "','" + mobilePhone.Text + "','" + address.Text + "')";

                     
                         SqlCommand komutInsertPersonal = new SqlCommand(insertPersonalNonAcademic, baglanti);

                         komutInsertPersonal.ExecuteNonQuery();
                     }
                         */
                    ////////////////////

                    int userLevel;

                    if (radioAdmin.Checked == true)
                        userLevel = 1;
                    else
                        userLevel = 0;
                    ////////////////
                    int personelID;
                    SqlCommand komutPersonelId = new SqlCommand("Select PersonelID from Kisisel_Bilgiler where TcKimlikNo='" + TcNoTextBox.Text + "'", baglanti);

                    reader = komutPersonelId.ExecuteReader();
                    reader.Read();
                    personelID = Convert.ToInt16(reader["PersonelID"]);
                    reader.Close();

                    ///////////////
                    string insertLogin = "insert into Login (UserName,UserLevel,PersonalID) values ('" + TcNoTextBox.Text + "','" + userLevel.ToString() + "','" + personelID + "')";

                    SqlCommand komutInsertLogin = new SqlCommand(insertLogin, baglanti);

                    komutInsertLogin.ExecuteNonQuery();

                    MessageBox.Show("Saved Succesfully... \nLogin Details, \nUsername:" + TcNoTextBox.Text + "\nPassword:maltepe");
                    textBosalt();

                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("Error occured...\nWe have the entered T.C. No in our records.\nTry to find and update the record if neccessary.");
                }

            }
            
            ////////////////
            
            
        }

        private void TcNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPersonel_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // removes red X button from right top
            FacultyComboBox.SelectedIndex = 0;
        }

        private void BloodComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;

        }

        private void TitleComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void TypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void FacultyComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void DeptComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void CourseComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (TypeComboBox.SelectedIndex == 0)
            {
                FacultyComboBox.Enabled = true;
                DeptComboBox.Enabled = true;
                CourseComboBox.Enabled = true;
                TitleComboBox.Enabled = true;

            }
            else
            {
                TitleComboBox.Enabled = false;
                FacultyComboBox.Enabled = false;
                DeptComboBox.Enabled =false;
                CourseComboBox.Enabled = false;

            }*/








        } // Makes combox readonly

       

        

       
       
    }
}
