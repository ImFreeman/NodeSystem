using System;

namespace Core.Node
{
    [Serializable]
    public class ConnectionModel
    {
        public int ID;
        public int FromNodeModelID;
        public int FromNodePortID;
        public int ToNodeModelID;
        public int ToNodePortID;
        public object Data;
    }
}
