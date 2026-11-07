using ConsoleApp1dot;
using ConsoleApp1dot.Evnts;
using ConsoleApp1dot.Model;
using ConsoleApp1dot.StructData;
using ConsoleApp1dot.Utility;
using System.Runtime.CompilerServices;
using System.Security.Principal;


Func<decimal, decimal> transactionFee =
    amount => amount * 0.02m;

decimal amount = 1000m;

decimal fee = transactionFee(amount);

Console.WriteLine($"Transaction fee: {fee}");