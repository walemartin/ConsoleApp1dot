using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1dot
{
    class ConnectionOptions
    {
        public string Host { get; init; } = "localhost";
        public int Port { get; init; } = 80;
        public bool UseSsl { get; init; }
    }
}
