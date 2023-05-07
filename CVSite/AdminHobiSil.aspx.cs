using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminHobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sıl = Convert.ToUInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.Tbl_HobıTableAdapter dt =
                new DataSet1TableAdapters.Tbl_HobıTableAdapter();
            dt.HobiSil(Convert.ToInt16(sıl));
            Response.Redirect("AdminHobiler.Aspx");
        }
    }
}