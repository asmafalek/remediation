using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remediation
{
    public class Singleton
    {
        private static Singleton instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();



        private Singleton() {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        internal static Singleton GetInstance()
        {
            throw new NotImplementedException();
        }

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
