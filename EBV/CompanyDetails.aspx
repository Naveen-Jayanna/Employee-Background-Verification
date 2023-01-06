<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="EBV.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="content-main">		   
				<h2>
				<a href="CompanyDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Company Details</span>
				</h2>
		    </div>
<div class="grid-form1">
 		<h3 id="forms-example" class="">Company Details</h3>
 		<form>
  <div class="form-group">
    <label>No Of Employees</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtNo" class="form-control" runat="server" 
          ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Number of employees is Required" ControlToValidate="txtNo" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
  <div class="form-group">
    <label>Company Address</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtAddress" class="form-control" runat="server" 
          ValidationGroup="A" TextMode="MultiLine"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="Company Address is Required" ControlToValidate="txtAddress" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
        <br />
        <%--<button type="submit" class="btn btn-default">Submit</button>--%>
  <div class="form-group">
    <label>Company Website</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtWebsite" class="form-control" runat="server" 
          ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="Company Website is Required" ControlToValidate="txtWebsite" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
         <asp:Button ID="btnEdit" runat="server" Text="Update" class="btn btn-default" 
             ValidationGroup="A" onclick="btnEdit_Click" />
</form>
</div>

    <asp:GridView ID="gvCompany" class="table table-bordered table-hover"  
        runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CmpnyName" HeaderText="Company Name" />
            <asp:BoundField DataField="NoOfEmp" HeaderText="No of Employees" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="Website" HeaderText="Website" />
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" 
                        CommandArgument='<%# Eval("CmpnyId") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
</asp:Content>
