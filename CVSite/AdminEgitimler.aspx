<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="CVSite.AdminEğitimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 250px;
            height: 12px;
        }
        .auto-style4 {
            width: 252px;
            height: 12px;
        }
        .auto-style5 {
            width: 270px;
            height: 12px;
        }
        .auto-style6 {
            height: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<form id="Form1" runat="server" class="auto-style1">
        <table class="table table-bordered" style="width: 99%; height: 145px">
            <tr>
                <th class="auto-style6">ID</th>
                <th class="auto-style2">BAŞLIK</th>
                <th class="auto-style5">ALT BAŞLIK</th>
                <th class="auto-style4">AÇIKLAMA</th>
                <th class="auto-style6">GENEL NOT</th>
                <th class="auto-style6">TARİH</th>
                <th class="auto-style6">İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%# Eval("ID")%></th>
                            <td><%# Eval("BASLIK")%></td>
                            <td><%# Eval("ALTBASLIK")%></td>
                            <td><%# Eval("ACIKLAMA")%><Height="70px" TextMode="MultiLine"></Height> </td>
                            <td><%# Eval("GNOT")%></td>
                            <td><%# Eval("TARIH")%></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"AdminEgitimSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1"
                                    runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.Aspx?ID="+ Eval("ID") %>' ID="HyperLink2"
                                    runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-success">Eğitim Ekle</asp:HyperLink>
    </form>
</asp:Content>
