using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "DialogScrObj", menuName = "DialogSystem/CreateDialogScrObj", order = 0)]
    public class DialogNodeScrObj : ScriptableObject
    {
        public List<DialogNodeDataForGraph> dialogNodes;
    }
}