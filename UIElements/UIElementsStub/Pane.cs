using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Automation;

namespace UIElementsStub
{
    public class Pane : IElement
    {
        public Pane(string automationId, IElement parent, string automationName = null)
        {
            AutomationId = automationId;
            Parent = parent;
            AutomationName = automationName;
            ElementsToWaitFor = new List<IElement> { this };
            TreeScope = TreeScope.Descendants;
        }

        public List<IElement> ElementsToWaitFor { get; set; }
        public string AutomationId { get; set; }
        public string AutomationName { get; set; }
        public IElement Parent { get; set; }
        public AutomationElement Self { get; set; }
        public TreeScope TreeScope { get; set; }

        public void WaitForExistance()
        {
            foreach (var element in ElementsToWaitFor)
            {
                var sw = Stopwatch.StartNew();
                while (element.Self == null && sw.Elapsed.TotalSeconds < 10)
                {
                    element.Self = element.Parent.Self.FindFirst(element.Parent.TreeScope,
                        element.AutomationName != null
                            ? new PropertyCondition(AutomationElement.NameProperty, element.AutomationName)
                            : new PropertyCondition(AutomationElement.AutomationIdProperty, element.AutomationId));
                    if (element.Self != null)
                        break;
                    Thread.Sleep(1000);
                }
                sw.Stop();
                if (element.Self == null)
                {
                    throw new ElementNotAvailableException(string.Format("Element not found, id: {0} name: {1}",
                        element.AutomationId, element.AutomationName));
                }
            }
        }

        public void WaitForEnabled()
        {
            foreach (var element in ElementsToWaitFor)
            {
                var sw = Stopwatch.StartNew();
                while (element.Self.Current.IsOffscreen && !element.Self.Current.IsEnabled &&
                       sw.Elapsed.TotalSeconds < 10)
                {
                    Thread.Sleep(1000);
                }
                sw.Stop();
                if (element.Self.Current.IsOffscreen || !element.Self.Current.IsEnabled)
                {
                    throw new ElementNotAvailableException(
                        string.Format("Element not visible or not enabled, id: {0} name: {1}", element.AutomationId,
                            element.AutomationName));
                }
            }
        }
    }
}