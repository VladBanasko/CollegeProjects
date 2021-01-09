package testpack;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ModifyAccount
 * Banasko Vladyslav 99152801
 */
@WebServlet("/ModifyAccount")
public class ModifyAccount extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
   
    public ModifyAccount() {
        super();
       
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		RequestDispatcher rd = request.getRequestDispatcher("/WEB-INF/pages/modifyAccount.jsp");
		rd.forward(request, response);
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		Integer uid = (Integer) request.getSession().getAttribute("uid");
		String fullName = request.getParameter("name");
		String pass = request.getParameter("lpass");
		DB_Access db = new DB_Access();
		if(fullName.isEmpty()) {
			fullName=db.getUserName(uid);
		}
		if (pass.isEmpty()) {
			pass = db.getUserPass(uid);
		}
		boolean res = db.updateAccountInfo(uid, fullName, pass);
		if(res== true) {
			response.sendRedirect("Home?msg=data updated , new name is "+fullName+" and new pass is "+pass);
		} else {
			
			response.sendRedirect("ModifyAccount?msg=Error,try again");
		}
	}

}
