<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<form method=post>
<table class="center">
	<tr><td colspan=2><span style="color:red;">${param.msg}</span></td></tr>
	<tr><td colspan=2><h2>Delete Item</h2></td></tr>
	<tr>
		<td align=left> Delete item ? </td>
	</tr>
	
	<tr><td colspan=2><input type=submit value=delete></td><td><a href="Home">Home</a><td></tr>
	
</table>
</form>