using System.Windows.Automation;

namespace UIElementsStub
{
    public interface IElement
    {
        string AutomationId { get; set; }
        IElement Parent { get; set; }
        AutomationElement Self { get; set; }
        string AutomationName { get; set; }
        TreeScope TreeScope { get; set; }
    }
}