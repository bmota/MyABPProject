using Abp;

namespace MyCompanyName.AbpZeroTemplate
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// �������������Ӧ�ó����еķ���Ļ��ࡣ
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// ����һЩ���õĶ�������ע�룬���Ҿ��д�������������Ҫ��һЩ����������
    /// It's suitable for non domain nor application service classes.�������ڷ����Ӧ�ó�������ࡣ
    /// For domain services inherit ���������̳� <see cref="AbpZeroTemplateDomainServiceBase"/>.
    /// For application services inherit ����Ӧ�ó������̳� AbpZeroTemplateAppServiceBase.
    /// </summary>
    public abstract class AbpZeroTemplateServiceBase : AbpServiceBase
    {
        protected AbpZeroTemplateServiceBase()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}