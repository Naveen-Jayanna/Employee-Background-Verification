<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="EBV.AdminView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>View Companies</span>
				</h2>
		    </div>
    <asp:GridView ID="gvView" class="table table-bordered table-hover" 
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CmpnyId" HeaderText="Company ID" />
            <asp:BoundField DataField="CmpnyName" HeaderText="Company Name" />
            <asp:BoundField DataField="Website" HeaderText="Website" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
</asp:Content>
