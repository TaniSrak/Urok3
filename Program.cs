using Russia;
using France;
using Germany;

namespace Urok3
{
    internal class Program
    {
        struct Name 
        {
            public Name(string name) { }
        }
        static void Main(string[] args)
        {
            int a = 3; int b;
            Class cl = new Class();
            cl.Method3(ref a, out b); //взаимодействуем с ссылками из другого файла
            Console.WriteLine(b);
            Console.WriteLine(a);

            Class1 cl1 = new Class1();
            cl1.Asd2 = "asd";
            Console.WriteLine(cl1.Asd2);

            //string str = Console.ReadLine("Введите имя клиента:");
            //string[] words = str.Split(" ");

            var Moscow = new Russia.Moscow(13000000);
            var Berlin = new Berlin(3000000); //благодаря юзингу можно не писать россия
            var Paris = new Paris(2000000);
            Console.WriteLine("Сравнение населения трех столиц:");
            Console.WriteLine($"Москва: {Moscow.Population} человек");
            Console.WriteLine($"Berlin: {Berlin.Population} человек");
            Console.WriteLine($"Paris: {Paris.Population} человек");
        }
    }
}
