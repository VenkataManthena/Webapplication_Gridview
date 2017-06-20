<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication14.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <table style="width: 582px">
                <tr>
                    <td style="width: 123px" >
                        First Name</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:Label ID="fname" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        Last Name</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:Label ID="lname" runat="server" Text="Label"></asp:Label></td>
                </tr>
         </table>



</asp:Content>
