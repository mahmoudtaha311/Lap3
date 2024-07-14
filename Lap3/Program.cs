namespace Lap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2= new Book("mahmoud",1, default, 1500);
            Book book3 = new Book("mahmoud", 2, default, 1200);
            Book book4 = new Book("mahmoud", 3, default, 1700);
            book4.HowManyBookBuy();




        }
    }
}
