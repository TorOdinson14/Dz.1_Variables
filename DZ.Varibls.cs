using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiaсSign;
            string work;
            int year;

            Console.Write("Введите своё Имя ? ");
            name = Console.ReadLine();

            Console.Write("Сколько вам лет ? ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш знак зодиака ? ");
            zodiaсSign = Console.ReadLine();

            Console.Write("Где сейчас трудоустроеены? ");
            work = Console.ReadLine();

            Console.WriteLine($"Ваше имя " + name+("\nВам ") + year + (" лет ") +  
                ("\nВаш зодиак ") + zodiaсSign + ("\nВы работаете  ") + work);


        }
    }
}
