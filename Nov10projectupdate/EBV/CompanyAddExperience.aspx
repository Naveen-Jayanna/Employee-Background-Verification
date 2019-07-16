<%@ Page Title="" Language="C#" MasterPageFile="~/Company.Master" AutoEventWireup="true" CodeBehind="CompanyAddExperience.aspx.cs" Inherits="EBV.CompanyAddExperience" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="content-main">
	   
				<h2>
				<a href="CompanyDetails.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Add Experience</span>
				</h2>
		    </div>
            <div class="grid-form1">
            
 		<form>
        <div class="form-group">
    <label>Domain</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtDom" class="form-control" runat="server" 
          ValidationGroup="C"></asp:TextBox>
          </div>
                  <div class="form-group">
    <label>Projects</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtProj" class="form-control" runat="server" 
          ValidationGroup="C"></asp:TextBox>
          </div>
                  <div class="form-group">
    <label>Number Of Years</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtnoy" class="form-control" runat="server" 
          ValidationGroup="C"></asp:TextBox>
          </div>
                  <div class="form-group">
    <label>Description</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtdesc" class="form-control" runat="server" 
          ValidationGroup="C"></asp:TextBox>
          </div>

<div class="form-group">
    <label>Current Project</label>
      <%-- <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email address">--%>
      <asp:TextBox ID="txtcproj" class="form-control" runat="server" 
          ValidationGroup="C"></asp:TextBox>
          </div>
    <asp:Button ID="btnadd" runat="server" Text="Add" class="btn btn-default" 
            onclick="btnadd_Click" ValidationGroup="C" />

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
              <asp:BoundField DataField="Domain" HeaderText="Domain" />
              <asp:BoundField DataField="Projects" HeaderText="Projects" />
              <asp:BoundField DataField="NoOfYrs" HeaderText="Number of years" />
              <asp:BoundField DataField="Description" HeaderText="Description" />
              <asp:BoundField DataField="CurrentProject" HeaderText="Current Project" />
              

              <asp:TemplateField HeaderText="Edit">
                  <ItemTemplate>
                      <asp:LinkButton ID="lnkEdit" runat="server" 
                          CommandArgument='<%# Eval("EmpID") %>' onclick="lnkEdit_Click">Edit</asp:LinkButton>
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
