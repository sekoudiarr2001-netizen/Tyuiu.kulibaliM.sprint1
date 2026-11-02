using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kulibaliM.sprint1.task0.V29.lib;
namespace Tyuiu.kulibaliM.sprint1.task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "спринт #К | Выполнил : спирин М.К .| ИСТНб-26-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема : Базовые навыки в С#                                              *");
            Console.WriteLine(" * Задание #0                                                                *");
            Console.WriteLine(" * Вариант #29                                                               *");
            Console.WriteLine("*  Выполнил : Спирин Кулибали Махамаду ИСТНб-26-1                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Условые :                                                                     *");
            Console.WriteLine("* Выражать 2*9+7*2                                                              *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* 2*9+7*2                                                                       *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* результат                                                                    *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine(dataService.Calculate());
            Console.ReadKey();
        }
    }
}
