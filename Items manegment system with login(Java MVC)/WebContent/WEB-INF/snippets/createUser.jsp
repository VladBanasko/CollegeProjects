<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<form method=post>
<table class="center">
	<tr><td colspan=2><span style="color:red;">${param.msg}</span></td></tr>
	<tr><td colspan=2><h2>Create new USer</h2></td></tr>
	<tr>
		<td align=left>Login Name: </td>
		<td><input type=text name=lname></td>
	</tr>
	<tr>
		<td align=left> Name: </td>
		<td><input type=text name=name></td>
	</tr>
	<tr>
		<td align=left>Password: </td>
		<td><input type=text name=pass></td>
	</tr>
	<tr>
		<td align=left>Confirm Password: </td>
		<td><input type=text name=pass2></td>
	</tr>
	<tr><td colspan=2><input type=submit value=Add></td></tr>
</table>
</form>