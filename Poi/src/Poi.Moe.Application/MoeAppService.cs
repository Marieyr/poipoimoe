using System;
using System.Collections.Generic;
using System.Text;
using Poi.Moe.Localization;
using Volo.Abp.Application.Services;

namespace Poi.Moe
{
    /* Inherit your application services from this class.
     */
    public abstract class MoeAppService : ApplicationService
    {
        protected MoeAppService()
        {
            LocalizationResource = typeof(MoeResource);
        }
    }
}
