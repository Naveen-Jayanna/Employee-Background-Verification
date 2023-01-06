<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="Guest16Bit.aspx.cs" Inherits="EBV.Guest16Bit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
				<h2>
				<a href="GuestHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Generate 16 bit</span>
				</h2>
		    </div>
<asp:TextBox ID="txtBit" class="form-control" runat="server" ValidationGroup="B"></asp:TextBox>
<br />
<asp:Button ID="btnBit" runat="server"  onclick="btnBit_Click" Text="Generate" class="btn btn-default"
    ValidationGroup="B" />
    <br />
    <br />
    <asp:Label ID="lblGuest" runat="server"></asp:Label>
<br />
<br />

</asp:Content>
