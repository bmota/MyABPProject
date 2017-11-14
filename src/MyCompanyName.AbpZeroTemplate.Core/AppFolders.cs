using Abp.Dependency;

namespace MyCompanyName.AbpZeroTemplate
{
    public class AppFolders : IAppFolders, ISingletonDependency
    {
        /// <summary>
        /// 临时文件下载文件夹
        /// </summary>
        public string TempFileDownloadFolder { get; set; }

        /// <summary>
        /// 示例图片文件夹
        /// </summary>
        public string SampleProfileImagesFolder { get; set; }

        /// <summary>
        /// Web日志文件夹
        /// </summary>
        public string WebLogsFolder { get; set; }
    }
}