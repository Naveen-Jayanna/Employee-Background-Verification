<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EBV.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!--
	Author: W3layouts
	Author URL: http://w3layouts.com
	License: Creative Commons Attribution 3.0 Unported
	License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="en">
<head>
<title>Verifyy Login</title>
<!-- Meta tag Keywords -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Trendy Flat Login Form Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Meta tag Keywords -->
<!--font-awesome-css-->
<link href="Login/css/font-awesome.css" rel="stylesheet"> 
<!--//font-awesome-css-->
<!-- css files -->
<link href="Login/css/style.css" rel="stylesheet" type="text/css" media="all">
<!-- online-fonts -->
<link href="//fonts.googleapis.com/css?family=Roboto+Slab:100,300,400,700Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900iSlabo+27px&subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet">
<!--//online-fonts -->
<body>
<!--header-->
<div class="agileheader">
	<h1>Sign In</h1>
</div>
<!--//header-->
<!--main-->
<section class="main-w3l">
	<div class="w3layouts-main">
		<h2>Login Now</h2>
			<div class="w3ls-form">
				<form id="form1" runat="server">
					<div class="email-w3ls">
						<input type="email" name="email" placeholder="E-mail" required="">
						<span class="icon1"><i class="fa fa-envelope" aria-hidden="true"></i></span>
					</div>	
					<div class="w3ls-password">
						<input type="password" name="password" placeholder="Password" required="">
						<span class="icon3"><i class="fa fa-lock" aria-hidden="true"></i></span>
					</div>	
					<span><input type="checkbox" />Remember Me</span>
					<h6><a href="#">Forgot Password?</a></h6>
						<div class="clear"></div>
						<%--<input type="submit" value="login" name="login">--%>
                        <asp:Button ID="btnSubmit" runat="server" Text="Login" 
                        onclick="btnSubmit_Click"></asp:Button>
				</form>
			</div>	
			<div class="w3ls-bottom">
				<p>Company not yet Registered?<a href="RegisterCompany.aspx">Register Company</a></p>
                <p>New to the system?<a href="RegisterNew.aspx">Register Now</a></p>
			</div>	
	</div>	
</section>
<!--//main-->
<!--footer-->
<div class="footer-w3l">
	<p>&copy; Login Form. All rights reserved | Design by Verifyy</a></p>
</div>
<!--//footer-->

   
</body>
</html>
 