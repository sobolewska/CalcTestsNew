using System.Windows.Automation;

namespace UIElementsStub
{
    public class Root : Pane
    {
        public Root() : base(null, null)
        {
            Self = AutomationElement.RootElement;
            TreeScope = TreeScope.Children;
        }
    }
}