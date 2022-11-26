using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03._12._2022___Магазин_музыкальных_дисков
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        public void DiscountPrice(int percent)
        {
            this.Price = percent * this.Price;
        }
    }
    internal class Disk : IStoreItem
    {
        public string name;
        public string genre;
        public static int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize { get; set; }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Burn() { }


    }

    class Audio : Disk
    {
        string artist;
        string recordingStudio;
        int songsNumber;
        public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
        }

        //Переопределенное свойство DiskSize
        public override int DiskSize {
            get
            {
                return songsNumber * 8;
            }
        }

        //Переопределенное свойство Burn
        public override void Burn()
        {
            burnCount++;
            
        }

        //Переопределеный метод ToString
        public override string ToString()
        {
            return "Название: " + name.ToString() + ", Жанр: " + genre.ToString() + ", Исполнитель: " + artist.ToString() + ", Студия звукозаписи: " + recordingStudio.ToString() + ", Количество песен: " + songsNumber.ToString() + ", Количество прожогов: " + burnCount.ToString() + "\n";
        }
    }

    class DVD : Disk
    {
        public string producer;
        string filmCompany;
        int minutesCount;

        public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }

        //Переопределенное свойство DiskSize
        public override int DiskSize
        {
            get
            {
                return (minutesCount / 64) * 2;
            }
        }

        //Переопределенное свойство Burn
        public override void Burn()
        {
            burnCount++;

        }

        //Переопределеный метод ToString
        public override string ToString()
        {
            return "Название: " + name.ToString() + ", Жанр: " + genre.ToString() + ", Режиссер: " + producer.ToString() + ", Кинокомпания: " + filmCompany.ToString() + ", Количество минут: " + minutesCount.ToString() + ", Количество прожогов: " + burnCount.ToString() + "\n";
        }
    }
}
