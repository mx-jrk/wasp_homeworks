using HomeWork_26._11._2022___Автопарк;

class main
{
    public static void Main(string[] args)
    {
        PassengerCar passangers = new PassengerCar("mercedes", "500hp", 2020, 15);
        passangers.add_autopart(2022, "подвеска");
        passangers.getting_the_replacement_year_by_name("подвеска");
        passangers.formatted_printing_of_the_entire_repair_book();

        Truck my_truck = new Truck("Volvo", "450", 2018, 150, "Сергеевич Сергей");
        my_truck.change_driver("Иванов Иван");
        my_truck.change_cargo("Картофель", 100, 1);
        my_truck.change_cargo("Морковь", 10, 1);
        my_truck.change_cargo("Картофель", 100, 0);
        my_truck.formatted_print_of_the_current_load();

        Autopark park = new Autopark("Park", new List<Car>{passangers, my_truck});
        Console.WriteLine(park.ToString());
    }
}
