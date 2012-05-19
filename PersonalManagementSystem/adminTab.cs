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
using Excel = Microsoft.Office.Interop.Excel;
using System.Resources;

namespace PersonalManagementSystem
{
    //implemented and designed by Yigitcan Bacakoglu
    //implemented by Eren Erciyes
    public partial class adminTab : Form
    {


        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\pms.mdf;Integrated Security=True;User Instance=True";
        int ID, unique, departmanID, bolumid;
        string text;
        
        public int searchID;//comes from searchForm 
        public bool closed = false;
        public adminTab()
        {
            
            InitializeComponent();
            
        }

        private void adminTab_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // removes red X button from right top
            panel1.Visible = false;
            tabControl1.Visible = false;
            ID = searchID;
            button3_Click(sender,e);
            

            SqlConnection baglanti = new SqlConnection(connstring);
            SqlCommand komut8 = new SqlCommand("select * from Kisisel_Bilgiler inner join Bolumler on Kisisel_Bilgiler.DepartmanID=Bolumler.DepartmanID where Kisisel_Bilgiler.PersonelID =" + ID, baglanti);
            SqlDataReader reader;
            baglanti.Open();
            reader = komut8.ExecuteReader();
            CourseComboBox.Items.Clear();
            DeptComboBox.Items.Clear();

            while (reader.Read())
            {
              //  CourseComboBox.Items.Add(reader["DersAdi"].ToString().TrimEnd());
                DeptComboBox.Items.Add(reader["BolumAdi"].ToString().TrimEnd());
                bolumid = Convert.ToInt16(reader["id"]);
            }
            reader.Close();
            SqlCommand komut = new SqlCommand("select * from Dersler where BolumID=" + bolumid, baglanti);




            reader = komut.ExecuteReader();
            CourseComboBox.Items.Clear();
            while (reader.Read())
            {
                CourseComboBox.Items.Add(reader["DersAdi"].ToString().TrimEnd());

            }
            reader.Close();
            baglanti.Close();
            
            
            
            
            //

            /*baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Kisisel_Bilgiler inner join DersProgram on Kisisel_Bilgiler.PersonelID=DersProgram.HocaID where PersonelID =" + ID, baglanti);
            reader = komut9.ExecuteReader();
            reader.Read();
            unique = Convert.ToInt32(reader["id"]);
            baglanti.Close();
            //
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from DersProgram inner join Dersler on DersProgram.id=Dersler.id where DersProgram.id=" + unique, baglanti);
            reader = komut10.ExecuteReader();
            while (reader.Read())
            {
                text = reader["DersAdi"].ToString().TrimEnd();

            }
            CourseComboBox.SelectedText = text;
            */




        }

        private void button3_Click(object sender, EventArgs e)
        {
           
               
                panel1.Visible = true;
                tabControl1.Visible = true;
                SqlConnection baglanti = new SqlConnection(connstring);
                SqlCommand komut = new SqlCommand("select * from Kisisel_Bilgiler where PersonelID=" + ID, baglanti);
                SqlCommand komut2 = new SqlCommand("select * from Kisisel_Bilgiler inner join Departman on Kisisel_Bilgiler.DepartmanID=Departman.id where PersonelID=" + ID, baglanti);
                SqlCommand komut3 = new SqlCommand("select * from Kisisel_Bilgiler inner join KanGrubu  on Kisisel_Bilgiler.KanGrubu=KanGrubu.id where PersonelID=" + ID, baglanti);
                SqlCommand komut4 = new SqlCommand("select * from Kisisel_Bilgiler inner join Unvan on Kisisel_Bilgiler.Unvan=Unvan.id where PersonelID=" + ID, baglanti);
                SqlCommand komut5 = new SqlCommand("select * from Kisisel_Bilgiler inner join Tip on Kisisel_Bilgiler.Tip=Tip.id where PersonelID=" + ID, baglanti);
                SqlCommand komut6 = new SqlCommand("select * from Kisisel_Bilgiler inner join Bolumler on Kisisel_Bilgiler.BolumID=Bolumler.id where PersonelID=" + ID, baglanti);
                SqlCommand komut7 = new SqlCommand("select * from Login where PersonalID=" + ID, baglanti);

                SqlDataReader reader;
                try
                {
                    baglanti.Open();

                    reader = komut7.ExecuteReader();

                    reader.Read();

                    userName.Text = reader["UserName"].ToString();

                    oldPass.Text = reader["Password"].ToString();



                    if (reader["UserLevel"].ToString() == "True")

                        radioAdmin.Checked = true;

                    else

                        radioPersonel.Checked = true;

                    reader.Close();

                    baglanti.Close();

                }
                catch {
                    baglanti.Close();
                }



                baglanti.Open();





                reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    lblAdSoyad.Text = reader["Ad"].ToString().TrimEnd().ToUpper() + "  " + reader["Soyad"].ToString().TrimEnd().ToUpper();
                    NameTextBox.Text = reader["Ad"].ToString().TrimEnd().ToUpper();
                    SurnameTextBox.Text = reader["Soyad"].ToString().TrimEnd().ToUpper();
                    TcNoTextBox.Text = reader["TcKimlikNo"].ToString().TrimEnd();

                    if (reader["Cinsiyet"].ToString().TrimEnd() == "Male")
                        maleRadio.Checked = true;
                    else
                        femaleRadio.Checked = true;
                    homePhone.Text = reader["Ev_Tel_No"].ToString().TrimEnd();
                    mobilePhone.Text = reader["Cep_No"].ToString().TrimEnd();
                    address.Text = reader["Adres"].ToString().TrimEnd();
                    dateTextBox.Text = reader["IseGirisTarihi"].ToString().TrimEnd();
                    InsRegisterNo.Text = reader["KurumSicilNo"].ToString().TrimEnd();

                    switch (Convert.ToInt16(reader["DepartmanID"]))
                    {
                        case 3:
                            FacultyComboBox.SelectedIndex = 1;
                            break;
                        case 6:
                            FacultyComboBox.SelectedIndex = 2;
                            break;
                        case 10:
                            FacultyComboBox.SelectedIndex = 3;
                            break;
                        case 4:
                            FacultyComboBox.SelectedIndex = 4;
                            break;
                        case 1:
                            FacultyComboBox.SelectedIndex = 5;
                            break;
                        case 9:
                            FacultyComboBox.SelectedIndex = 6;
                            break;
                        case 5:
                            FacultyComboBox.SelectedIndex = 7;
                            break;
                        case 2:
                            FacultyComboBox.SelectedIndex = 8;
                            break;
                        case 8:
                            FacultyComboBox.SelectedIndex = 9;
                            break;
                    }




                }
                reader.Close();
                baglanti.Close();
                /// 
                baglanti.Open();

                reader = komut2.ExecuteReader();
                while (reader.Read())
                {
                    lblBirim.Text =reader["Fakulte"].ToString().TrimEnd();

                }
                reader.Close();
                baglanti.Close();
                ///
                baglanti.Open();
                reader = komut3.ExecuteReader();
                while (reader.Read())
                {
                    BloodComboBox.Text = reader["Grup"].ToString().TrimEnd();

                }

                baglanti.Close();
                //
                baglanti.Open();
                reader = komut4.ExecuteReader();
                while (reader.Read())
                {
                    TitleComboBox.Text = reader["Unvani"].ToString().TrimEnd();

                }
                baglanti.Close();

                ///
                baglanti.Open();
                reader = komut5.ExecuteReader();
                while (reader.Read())
                {
                    TypeComboBox.Text = reader["Gorevi"].ToString().TrimEnd();

                }
                baglanti.Close();
                ///
                baglanti.Open();
                reader = komut6.ExecuteReader();
                while (reader.Read())
                {
                    lblBolum.Text =reader["BolumAdi"].ToString().TrimEnd();
                    DeptComboBox.Text = lblBolum.Text;

                }
         
        }

        

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            closed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            groupBox3.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(connstring);
                    SqlCommand komut = new SqlCommand("Delete from Kisisel_Bilgiler where PersonelID="+ID,baglanti);
                    SqlCommand komut2 = new SqlCommand("Delete from Login where PersonalID=" + ID, baglanti);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesfully");
                    
                    baglanti.Close();
                    closed = true;
                    this.Close();
                }
                catch { MessageBox.Show("Error occured"); }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
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

            SqlCommand komut2 = new SqlCommand("select id from Bolumler where BolumAdi='" + DeptComboBox.Text + "'", baglanti);

            SqlDataReader reader;

            baglanti.Open();
            reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                bolumid = Convert.ToInt32(reader["id"]);

            }



            reader.Close();
            SqlCommand komut = new SqlCommand("select * from Dersler where BolumID=" + bolumid, baglanti);




            reader = komut.ExecuteReader();
            CourseComboBox.Items.Clear();
            while (reader.Read())
            {
                CourseComboBox.Items.Add(reader["DersAdi"].ToString().TrimEnd());

            }
            reader.Close();
            baglanti.Close(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {/*
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook wb = xla.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)xla.ActiveSheet;
            
            xla.Visible = true;*/

            Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet ws ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            ws = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlApp.Visible = true;

            //Sayfa ayarlari

            ws.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperA4;
            ws.get_Range("A1", "H8").Font.Bold = true;
            ws.get_Range("A1", "H8").Font.Size=14;
            //
            
            //ResourceManager resManager = new ResourceManager("PersonalManagementSystem.Resource1",System.Reflection.Assembly.GetExecutingAssembly());

            // resmi kopyalayip yapistiran kod
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminTab));
            
            //Image image = ((System.Drawing.Image)(resources.GetObject("1")));
            //System.Windows.Forms.Clipboard.SetDataObject(image, true);
            //ws.Paste(ws.get_Range("A2", "A2"), image);

            ws.Shapes.AddPicture(Application.StartupPath+"\\1.JPG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 70, 70); 
            

            
            ws.Cells[3, 3] = "T.C. MALTEPE UNIVERSITY";
            ws.Cells[4, 3] = FacultyComboBox.Text.ToUpper();
            ws.Cells[7, 1] = "Personnel Information";

            ws.Cells[9, 1] = "Type";
            ws.Cells[10, 1] = "Title";
            ws.Cells[11, 1] = "Name";
            ws.Cells[12, 1] = "SurName";
            ws.Cells[13, 1] = "TC No";
            ws.Cells[14, 1] = "Gender";
            ws.Cells[15, 1] = "Blood Type";
            ws.Cells[16, 1] = "Home Phone";
            ws.Cells[17, 1] = "Mobile Phone";
            ws.Cells[18, 1] = "Address";
            ws.Cells[19, 1] = "Institution Reg. No.";
            
           
            ws.Cells[20, 1] = "Faculty";
            ws.Cells[21, 1] = "Departmant";
            ws.Cells[22, 1] = "Courses";
            ws.Cells[23, 1] = "PMS User Type";



            ws.Cells[10, 3] = ": " + TitleComboBox.Text.ToUpper();
            ws.Cells[9, 3] = ": " + TypeComboBox.Text.ToUpper();
            
            ws.Cells[11, 3] =": "+ NameTextBox.Text.ToUpper();
            ws.Cells[12, 3] = ": " + SurnameTextBox.Text.ToUpper();
            ws.Cells[13, 3] = ": " + TcNoTextBox.Text;
            ws.Cells[14, 3] = ": " + ((maleRadio.Checked) ? "MALE" : "FEMALE");
            ws.Cells[15, 3] = ": " + BloodComboBox.Text;
            ws.Cells[16, 3] = ": " + homePhone.Text;
            ws.Cells[17, 3] = ": " + mobilePhone.Text;
            ws.Cells[18, 3] = ": " + address.Text.ToUpper();
            ws.Cells[19, 3] = ": " + InsRegisterNo.Text;
            ws.Cells[20, 3] = ": " + FacultyComboBox.Text.ToUpper();
            ws.Cells[21, 3] = ": " + DeptComboBox.Text.ToUpper();
            ws.Cells[22, 3] = ": " + CourseComboBox.Text.ToUpper();
            ws.Cells[23, 3] = ": " + ((radioAdmin.Checked) ? "ADMIN" : "PERSONNEL");
            
            xlWorkBook.Close(true,misValue,misValue);
            xlApp.Quit();
            ExcelKill();
            

        }

        private void ExcelKill()
        {
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "EXCEL")
                    p.Kill();
        }


    }
}
