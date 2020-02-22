using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast
{
  public class AccountsManager
  {
    public List<Account> accounts { get; set; } = new List<Account>();

    public void LoadAccounts()
    {
      var reader = new StreamReader("accounts.csv");
      var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
      accounts = csvReader.GetRecords<Account>().ToList();
    }


    public void SaveAccounts()
    {
      var writer = new StreamWriter("accounts.csv");
      var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
      csvWriter.WriteRecords(accounts);
      writer.Flush();
    }


    public void DisplayAccounts()
    {
      foreach (var account in accounts)
      {
        Console.WriteLine($"You have {account.Amount} in you {account.AccountType} account");
      }
    }

    //deposit "add" funds
    public void Adding(string AccountType, double Amount)
    {
      var account = accounts.First(accounts => accounts.AccountType == AccountType).Amount;
      account += Amount;
      accounts.First(account => account.AccountType == AccountType).Amount = account;
    }

    //withdraw
    public void Withdraw(string AccountType, double Amount)
    {
      var account = accounts.First(accounts => accounts.AccountType == AccountType).Amount;
      account -= Amount;
      accounts.First(account => account.AccountType == AccountType).Amount = account;
    }
  }
}







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








