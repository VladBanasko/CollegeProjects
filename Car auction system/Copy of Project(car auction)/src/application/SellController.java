package application;

import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.TextField;
import javafx.scene.control.Alert.AlertType;
import javafx.stage.Stage;

public class SellController {
	@FXML
	private TextField txtBrand;
	@FXML
	private TextField txtYear;
	@FXML
	private TextField txtPrice;
	@FXML
	private ChoiceBox<String> chbTransmission;
	@FXML
	private Button btnAdd;
	@FXML
	private Button btnClose;

	CarList list = new CarList();

	@FXML
	private void initialize(){

	chbTransmission.getItems().add("Manual");
	chbTransmission.getItems().add("Auto");
	chbTransmission.setValue("Auto");

	btnAdd.setOnAction(e -> onAddClicked());
	btnClose.setOnAction(e -> onCloseClicked());


	}
	private void onAddClicked(){

		Car car = new Car(txtBrand.getText(), Integer.parseInt(txtYear.getText()), chbTransmission.getValue(), Double.parseDouble(txtPrice.getText()));
		list.load();
		list.addCar(car);
		list.save();
		Alert alert = new Alert(AlertType.INFORMATION, "Thank you, your car was successfully added to list of selling cars");
		alert.show();

	}
	 private void onCloseClicked() {
	        // Get a reference to the stage
	        Stage stage = (Stage) btnClose.getScene().getWindow();
	        // Close the window
	        stage.close();
	    }



}
