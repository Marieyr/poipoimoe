using Poi.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Poi.Blog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlogController : AbpController
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}