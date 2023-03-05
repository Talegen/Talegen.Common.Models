namespace Talegen.Common.Models.Server
{
    /// <summary>
    /// This class represents the basic tenant information needed for the web application.
    /// </summary>
    public class TenantDetailModel<TKey, TSubscription, TLanguageCode>
        where TKey : notnull
        where TSubscription : notnull
        where TLanguageCode : notnull
    {
        /// <summary>
        /// Gets or sets the domain key.
        /// </summary>
        public TKey DomainKey { get; set; } = default(TKey)!;

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the subscription type.
        /// </summary>
        public TSubscription Subscription { get; set; } = default(TSubscription)!;

        /// <summary>
        /// Gets or sets the support information about the Tenant.
        /// </summary>
        public string SupportInfo { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the support contact e-mail address for the Tenant.
        /// </summary>
        public string SupportEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the default language to use for the tenant application.
        /// </summary>
        public TLanguageCode DefaultLanguage { get; set; } = default(TLanguageCode)!;

        /// <summary>
        /// Gets or sets the server's session timeout in minutes.
        /// </summary>
        public int SessionTimeout { get; set; }
    }
}