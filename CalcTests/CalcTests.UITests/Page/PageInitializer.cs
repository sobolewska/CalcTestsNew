using TechTalk.SpecFlow;

namespace CalcTests.UITests.Page
{
    public static class PageInitializer
    {
        public static IPage GetOrCreate(this IPage page, ScenarioContext context)
        {
            if (context.ContainsKey(page.Id))
                return context.Get<IPage>(page.Id);
            page.Init();
            context.Add(page.Id, page);
            return page;
        }

        public static IPage GetOrCreate(this IPage page)
        {
            return page.GetOrCreate(ScenarioContext.Current);
        }
    }
}