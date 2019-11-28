using Poi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Poi.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PoiController : AbpController
    {
        protected PoiController()
        {
            LocalizationResource = typeof(PoiResource);
        }
    }
}