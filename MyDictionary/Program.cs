using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Ankara");
            myList.Add("İzmir");
            myList.Add("Sivas");
            Console.WriteLine("myList eleman sayısı : {0}",myList.Count);

            MyList<string> myList2 = new MyList<string>();
            myList2.Add("İstanbul");
            myList2.Add("Adana");
            Console.WriteLine("myList2 eleman sayısı : {0}",myList2.Count);
            Console.ReadLine();


        }
    }
}
