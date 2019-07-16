<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyVacancy.aspx.cs" Inherits="EBV.CompanyVacancy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 	   
				<h2>
				<a href="CompanyDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Company Vacancy</span>
				</h2>
		    </div>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Select a category"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlCompanyVacancy" runat="server" 

        ValidationGroup="A" AutoPostBack="True" 
        onselectedindexchanged="ddlCompanyVacancy_SelectedIndexChanged" 
        Height="28px" Width="148px">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblCV" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="txtCV" class="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnCV" runat="server" Text="ADD" onclick="btnCV_Click" 
        ValidationGroup="A"/>
     <br />
    <br />
     <asp:GridView ID="gvVacancy" runat="server" 
        class="table table-bordered table-hover" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:BoundField DataField="Vacancy" HeaderText="Vacancy" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" />
             <asp:BoundField DataField="Requirements" HeaderText="Requirements" />
              <asp:BoundField DataField="Description" HeaderText="Description" />
            
               
                   
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg1" runat="server" Text=""></asp:Label>
</asp:Content>
