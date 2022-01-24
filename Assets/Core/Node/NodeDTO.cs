using System;
using System.Collections.Generic;

namespace Core.Node
{
    [Serializable]
    public struct NodeDTO
    {
        public int ModelID;
        public List<ConnectionDTO> CurrentInputs;
        public List<ConnectionDTO> CurrentOutputs;

        public NodeDTO(int modelID, List<ConnectionDTO> currentInputs, List<ConnectionDTO> currentOutputs )
        {
            ModelID = modelID;
            CurrentInputs = currentInputs;
            CurrentOutputs = currentOutputs;
        }
    }
}
