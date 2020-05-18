//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.1
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
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("content")]
		public global::Skybrud.Umbraco.GridData.GridDataModel Content => this.Value<global::Skybrud.Umbraco.GridData.GridDataModel>("content");

		///<summary>
		/// Link Sections
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerLinkSections")]
		public global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteFooterLinkSection> FooterLinkSections => this.Value<global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteFooterLinkSection>>("footerLinkSections");

		///<summary>
		/// Company Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("headerCompanyName")]
		public string HeaderCompanyName => this.Value<string>("headerCompanyName");

		///<summary>
		/// Nav Sections
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("navNavSections")]
		public global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteNavNavSection> NavNavSections => this.Value<global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteNavNavSection>>("navNavSections");

		///<summary>
		/// NewsletterSection Form
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("newsletterSectionForm")]
		public object NewsletterSectionForm => this.Value("newsletterSectionForm");

		///<summary>
		/// NewsletterSection Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("newsletterSectionTitle")]
		public string NewsletterSectionTitle => this.Value<string>("newsletterSectionTitle");

		///<summary>
		/// SocialSection Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialSectionLinks")]
		public global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteFooterLink> SocialSectionLinks => this.Value<global::System.Collections.Generic.IEnumerable<global::YuzuDelivery.UmbracoModels.SiteFooterLink>>("socialSectionLinks");

		///<summary>
		/// SocialSection Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialSectionTitle")]
		public string SocialSectionTitle => this.Value<string>("socialSectionTitle");
	}
}
