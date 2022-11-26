using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_26._11._2022___Автопарк
{
    internal class Autopark
    {
        string name;
        public List<Car> park = new List<Car>();
        public Autopark(string name, List<Car> park)
        {
            this.name = name;
            this.park= park;
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string res = "Название автопарка: " +  name + "\n" + "Параметры автомобиля:";
            foreach (var x in park)
            {
                if (x.ToString().Contains("Марка")) res += "\n";
                res += " " + x.ToString();
                
            }
            res+= "\n";
            return res;
        }
    }
}
