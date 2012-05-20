using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//designed and implemented by Yigitcan Bacakoglu
//implemented by Eren Erciyes
namespace PersonalManagementSystem
{
    public partial class SearchForm : Form
    {
        public bool closed = false;
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\pms.mdf;Integrated Security=True;User Instance=True";
        int control;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            searchCombo.SelectedIndex = 0;
            this.ControlBox = false; // removes red X button from right top

            
            
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            closed = true;
            this.Close();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connstring);
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            SqlDataAdapter myAdapter3 = new SqlDataAdapter(komut);
            DataSet sds3 = new DataSet();
            baglanti.Open();
            
            try
            {
                if (searchCombo.Text =="T.C. Number")
                {
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where TCKimlikNo='" + searchTextBox.Text + "'";
                }
                if (searchCombo.Text == "Name")
                {
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where Ad='" + searchTextBox.Text + "'";
                }
                if (searchCombo.Text == "Surname")
                {
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where Soyad='" + searchTextBox.Text + "'";
                }
                if (searchCombo.SelectedIndex==5)
                {
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler";
                    
                }
                if (searchCombo.Text == "Faculty")
                {
                    switch (searchTextBox.Text)
                    {
                        case "Mühendislik":
                            control = 1;
                            break;
                        case "Fen-Edebiyat":
                            control = 2;
                            break;
                        case "Mimarlık":
                            control = 3;
                            break;
                        case "Eğitim":
                            control = 4;
                            break;
                        case "Tıp":
                            control = 5;
                            break;
                        case "İletişim":
                            control = 6;
                            break;
                        case "Hemşirelik":
                            control = 7;
                            break;
                        case "Yabancı Diller":
                            control = 8;
                            break;
                        case "Hukuk":
                            control = 9;
                            break;
                        case "Iktisadi ve Idari Bilimler":
                            control = 10;
                            break;
                        default:
                            MessageBox.Show("Geçerli bir değer girin:", "Uyarı", MessageBoxButtons.OK);
                            break;
                    }
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where DepartmanID='" +control+ "'";
                }
                if (searchCombo.Text == "Blood Type")
                {
                    switch(searchTextBox.Text)
                    {
                        case "Arh+":
                            control=1;
                            break;
                        case "Brh+":
                            control=2;
                            break;
                        case "Arh-":
                            control=3;
                            break;
                        case "Brh-":
                            control=4;
                            break;
                        case "ABrh+":
                            control=5;
                            break;
                        case "ABrh-":
                            control=6;
                            break;
                        case "0rh+":
                            control=7;
                            break;
                        case "0rh-":
                            control=8;
                            break;
                        default:
                            MessageBox.Show("Geçerli bir değer girin:", "Uyarı", MessageBoxButtons.OK);
                            break;
                    }
                    komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where KanGrubu='" +control+ "'";
                }

                
                myAdapter3.Fill(sds3, "Kisisel_Bilgiler");
                DataTable stable1 = sds3.Tables["Kisisel_Bilgiler"];
                baglanti.Close();

                // sql baglanti end

                dataGridView1.DataSource = sds3.Tables["Kisisel_Bilgiler"];
                dataGridView1.ReadOnly = true;

                dataGridView1.Columns[0].HeaderText = "TC";
                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[1].HeaderText = "NAME";
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[2].HeaderText = "SURNAME";
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[3].HeaderText = "INSTUTY NO";
                dataGridView1.Columns[1].Width = 110;

                dataGridView1.Columns["PersonelID"].Visible = false;
                


                    
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch { }



        }
        adminTab form;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (form == null || form.closed == true)
                {
                    form = new adminTab();
                    form.MdiParent = this.MdiParent;
                    form.searchID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["PersonelID"].Value);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("You already opened one...");
                }
            }
            catch {
                MessageBox.Show("Do search !");
                form = null;
            }
        }

        private void searchCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnFind_Click(sender, e);
                }
            }
        }

       

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
