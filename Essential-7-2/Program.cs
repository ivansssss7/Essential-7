
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Essential_7_2
{
class Program
{
    static void ClassTaker(MyClass myClass)
    {
        myClass.change = "MyClass змінено";
    }
    static void StruktTaker(MyStruct myStruct)
    {
        myStruct.change = "MyStruct змінено";
    }
    static void Main(string[] args)
    {
       MyClass myClass = new MyClass();
       MyStruct myStruct = new MyStruct();

        ClassTaker(myClass);

        Console.WriteLine(myClass.change);//поле змінилось

        StruktTaker(myStruct);

        Console.WriteLine(myStruct.change);//Default value, Оскільки
                                           //в структурах копіюється значення,
                                           //а не посилання, зміни,
                                           //зроблені в методі StructTaker

        Console.ReadKey();
    }
}
}