namespace Assignment_6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList houseList = new();

            houseList.AddFirst(new House(2, "South Street", "Colonial"));
            houseList.AddLast(new House(3, "North Street", "Ranch"));
            houseList.AddLast(new House(4, "East Street", "Modern"));
            houseList.AddLast(new House(5, "West Street", "Complex"));
            houseList.AddFirst(new House(1, "MidWest Street", "Cabin"));

            houseList.DisplayAll();

            Console.WriteLine("\n\n---Search Complete--- ");
            House foundHouse = houseList.Search(0);

            if (foundHouse != null)
            Console.WriteLine($"\nNumber: {foundHouse.Number} \n Address: {foundHouse.Address} \n Type: {foundHouse.Type}");


            Console.ReadKey();
        }
    }
}
