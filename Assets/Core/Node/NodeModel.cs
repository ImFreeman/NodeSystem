using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Node
{
    [Serializable]
    public class NodeModel
    {
        public int ID;
        public string Name;
        public int[] InputPortsID;
        public int[] OutPortsID;
        public List<ConnectionModel> Inputs;
        public List<ConnectionModel> Outputs;

        public NodeModel Get(string path)
        {
            //return JsonUtility.FromJson<NodeModel>();
        }
    }
}
