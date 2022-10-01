using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MenuDollarToEuro = "1";
            const string MenuDollarToRuble = "2";
            const string MenuEuroToDollar = "3";
            const string MenuEuroToRuble = "4";
            const string MenuRubleToDollar = "5";
            const string MenuRubleToEuro = "6";
            const string MenuExit = "7";

            double balanceDollar = 500;
            double balanceEuro = 400;
            double balanceRuble = 5000;
            double amountToSell;

            double rateDollarToEuro = 1.0362;
            double rateDollarToRuble = 57.4130;
            double rateEuroToDollar = 0.9650;
            double rateEuroToRuble = 55.4064;
            double rateRubleToDollar = 0.0174;
            double rateRubleToEuro = 0.0180;

            string userInput;
            bool isOpen = true;

            string amountRequestMessage = "Введите сумму, которую хотите продать";
            string notEnoughMoneyMessage = "Нехватка средств для проведения операции";
            string successfulMessage = "Операция выполненна успешно";

            string textDollarToEuro = "доллары на евро";
            string textDollarToRuble = "долары на рубли";
            string textEuroToDollar = "евро на доллары";
            string textEuroToRuble = "евро на рубли";
            string textRubleToDollar = "рубли на доллары";
            string textRubleToEuro = "рубли на евро";

            while (isOpen)
            {                
                Console.WriteLine($"-----------------------------------------------");
                Console.WriteLine($" Добро пожаловать на рынок валютных спекуляций ");
                Console.WriteLine($"-----------------------------------------------");
                Console.WriteLine($" Ваш баланс: рубли {balanceRuble}, доллары {balanceDollar}, евро {balanceEuro}");
                Console.WriteLine($"-----------------------------------------------");
                Console.WriteLine($"\nвведите пункт Меню:\n");

                Console.Write($"{MenuDollarToEuro} - {textDollarToEuro}\t");
                Console.WriteLine($"{MenuDollarToRuble} - {textDollarToRuble}");
                Console.WriteLine($"-----------------------------------------------");
                Console.Write($"{MenuEuroToDollar} - {textEuroToDollar}\t");
                Console.WriteLine($"{MenuEuroToRuble} - {textEuroToRuble}");
                Console.WriteLine($"-----------------------------------------------");
                Console.Write($"{MenuRubleToDollar} - {textRubleToDollar}\t");
                Console.WriteLine($"{MenuRubleToEuro} - {textRubleToEuro}");
                Console.WriteLine($"-----------------------------------------------");
                Console.WriteLine($"{MenuExit} - выход");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case MenuDollarToEuro:
                        Console.WriteLine($"обмен {textDollarToEuro}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());

                        if(amountToSell <= balanceDollar)
                        {
                            balanceDollar -= amountToSell;
                            balanceEuro += amountToSell * rateDollarToEuro;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuDollarToRuble:
                        Console.WriteLine($"обмен {textDollarToRuble}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());

                        if (amountToSell <= balanceDollar)
                        {
                            balanceDollar -= amountToSell;
                            balanceRuble += amountToSell * rateDollarToRuble;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuEuroToDollar:
                        Console.WriteLine($"обмен {textEuroToDollar}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());

                        if (amountToSell <= balanceEuro)
                        {
                            balanceEuro -= amountToSell;
                            balanceDollar += amountToSell * rateEuroToDollar;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuEuroToRuble:
                        Console.WriteLine($"обмен {textEuroToRuble}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());
                        
                        if (amountToSell <= balanceEuro)
                        {
                            balanceEuro -= amountToSell;
                            balanceRuble += amountToSell * rateEuroToRuble;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuRubleToDollar:
                        Console.WriteLine($"обмен {textRubleToDollar}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());

                        if (amountToSell <= balanceRuble)
                        {
                            balanceRuble -= amountToSell;
                            balanceDollar += amountToSell * rateRubleToDollar;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuRubleToEuro:
                        Console.WriteLine($"обмен {textRubleToEuro}\n{amountRequestMessage}");
                        amountToSell = Convert.ToDouble(Console.ReadLine());

                        if (amountToSell <= balanceRuble)
                        {
                            balanceRuble -= amountToSell;
                            balanceEuro += amountToSell * rateRubleToEuro;

                            Console.WriteLine($"{successfulMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"{notEnoughMoneyMessage}");
                        }
                        break;
                    case MenuExit:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
