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
    public partial class AnaEkran : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");
        public AnaEkran()
        {
            InitializeComponent();
        }
        public string Mail;
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'frebookDataSet.TBLBOOK' table. You can move, or remove it, as needed.
            this.tBLBOOKTableAdapter.Fill(this.frebookDataSet.TBLBOOK);
            //adsoyad getirme
            baglanti.Open();
            lblMail.Text = Mail;
            SqlCommand komut = new SqlCommand("Select userName FROM TBLUSERS WHERE userMail = @p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", lblMail.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read() )
            {
                LblMenuNameSurname.Text = dr[0].ToString();
            }
            baglanti.Close();

            //Kitap bağışı için combobox
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select bookType FROM TBLBOOK  ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBookType.Items.Add(dr2[0].ToString());
            }
            baglanti.Close();

        }

        private void BtnGiveComment_Click(object sender, EventArgs e)
        {
            BtnGiveComment form = new BtnGiveComment();
            form.commentname = LblMenuNameSurname.Text;
            form.Show();
        }

        private void BtnListComment_Click(object sender, EventArgs e)
        {
            ListComment form = new ListComment();
            form.Show();
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLBOOK ( writerName, bookName, bookPage) values (@p1, @p2,@p3) ", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtDonateWriterName.Text);
            komut.Parameters.AddWithValue("@p2", TxtDonateBookName.Text);
            komut.Parameters.AddWithValue("@p3", TxtDonateBookPage.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Thanks to your donate. Sincerely");


        }

        private void LblUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update form = new Update();
            form.Show();
        }

     
    }
}

