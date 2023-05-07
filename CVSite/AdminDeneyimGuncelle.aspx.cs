using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int getir = Convert.ToInt16(Request.QueryString["ID"]);
            TextID.Text = getir.ToString();
            TextID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_DeneyimTableAdapter dt = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
                TextBASLIK.Text = dt.DeneyimGetir(Convert.ToInt16(getir))[0].BASLIK;
                TextALTBASLIK.Text = dt.DeneyimGetir(Convert.ToInt16(getir))[0].ALTBASLIK;
                TextACIKLAMA.Text = dt.DeneyimGetir(Convert.ToInt16(getir))[0].ACIKLAMA;
                TextTARIH.Text = dt.DeneyimGetir(Convert.ToInt16(getir))[0].TARIH;
            }

        }

        protected void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_DeneyimTableAdapter dt = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            dt.DeneyimGuncelle(TextBASLIK.Text, TextALTBASLIK.Text, TextACIKLAMA.Text, TextTARIH.Text,Convert.ToInt16(TextID.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}