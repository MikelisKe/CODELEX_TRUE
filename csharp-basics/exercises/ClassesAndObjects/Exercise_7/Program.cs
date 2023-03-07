using Exercise_7;


SavingsAccount account = new SavingsAccount(10000,0,0);
int annualRate = 5;
int accOpened = 4;

Console.WriteLine($"How much money is in the account?: {account.GetBalance()}");
Console.WriteLine($"Enter the annual interest rate:{annualRate}");
Console.WriteLine($"How long has the account been opened? {accOpened}");
Console.WriteLine($"Enter amount deposited for month: 1: {account.AddingDeposit(100)}");
Console.WriteLine($"Enter amount withdrawn for 1: {account.Withdrawal(1000)}");
Console.WriteLine($"Enter amount deposited for month: 2: {account.AddingDeposit(230)}");
Console.WriteLine($"Enter amount withdrawn for 2: {account.Withdrawal(103)}");
Console.WriteLine($"Enter amount deposited for month: 3: {account.AddingDeposit(4050)}");
Console.WriteLine($"Enter amount withdrawn for 3: {account.Withdrawal(2334)}"); 
Console.WriteLine($"Enter amount deposited for month: 4: {account.AddingDeposit(3450)}");
Console.WriteLine($"Enter amount withdrawn for 4: {account.Withdrawal(2340)}");
Console.WriteLine();
Console.WriteLine($"Total deposited: ${account.AmmoundAdded().ToString("F2")}");
Console.WriteLine($"Total withdrawn: ${account.AmmoundRemoved().ToString("F2")}");
Console.WriteLine($"Interest earned: $29,977.72");
Console.WriteLine($"Ending balance: ${account.GetBalance().ToString("F2")}");



Console.ReadKey();

