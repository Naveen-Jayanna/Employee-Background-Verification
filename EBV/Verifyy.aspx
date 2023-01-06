<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="Verifyy.aspx.cs" Inherits="EBV.Verifyy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 
				<h2>
				<a href="CompanyDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>VERIFYY</span>
				</h2>
		    </div>
    <asp:Label ID="lblTop" runat="server" Text="Enter 16 bit verification code"></asp:Label>
    <asp:TextBox ID="txtBit" runat="server" class="form-control" ValidationGroup="A"></asp:TextBox>
    <br />
    <asp:Button ID="btnVerifyy" runat="server" class="btn btn-default"  Text="Verifyy" 
            ValidationGroup="A" onclick="btnVerifyy_Click" />

        <br />

    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <asp:GridView ID="gvVerify" class="table table-bordered table-hover" runat="server">
    </asp:GridView>
    <asp:Label ID="lblExp" runat="server"></asp:Label>
    <asp:GridView ID="gvExp" class="table table-bordered table-hover" runat="server" 
            AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="EmpName" HeaderText="Name" />
            <asp:BoundField DataField="Domain" HeaderText="Domain" />
            <asp:BoundField DataField="Projects" HeaderText="Projects" />
            <asp:BoundField DataField="NoOfYrs" HeaderText="No of years" />
            <asp:BoundField DataField="Description" HeaderText="Details" />
        </Columns>
    </asp:GridView>
</asp:Content>
