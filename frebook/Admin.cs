using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frebook
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");

        private void BtnAdminSignIn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * FROM TBLADMIN WHERE adminMail = @p1 AND adminPassword = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAdminMail.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdminPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                AdminMainMenu form = new AdminMainMenu();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Something went wrong, please try again");
                ;
            }
            baglanti.Close();
        }

    }
    }

