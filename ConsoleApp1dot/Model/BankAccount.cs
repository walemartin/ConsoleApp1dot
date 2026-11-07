        using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1dot.Model
{
    public class BankAccount
    {
        // Event declaration
        public event EventHandler<string>? MoneyTransferred;

        // Transfer money
        public void Transfer(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid transfer amount.");
                return;
            }

            Console.WriteLine($"\nTransferring ${amount}...");

            // Raise event
            MoneyTransferred?.Invoke(
                this,
                $"Successfully transferred ${amount}");
        }
    }

    // Subscriber 1: SMS Notification
    public class SmsService
    {
        public void SendSms(object? sender, string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }

    // Subscriber 2: Email Notification
    public class EmailService
    {
        public void SendEmail(object? sender, string message)
        {
            Console.WriteLine($"[EMAIL] {message}");
        }
    }

    // Subscriber 3: Audit Logging
    public class AuditService
    {
        public void LogTransaction(object? sender, string message)
        {
            Console.WriteLine($"[AUDIT LOG] {message}");
        }
    }
}
