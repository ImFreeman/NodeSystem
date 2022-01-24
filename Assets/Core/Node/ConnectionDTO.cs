using System;

namespace Core.Node
{
    [Serializable]
    public struct ConnectionDTO
    {
        public int ModelID;
        public int FromNodeModelID;
        public int FromNodePortID;
        public int ToNodeModelID;
        public int ToNodePortID;
        public object Data;

        public ConnectionDTO(int modelID, int fromNodeModelID, int toNodeModelID, int fromNodePortID, int toNodePortID, object data )
        {
            Data = data;
            ModelID = modelID;
            FromNodeModelID = fromNodeModelID;
            ToNodeModelID = toNodeModelID;
            FromNodePortID = fromNodePortID;
            ToNodePortID = toNodePortID;
        }
    }
}
