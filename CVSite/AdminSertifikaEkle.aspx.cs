using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminSertifikaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SertifikaTableAdapter dt = new DataSet1TableAdapters.Tbl_SertifikaTableAdapter();
            dt.SertifikaEkle(TextBox2.Text);
            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}