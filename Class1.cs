using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok3
{
    internal class Class1
    {
        private int _num;

        //свойства
        public int Num { get { return _num; } set { _num = value; } } //просто свойства

        public string Asd2 { get; set; } //автосвойства

        public void Der (int num = 12, params int[] cow) //парамс обозначает переменное количество аргументов, то есть массив
        {
            Article srticle1 = new Article(1, "Товар 1", 100, ArticleType.Type1);
        }
    }
}
