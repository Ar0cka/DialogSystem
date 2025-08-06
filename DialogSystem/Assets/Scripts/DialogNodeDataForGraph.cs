using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    [Serializable]
    public class DialogNodeDataForGraph
    {
        public string guid;
        public string dialogText;
        public State state = State.Default;
        public Vector2 position;
        [FormerlySerializedAs("dialogNodes")] public List<string> dialogNodesChild;
    }

    public enum State
    {
        Default,
        Friendly
    }
}