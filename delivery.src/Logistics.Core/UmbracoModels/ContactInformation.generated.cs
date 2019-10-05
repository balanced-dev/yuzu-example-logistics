//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Logistics.Core.UmbracoModels
{
	/// <summary>ContactInformation</summary>
	[PublishedModel("contactInformation")]
	public partial class ContactInformation : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "contactInformation";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactInformation, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactInformation(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Contact Sections
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("contactSections")]
		public IEnumerable<ContactInformationSection> ContactSections => this.Value<IEnumerable<ContactInformationSection>>("contactSections");

		///<summary>
		/// Form
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("form")]
		public object Form => this.Value("form");

		///<summary>
		/// More Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("moreLink")]
		public IPublishedContent MoreLink => this.Value<IPublishedContent>("moreLink");

		///<summary>
		/// More Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("moreText")]
		public string MoreText => this.Value<string>("moreText");

		///<summary>
		/// More Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("moreTitle")]
		public string MoreTitle => this.Value<string>("moreTitle");
	}
}
