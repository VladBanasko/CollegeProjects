package application;


import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Modality;
import javafx.stage.Stage;

public class MainController {
	@FXML
	private Button btnBuy;
	@FXML
	private Button btnSell;



	@FXML
	private void initialize(){

		btnBuy.setOnAction(e -> onBuyClicked());
		btnSell.setOnAction(e -> onSellClicked());


	}
    private void onBuyClicked(){
    	try {
            AnchorPane root = (AnchorPane)FXMLLoader.load(getClass().getResource("Buy.fxml"));
            Scene scene = new Scene(root,600,400);
            scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
            Stage secondStage = new Stage();
            secondStage.setScene(scene);
            secondStage.initModality(Modality.APPLICATION_MODAL);  // Use this so you have to close the 2nd window to return to main window
            secondStage.showAndWait();
        } catch(Exception e) {
            e.printStackTrace();
        }

	}

	private void onSellClicked(){
		try {
            AnchorPane root = (AnchorPane)FXMLLoader.load(getClass().getResource("Sell.fxml"));
            Scene scene = new Scene(root,600,400);
            scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
            Stage secondStage = new Stage();
            secondStage.setScene(scene);
            secondStage.initModality(Modality.APPLICATION_MODAL);  // Use this so you have to close the 2nd window to return to main window
            secondStage.showAndWait();
        } catch(Exception e) {
            e.printStackTrace();
        }

	}


}
