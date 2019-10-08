﻿<%@ Page Title="MeNu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SPList.aspx.cs" Inherits="AnVat_WebTM.SPList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <section>
         <div>
         <hgroup>
         <h2>Món sẵn có:</h2>
         </hgroup>
         <asp:ListView ID="SPList" runat="server" DataKeyNames="MaSP"
        GroupItemCount="4"
         ItemType="AnVat_WebTM.Models.SP" SelectMethod="GetSP">
         <EmptyDataTemplate>
         <table >
         <tr>
         <td>No data was returned.</td>
         </tr>
         </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
         <tr id="itemPlaceholderContainer" runat="server">
         <td id="itemPlaceholder" runat="server"></td>
         </tr>
         </GroupTemplate>
         <ItemTemplate>
         <%--<td runat="server">--%>
         <table>
         <tr>
         <td>
         <a href="SPDetails.aspx?MaSP=<%#:Item.MaSp%>">
         <img src ="/Images/<%#:Item.AnhPath%>"
         width="300" height="300" style="border:solid" /></a>
         </td>
         </tr>
         <tr>
         <td>
         <a href="SPDetails.aspx?MaSP=<%#:Item.MaSP%>">
         <span>
         <%#:Item.TenSP%>
         </span>
         </a>
         <br />
         <span>
         <b>Giá Tiền: </b><%#:String.Format("{0:c}",Item.UnitGiaTien)%>
         </span>
         <br />
             <%--<a href="AddToCart.aspx?MaSP=<%#:Item.MaSP%>">
<span>
<b>thêm vào giỏ hàng<b>
</span>
</a
         </td>--%>
         </tr>
         <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
         <table style="width:100%;">
         <tbody>
         <tr>
         <td>
         <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
         <tr id="groupPlaceholder"></tr>
         </table>
         </td>
         </tr>
         <tr>
         <td></td>
         </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
</asp:Content>
