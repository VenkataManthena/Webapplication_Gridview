<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication14.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
        <div>
        <div>
            <strong><span style="font-size: 14pt; color: #0000ff">Student Application Form</span></strong><br />

        </div>
            <br />
            <br />
            <br />
            <table style="width: 582px">
                <tr>
                    <td style="width: 123px" >
                        First Name</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="fname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        Last Name</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="lname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        Date of Birth</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="dob" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        Gender</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="gender" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        University</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="university" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        State</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:Dropdownlist ID="state" runat="server"  OnSelectedIndexChanged="state_SelectedIndexChanged" ViewStateMode="Enabled"></asp:Dropdownlist></td>
                </tr>
                 <tr>
                    <td style="width: 123px">
                        Major</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="major" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                        GPA</td>
                    <td style="width: 63px">
                        :</td>
                    <td style="width: 236px">
                        <asp:TextBox ID="gpa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 123px; height: 21px">
                    </td>
                    <td style="width: 63px; height: 21px">
                    </td>
                    <td style="width: 236px; height: 21px">
                        <asp:Label ID="confirm" runat="server" Text="Submitted, thank you !" Visible="False"
                            Width="152px" style="margin-left: 24px"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 123px">
                    </td>
                    <td style="width: 63px; text-align: center">
                    </td>
                    <td style="width: 236px">
                        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" Width="125px" />
                               <td style="width: 246px">
                        <asp:Button ID="Button1" runat="server" OnClick="SendDataTo_Form" Text="SaveAndContinue" Width="144px" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />


</asp:Content>
