using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//Designed and Implemented by Yigitcan Bacakoglu
namespace PersonalManagementSystem
{
    public partial class userSettings : Form
    {

        public string sessionID="0";
        public bool closed = false;
        bool passSame = true;
        string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\pms.mdf;Integrated Security=True;User Instance=True";
        SqlConnection baglanti;
        string oldPassword="";
        public userSettings()
        {
            InitializeComponent();
        }

        private void userSettings_Load(object sender, EventArgs e)
        {
             baglanti = new SqlConnection(connstring);
             this.ControlBox = false; // removes red X button from right top
             try
             {
                 SqlCommand komut = new SqlCommand("select * from Login where PersonalID=" + sessionID, baglanti);
                 SqlDataReader reader;
                 baglanti.Open();
                 reader = komut.ExecuteReader();
                 reader.Read();
                 userName.Text = reader["UserName"].ToString();
                 oldPassword = reader["Password"].ToString();

                 if (reader["UserLevel"].ToString() == "True")
                     radioAdmin.Checked = true;
                 else
                     radioPersonnel.Checked = true;
                 reader.Close();
                 baglanti.Close();
             }
             catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closed = true;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             ////////////////////
            /*try
            {*/
                int userLevel;

                if (radioAdmin.Checked == true)
                    userLevel = 1;
                else
                    userLevel = 0;
                ////////////////

                if (passSame && oldPass.Text == oldPassword)
                {
                    SqlCommand komut = new SqlCommand("Update Login Set UserName='" + userName.Text + "',Password='" + newConfirmPass.Text + "',UserLevel=" + userLevel.ToString() + "where PersonalID=" + sessionID, baglanti);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Updated");
                    this.Close();
                    closed = true;
                }
                else {
                    MessageBox.Show("The informations you entered are not correct");
                }
           /*}
            catch {
                MessageBox.Show("Error");
            }*/
        }

        private void newConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (newConfirmPass.Text == newPass.Text)
            {
                passSame = true;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Green;
            }
            else
            {
                passSame = false;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
            
            }
        }
    }
}
