using System;
using System.Windows.Automation;

namespace UIElementsStub
{
    public class Text : Pane
    {
        public Text(string automationId, IElement parent) : base(automationId, parent)
        {
        }

        public string GetText()
        {
            object pattern;
            if (Self.TryGetCurrentPattern(ValuePattern.Pattern, out pattern))
            {
                return ((ValuePattern) pattern).Current.Value;
            }
            if (!string.IsNullOrWhiteSpace(Self.Current.Name))
            {
                return Self.Current.Name;
            }
            throw new NotSupportedException("ValuePattern is not supported for this button and name was empty");
        }
    }
}