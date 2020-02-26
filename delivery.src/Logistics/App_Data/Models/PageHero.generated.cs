//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.5.3
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace YuzuDelivery.UmbracoModels
{
	/// <summary>PageHero</summary>
	[PublishedModel("pageHero")]
	public partial class PageHero : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new const string ModelTypeAlias = "pageHero";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageHero, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public PageHero(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Breadcrumbs
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("breadcrumbs")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> Breadcrumbs => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("breadcrumbs");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("image")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Image => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("image");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}
}