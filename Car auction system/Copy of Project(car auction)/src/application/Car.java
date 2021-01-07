package application;

public class Car {

	private String _brand;
	private int _year;
	private String _transmission;
	private double _price;
	public Car(String _brand, int _year, String _transmission, double _price) {

		this._brand = _brand;
		this._year = _year;
		this._transmission = _transmission;
		this._price = _price;
	}
	public String get_brand() {
		return _brand;
	}
	public void set_brand(String _brand) {
		this._brand = _brand;
	}
	public int get_year() {
		return _year;
	}
	public void set_year(int _year) {
		this._year = _year;
	}

	public String get_transmission() {
		return _transmission;
	}
	public void set_transmission(String _transmission) {
		this._transmission = _transmission;
	}
	public double get_price() {
		return _price;
	}
	public void set_price(double _price) {
		this._price = _price;
	}
	//@Override
	//public String toString() {
		// TODO Auto-generated method stub
		//return _brand +","+Integer.toString(_year)+","+_transmission+","+Double.toString(_price);
	//}
	@Override
	public int hashCode() {
		// TODO Auto-generated method stub
		return super.hashCode();
	}
	@Override
	public String toString() {
		return "Car brand = " + _brand + ", year = " + _year + ", transmission = " + _transmission + ", price = " + _price;
	}






}
