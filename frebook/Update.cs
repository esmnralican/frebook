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
    public partial class Update : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");

        public Update()
        {
            InitializeComponent();
        }

        private void BtnUpdateInf_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLUSERS Set userName = @p1 , userPassword= @p2,  userPhone=@p3  WHERE userMail = @p4", baglanti );
            komut.Parameters.AddWithValue("@p1", TxtNameUpdate.Text);
            komut.Parameters.AddWithValue("@p2", TxtPasswordUpdate.Text);
            komut.Parameters.AddWithValue("@p3", TxtPhoneUpdate.Text);
            komut.Parameters.AddWithValue("@p4", TxtMailUpdate.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Your information has been updated.");
            this.Hide();
        }
    }
}
