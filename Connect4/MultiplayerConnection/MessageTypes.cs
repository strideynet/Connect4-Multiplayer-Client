using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.MessageTypes
{
    class _MessageShell {
        public string type { get { return this.GetType().Name; } }
        public string agent = "NStride C4 v1";

        public struct dataStructure {};

        public dataStructure data;
    }

    class _AuthenticatedMessageShell : _MessageShell
    {
        public string jwt;

        public _AuthenticatedMessageShell (string jwt) {
            this.jwt = jwt;
        }
    }

    class Registration : _MessageShell
    {
        public new struct dataStructure {
            public string username;
        }

        public new dataStructure data;

        public Registration(string username) {
            this.data.username = username;
        }
    }
}
