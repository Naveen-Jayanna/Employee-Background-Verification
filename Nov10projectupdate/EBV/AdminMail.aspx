<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminMail.aspx.cs" Inherits="EBV.AdminMail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>View Company Mail</span>
				</h2>
		    </div>
    <asp:GridView ID="gvRegister" runat="server" 
        class="table table-bordered table-hover" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="Company" HeaderText="Company Name" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" />
            <asp:BoundField DataField="Phone" HeaderText="Contact" />
            <asp:TemplateField HeaderText="Add">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkAdd" runat="server" 
                        CommandArgument='<%# Eval("Company") %>' onclick="lnkAdd_Click">Add</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
</asp:Content>
