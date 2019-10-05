using AutoMapper;
using YuzuDelivery.Umbraco.Blocks;
using YuzuDelivery.Umbraco.Grid;
using YuzuDelivery.Umbraco.Forms;
using Logistics.Core.UmbracoModels;
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.23.0 (Newtonsoft.Json v9.0.0.1) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Logistics.Core.ViewModels
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v9.0.0.1)")]
    public partial class vmBlock_SectionGridConfig 
    {
        [Newtonsoft.Json.JsonProperty("backgroundTheme", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public vmSub_SectionGridConfigVmBlock_SectionGridConfigBackgroundTheme BackgroundTheme { get; set; }
    
        [Newtonsoft.Json.JsonProperty("borderBottom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool BorderBottom { get; set; }
    
        [Newtonsoft.Json.JsonProperty("width", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public vmSub_SectionGridConfigVmBlock_SectionGridConfigWidth Width { get; set; }
    
        [Newtonsoft.Json.JsonProperty("_ref", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _ref { get; set; }
    
        [Newtonsoft.Json.JsonProperty("_modifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> _modifiers { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v9.0.0.1)")]
    public enum vmSub_SectionGridConfigVmBlock_SectionGridConfigBackgroundTheme
    {
        [System.Runtime.Serialization.EnumMember(Value = @"light")]
        Light = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"none")]
        None = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v9.0.0.1)")]
    public enum vmSub_SectionGridConfigVmBlock_SectionGridConfigWidth
    {
        [System.Runtime.Serialization.EnumMember(Value = @"full")]
        Full = 0,
    
    }
}