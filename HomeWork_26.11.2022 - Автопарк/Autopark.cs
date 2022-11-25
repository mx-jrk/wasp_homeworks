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
        public List<String> park = new List<String>();
        public Autopark(string name, string brand, string power, int production_year)
        {
            this.name = name;
            this.park.Add(brand);
            this.park.Add(power);
            this.park.Add(production_year.ToString());
        }

        public override string ToString()
        {
            string res = "Название автопарка: " +  name + "\n" + "Параметры автомобиля:";
            foreach (var x in park)
            {
                res += " " + x.ToString();
            }
            return res;
        }
    }
}
