using System;
using System.Collections.Generic;

namespace DictonaryDemo
{
    class Program
    {
  

        static void Main(string[] args)
        {
            MyDictonary<int, string> myDictonary = new MyDictonary<int, string>();

            myDictonary.Add(1, "Psikoloji Kitapları");
            myDictonary.Add(2, "Edebiyat Kitapları");
            myDictonary.Add(3, "Eğitim Kitapları");
            myDictonary.Add(4, "Anı Kitapları");

            myDictonary.WriteDictonary();
            

        }
    }

    
}
