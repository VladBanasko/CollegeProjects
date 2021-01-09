package testpack;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ViewItem
 * Banasko Vladyslav 99152801
 */
@WebServlet("/ViewItem")
public class ViewItem extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public ViewItem() {
		super();

	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		DB_Access db = new DB_Access();
		Integer uid = (Integer) request.getSession().getAttribute("uid");

		String id = request.getParameter("id");

		Item item = new Item();
		item.setName(db.getItemName(id, uid));
		Integer qty = Integer.parseInt(db.getItemQty(id, uid));
		item.setQty(qty);

		request.setAttribute("item", item);

		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/pages/viewItem.jsp");
		rd.forward(request, response);

	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

	}

}
