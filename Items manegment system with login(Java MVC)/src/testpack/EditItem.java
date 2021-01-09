package testpack;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class EditItem
 * Banasko Vladyslav 99152801
 */
@WebServlet("/EditItem")
public class EditItem extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public EditItem() {
		super();
		// TODO Auto-generated constructor stub
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/pages/editItem.jsp");
		rd.forward(request, response);

	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		Integer uid = (Integer) request.getSession().getAttribute("uid");
		String id = request.getParameter("id");

		String iName = request.getParameter("iname");

		String iQty = request.getParameter("iqty");
		DB_Access db = new DB_Access();
		if (iName == "") {
			iName = db.getItemName(id, uid);
		}
		if (iQty == "") {
			iQty = db.getItemQty(id, uid);
		}
		boolean res = db.updateItemInfo(id, iName, iQty, uid);
		if (res == true) {
			response.sendRedirect("Home?msg=data updated");
		} else {

			response.sendRedirect("EditItem?msg=Error,try again");
		}

	}

}
