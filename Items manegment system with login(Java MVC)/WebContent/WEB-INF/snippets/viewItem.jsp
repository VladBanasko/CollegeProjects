<%@ page import="testpack.Item" language="java"
	contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<table class="center" width="70%">
	<tr>
		<td colspan=2 align=center>
			<h2>Item info</h2>

			<table class="center">
				<tr>
					<th>Item Name</th>
					<th>Quantity</th>
				</tr>
				<%
					Item item = (Item) request.getAttribute("item");
				%>
				<tr>
					<td><%=item.getName()%></td>
					<td><%=item.getQty()%></td>
				</tr>

			</table>

		</td>
	</tr>
</table>
<a href="Home">Home</a>