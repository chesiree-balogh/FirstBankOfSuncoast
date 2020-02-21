using System;
using System.Collections.Generic;

namespace FirstBankOfSuncoast
{
  public class AccountsManager
  {
    public List<Account> accounts { get; set; } = new List<Account>();

    public static void DisplayAccounts(List<Account> accounts)
    {
      foreach (var account in accounts)
      {
        Console.WriteLine($"You have {account.Amount} in you {account.AccountType} account");
      }
    }

    //deposit "add" funds
    public static void Adding(string AccountType, int Amount)
    {
      //var add = Accounts
    }






    //withdraw

    //transfer

    //transation history
    // public string GetAccountHistory()
    // {
    //     var report = new System.Text.StringBuilder();

    //     decimal balance = 0;
    //     report.AppendLine("Date\t\tAmount\tBalance\tNote");
    //     foreach (var item in allTransactions)
    //     {
    //         balance += item.Amount;
    //         report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
    //     }

    //     return report.ToString();
    // }
    //Console.WriteLine(account.GetAccountHistory());



  }
}



