using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightFramework.Pages.Components
{
    public class HeaderComponent
    {
        private readonly IPage _page;
        public readonly ILocator Title;
        public readonly ILocator HomeLink;
        public readonly ILocator PortfolioLink;
        public readonly ILocator PostsLink;
        public readonly ILocator StoriesLink;
        public readonly ILocator AboutMeLink;

        public HeaderComponent(IPage page)
        {
            _page = page;
            Title = _page.Locator("article > h1");
            HomeLink = _page.Locator("a[href=\"/\"]");
            PortfolioLink = _page.Locator("a[href=\"/Portfolio\"]");
            PostsLink = _page.Locator("a[href=\"/posts\"]");
            StoriesLink = _page.Locator("a[href=\"/stories\"]");
            AboutMeLink = _page.Locator("a[href=\"/AboutMe\"]");
        }

        public async Task ClickHomeLink()
        {
            await HomeLink.ClickAsync();
        }

        public async Task ClickPortfolioLink()
        {
            await PortfolioLink.ClickAsync();
        }

        public async Task ClickPostsLink()
        {
            await PostsLink.ClickAsync();
        }

        public async Task ClickStoriesLink()
        {
            await StoriesLink.ClickAsync();
        }

        public async Task ClickAboutMeLink()
        {
            await AboutMeLink.ClickAsync();
        }
    }
}
