using Abp.Domain.Services;

namespace MyCompanyName.AbpZeroTemplate
{
    /*
     * 领域服务没有状态只有行为 所有的状态还是都保存在相应的领域对象中
     */

    /// <summary>
    /// 添加您的所有域服务的常见成员
    /// </summary>
    public abstract class AbpZeroTemplateDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected AbpZeroTemplateDomainServiceBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}
