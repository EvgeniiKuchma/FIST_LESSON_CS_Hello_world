using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;
//using System.Threading.Tasks;

namespace FIST_LESSON_CS_Hello_world
{
    internal class Program
    {
        static void PrintName(string name1, string _order = "") 
        {
            Console.WriteLine("hello, ");
            Console.Write("Hello, \n");
            if (_order == "-")
            {
                for (int i = 0; i > name1.Length; i++)
                {
                    Console.Write(name1[i] + "\n");
                }
                Console.WriteLine("!");
            }
           else
            for (int i = name1.Length - 1; i >= 0; i--)
            {
                Console.Write(name1[i] + "\n");
            }
           Console.WriteLine("!");
        }
        static void Main(string[] args)
        {
            string name = "", order = "";
            try 
            {
                //Console.WriteLine("Hello, {0}!", args[0]);
                name = args[0];
                order = args[1];
            }
           
            catch
            {
            Console.WriteLine("Как зовут тебя?");
            name = Console.ReadLine();
            }
            finally 
            {
               PrintName(name, order);
               //PrintName(name);или так если 
               //Console.WriteLine("hello, {0}!", name);
               // Console.Write("Hello, \n");
               //for (int i = name.Length - 1; i >= 0; i--) 
               //{ 
               // Console.Write(name[i] + "\n");
               //}
               //Console.Write("!");    
            }
            Console.ReadKey();
            //Console.WriteLine("Hello world");//варианты вывода в консоль
            //Console.WriteLine("hello, " + name + "!");
            //Console.WriteLine("hello, {0}!", name);
            //Console.WriteLine($"hello, { name}!");
            //Console.ReadKey();//задержка до продолжения
            //int i;

        }

    }
}
