using Poi.Moe.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Poi.Moe.Permissions
{
    public class MoePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MoePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MoePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MoeResource>(name);
        }
    }
}
