using PlaywrightFramework.Config;
using PlaywrightFramework.Pages.Components;

namespace PlaywrightFramework.Pages;

public class HomePage
{
    private readonly IPage _page;
    internal readonly HeaderComponent _headerComponent;

    public HomePage(IPage page)
    {
        _page = page;
        _headerComponent = new HeaderComponent(page);
    }

    public async Task GotoAsync()
    {
        await _page.GotoAsync(ConfigManager.BaseUrl + ConfigManager.PagePaths.HomePage);
    }
}
