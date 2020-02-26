using AutoMapper;
using YuzuDelivery.Umbraco.Core;
using YuzuDelivery.Umbraco.Forms;
using YuzuDelivery.Umbraco.Grid;
using YuzuDelivery.UmbracoModels;
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.23.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace YuzuDelivery.ViewModels
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v12.0.0.0)")]
    [AutoMap(typeof(Template))]
    public partial class vmPage_Template 
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public vmBlock_SiteHeader Header { get; set; }
    
        [Newtonsoft.Json.JsonProperty("footer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public vmBlock_SiteFooter Footer { get; set; }
    
    
    }
}