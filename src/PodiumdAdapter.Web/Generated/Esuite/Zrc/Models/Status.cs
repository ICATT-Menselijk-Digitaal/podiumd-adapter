// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Generated.Esuite.ZrcClient.Models {
    public class Status : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Tijdstip waarop de zaak de status heeft verkregen.</summary>
        public DateTimeOffset? DatumStatusGezet { get; private set; }
        /// <summary>Toelichting bij wijziging zaak status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Statustoelichting { get; set; }
#nullable restore
#else
        public string Statustoelichting { get; set; }
#endif
        /// <summary>URI van een statustype. Binnen de e-Suite is dat een zaak status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Statustype { get; set; }
#nullable restore
#else
        public string Statustype { get; set; }
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
        /// Instantiates a new Status and sets the default values.
        /// </summary>
        public Status() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Status CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Status();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"datumStatusGezet", n => { DatumStatusGezet = n.GetDateTimeOffsetValue(); } },
                {"statustoelichting", n => { Statustoelichting = n.GetStringValue(); } },
                {"statustype", n => { Statustype = n.GetStringValue(); } },
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
            writer.WriteStringValue("statustoelichting", Statustoelichting);
            writer.WriteStringValue("statustype", Statustype);
            writer.WriteStringValue("zaak", Zaak);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
