<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee16bit.aspx.cs" Inherits="EBV.Employee16bit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="txtBit" class="form-control" runat="server" ValidationGroup="A"></asp:TextBox>
<br />
<asp:Button ID="btnBit" runat="server" onclick="btnBit_Click" Text="Generate" class="btn btn-default"
    ValidationGroup="A" />
<br />
<br />

</asp:Content>
