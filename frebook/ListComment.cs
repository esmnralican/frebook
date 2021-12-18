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
    public partial class ListComment : Form
    {
        public ListComment()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5Q60TFA;Initial Catalog=frebook;Integrated Security=True");

       //Kitapları listelemek için kullanılan combobox
        private void ListComment_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select bookName FROM TBLBOOK  ",baglanti );
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbListComment.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        SqlDataAdapter da;
        DataSet ds; 
        private void CmbListComment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //Kitap ismine göre yorumlar listelendi.
            da = new SqlDataAdapter("Select * from TBLCOMMENT where commentBook = '"+  CmbListComment.SelectedItem.ToString() + "'", baglanti);
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        
    }
}
