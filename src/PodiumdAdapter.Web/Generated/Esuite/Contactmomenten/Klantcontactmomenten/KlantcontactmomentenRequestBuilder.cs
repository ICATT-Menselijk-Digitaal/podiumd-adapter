// <auto-generated/>
using Generated.Esuite.ContactmomentenClient.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Generated.Esuite.ContactmomentenClient.Klantcontactmomenten {
    /// <summary>
    /// Builds and executes requests for operations under \klantcontactmomenten
    /// </summary>
    public class KlantcontactmomentenRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new KlantcontactmomentenRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KlantcontactmomentenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/klantcontactmomenten{?klant*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new KlantcontactmomentenRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KlantcontactmomentenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/klantcontactmomenten{?klant*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lopende contact(moment)en van een Klant (persoon in e-Suite) opvragen.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KlantcontactmomentResults?> GetAsync(Action<RequestConfiguration<KlantcontactmomentenRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<KlantcontactmomentResults> GetAsync(Action<RequestConfiguration<KlantcontactmomentenRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ValidatieFout.CreateFromDiscriminatorValue},
                {"401", Fout.CreateFromDiscriminatorValue},
                {"403", Fout.CreateFromDiscriminatorValue},
                {"500", Fout.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<KlantcontactmomentResults>(requestInfo, KlantcontactmomentResults.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Koppelen van een Contact(moment) aan een Klant (persoon in e-Suite).
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Klantcontactmoment?> PostAsync(Klantcontactmoment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Klantcontactmoment> PostAsync(Klantcontactmoment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ValidatieFout.CreateFromDiscriminatorValue},
                {"401", Fout.CreateFromDiscriminatorValue},
                {"403", Fout.CreateFromDiscriminatorValue},
                {"500", Fout.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Klantcontactmoment>(requestInfo, Klantcontactmoment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lopende contact(moment)en van een Klant (persoon in e-Suite) opvragen.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KlantcontactmomentenRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KlantcontactmomentenRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Koppelen van een Contact(moment) aan een Klant (persoon in e-Suite).
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Klantcontactmoment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Klantcontactmoment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KlantcontactmomentenRequestBuilder WithUrl(string rawUrl) {
            return new KlantcontactmomentenRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lopende contact(moment)en van een Klant (persoon in e-Suite) opvragen.
        /// </summary>
        public class KlantcontactmomentenRequestBuilderGetQueryParameters {
            /// <summary>URL-referentie naar de KLANT</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("klant")]
            public string? Klant { get; set; }
#nullable restore
#else
            [QueryParameter("klant")]
            public string Klant { get; set; }
#endif
            /// <summary>Een pagina binnen de gepagineerde set resultaten.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page")]
            public string? Page { get; set; }
#nullable restore
#else
            [QueryParameter("page")]
            public string Page { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class KlantcontactmomentenRequestBuilderGetRequestConfiguration : RequestConfiguration<KlantcontactmomentenRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class KlantcontactmomentenRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
