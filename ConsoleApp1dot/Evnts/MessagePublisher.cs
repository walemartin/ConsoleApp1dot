using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1dot.Evnts
{
    public sealed class MessagePublisher
    {
        public event EventHandler<string>? MessagePublished;

        public void Publish(string message) => MessagePublished?.Invoke(this, message);
    }
}
