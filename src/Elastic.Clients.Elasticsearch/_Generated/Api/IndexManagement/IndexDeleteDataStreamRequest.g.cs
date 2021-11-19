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
	public class IndexDeleteDataStreamRequestParameters : RequestParameters<IndexDeleteDataStreamRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }
	}

	public partial class IndexDeleteDataStreamRequest : PlainRequestBase<IndexDeleteDataStreamRequestParameters>
	{
		public IndexDeleteDataStreamRequest(Elastic.Clients.Elasticsearch.DataStreamNames name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }
	}

	public sealed partial class IndexDeleteDataStreamRequestDescriptor : RequestDescriptorBase<IndexDeleteDataStreamRequestDescriptor, IndexDeleteDataStreamRequestParameters>
	{
		public IndexDeleteDataStreamRequestDescriptor(Elastic.Clients.Elasticsearch.DataStreamNames name) : base(r => r.Required("name", name))
		{
		}

		public IndexDeleteDataStreamRequestDescriptor()
		{
		}

		internal IndexDeleteDataStreamRequestDescriptor(Action<IndexDeleteDataStreamRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public IndexDeleteDataStreamRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}