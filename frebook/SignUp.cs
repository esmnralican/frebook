using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frebook
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBLUSERS (userName,userMail,userPassword,userPhone) values ( @p1, @p2, @p3, @p4 );", baglanti);
            try
            {
                baglanti.Open();
                komut.Parameters.AddWithValue("@p1", TxtUserNameSurname.Text);
                komut.Parameters.AddWithValue("@p2", TxtUserMail.Text);
                komut.Parameters.AddWithValue("@p3", TxtUserPassword.Text);
                komut.Parameters.AddWithValue("@p4", TxtUserPhone.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sign up successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            catch 
            {
                MessageBox.Show("Hata");
                baglanti.Close();
            }
             
        }
    }
}
