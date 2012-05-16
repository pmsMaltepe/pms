using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

//Implemented by Tore Serter
//Designed by Yigitcan Bacakoglu
//

namespace PersonalManagementSystem
{
    public partial class login : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\pms.mdf;Integrated Security=True;User Instance=True";
        public string sessionPersonelID;
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connstring);
            baglanti.Open();

            

            SqlCommand komut = new SqlCommand("Select * from Login Where UserName='" + txtUserName.Text + "' AND Password='" + txtPassword.Text + "'", baglanti);
            try
            {
                SqlDataReader alinan_veri = komut.ExecuteReader();
                alinan_veri.Read();

                sessionPersonelID = alinan_veri["PersonalID"].ToString();

                if (alinan_veri["UserLevel"].ToString() == "True")
                {//admin girisi
                    Form1 form = new Form1();
                    form.sessionUserID = sessionPersonelID;
                    form.Show();
                    this.Visible = false;
                }
                else if (alinan_veri["UserLevel"].ToString() == "False")
                {// kullanıcı girisi 
                    PersonelForm form = new PersonelForm();
                    form.sessionUserID = sessionPersonelID;
                    form.Show();
                    this.Visible = false;
                }
                else
                {//basarısız giris
                    MessageBox.Show("User name or password is wrong!");
                    label3.Visible = true;
                }
            }
            catch (InvalidOperationException ex)
            {
                /*
                //FOR TESTING
                Form1 form = new Form1();
                form.Show();
                this.Visible = false;
                */
               MessageBox.Show("Error!");
            }



        }// Confirm button click

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//cancel button click

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPass form = new forgotPass();
            form.Show();
        }//Forgot password link click

       

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button1_Click(sender, e);
                }
            }
        }// Enter key down

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button1_Click(sender, e);
                }
            }
        }// Enter key down
    }
}
