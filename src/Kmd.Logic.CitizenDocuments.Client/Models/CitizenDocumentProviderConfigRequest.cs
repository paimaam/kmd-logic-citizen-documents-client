// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.CitizenDocuments.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CitizenDocumentProviderConfigRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CitizenDocumentProviderConfigRequest class.
        /// </summary>
        public CitizenDocumentProviderConfigRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CitizenDocumentProviderConfigRequest class.
        /// </summary>
        public CitizenDocumentProviderConfigRequest(string configName = default(string), System.Guid? digitalPostConfigurationId = default(System.Guid?), string systemName = default(string), string appTitle = default(string), string pageHeader = default(string), string footer = default(string))
        {
            ConfigName = configName;
            DigitalPostConfigurationId = digitalPostConfigurationId;
            SystemName = systemName;
            AppTitle = appTitle;
            PageHeader = pageHeader;
            Footer = footer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configName")]
        public string ConfigName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "digitalPostConfigurationId")]
        public System.Guid? DigitalPostConfigurationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemName")]
        public string SystemName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appTitle")]
        public string AppTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageHeader")]
        public string PageHeader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "footer")]
        public string Footer { get; set; }

    }
}
