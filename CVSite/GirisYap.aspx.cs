using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CVSite
{
    public partial class GirişYap : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=CV_Sitesi;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Table_Kullanici where Kullanici_Ad=@kullanici and Sifre=@sifre", baglanti);
            komut.Parameters.AddWithValue("@kullanici", TextBox1.Text);
            komut.Parameters.AddWithValue("@sifre", TextBox2.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("hakkımda.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Girişi");
            }
            baglanti.Close();

        }
    }
}