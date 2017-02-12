using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бойцовский_клуб
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int live_player1 = 10, live_player2 = 10, udar_player1 = 0, udar_player2 = 0, blok_player1 = 0, blok_player2 = 0;
            bool flag = false, flag1 = true;
            do
            {
                if (flag == false)
                {
                    blok_player2 = rnd.Next(1, 3);

                    Console.WriteLine("Выберите по какому участку тела, вы нанесете удар:");
                    Console.WriteLine("1.Голова");
                    Console.WriteLine("2.Туловище");
                    Console.WriteLine("3.Ноги");
                    udar_player1 = Convert.ToInt32(Console.ReadLine());

                    if (blok_player2 == 1)
                        Console.Write("Блок поставили на голову. ");
                    else
                    {
                        if (blok_player2 == 2)
                            Console.Write("Блок поставили на туловище. ");
                        else
                            Console.Write("Блок поставили на ноги. ");
                    }
                   
                    if (udar_player1 != blok_player2)
                    {
                        Console.WriteLine("Вы нанесли удар.");
                        live_player2 = live_player2 - 1;
                    }
                    else
                        Console.WriteLine("Ваш удар блокировали.");

                    blok_player2 = 0;
                    udar_player1 = 0;
                    flag = true;

                    if (live_player2 == 0)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Победа. Поздравляем.");
                        flag1 = false;
                    }
                }
                else
                {
                    udar_player2 = rnd.Next(1, 3);

                    Console.WriteLine("Выберите какой участок тела, вы хотите заблокировать:");
                    Console.WriteLine("1.Голова");
                    Console.WriteLine("2.Туловище");
                    Console.WriteLine("3.Ноги");
                    blok_player1 = Convert.ToInt32(Console.ReadLine());

                    if (udar_player2 == 1)
                        Console.Write("Удар нанесли по голове. ");
                    else
                    {
                        if (udar_player2 == 2)
                            Console.Write("Удар нанесли по туловищу. ");
                        else
                            Console.Write("Удар нанесли по ноге. ");
                    }

                    if (udar_player2 != blok_player1)
                    {
                        Console.WriteLine("Вы не смогли блокировать удар.");
                        live_player1 = live_player1 - 1;
                    }
                    else
                        Console.WriteLine("Вы блокировали удар.");
                    
                    blok_player1 = 0;
                    udar_player2 = 0;
                    flag = false;

                    if (live_player1 == 0)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Поражение.");
                        flag1 = false;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (flag1 == true);
           
            Console.ReadKey();

        }
    }
}
