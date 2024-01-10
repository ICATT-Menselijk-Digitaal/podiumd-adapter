// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Generated.Esuite.ZrcClient.Models {
    public class BAGZaakObject : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The objectIdentificatie property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BAGObjectIdentificatie? ObjectIdentificatie { get; set; }
#nullable restore
#else
        public BAGObjectIdentificatie ObjectIdentificatie { get; set; }
#endif
        /// <summary>Beschrijft het type object. Als er geen passend type is, dan moet het type worden opgegeven onder objectTypeOverige</summary>
        public BAGZaakObject_objectType? ObjectType { get; set; }
        /// <summary>Beschrijft het type object als objectType de waarde overige heeft.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectTypeOverige { get; set; }
#nullable restore
#else
        public string ObjectTypeOverige { get; set; }
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
        /// Instantiates a new BAGZaakObject and sets the default values.
        /// </summary>
        public BAGZaakObject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BAGZaakObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BAGZaakObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"objectIdentificatie", n => { ObjectIdentificatie = n.GetObjectValue<BAGObjectIdentificatie>(BAGObjectIdentificatie.CreateFromDiscriminatorValue); } },
                {"objectType", n => { ObjectType = n.GetEnumValue<BAGZaakObject_objectType>(); } },
                {"objectTypeOverige", n => { ObjectTypeOverige = n.GetStringValue(); } },
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
            writer.WriteObjectValue<BAGObjectIdentificatie>("objectIdentificatie", ObjectIdentificatie);
            writer.WriteEnumValue<BAGZaakObject_objectType>("objectType", ObjectType);
            writer.WriteStringValue("objectTypeOverige", ObjectTypeOverige);
            writer.WriteStringValue("zaak", Zaak);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
