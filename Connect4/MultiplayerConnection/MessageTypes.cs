using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.MessageTypes
{
    #region super class definition
    abstract class MessageShell {
        public string type { get { return this.GetType().Name; } }
        public string agent = "NStride C4 v1";

        public struct DataStructure { };
        public DataStructure data;
    }

    abstract class AuthenticatedMessageShell : MessageShell
    {
        public string jwt;

        public AuthenticatedMessageShell (string jwt) {
            this.jwt = jwt;
        }
    }
    #endregion

    class Registration : MessageShell
    {
        public new struct DataStructure {
            public string username;
        };
        public new DataStructure data;

        public Registration(string username) {
            this.data.username = username;
        }
    }

    class MatchRequest : AuthenticatedMessageShell
    {
        public new struct DataStructure {};
        public new DataStructure data;

        public MatchRequest(string jwt) : base(jwt) { }
    }

    class ChatMessage : AuthenticatedMessageShell
    {
        public new struct DataStructure {
            public string message;
        };
        public new DataStructure data;

        public ChatMessage(string jwt, string chat) : base(jwt) {
            this.data.message = chat;
        }
    }

    class PlayPosition : AuthenticatedMessageShell
    {
        public new struct DataStructure
        {
            public int column;
        };
        public new DataStructure data;

        public PlayPosition(string jwt, int column) : base(jwt)
        {
            this.data.column = column;
        }
    }
}
