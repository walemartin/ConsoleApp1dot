using ConsoleApp1dot;
using ConsoleApp1dot.Evnts;
using ConsoleApp1dot.Model;
using ConsoleApp1dot.StructData;
using ConsoleApp1dot.Utility;
using System.Runtime.CompilerServices;
using System.Security.Principal;


// Create bank account
BankAccount account = new BankAccount();

// Create subscribers
SmsService sms = new SmsService();
EmailService email = new EmailService();
AuditService audit = new AuditService();

// Subscribe to event
account.MoneyTransferred += sms.SendSms;
account.MoneyTransferred += email.SendEmail;
account.MoneyTransferred += audit.LogTransaction;

// Perform transaction
account.Transfer(500);

// Unsubscribe email service
account.MoneyTransferred -= email.SendEmail;

Console.WriteLine("\nSecond transaction:");

// Only SMS and Audit receive this event
account.Transfer(200);