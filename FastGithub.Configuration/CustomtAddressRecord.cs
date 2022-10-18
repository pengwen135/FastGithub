namespace FastGithub.Configuration
{
    /// <summary>
    /// 自定义解析记录。
    /// </summary>
    public class CustomtAddressRecord
    {
        /// <summary>
        /// 域名。
        /// </summary>
        public string Domain { get; set; } = string.Empty;

        /// <summary>
        /// IP地址。
        /// </summary>
        public string IPAddress { get; set; } = string.Empty;

    }
}
