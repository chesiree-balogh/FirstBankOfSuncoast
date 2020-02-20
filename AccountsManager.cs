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
  }



}