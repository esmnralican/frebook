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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * FROM TBLUSERS WHERE userMail = @p1 AND userPassword = @p2" , baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMail.Text );
            komut.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read ())
            {
                AnaEkran form = new AnaEkran();
                form.Mail = TxtMail.Text;
                form.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Something went wrong, please try again");
;            }
            baglanti.Close();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin mainmenu = new Admin();
            mainmenu.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
