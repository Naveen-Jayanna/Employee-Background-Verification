<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCompany.aspx.cs" Inherits="EBV.RegisterCompany" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html lang="en">
<head>
<title>Register Form</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta charset="utf-8">
<meta name="keywords" content="Quick Register Form Responsive, Login form web template, Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<link href="Register/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all">
<link href="Register/css/style.css" rel="stylesheet" type="text/css" media="all"/>
<link href="Register///fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
<div class="signupform">
<h1>Quick Register Form</h1>
	<div class="container">
		
		<div class="agile_info">
			<div class="w3_info">
				<h2>Register Here</h2>
                <p>&nbsp;</p>
						<div class="left margin">
							<label>Company Name</label>
                            <span><i class="fa fa-user" aria-hidden="true"></i></span>
							<div class="input-group">
                                <asp:TextBox ID="txtComapny" runat="server" placeholder="Company Name" ValidationGroup="A"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Enter a valid Company Name" ForeColor="Red" 
                                    ValidationGroup="A" ControlToValidate="txtComapny"></asp:RequiredFieldValidator>
							</div>
						</div>
						<%--<div class="left">
							<label>Last Name</label>
							<div class="input-group">
								<span><i class="fa fa-user" aria-hidden="true"></i></span>
								<input type="text" placeholder="Last Name" required=""> 
							</div>
						</div>--%>
						<div class="left margin">
							<label>Email Address</label>
                            <span><i class="fa fa-envelope" aria-hidden="true"></i></span>
							<div class="input-group">
								<asp:TextBox ID="txtMail" runat="server" placeholder="Email ID" ValidationGroup="A"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtMail" ErrorMessage="Enter Valid Mail" ForeColor="Red" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    ValidationGroup="A"></asp:RegularExpressionValidator>
							</div>
						</div>
						<div class="left margin">
							<label>Phone Number</label>
								<span><i class="fa fa-phone" aria-hidden="true"></i></span>
							<div class="input-group">
								<asp:TextBox ID="txtPhone" runat="server" placeholder="Phone Number" ValidationGroup="A"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtPhone" ErrorMessage="Enter Valid Number" ForeColor="Red" 
                                    ValidationGroup="A"></asp:RequiredFieldValidator>
							</div>
						</div>
						<%--<div class="left margin">
							<label>Password</label>
							<div class="input-group">
								<span><i class="fa fa-lock" aria-hidden="true"></i></span>
								<input type="Password" placeholder="Password" required="">
							</div>
						</div>
						<div class="left">
							<label>Confirm Password</label>
							<div class="input-group">
								<span><i class="fa fa-lock" aria-hidden="true"></i></span>
								<input type="Password" placeholder="Confirm Password" required="">
							</div>
						</div>--%>
						<div class="clear"></div>
							<input type="checkbox" value="remember-me" /> <h4> I agree to the terms & contidions </h4>        
							<%--<button class="btn btn-danger btn-block" type="submit">Register Now <i class="fa fa-long-arrow-right" aria-hidden="true"></i></button >   --%>
                <asp:Button class="btn btn-danger btn-block"  runat="server" 
                    Text="Register" ValidationGroup="A" ID="Register" onclick="Register_Click" 
                     />
                <%--<i class="fa fa-long-arrow-right" aria-hidden="true"></i>--%>
                            
			</div>
			<div class="w3l_form">
				<div class="left_grid_info">
					<h3>Already Registered?</h3>
					<p> Click below to login and manage your company deails</p>
					<a href="Login.aspx" class="btn">Login <i class="fa fa-long-arrow-right" aria-hidden="true"></i></a>
				</div>
			</div>
			<div class="clear"></div>
			</div>
			
		</div>
		<div class="footer">

 <p>&copy; 2018 Register form. All Rights Reserved | Design by Verifyy</a></p>
 </div>
	</div>
    <div>
    
    </div>
    </form>
	</body>
</html>

