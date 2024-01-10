// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Generated.Esuite.ZrcClient.Models {
    public class ZaakInformatieobject : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Beschrijving van het document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Beschrijving { get; set; }
#nullable restore
#else
        public string Beschrijving { get; set; }
#endif
        /// <summary>URL-referentie naar het informatieobject</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Informatieobject { get; set; }
#nullable restore
#else
        public string Informatieobject { get; set; }
#endif
        /// <summary>Creatiedatum van de laatste versie van het document in e-Suite</summary>
        public DateTimeOffset? Registratiedatum { get; private set; }
        /// <summary>Titel van het document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Titel { get; set; }
#nullable restore
#else
        public string Titel { get; set; }
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
        /// <summary>URL-referentie naar een zaak</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zaak { get; set; }
#nullable restore
#else
        public string Zaak { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ZaakInformatieobject and sets the default values.
        /// </summary>
        public ZaakInformatieobject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ZaakInformatieobject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZaakInformatieobject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"beschrijving", n => { Beschrijving = n.GetStringValue(); } },
                {"informatieobject", n => { Informatieobject = n.GetStringValue(); } },
                {"registratiedatum", n => { Registratiedatum = n.GetDateTimeOffsetValue(); } },
                {"titel", n => { Titel = n.GetStringValue(); } },
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
            writer.WriteStringValue("beschrijving", Beschrijving);
            writer.WriteStringValue("informatieobject", Informatieobject);
            writer.WriteStringValue("titel", Titel);
            writer.WriteStringValue("zaak", Zaak);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
