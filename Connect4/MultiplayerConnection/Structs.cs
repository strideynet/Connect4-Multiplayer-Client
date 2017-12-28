using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.MessageTypes
{
    class MessageShell {
        public string type;
        public string agent = "NStride C4 v1";

        public MessageContents data;

        public MessageShell(MessageContents messageContents)
        {
            type = messageContents.GetType().Name;
            data = messageContents;
        }
    }

    class AuthenticatedMessageShell : MessageShell
    {
        public string jwt;

        public AuthenticatedMessageShell(MessageContents messageContents, string jwt) : base (messageContents)
        {
            this.jwt = jwt;
        }
    }

    class MessageContents { } // Base class for all message types

    class Registration : MessageContents
    {
        public string username;

        public Registration(string username)
        {
            this.username = username;
        }
    }

    class PlayMove : MessageContents
    {
        public int x;
        public int y;
    }

}
