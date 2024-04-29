using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok3
{
    public  class Class2 
    {
        public void Method(Class obj) 
        {
            obj.Method2(this); //this используется как передача ссылки на нынешний класс
        }
    }

    public partial class Class //partial нам нужен чтобы разграничить описания класса между файлами
    {
        //поля
        public string Name;
        public static string Surname;
        public const string Asd = "asd";
        public readonly string Wasd;

        //методы
        public string Hello(string name) { return name; }
        public void Method2(Class2 obj) { }

        public void Method3(ref int a, out int b) //благодаря ref можем передать целочисленное значение а, out позволяет вытащить
        {
            a = 1; b = 2;
        }
        //конструкторы
        public Class(string name) 
        {
            this.Name = Name; //компилтор понимает к какому полю относится первый нейм, благодаря ключевому слову this
        }
        public Class() { }
    }
}
