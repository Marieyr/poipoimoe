using Volo.Abp.Settings;

namespace Poi.Moe.Settings
{
    public class MoeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MoeSettings.MySetting1));
        }
    }
}
