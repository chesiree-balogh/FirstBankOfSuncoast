using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast
{
  class Program
  {

    static void SaveAccounts(List<Account> accounts)
    {
      var writer = new StreamWriter("accounts.csv");
      var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
      csvWriter.WriteRecords(accounts);
      writer.Flush();
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to First Bank of Suncoast");
      var accountsManager = new AccountsManager();
      var accounts = new List<Account>();
      accounts.Add(new Account { AccountType = "Checking", Amount = 0 });
      accounts.Add(new Account { AccountType = "Saving", Amount = 0 });

      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      accounts = csvReader.GetRecords<Account>().ToList();

      AccountsManager.DisplayAccounts(accounts);

      //******************************
      //Console.WriteLine("which account are we working with? (Check)ing, (Sav)ing, or (Q)uit");
      //string accountType = Console.ReadLine();

      //Console.Write("Would you like to (Dep) -Deposit or (With) -Withdraw)?");
      //string depositwithdrawl = Console.ReadLine();


      var isRunning = true;
      while (isRunning)
      {

        Console.WriteLine("What would you like to do? (A)dd funds, (W)ithdrawl funds, (T)ransfer funds, or (Q)iut?");
        var input = Console.ReadLine().ToLower();




        if (input == "a")
        {
          Console.WriteLine("which account would you like to add to? (C)hecking or (S)aving");
          var add = Console.ReadLine().ToLower();
          if (add == "c")
          {
            Console.WriteLine("how much?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Adding("Checking", deposit);

            SaveAccounts(accounts);
          }
          else if (add == "s")
          {
            Console.WriteLine("how much?");
            var deposit = double.Parse(Console.ReadLine());
            accountsManager.Adding("Saving", deposit);

            SaveAccounts(accounts);
          }
          SaveAccounts(accounts);
        }




        else if (input == "w")
        {
          Console.WriteLine("which account would you like to withdrawl from? (C)hecking or (S)aving");
          var withdrawl = Console.ReadLine().ToLower();
          if (withdrawl == "c")
          {
            Console.WriteLine("how much?");
            var withdrawlFunds = double.Parse(Console.ReadLine());
            accountsManager.Withdraw("Checking", withdrawlFunds);

            SaveAccounts(accounts);
          }
          else if (withdrawl == "s")
          {
            Console.WriteLine("how much?");
            var withdrawlFunds = double.Parse(Console.ReadLine());
            accountsManager.Withdraw("Saving", withdrawlFunds);

            SaveAccounts(accounts);
          }
          SaveAccounts(accounts);
        }



        //transfer
        else if (input == "t")
        {
          Console.WriteLine("which account would you like to transfer to? (C)hecking or (S)aving");
          var transfer = Console.ReadLine().ToLower();

          SaveAccounts(accounts);
        }


        //quit
        else if (input == "q")
        {
          isRunning = false;
        }

        SaveAccounts(accounts);

      }

    }
  }
}
