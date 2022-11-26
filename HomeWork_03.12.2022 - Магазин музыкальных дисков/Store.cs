using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03._12._2022___Магазин_музыкальных_дисков
{
    internal class Store
    {
        string storeName;
        string address;
        List<Audio> audios = new List<Audio>();
        List<DVD> dvds = new List<DVD>();

        public Store(string storeName, string address)
        {
            this.storeName = storeName;
            this.address = address;
        }

        //Удаление и добавление дисков
        public void addaudio(Audio audio)
        {
            audios.Add(audio);
        }
        public void removeaudio(Audio audio)
        {
            audios.Remove(audio);
        }

        //Добавление и удаление фильмов
        public void addfilm(DVD dVD)
        {
            dvds.Add(dVD);
        }
        public void removefilm(DVD dVD)
        {
            dvds.Remove(dVD);
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string res = "Песни:\n";
            foreach(Audio audio in audios)
            {
                if (audio.ToString().Equals("Название")) res += "\n";
                res += audio.ToString();
            }
            res += "Фильмы:\n";
            foreach(DVD dVD in dvds){
                if (dVD.ToString().Equals("Название")) res+= "\n";
                res += dVD.ToString();
            }
            return res;
        }

    }
}
