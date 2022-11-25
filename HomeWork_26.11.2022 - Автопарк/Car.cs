using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_26._11._2022___Автопарк
{
    public class Car
    {
        public string brand;
        public string power;
        public int production_year;

        public Car(string brand, string power, int production_year)
        {
            this.brand = brand;
            this.power = power;
            this.production_year = production_year;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return "Марка автомоиля: " + this.brand.ToString() + ", Мощность:  " + this.power.ToString() + ", Год выпуска: " + this.production_year.ToString();
        }
    }

    class PassengerCar : Car
    {
        public int count_of_passangers;
        Dictionary<string, int> repair_book = new Dictionary<string, int>() { };

        //Конструктор в вызовом родительского конструктора
        public PassengerCar(string brand, string power, int production_year) : base(brand, power, production_year) { }

        //Добавление замененной запчасти в ремонтную книжку
        public void add_autopart(int replacement_year, string replaced_autopart) {
            repair_book.Add(replaced_autopart, replacement_year);
        }

        //Получение года замены по названию
        public int getting_the_replacement_year_by_name(string replaced_autopart) {
            return repair_book.GetValueOrDefault(replaced_autopart) + 1;
        }

        //Форматированная печать всей ремонтной книжки
        public void formatted_printing_of_the_entire_repair_book()
        {
            foreach (var kvp in repair_book)
            {
                Console.WriteLine("Запчасть = {0}, Год замены = {1}", kvp.Key, kvp.Value);
            }
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return "Марка автомоиля: " + this.brand.ToString() + ", Мощность:  " + this.power.ToString() + ", Год выпуска: " + this.production_year.ToString() + ", Количество пассажиров: " + this.count_of_passangers.ToString();
        }
    }

    class Truck : Car
    {
        public int maximum_load_capacity;
        public string drivers_FM;
        Dictionary<string, int> current_cargo = new Dictionary<string, int>() { };

        public Truck(string brand, string power, int production_year) : base(brand, power, production_year)
        {
        }

        //Изменение водителя
        public void change_driver(string new_driver)
        {
            this.drivers_FM = new_driver;
        }

        //Добавление и удаление груза;
        public void change_cargo()
        {
            Console.WriteLine("Чтобы добавить груз - введите 1. Чтобы удалить груз ввведите 0");
            int to_do = Int32.Parse(Console.ReadLine());
            string product_name;
            if (to_do == 1)
            {
                Console.WriteLine("Введите название товара");
                product_name = Console.ReadLine();
                Console.WriteLine("Введите вес товара");
                int weight = Int32.Parse(Console.ReadLine());
                current_cargo.Add(product_name, weight);

            }
            else
            {
                Console.WriteLine("Введите название груза, который необходимо удалить");
                product_name = Console.ReadLine();
                current_cargo.Remove(product_name);
            }
        }

        //Форматированная печать текущего груза
        public void formatted_print_of_the_current_load()
        {
            foreach (var kvp in current_cargo)
            {
                Console.WriteLine("Наименование груза = {0}, Вес груза = {1}", kvp.Key, kvp.Value);
            }
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            return "Марка автомоиля: " + this.brand.ToString() + ", Мощность:  " + this.power.ToString() + ", Год выпуска: " + this.production_year.ToString() + ", Максимальная грузоподъемность: " + this.maximum_load_capacity + ", ФИ водителя: " + this.drivers_FM;
        }
    }


}
