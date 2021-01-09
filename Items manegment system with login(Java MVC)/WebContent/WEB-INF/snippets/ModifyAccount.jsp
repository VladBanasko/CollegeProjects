<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<form method=post>
<table class="center">
	<tr><td colspan=2><span style="color:red;">${param.msg}</span></td></tr>
	<tr><td colspan=2><h2>Update information form</h2></td></tr>
	<tr>
		<td align=left>new Name: </td>
		<td><input type=text name=name></td>
	</tr>
	<tr>
		<td align=left>new Password: </td>
		<td><input type=text name=lpass></td>
	</tr>
	<tr><td colspan=2><input type=submit value=Update></td></tr>
</table>
<a href="Home">Home</a>
</form>