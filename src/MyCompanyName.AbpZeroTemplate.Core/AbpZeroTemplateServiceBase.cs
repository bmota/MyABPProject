using Abp;

namespace MyCompanyName.AbpZeroTemplate
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// 该类可以用作此应用程序中的服务的基类。
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// 它有一些有用的对象属性注入，并且具有大多数服务可能需要的一些基本方法。
    /// It's suitable for non domain nor application service classes.它适用于非域或应用程序服务类。
    /// For domain services inherit 对于域服务继承 <see cref="AbpZeroTemplateDomainServiceBase"/>.
    /// For application services inherit 对于应用程序服务继承 AbpZeroTemplateAppServiceBase.
    /// </summary>
    public abstract class AbpZeroTemplateServiceBase : AbpServiceBase
    {
        protected AbpZeroTemplateServiceBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}