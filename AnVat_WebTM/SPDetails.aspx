<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SPDetails.aspx.cs" Inherits="AnVat_WebTM.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <asp:FormView ID="SPDetail" runat="server"
        ItemType="AnVat_WebTM.Models.SP" SelectMethod ="GetDetails"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1><%#:Item.TenSP %></h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.AnhPath %>"
         style="border:solid; height:225px" alt="<%#:Item.TenSP %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Giới thiệu:</b><br /><%#:Item.GioiThieu%>
         <br />
         <span><b>Giá Tiền:</b>&nbsp;<%#: String.Format("{0:c}",Item.UnitGiaTien)
        %></span>
         <br />
         <span><b>Mã sản phẩm:</b>&nbsp;<%#:Item.MaSP %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
