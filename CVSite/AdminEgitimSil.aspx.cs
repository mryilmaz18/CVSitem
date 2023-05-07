using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sıl = Convert.ToUInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.Tbl_EgitimTableAdapter dt =
                new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            dt.EgitimSil(Convert.ToInt16(sıl));
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}