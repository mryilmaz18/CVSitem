using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sıl = Convert.ToUInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.Tbl_YetenekTableAdapter dt =
                new DataSet1TableAdapters.Tbl_YetenekTableAdapter();
            dt.YetenekSil(Convert.ToInt16(sıl));
            Response.Redirect("AdminYetenekler.Aspx");
        }
    }
}