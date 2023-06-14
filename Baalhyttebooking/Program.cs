namespace Baalhyttebooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boernegruppe gruppe1 = new Boernegruppe("1", "Piltene", "Pilt", 4);

            Reservation reservation1 = new Reservation(1, new DateTime(2023, 6, 14), gruppe1);

            Console.WriteLine("Din gruppe ser således ud: ID " + gruppe1);
            Console.WriteLine(reservation1);
        }
    }
}