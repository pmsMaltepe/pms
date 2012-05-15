using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//Designed and implemented by Yigitcan Bacakoglu

namespace PersonalManagementSystem
{
    public partial class forgotPass : Form
    {
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\pms.mdf;Integrated Security=True;User Instance=True";
       
        public forgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.TrimEnd() != "")
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(connstring);
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Select * from Login Where UserName='" + textBox1.Text + "'", baglanti);

                    SqlDataReader alinan_veri = komut.ExecuteReader();
                    alinan_veri.Read();

                    lblError.Visible = false;
                    lbluserName.Text = alinan_veri["UserName"].ToString();
                    lblPassword.Text = alinan_veri["Password"].ToString();

                    lblPassword.Visible = true;
                    lbluserName.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    alinan_veri.Close();
                    baglanti.Close();
                }
                catch
                {
                    lblError.Visible = true;
                    lblPassword.Visible = false;
                    lbluserName.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
