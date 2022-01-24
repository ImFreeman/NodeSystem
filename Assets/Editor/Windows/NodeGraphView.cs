using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace Editor.Windows
{
    public class NodeGraphView : GraphView
    {
        public NodeGraphView()
        {
            AddGridBackground();
            AddStyles();

            AddManipulators();
        }

        private void AddManipulators()
        {
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
            this.AddManipulator(new ContentDragger());
        }

        private void AddGridBackground()
        {
            GridBackground gridBackground = new GridBackground();
            gridBackground.StretchToParentSize();
            Insert(0, gridBackground);
        }

        private void AddStyles()
        {
            this.AddStyleSheets("DSGraphViewStyles.uss");
        }
    }
}
