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
    public partial class BtnGiveComment : Form
    {
        public BtnGiveComment()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");
       
        
        public string commentname;
        private void GiveComment_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            LblCommentName.Text = commentname;
            SqlCommand komut = new SqlCommand("Select bookName FROM TBLBOOK ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbChooseBook.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void BtnAddComment_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into TBLCOMMENT ( comment,commentPerson,commentbook) values (@p1,@p2,@p3) " , baglanti);
            komut.Parameters.AddWithValue("@p1", RchComment.Text);
            komut.Parameters.AddWithValue("@p2", LblCommentName.Text);
            komut.Parameters.AddWithValue("@p3", RchComment.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Comment added successfully.");
            this.Hide();
        }

      
        
    }
}

