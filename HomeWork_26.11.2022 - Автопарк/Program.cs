using HomeWork_26._11._2022___Автопарк;

class Program
{
    public static void Main(string[] args)
    {
        Car my_car = new Car("mercedes", "500hp", 2020);
        Console.WriteLine(my_car.ToString());

        PassengerCar passangers = new PassengerCar("mercedes", "500hp", 2020);
        passangers.count_of_passangers = 12;
        passangers.add_autopart(2022, "подвеска");
        passangers.getting_the_replacement_year_by_name("подвеска");
        passangers.formatted_printing_of_the_entire_repair_book();
        Console.WriteLine(passangers.ToString());

        Truck my_truck = new Truck("mercedes", "500hp", 2020);
        my_truck.drivers_FM = "Сергей Сергеевич";
        my_truck.maximum_load_capacity= 100;
        my_truck.change_driver("Иванов Иван");
        my_truck.change_cargo();
        my_truck.change_cargo();
        my_truck.change_cargo();
        my_truck.formatted_print_of_the_current_load();
        Console.WriteLine(my_truck.ToString());



    }
}
