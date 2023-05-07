using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int getir = Convert.ToInt16(Request.QueryString["ID"]);
            TextID.Text = getir.ToString();
            TextID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
                TextBASLIK.Text = dt.EgitimGetir(Convert.ToInt16(getir))[0].BASLIK;
                TextALTBASLIK.Text = dt.EgitimGetir(Convert.ToInt16(getir))[0].ALTBASLIK;
                TextACIKLAMA.Text = dt.EgitimGetir(Convert.ToInt16(getir))[0].ACIKLAMA;
                TextGENELNOT.Text = dt.EgitimGetir(Convert.ToInt16(getir))[0].GNOT;
                TextTARIH.Text = dt.EgitimGetir(Convert.ToInt16(getir))[0].TARIH;
            }
        }

        protected void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EgitimTableAdapter dt = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            dt.EgitimGuncelle(TextBASLIK.Text, TextALTBASLIK.Text, TextACIKLAMA.Text,TextGENELNOT.Text, TextTARIH.Text, Convert.ToInt16(TextID.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}