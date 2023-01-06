<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyAdd.aspx.cs" Inherits="EBV.CompanyAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="content-main">
<div class="content-main">
 
  		<!--banner-->	
		    <%--<div class="banner">--%>
		   
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Add/Remove Employee</span>
				</h2>
		    </div>
<div class="grid-form1">
 		<h3 id="forms-example" class="">ADD Employees</h3>
 		<form>
  <div class="form-group">
    <label>Employee Name</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtEmp" class="form-control" runat="server" 
          ValidationGroup="B"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Employee Name is Required" ControlToValidate="txtEmp" 
          ForeColor="Red" ValidationGroup="B"></asp:RequiredFieldValidator>
  </div>
  <div class="form-group">
    <label>Employee Mail</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtmail" class="form-control" runat="server" 
          ValidationGroup="B"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="Employee ID is Required" ControlToValidate="txtmail" 
          ForeColor="Red" ValidationGroup="B"></asp:RequiredFieldValidator>
  </div>
        <br />
        <%--<button type="submit" class="btn btn-default">Submit</button>--%>
  <div class="form-group">
    <label>Employee Password</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtPass" class="form-control" runat="server" 
          TextMode="Password" ValidationGroup="B"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="Employee Password is Required" ControlToValidate="txtPass" 
          ForeColor="Red" ValidationGroup="B"></asp:RequiredFieldValidator>
  </div>

  

         <asp:Button ID="btnSubmit" runat="server" Text="Add" class="btn btn-default" 
            onclick="btnSubmit_Click" ValidationGroup="B" />
</form>
</div>
<div class="grid-form1">
 		<h3 id="H1" class="">Edit Employee details</h3>
 		<form>
  <div class="form-group">
    <b>
      <asp:GridView ID="gvEmployee" runat="server" 
          class="table table-bordered table-hover" AutoGenerateColumns="False">
          <Columns>
              <asp:BoundField DataField="EmpName" HeaderText="Employee Name" />
              <asp:BoundField DataField="Email" HeaderText="Email" />
              <asp:BoundField DataField="Password" HeaderText="Password" />
              <asp:BoundField DataField="Address" HeaderText="Address" />
              <asp:BoundField DataField="Status" HeaderText="Status" />
              <asp:BoundField DataField="Adhaar" HeaderText="Adhaar" />

              <asp:TemplateField HeaderText="Edit">
                  <ItemTemplate>
                      <asp:LinkButton ID="lnkEdit" runat="server" 
                          CommandArgument='<%# Eval("EmpId") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
      </asp:GridView></b>
      <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
        
</form>

</div>
</div>
</asp:Content>
