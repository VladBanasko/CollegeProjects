package application;

import java.util.Arrays;
import java.util.List;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.ListView;
import javafx.scene.control.Separator;
import javafx.scene.control.Tooltip;
import javafx.scene.control.Alert.AlertType;
import javafx.stage.Stage;

public class BuyController {
	@FXML
	private ChoiceBox chbCar;
	@FXML
	private Button btnPurchase;
	@FXML
	private Button btnClose;
	@FXML
	private ComboBox<String> listView;

	  CarList list = new CarList();

	@FXML
	private void initialize(){

		btnPurchase.setOnAction(e -> onPurchaseClicked());
		btnClose.setOnAction(e -> onCloseClicked());




		list.load();

		String[] o =  list.toStringArray();



		chbCar.getItems().setAll(o);
        chbCar.setTooltip(new Tooltip("Select the car")); // this one doesn't work for know
        listView.getItems().setAll(o);





	}
	private void onPurchaseClicked(){
		//alerts the user on successful purchase





		Alert alert = new Alert(AlertType.INFORMATION, "Thank you for the purchase");
		alert.show();
	}
	 private void onCloseClicked() {
	        // Get a reference to the stage
	        Stage stage = (Stage) btnClose.getScene().getWindow();
	        // Close the window
	        stage.close();
	        }}



