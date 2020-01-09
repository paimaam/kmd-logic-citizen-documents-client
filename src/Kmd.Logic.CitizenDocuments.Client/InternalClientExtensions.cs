// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.CitizenDocuments.Client
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InternalClient.
    /// </summary>
    internal static partial class InternalClientExtensions
    {
            /// <summary>
            /// Gets the citizen document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static object GetDocument(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GetDocumentAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the citizen document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetDocumentAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDocumentWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads the data for Citizen Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static CitizenDocumentFileAccessPageData GetFileAccessPageData(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GetFileAccessPageDataAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads the data for Citizen Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CitizenDocumentFileAccessPageData> GetFileAccessPageDataAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFileAccessPageDataWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Uploads the single citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// </param>
            /// <param name='cpr'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='documentType'>
            /// Possible values include: 'citizenDocument', 'digitalPostCoverLetter',
            /// 'snailMailCoverLetter'
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            public static object UploadAttachment(this IInternalClient operations, System.Guid subscriptionId, string configurationId = default(string), string cpr = default(string), int? retentionPeriodInDays = default(int?), string documentType = default(string), Stream document = default(Stream), string documentName = default(string))
            {
                return operations.UploadAttachmentAsync(subscriptionId, configurationId, cpr, retentionPeriodInDays, documentType, document, documentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads the single citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// </param>
            /// <param name='cpr'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='documentType'>
            /// Possible values include: 'citizenDocument', 'digitalPostCoverLetter',
            /// 'snailMailCoverLetter'
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UploadAttachmentAsync(this IInternalClient operations, System.Guid subscriptionId, string configurationId = default(string), string cpr = default(string), int? retentionPeriodInDays = default(int?), string documentType = default(string), Stream document = default(Stream), string documentName = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadAttachmentWithHttpMessagesAsync(subscriptionId, configurationId, cpr, retentionPeriodInDays, documentType, document, documentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create provider config to send citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object SaveConfig(this IInternalClient operations, System.Guid subscriptionId, CitizenDocumentProviderConfigRequest request)
            {
                return operations.SaveConfigAsync(subscriptionId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create provider config to send citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SaveConfigAsync(this IInternalClient operations, System.Guid subscriptionId, CitizenDocumentProviderConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveConfigWithHttpMessagesAsync(subscriptionId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads the provider config.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            public static CitizenDocumentConfigResponse LoadProviderConfiguration(this IInternalClient operations, System.Guid subscriptionId)
            {
                return operations.LoadProviderConfigurationAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads the provider config.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CitizenDocumentConfigResponse> LoadProviderConfigurationAsync(this IInternalClient operations, System.Guid subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LoadProviderConfigurationWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends the documents to citizens
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='sendCitizenDocumentRequest'>
            /// </param>
            public static SendCitizenDocumentResponse SendDocument(this IInternalClient operations, System.Guid subscriptionId, SendCitizenDocumentRequest sendCitizenDocumentRequest)
            {
                return operations.SendDocumentAsync(subscriptionId, sendCitizenDocumentRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends the documents to citizens
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='sendCitizenDocumentRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SendCitizenDocumentResponse> SendDocumentAsync(this IInternalClient operations, System.Guid subscriptionId, SendCitizenDocumentRequest sendCitizenDocumentRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SendDocumentWithHttpMessagesAsync(subscriptionId, sendCitizenDocumentRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edit citizen document configuration settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// configuration Id
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object EditConfig(this IInternalClient operations, System.Guid subscriptionId, System.Guid configurationId, CitizenDocumentProviderConfigRequest request)
            {
                return operations.EditConfigAsync(subscriptionId, configurationId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edit citizen document configuration settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// configuration Id
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> EditConfigAsync(this IInternalClient operations, System.Guid subscriptionId, System.Guid configurationId, CitizenDocumentProviderConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EditConfigWithHttpMessagesAsync(subscriptionId, configurationId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
