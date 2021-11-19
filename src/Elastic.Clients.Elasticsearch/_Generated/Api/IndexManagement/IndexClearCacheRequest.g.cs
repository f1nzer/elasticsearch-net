// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexClearCacheRequestParameters : RequestParameters<IndexClearCacheRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

		[JsonIgnore]
		public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
	}

	public partial class IndexClearCacheRequest : PlainRequestBase<IndexClearCacheRequestParameters>
	{
		public IndexClearCacheRequest()
		{
		}

		public IndexClearCacheRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

		[JsonIgnore]
		public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
	}

	public sealed partial class IndexClearCacheRequestDescriptor<T> : RequestDescriptorBase<IndexClearCacheRequestDescriptor<T>, IndexClearCacheRequestParameters>
	{
		public IndexClearCacheRequestDescriptor()
		{
		}

		public IndexClearCacheRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal IndexClearCacheRequestDescriptor(Action<IndexClearCacheRequestDescriptor<T>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IndexClearCacheRequestDescriptor<T> AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public IndexClearCacheRequestDescriptor<T> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public IndexClearCacheRequestDescriptor<T> Fielddata(bool? fielddata) => Qs("fielddata", fielddata);
		public IndexClearCacheRequestDescriptor<T> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public IndexClearCacheRequestDescriptor<T> IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public IndexClearCacheRequestDescriptor<T> Query(bool? query) => Qs("query", query);
		public IndexClearCacheRequestDescriptor<T> Request(bool? request) => Qs("request", request);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}