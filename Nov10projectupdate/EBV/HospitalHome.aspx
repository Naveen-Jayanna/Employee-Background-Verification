<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital.Master" AutoEventWireup="true" CodeBehind="HospitalHome.aspx.cs" Inherits="EBV.HospitalHome" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="content-main" style="font-style: italic">
 
				<h2>
				<a href="HospitalHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>Test</span>
				</h2>
     </div>

     <div>

         <div>
        <br />
        <h3>
         <asp:Label ID="lbl16bit" runat="server" Text="Enter the 16 bit verification ID" Font-Size="Medium"></asp:Label>
         </h3>
             <asp:TextBox ID="tb16bit" class="form-control"  runat="server"  placeholder="16-Bit ID" 
                 ValidationGroup="A"></asp:TextBox>

             <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ControlToValidate="tb16bit" ErrorMessage="Enter 16 bit address" 
                 ForeColor="Red" ValidationGroup="A"></asp:RequiredFieldValidator>

    </div>
        <div>
        <br />
        <h3>
         <asp:Label ID="lblDrugTest" runat="server" Text="DrugTest" ></asp:Label>
         </h3>
         
         <asp:DropDownList ID="ddlDrugtest" class="form-control" RenderMode="Lightweight" 
                runat="server" ValidationGroup="A" Width="250px" >
             <asp:ListItem>Select One</asp:ListItem>
             <asp:ListItem>Pass</asp:ListItem>
             <asp:ListItem>Fail</asp:ListItem>
             
         </asp:DropDownList>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="ddlDrugtest" ErrorMessage="Select an entry" 
                ForeColor="Red" InitialValue="Select One" ValidationGroup="A"></asp:RequiredFieldValidator>
         </div>

          
         

          
          <div>
        <br />
        <h3>
        <br />
          <asp:Label ID="lblCriminalrecords" runat="server" Text="Criminal Records"></asp:Label>
          </h3>
          <asp:DropDownList ID="ddlCriminalrecords"  class="form-control" Width="250px" runat="server" ValidationGroup="A" >
              <asp:ListItem Selected="True">Select One</asp:ListItem>
              <asp:ListItem>Pass</asp:ListItem>
              <asp:ListItem>Fail</asp:ListItem>
         </asp:DropDownList>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                  ControlToValidate="ddlCriminalrecords" ErrorMessage="Select an entry" 
                  ForeColor="Red" InitialValue="Select One" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>

           


           <br />

           <div>
                <br />
            <h3>
           <asp:Label ID="lblHealth" runat="server" Text="Health"></asp:Label>
           </h3>
           <asp:DropDownList ID="ddlHealth" class="form-control" Width="250px" runat="server" ValidationGroup="A" 
             >
               <asp:ListItem Selected="True">Select One</asp:ListItem>
               <asp:ListItem>Pass</asp:ListItem>
               <asp:ListItem>Fail</asp:ListItem>
         </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="ddlHealth" ErrorMessage="Select an entry" 
                    ForeColor="Red" InitialValue="Select One" ValidationGroup="A"></asp:RequiredFieldValidator>
                <br />
               
         </div>

         


         <br />


         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


         <asp:Button ID="btnSubmit" runat="server" Text="Submit"  
             class="btn btn-info btn-md" style="background-color:DodgerBlue;" 
             onclick="btnSubmit_Click" ValidationGroup="A"/>
         <br />
         <br />
         <br />


     </div>
     <div class="content-main" style="font-style: italic">
 
				<h2>
				<a href="HospitalHome.aspx">Home</a>
				<i class="fa fa-angle-right"></i>
				<span>View Requests</span>
				</h2>
     </div>

     <div>
         <asp:GridView ID="gvRequest" runat="server" 
             class="table table-bordered table-hover" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="16Bit" HeaderText="16-Bit ID " />
                 <asp:TemplateField HeaderText="Test">
                     <ItemTemplate>
                         <asp:LinkButton ID="lbTest" runat="server" 
                             CommandArgument='<%# Eval("GuestId") %>' onclick="lbTest_Click">Test</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>


     </div>



</asp:Content>

