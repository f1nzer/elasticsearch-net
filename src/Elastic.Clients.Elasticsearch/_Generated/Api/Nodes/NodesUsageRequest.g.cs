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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public class NodesUsageRequestParameters : RequestParameters<NodesUsageRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class NodesUsageRequest : PlainRequestBase<NodesUsageRequestParameters>
	{
		public NodesUsageRequest()
		{
		}

		public NodesUsageRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		public NodesUsageRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public NodesUsageRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("node_id", node_id).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class NodesUsageRequestDescriptor : RequestDescriptorBase<NodesUsageRequestDescriptor, NodesUsageRequestParameters>
	{
		internal NodesUsageRequestDescriptor(Action<NodesUsageRequestDescriptor> configure) => configure.Invoke(this);
		public NodesUsageRequestDescriptor()
		{
		}

		public NodesUsageRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public NodesUsageRequestDescriptor(Elastic.Clients.Elasticsearch.NodeIds? node_id, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("node_id", node_id).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public NodesUsageRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public NodesUsageRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? node_id)
		{
			RouteValues.Optional("node_id", node_id);
			return Self;
		}

		public NodesUsageRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}