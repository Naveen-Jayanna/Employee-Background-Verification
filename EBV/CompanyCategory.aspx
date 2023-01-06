<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyCategory.aspx.cs" Inherits="EBV.CompanyCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
 
				<h2>
				<a href="CompanyDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>View Category</span>
				</h2>
		    </div>
    <label>Manage Category</label>
      <br />
      <asp:TextBox ID="txtCategory" class="form-control" runat="server" 
          ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Category Name is Required" ControlToValidate="txtCategory" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
          <br />
          <asp:Button ID="btnSubmit" runat="server" Text="Add" class="btn btn-default" 
             ValidationGroup="A" onclick="btnSubmit_Click" />
    <br />
    <br />
    <asp:GridView ID="gvCategory" class="table table-bordered table-hover"  
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" 
                        CommandArgument='<%# Eval("CatId") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" 
                        CommandArgument='<%# Eval("CatId") %>' onclick="lnkDelete_Click">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
</asp:Content>
