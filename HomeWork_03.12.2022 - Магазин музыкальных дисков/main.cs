using HomeWork_03._12._2022___Магазин_музыкальных_дисков;
class main
{
    public static void Main(string[] args)
    {
        Store store = new Store("My Store", "Moscow");
        Audio audio1 = new Audio("Song1", "Genre1", "Artist1", "Strudo1", 3);
        Audio audio2 = new Audio("Song2", "Genre2", "Artist2", "Strudo2", 5);

        DVD dvd1 = new DVD("Film1", "Genre1", "Producer1", "Company1", 186);
        DVD dvd2 = new DVD("Film2", "Genre2", "Producer2", "Company2", 65);

        //Демонстрация работоспособности функции добавления аудио и видео
        store.addaudio(audio1);
        store.addaudio(audio2);
        store.addfilm(dvd1);
        store.addfilm(dvd2);

        //Демонстрация работоспособности функции удаления аудио и видео
        store.removeaudio(audio1);
        store.removefilm(dvd2);

        Console.WriteLine(store.ToString());

        audio1.Burn();
        audio1.Burn();
        dvd2.Burn();


        Console.WriteLine(audio1.name + " " +  audio1.DiskSize);
        Console.WriteLine(audio2.name + " " +  audio2.DiskSize);
        Console.WriteLine(dvd1.name + " " + dvd1.DiskSize);
        Console.WriteLine(dvd2.name + " " + dvd2.DiskSize);






    }
}
