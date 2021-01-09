package testpack;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class DeleteItem
 * Banasko Vladyslav 99152801
 */
@WebServlet("/DeleteItem")
public class DeleteItem extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    
    public DeleteItem() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/pages/deleteItem.jsp");
		rd.forward(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		Integer uid = (Integer) request.getSession().getAttribute("uid");
		String id = request.getParameter("id");
		
		DB_Access db = new DB_Access();
		boolean res = db.deleteItem(id, uid);
		if (res == true) {
			response.sendRedirect("Home?msg=data deleted");
		} else {

			response.sendRedirect("DeleteItem?msg=Error,try again");
		}

	}
	

}
