using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace MyCompanyName.AbpZeroTemplate.Authorization.Users
{
    /// <summary>
    /// 用户策略
    /// </summary>
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
