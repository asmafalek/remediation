using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remediation
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
        new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => lazy.Value;

        private Singleton() { }

        public string CreateMessage() => "Message";
    }
}
