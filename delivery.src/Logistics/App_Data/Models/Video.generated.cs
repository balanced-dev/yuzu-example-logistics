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
	/// <summary>Video</summary>
	[PublishedModel("video")]
	public partial class Video : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new const string ModelTypeAlias = "video";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Video, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Video(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Poster
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("poster")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Poster => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("poster");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");

		///<summary>
		/// Video Id
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.3")]
		[ImplementPropertyType("videoId")]
		public string VideoId => this.Value<string>("videoId");
	}
}