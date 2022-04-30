using System;

namespace G4_1
{
    class Program
    {
        private string date;
        private int balance;
        static void Main(string[] args)
        {
        

            Console.WriteLine("Проверка универсальности.");
            Universaly uni = new Universaly();
            uni.ContoraON();
            uni.takeMoney();
            uni.putMoney();
            uni.ContoraOff();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Депозит 'Cохраняй'");
            Deposit_Save save = new Deposit_Save();
            save.ContoraON();
            save.precent = 20;
            save.DateOPyear = 2024;
            save.DateOPmonth = 3;
            save.DateOPday = 31;
            save.PrecentAdd();
            save.CheckDepositStatus();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Депозит 'Cохраняй'");
            Deposit_Save_and_topup saveup = new Deposit_Save_and_topup();
            saveup.ContoraON();
            saveup.DepContora();
        }
        
           
    }
}
