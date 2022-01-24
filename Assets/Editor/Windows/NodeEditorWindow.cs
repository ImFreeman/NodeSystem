using UnityEditor;
using UnityEngine.UIElements;

namespace Editor.Windows
{
    public class NodeEditorWindow : EditorWindow
    {
        [MenuItem("Window/UI Toolkit/NodeSystem")]
        public static void ShowExample()
        {
            GetWindow<NodeEditorWindow>("NodeSystem");
        }

        private void OnEnable()
        {
            AddGraphView();
        }

        private void AddGraphView()
        {
            NodeGraphView nodeGraphView = new NodeGraphView();

            rootVisualElement.Add(nodeGraphView);
            nodeGraphView.StretchToParentSize();
        }
    }
}