// <auto-generated/>
using Generated.Esuite.ZtcClient.Informatieobjecttypen.Item;
using Generated.Esuite.ZtcClient.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Generated.Esuite.ZtcClient.Informatieobjecttypen {
    /// <summary>
    /// Builds and executes requests for operations under \informatieobjecttypen
    /// </summary>
    public class InformatieobjecttypenRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Generated.Esuite.ZtcClient.informatieobjecttypen.item collection</summary>
        /// <param name="position">Unieke resource identifier (UUID4)</param>
        public WithUuItemRequestBuilder this[Guid position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("uuid", position);
            return new WithUuItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Generated.Esuite.ZtcClient.informatieobjecttypen.item collection</summary>
        /// <param name="position">Unieke resource identifier (UUID4)</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithUuItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("uuid", position);
            return new WithUuItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new InformatieobjecttypenRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InformatieobjecttypenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/informatieobjecttypen{?omschrijving*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new InformatieobjecttypenRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InformatieobjecttypenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/informatieobjecttypen{?omschrijving*}", rawUrl) {
        }
        /// <summary>
        /// Deze lijst moet gefilterd wordt met query-string parameters.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<InformatieobjecttypeResults?> GetAsync(Action<RequestConfiguration<InformatieobjecttypenRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<InformatieobjecttypeResults> GetAsync(Action<RequestConfiguration<InformatieobjecttypenRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ValidatieFout.CreateFromDiscriminatorValue},
                {"401", Fout.CreateFromDiscriminatorValue},
                {"403", Fout.CreateFromDiscriminatorValue},
                {"404", Fout.CreateFromDiscriminatorValue},
                {"500", Fout.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<InformatieobjecttypeResults>(requestInfo, InformatieobjecttypeResults.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deze lijst moet gefilterd wordt met query-string parameters.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InformatieobjecttypenRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<InformatieobjecttypenRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public InformatieobjecttypenRequestBuilder WithUrl(string rawUrl) {
            return new InformatieobjecttypenRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deze lijst moet gefilterd wordt met query-string parameters.
        /// </summary>
        public class InformatieobjecttypenRequestBuilderGetQueryParameters {
            /// <summary>Naam van het documenttype.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("omschrijving")]
            public string? Omschrijving { get; set; }
#nullable restore
#else
            [QueryParameter("omschrijving")]
            public string Omschrijving { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class InformatieobjecttypenRequestBuilderGetRequestConfiguration : RequestConfiguration<InformatieobjecttypenRequestBuilderGetQueryParameters> {
        }
    }
}
