package testpack;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CreateUser
 * Banasko Vladyslav 99152801
 */
@WebServlet("/CreateUser")
public class CreateUser extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public CreateUser() {
		super();

	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/pages/createUser.jsp");
		rd.forward(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String loginName = request.getParameter("lname");
		String name = request.getParameter("name");
		String pass = request.getParameter("pass");
		String pass2 = request.getParameter("pass2");
		User u = new User(-1, loginName, name, pass,pass2);
		DB_Access db = new DB_Access();

		int res = db.createUserAccount(u);
		if(res==0) {
			response.sendRedirect("Login?msg=User successfully added");
		} else {
			response.sendRedirect("Login?msg= error, try again");
		}
	}

}
