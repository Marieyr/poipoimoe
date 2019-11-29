using Poi.Moe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Poi.Moe.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MoeController : AbpController
    {
        protected MoeController()
        {
            LocalizationResource = typeof(MoeResource);
        }
    }
}