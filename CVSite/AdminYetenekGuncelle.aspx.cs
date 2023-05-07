using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int getir = Convert.ToInt16(Request.QueryString["ID"]);
            TextID.Text = getir.ToString();
            TextID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_YetenekTableAdapter dt = new DataSet1TableAdapters.Tbl_YetenekTableAdapter();
                TextYetenek.Text = dt.YetenekGetir(Convert.ToInt16(getir))[0].YETENEK;
            }
        }

        protected void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_YetenekTableAdapter dt = new DataSet1TableAdapters.Tbl_YetenekTableAdapter();
            dt.YetenekGuncelle(TextYetenek.Text, Convert.ToInt16(TextID.Text));
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}