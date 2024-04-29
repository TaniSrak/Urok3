using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok3
{
    //Task1
    struct Article
    {
        public int id;
        public string title;
        public int price;

        public ArticleType Type;
        public Article(int id, string title, int price, ArticleType type)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.Type = type;
        }
    }
    public enum ArticleType //enum - перечисления
    {
        Type1,
        Type2,
        Type3
    }

    //Task2
    struct Client
    {
        public int cod;
        public string name;
        public string address;
        public double phone;
        public int numberOfOrders;
        public int totalOrders;

        public ClientType Type;

    }
    public enum ClientType
    {
        Vip1,
        Top2,
        Full3,
        Loh4
    }

    //Task3


    internal class Upr
    {
    }
}
