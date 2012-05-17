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

//Designed and implemented by Yigitcan Bacakoglu

namespace PersonalManagementSystem
{
    public partial class Form1 : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\pms.mdf;Integrated Security=True;User Instance=True";
        public string sessionUserID="3";// Set to 3 for testing

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Minimum = 0;
            try
            {
                // Welcome username codes start ---------------
                SqlConnection baglanti = new SqlConnection(connstring);
                baglanti.Open();
                if (baglanti.State.ToString() == "Open")
                {
                    toolStripProgressBar1.Value = 100;
                    toolStripStatusLabel1.Text = "Connected to database succesfully";
                    toolStripStatusLabel1.ForeColor = Color.Green;
                }

                SqlCommand komut = new SqlCommand("Select Ad,Soyad from Kisisel_Bilgiler Where PersonelID='" + sessionUserID + "'", baglanti);


                SqlDataReader alinan_veri = komut.ExecuteReader();
                alinan_veri.Read();

                lblUserName.Text = "Welcome, " + alinan_veri["Ad"].ToString().ToUpper() + " " + alinan_veri["Soyad"].ToString().ToUpper();

                alinan_veri.Close();
                baglanti.Close();
                //Welcome username codes ends------------------------------
            }
            catch
            {
                toolStripStatusLabel1.Text=("Couldn't connect to database. Please verify that you have installed SQL Server 2008 R2");
                toolStripStatusLabel1.ForeColor = Color.Red;
            }

            
        }

        //Prevents opening forms more than 1.
        SearchForm childTab;
        private void button1_Click(object sender, EventArgs e)
        {
            if (childTab == null || childTab.closed == true)
            {
                childTab = new SearchForm();
                childTab.MdiParent = this;
                childTab.Show();
            }
            else
                MessageBox.Show("You already opened one...");
        } // Admin Tab button
        //ends admintab

        //Prevents opening forms more than 1.
        addPersonel personelEkle;
        private void button2_Click(object sender, EventArgs e)
        {
            if(personelEkle==null || personelEkle.closed==true)
            {
                personelEkle = new addPersonel();
                personelEkle.MdiParent = this;
                personelEkle.Show();
            }
            else
                MessageBox.Show("You already opened one...");

        } // Personel Ekle Button
        // ends personelEkle

       

       

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Exit Button
        SearchForm searchForm;
        private void button3_Click(object sender, EventArgs e)
        {
            if (searchForm == null || searchForm.closed == true)
            {
                searchForm = new SearchForm();
                searchForm.MdiParent = this;
                searchForm.Show();
            }
            else
                MessageBox.Show("You already opened one...");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            login form = new login();
            form.Show();
            this.Close();
        }
        userSettings form;
        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (form == null || form.closed == true)
            {
                form = new userSettings();
                form.sessionID = this.sessionUserID;
                form.MdiParent = this;
                form.Show();
            }
            else
                MessageBox.Show("You already opened one...");

        }

       
    }
}
