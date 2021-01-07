package application;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CarList extends ArrayList<Car>  {

	private ArrayList<Car> _carList = new ArrayList<>();

	public void load() {
		Scanner reader = null;
		try {
			File fileDescriptor = new File("carlist.txt");
			reader = new Scanner(fileDescriptor);

			_carList.clear(); // Make sure the array list is empty before
									// loading
			while (reader.hasNext()) {
				// Read the next line from the file
				String record = reader.nextLine();

				// Now split the line into separate fields
				String[] fields = record.split(",");

				String brand = fields[0];
				int year = Integer.parseInt(fields[1]);
				String transmission = (fields[2]);
				double price = Double.parseDouble(fields[3]);

				// Create a player object and add it to the list
				Car car = new Car(brand, year, transmission,price);
				_carList.add(car);
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace(); // Note this can't recover from the error
		} finally {
			if (reader != null) {
				reader.close();
			}
		}

	}
	public void save() {
		if (_carList.size() == 0) {
			return; // Don't overwrite the file with an empty list
		}

		PrintWriter writer = null;
		try {
			File fileDescriptor = new File("carlist.txt");
			writer = new PrintWriter(fileDescriptor);

			for (int i = 0; i < _carList.size(); i++) {
				Car car = _carList.get(i);
				writer.println(car.get_brand() + "," + car.get_year() + "," + car.get_transmission() +","+ car.get_price());
			}


		} catch (FileNotFoundException e) {
			e.printStackTrace(); // Note this can't recover from the error
		} finally {
			if (writer != null) {
				writer.close();
			}
		}

	}



	public void addCar(Car car){
		_carList.add(car);
	}
	 public List<Car> getList(){
	      return _carList;
	  }

	public String[] toStringArray() {
		// TODO Auto-generated method stub
		String[] str = new String[_carList.size()];
		for (int i = 0; i < _carList.size(); i++) {
			str[i] = _carList.get(i).toString();
		}
		return str;
	}




}
