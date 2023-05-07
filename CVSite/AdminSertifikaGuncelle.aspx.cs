using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminSertifikaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int getir = Convert.ToInt16(Request.QueryString["ID"]);
            TextID.Text = getir.ToString();
            TextID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_SertifikaTableAdapter dt = new DataSet1TableAdapters.Tbl_SertifikaTableAdapter();
                Textsertifika.Text = dt.SertifikaGetir(Convert.ToInt16(getir))[0].SERTIFIKA;
            }
        }

        protected void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SertifikaTableAdapter dt = new DataSet1TableAdapters.Tbl_SertifikaTableAdapter();
            dt.SertifikaGuncelle(Textsertifika.Text, Convert.ToInt16(TextID.Text));
            Response.Redirect("AdminSertifikalar.aspx");
        }
    }
}