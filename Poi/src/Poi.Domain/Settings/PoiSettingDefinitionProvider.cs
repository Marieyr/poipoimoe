using Volo.Abp.Settings;

namespace Poi.Settings
{
    public class PoiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PoiSettings.MySetting1));
        }
    }
}
