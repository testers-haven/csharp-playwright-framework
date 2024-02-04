using PlaywrightFramework.Pages;
using System.Text.RegularExpressions;

namespace PlaywrightFramework;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HeaderHasAllElements()
    {
        var homePage = new HomePage(Page);

        await homePage.GotoAsync();

        await Expect(homePage._headerComponent.AboutMeLink).ToBeVisibleAsync();
        await Expect(homePage._headerComponent.PortfolioLink).ToBeVisibleAsync();
        await Expect(homePage._headerComponent.PostsLink).ToBeVisibleAsync();
        await Expect(homePage._headerComponent.StoriesLink).ToBeVisibleAsync();
        await Expect(homePage._headerComponent.Title).ToBeVisibleAsync();
    }
}