<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyView.aspx.cs" Inherits="EBV.CompanyView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
<!--banner-->	
		    <%--<div class="banner">--%>
		   
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>View Employees</span>
				</h2>
		    </div>
    <asp:GridView ID="GridView1" class="table table-bordered table-hover" 
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="EmpID" HeaderText="Employee ID" />
            <asp:BoundField DataField="EmpName" HeaderText="Employee Name" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="Adhaar" HeaderText="Adhaar" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>


