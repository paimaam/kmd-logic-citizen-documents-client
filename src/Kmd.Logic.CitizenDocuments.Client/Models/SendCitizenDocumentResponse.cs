// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.CitizenDocuments.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendCitizenDocumentResponse
    {
        /// <summary>
        /// Initializes a new instance of the SendCitizenDocumentResponse
        /// class.
        /// </summary>
        public SendCitizenDocumentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendCitizenDocumentResponse
        /// class.
        /// </summary>
        public SendCitizenDocumentResponse(string messageId = default(string))
        {
            MessageId = messageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

    }
}
