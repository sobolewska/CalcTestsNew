using System;
using System.Windows.Automation;

namespace UIElementsStub
{
    public class Button : Pane
    {
        public Button(string automationId, IElement parent)
            : base(automationId, parent)
        {
        }

        public void Click()
        {
            object pattern;
            if (!Self.TryGetCurrentPattern(InvokePattern.Pattern, out pattern))
                throw new NotSupportedException("InvokePattern is not supported for this button");
            ((InvokePattern) pattern).Invoke();
        }
    }
}