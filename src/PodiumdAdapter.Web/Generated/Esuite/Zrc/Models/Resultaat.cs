// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Generated.Esuite.ZrcClient.Models {
    public class Resultaat : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>URI van een resultaattype.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resultaattype { get; set; }
#nullable restore
#else
        public string Resultaattype { get; set; }
#endif
        /// <summary>Toelichting op zetten van resultaat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Toelichting { get; set; }
#nullable restore
#else
        public string Toelichting { get; set; }
#endif
        /// <summary>URL-referentie naar dit object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>Unieke resource identifier (UUID4)</summary>
        public Guid? Uuid { get; private set; }
        /// <summary>URI van een zaak.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zaak { get; set; }
#nullable restore
#else
        public string Zaak { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Resultaat and sets the default values.
        /// </summary>
        public Resultaat() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Resultaat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Resultaat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"resultaattype", n => { Resultaattype = n.GetStringValue(); } },
                {"toelichting", n => { Toelichting = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"uuid", n => { Uuid = n.GetGuidValue(); } },
                {"zaak", n => { Zaak = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("resultaattype", Resultaattype);
            writer.WriteStringValue("toelichting", Toelichting);
            writer.WriteStringValue("zaak", Zaak);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
