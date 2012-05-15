using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalManagementSystem
{
    public partial class SearchForm : Form
    {
        public bool closed = false;
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\pms.mdf;Integrated Security=True;User Instance=True";
        
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
                komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler";
                //komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where Ad='" + searchTextBox.Text + "'";
                //komut.CommandText = "select TcKimlikNo,Ad,Soyad,KurumSicilNo,PersonelID from Kisisel_Bilgiler where Soyad='" + searchTextBox.Text + "'";
                
                
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
                dataGridView1.Columns[1].HeaderText = "SURNAME";
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[1].HeaderText = "INSTUTY NO";
                dataGridView1.Columns[1].Width = 110;

                dataGridView1.Columns["PersonelID"].Visible = false;
                


                    
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminTab form = new adminTab();
            form.searchID =Convert.ToInt16(dataGridView1.CurrentRow.Cells["PersonelID"].Value);
            form.Show();
            
        }
    }
}
