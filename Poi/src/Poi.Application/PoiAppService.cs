using System;
using System.Collections.Generic;
using System.Text;
using Poi.Localization;
using Volo.Abp.Application.Services;

namespace Poi
{
    /* Inherit your application services from this class.
     */
    public abstract class PoiAppService : ApplicationService
    {
        protected PoiAppService()
        {
            LocalizationResource = typeof(PoiResource);
        }
    }
}
