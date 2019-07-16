<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="GuestHome.aspx.cs" Inherits="EBV.GuestHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
				<h2>
				<a href="GuestHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Check vacancy</span>
				</h2>
		    </div>
    <asp:Label ID="lblcompany" runat="server">Select Company</asp:Label>

    <br />

    <asp:DropDownList ID="ddlcompany" runat="server" AutoPostBack="True" class="form-control"
        ValidationGroup="A" 
        onselectedindexchanged="ddlcompany_SelectedIndexChanged" Width="250px" 
   >
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Label ID="lblcategory" runat="server"></asp:Label>
 
<asp:GridView ID="gvEVacancy" runat="server" 
        class="table table-bordered table-hover" AutoGenerateColumns="False" 
        >
        <Columns>
        <asp:BoundField DataField="CatId" HeaderText="CatId" />
        <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:BoundField DataField="Vacancy" HeaderText="Vacancy" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" />
            <asp:BoundField DataField="Requirements" HeaderText="Requirements" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:TemplateField HeaderText="Apply">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkAdd" runat="server" 
                        CommandArgument='<%# Eval("CatId") %>' onclick="lnkAdd_Click">Add</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg1" runat="server"></asp:Label>

</asp:Content>