using System.Linq;
using TechTalk.SpecFlow;

namespace CalcTests.UITests.Page
{
    public static class PageInitializer
    {
        public static T GetOrCreate<T>(this ScenarioContext context) where T : new()
        {
            var existingPage = (T) ScenarioContext.Current.Values.FirstOrDefault(value => value.GetType() == typeof (T));
            if (existingPage != null) return existingPage;
            var page = new T();
            ScenarioContext.Current.Add(((IPage)page).Id, page);
            return page;
        }
    }
}