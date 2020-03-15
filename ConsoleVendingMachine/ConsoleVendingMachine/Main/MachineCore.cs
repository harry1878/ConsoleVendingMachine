using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class MachineCore
{
    public void Run()
    {
        while(true)
        {
            Console.Clear();

            Console.WriteLine("===========================================");
            Console.WriteLine("\t     Vending Machine\t\t\t\t\t\t\t\t\t가지고 있는돈 : {0}", Player.Get.money);
            Console.WriteLine("===========================================");
            Console.WriteLine("무엇을 구입하시겠습니까?");
            Console.WriteLine();
            Console.Write("인벤토리: ");
            foreach (string i in Player.Get.inv)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("상품목록: ");
            foreach (KeyValuePair<string, int> v in Player.Get.beverage)
            {
                Console.WriteLine();
                Console.WriteLine($" 음료 :{v.Key}\n 가격 :{v.Value.ToString()}");
            }

            string input = Console.ReadLine();

            if (input.Equals("Coke", StringComparison.CurrentCultureIgnoreCase))
            {
                if (Player.Get.money >= Player.Get.beverage["Coke"])
                {
                    Player.Get.money -= Player.Get.beverage["Coke"];
                    Player.Get.inv.Add("Coke");
                }
                else
                {
                    Console.Write("돈이 부족하여 구입하실 수 없습니다");
                    Thread.Sleep(2000);
                }
                
            }
            if (input.Equals("OrangeJuice", StringComparison.CurrentCultureIgnoreCase))
            {
                if (Player.Get.money >= Player.Get.beverage["OrangeJuice"])
                {
                    Player.Get.money -= Player.Get.beverage["OrangeJuice"];
                    Player.Get.inv.Add("OrangeJuice");
                }
                else
                {
                    Console.Write("돈이 부족하여 구입하실 수 없습니다");
                    Thread.Sleep(2000);
                }

            }
            if (input.Equals("Coffee", StringComparison.CurrentCultureIgnoreCase))
            {
                if (Player.Get.money >= Player.Get.beverage["Coffee"])
                {
                    Player.Get.money -= Player.Get.beverage["Coffee"];
                    Player.Get.inv.Add("Coffee");
                }
                else
                {
                    Console.Write("돈이 부족하여 구입하실 수 없습니다");
                    Thread.Sleep(2000);
                }

            }
            if (input.Equals("Monster", StringComparison.CurrentCultureIgnoreCase))
            {
                if (Player.Get.money >= Player.Get.beverage["Monster"])
                {
                    Player.Get.money -= Player.Get.beverage["Monster"];
                    Player.Get.inv.Add("Monster");
                }
                else
                {
                    Console.Write("돈이 부족하여 구입하실 수 없습니다");
                    Thread.Sleep(2000);
                }

            }

            if (input.Equals("Exit", StringComparison.CurrentCultureIgnoreCase))
                break;

            if(!input.Equals("Coke", StringComparison.CurrentCultureIgnoreCase) && !input.Equals("OrangeJuice", StringComparison.CurrentCultureIgnoreCase) 
                && !input.Equals("Coffee", StringComparison.CurrentCultureIgnoreCase) && !input.Equals("Monster", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Write("해당 상품을 찾을 수 없습니다");
                Thread.Sleep(2000);
            }


            
        }
        FileUtility.Save(Player.Get.inv, Player.Get.money);
        }

}
