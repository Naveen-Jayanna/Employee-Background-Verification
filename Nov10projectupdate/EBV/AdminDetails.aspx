<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDetails.aspx.cs" Inherits="EBV.AdminDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 
  		<!--banner-->	
		    <%--<div class="banner">--%>
		   
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Company Details</span>
				</h2>
		    </div>
    <asp:GridView ID="gvDetails"  class="table table-bordered table-hover"  
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CmpnyName" HeaderText="Company Name" />
            <asp:BoundField DataField="NoOfEmp" HeaderText="Total Employees" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" />
            <asp:BoundField DataField="Password" HeaderText="Password" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="lbl" runat="server"></asp:Label>
    <asp:GridView ID="gvEmp" class="table table-bordered table-hover"   
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Company Name" HeaderText="Company Name" />
            <asp:BoundField DataField="Expr1" HeaderText="Present Employees" />
        </Columns>
    </asp:GridView>
</asp:Content>
