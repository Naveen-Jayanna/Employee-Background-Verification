<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="EBV.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
<div class="content-main" style="font-style: italic">
 
  		<!--banner-->	
		    <%--<div class="banner">--%>
		   
				<h2>
				<a href="AdminHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Add/Remove Request</span></h2>
		    </div>
<div class="grid-form1">
 		<h3 id="forms-example" class="">Add Request</h3>
 		<form>
  <div class="form-group">
    <label>Name</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtCompany" class="form-control" runat="server" 
          ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Name is Required" ControlToValidate="txtCompany" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
  <div class="form-group">
    <label>Mail</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtmail" class="form-control" runat="server" 
          ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="Mail is Required" ControlToValidate="txtmail" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
        <br />
        <%--<button type="submit" class="btn btn-default">Submit</button>--%>
  <div class="form-group">
    <label>Password</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtPass" class="form-control" runat="server" 
          TextMode="Password" ValidationGroup="A"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="Password is Required" ControlToValidate="txtPass" 
          ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>
  </div>
         <asp:Button ID="btnSubmit" runat="server" Text="Add" class="btn btn-default" 
            onclick="btnSubmit_Click" ValidationGroup="A" />
</form>
</div>
<div class="grid-form1">
 		<h3 id="H1" class="">Edit</h3>
 		<form>
  <div class="form-group">
    <b>
      <asp:GridView ID="gvCompany" runat="server" 
          class="table table-bordered table-hover" AutoGenerateColumns="False">
          <Columns>
              <asp:BoundField DataField="CmpnyName" HeaderText="Company Name" />
              <asp:BoundField DataField="Mail" HeaderText="Email" />
              <asp:TemplateField HeaderText="Edit">
                  <ItemTemplate>
                      <asp:LinkButton ID="lnkEdit" runat="server" 
                          CommandArgument='<%# Eval("CmpnyId") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
      </asp:GridView></b>
      <b>
      <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
       <br />
      <br />
       <asp:GridView ID="gvGuest1" runat="server" 
          class="table table-bordered table-hover" AutoGenerateColumns="False">
          <Columns>
              <asp:BoundField DataField="GuestName" HeaderText="Name" />
              <asp:BoundField DataField="AdminMail" HeaderText="Email" />
              <asp:BoundField DataField="Password" HeaderText="Password" />
          </Columns>
      </asp:GridView></b>
      <asp:Label ID="lblMsg1" runat="server"></asp:Label>
    </div>
        
</form>

</div>
</div>
</asp:Content>
