using DefaultNamespace;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.TreeView
{
    public class DialogNodeView : Node
    {
        public string guid;
        public DialogNodeDataForGraph dialogNodeData;
        
        public Port InputPort { get; private set; }
        public Port OutputPort { get; private set; }

        public DialogNodeView(DialogNodeDataForGraph dialogNodeData)
        {
            this.dialogNodeData = dialogNodeData;
            guid = dialogNodeData.guid;
            
            BuildNodeUI(dialogNodeData);
            
            SetPosition(new Rect(dialogNodeData.position, new Vector2(200, 150)));
            
            InputPort = CreatePort(Orientation.Horizontal, Direction.Input);
            InputPort.portName = "Add parent";
            inputContainer.Add(InputPort);
            Debug.Log("InputPort created: " + InputPort);

            OutputPort  = CreatePort(Orientation.Horizontal, Direction.Output);
            OutputPort.portName = "Add child";
            outputContainer.Add(OutputPort);
            Debug.Log("OutputPort created: " + OutputPort);
            
            RefreshExpandedState();
            RefreshPorts();
        }

        private void BuildNodeUI(DialogNodeDataForGraph data)
        {
            var text = new TextField("Dialog text")
            {
                value = data?.dialogText ?? "",
            };
            text.RegisterValueChangedCallback(etv =>
            {
                data.dialogText = etv.newValue;
            });
            mainContainer.Add(text);

            var state = new EnumField("Special Panel", data?.state)
            {
                value = data?.state,
            };
            state.RegisterValueChangedCallback(etv =>
            {
                data.state = (State)etv.newValue;
            });
            mainContainer.Add(state);
        }

        private Port CreatePort(Orientation orientation, Direction direction)
        {
            return InstantiatePort(orientation, direction, Port.Capacity.Multi, typeof(object));
        }
        
        public DialogNodeDataForGraph GetData()
        {
            dialogNodeData.position = GetPosition().position;
            return dialogNodeData;
        }
    }
}