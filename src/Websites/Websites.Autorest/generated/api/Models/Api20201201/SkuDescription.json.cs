namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Description of a SKU for a scalable resource.</summary>
    public partial class SkuDescription
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ISkuDescription.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ISkuDescription.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ISkuDescription FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json ? new SkuDescription(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject into a new instance of <see cref="SkuDescription" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SkuDescription(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_skuCapacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("skuCapacity"), out var __jsonSkuCapacity) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.SkuCapacity.FromJson(__jsonSkuCapacity) : SkuCapacity;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_tier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString>("tier"), out var __jsonTier) ? (string)__jsonTier : (string)Tier;}
            {_size = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString>("size"), out var __jsonSize) ? (string)__jsonSize : (string)Size;}
            {_family = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString>("family"), out var __jsonFamily) ? (string)__jsonFamily : (string)Family;}
            {_capacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNumber>("capacity"), out var __jsonCapacity) ? (int?)__jsonCapacity : Capacity;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("locations"), out var __jsonLocations) ? If( __jsonLocations as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Location;}
            {_capability = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("capabilities"), out var __jsonCapabilities) ? If( __jsonCapabilities as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ICapability[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ICapability) (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.Capability.FromJson(__p) )) ))() : null : Capability;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SkuDescription" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SkuDescription" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._skuCapacity ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._skuCapacity.ToJson(null,serializationMode) : null, "skuCapacity" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._tier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(this._tier.ToString()) : null, "tier" ,container.Add );
            AddIf( null != (((object)this._size)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(this._size.ToString()) : null, "size" ,container.Add );
            AddIf( null != (((object)this._family)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(this._family.ToString()) : null, "family" ,container.Add );
            AddIf( null != this._capacity ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNumber((int)this._capacity) : null, "capacity" ,container.Add );
            if (null != this._location)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __x in this._location )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("locations",__w);
            }
            if (null != this._capability)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __s in this._capability )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("capabilities",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}