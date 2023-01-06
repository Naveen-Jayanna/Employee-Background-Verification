<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="EBV.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="content-main">
<div class="content-main">
            <h2>
				<a href="EmployeeDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Updations of personal Details</span>
				</h2>
		    </div>
<div class="grid-form1">
 		<h3 id="forms-example" class=""></h3>
 		<form>
  <div class="form-group">
    <label>Name</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtEmpName" class="form-control" runat="server" 
          ValidationGroup="E"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Name is Required" ControlToValidate="txtEmpName" 
          ForeColor="Red" ValidationGroup="E"></asp:RequiredFieldValidator>
  </div>
  <div class="form-group">
    <label>Mail</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtEmail" class="form-control" runat="server" 
          ValidationGroup="E"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="Mail Id is Required" ControlToValidate="txtEmail" 
          ForeColor="Red" ValidationGroup="E"></asp:RequiredFieldValidator>
  </div>
        <%--<button type="submit" class="btn btn-default">Submit</button>--%>
  <div class="form-group">
    <label>Password</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtEPass" class="form-control" runat="server" 
          TextMode="Password" ValidationGroup="E"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="Password is Required" ControlToValidate="txtEPass" 
          ForeColor="Red" ValidationGroup="E"></asp:RequiredFieldValidator>
  </div>

  <div class="form-group">
    <label>Address</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtaddress" class="form-control" runat="server" 
          ValidationGroup="E"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ErrorMessage="Address is Required" ControlToValidate="txtaddress" 
          ForeColor="Red" ValidationGroup="E"></asp:RequiredFieldValidator>
  </div>
  <%--<div class="form-group">
    <label>Employee Status</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
    <%--  <asp:TextBox ID="txtstat" class="form-control" runat="server" 
          ValidationGroup="B"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
          ErrorMessage="Employee Status is Required" ControlToValidate="txtstat" 
          ForeColor="Red" ValidationGroup="B"></asp:RequiredFieldValidator>
  </div>----%>

  <div class="form-group">
    <label>Adhaar number</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtAdhaar" class="form-control" runat="server" 
          ValidationGroup="E"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
          ErrorMessage="Adhaar number is Required" ControlToValidate="txtAdhaar" 
          ForeColor="Red" ValidationGroup="E"></asp:RequiredFieldValidator>
  </div>

         <asp:Button ID="btnSubmit" runat="server" Text="Update" class="btn btn-default" 
            onclick="btnSubmit_Click" ValidationGroup="E" />
        <br />
</form>
        <h3 id="H1" class="">
&nbsp;Details</h3>
        <form>
        <div class="form-group">
            <b>
            <asp:GridView ID="gvEmployeeDetails" runat="server" 
          class="table table-bordered table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="EmpID" HeaderText="Employee Id" />
                    <asp:BoundField DataField="EmpName" HeaderText="Employee Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Adhaar" HeaderText="Adhaar" />
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEdit" runat="server" 
                          CommandArgument='<%# Eval("EmpId") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbkDelete" runat="server" 
                          CommandArgument='<%# Eval("EmpID") %>' onclick="lbkDelete_Click">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </b>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
        </form>
</div>
</div>
</asp:Content>
