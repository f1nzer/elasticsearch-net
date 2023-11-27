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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Core.Mtermvectors;

public sealed partial class MultiTermVectorsOperation
{
	/// <summary>
	/// <para>The ID of the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Id Id { get; set; }

	/// <summary>
	/// <para>The index of the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_index")]
	public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

	/// <summary>
	/// <para>An artificial document (a document not present in the index) for which you want to retrieve term vectors.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("doc")]
	public object? Doc { get; set; }

	/// <summary>
	/// <para>If `true`, the response includes the document count, sum of document frequencies, and sum of total term frequencies.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_statistics")]
	public bool? FieldStatistics { get; set; }

	/// <summary>
	/// <para>Comma-separated list or wildcard expressions of fields to include in the statistics.<br/>Used as the default list unless a specific field list is provided in the `completion_fields` or `fielddata_fields` parameters.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

	/// <summary>
	/// <para>Filter terms based on their tf-idf scores.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.Core.TermVectors.Filter? Filter { get; set; }

	/// <summary>
	/// <para>If `true`, the response includes term offsets.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("offsets")]
	public bool? Offsets { get; set; }

	/// <summary>
	/// <para>If `true`, the response includes term payloads.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("payloads")]
	public bool? Payloads { get; set; }

	/// <summary>
	/// <para>If `true`, the response includes term positions.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("positions")]
	public bool? Positions { get; set; }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	/// <summary>
	/// <para>If true, the response includes term frequency and document frequency.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("term_statistics")]
	public bool? TermStatistics { get; set; }

	/// <summary>
	/// <para>If `true`, returns the document version as part of a hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }

	/// <summary>
	/// <para>Specific version type.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version_type")]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
}

public sealed partial class MultiTermVectorsOperationDescriptor<TDocument> : SerializableDescriptor<MultiTermVectorsOperationDescriptor<TDocument>>
{
	internal MultiTermVectorsOperationDescriptor(Action<MultiTermVectorsOperationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiTermVectorsOperationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }
	private object? DocValue { get; set; }
	private bool? FieldStatisticsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.TermVectors.Filter? FilterValue { get; set; }
	private Core.TermVectors.FilterDescriptor FilterDescriptor { get; set; }
	private Action<Core.TermVectors.FilterDescriptor> FilterDescriptorAction { get; set; }
	private bool? OffsetsValue { get; set; }
	private bool? PayloadsValue { get; set; }
	private bool? PositionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private bool? TermStatisticsValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>The ID of the document.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>The index of the document.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>An artificial document (a document not present in the index) for which you want to retrieve term vectors.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Doc(object? doc)
	{
		DocValue = doc;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes the document count, sum of document frequencies, and sum of total term frequencies.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> FieldStatistics(bool? fieldStatistics = true)
	{
		FieldStatisticsValue = fieldStatistics;
		return Self;
	}

	/// <summary>
	/// <para>Comma-separated list or wildcard expressions of fields to include in the statistics.<br/>Used as the default list unless a specific field list is provided in the `completion_fields` or `fielddata_fields` parameters.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Filter terms based on their tf-idf scores.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Core.TermVectors.Filter? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public MultiTermVectorsOperationDescriptor<TDocument> Filter(Core.TermVectors.FilterDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public MultiTermVectorsOperationDescriptor<TDocument> Filter(Action<Core.TermVectors.FilterDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term offsets.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Offsets(bool? offsets = true)
	{
		OffsetsValue = offsets;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term payloads.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Payloads(bool? payloads = true)
	{
		PayloadsValue = payloads;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term positions.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Positions(bool? positions = true)
	{
		PositionsValue = positions;
		return Self;
	}

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>If true, the response includes term frequency and document frequency.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> TermStatistics(bool? termStatistics = true)
	{
		TermStatisticsValue = termStatistics;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns the document version as part of a hit.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	/// <summary>
	/// <para>Specific version type.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("_id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			JsonSerializer.Serialize(writer, DocValue, options);
		}

		if (FieldStatisticsValue.HasValue)
		{
			writer.WritePropertyName("field_statistics");
			writer.WriteBooleanValue(FieldStatisticsValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Core.TermVectors.FilterDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (OffsetsValue.HasValue)
		{
			writer.WritePropertyName("offsets");
			writer.WriteBooleanValue(OffsetsValue.Value);
		}

		if (PayloadsValue.HasValue)
		{
			writer.WritePropertyName("payloads");
			writer.WriteBooleanValue(PayloadsValue.Value);
		}

		if (PositionsValue.HasValue)
		{
			writer.WritePropertyName("positions");
			writer.WriteBooleanValue(PositionsValue.Value);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (TermStatisticsValue.HasValue)
		{
			writer.WritePropertyName("term_statistics");
			writer.WriteBooleanValue(TermStatisticsValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MultiTermVectorsOperationDescriptor : SerializableDescriptor<MultiTermVectorsOperationDescriptor>
{
	internal MultiTermVectorsOperationDescriptor(Action<MultiTermVectorsOperationDescriptor> configure) => configure.Invoke(this);

	public MultiTermVectorsOperationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }
	private object? DocValue { get; set; }
	private bool? FieldStatisticsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.TermVectors.Filter? FilterValue { get; set; }
	private Core.TermVectors.FilterDescriptor FilterDescriptor { get; set; }
	private Action<Core.TermVectors.FilterDescriptor> FilterDescriptorAction { get; set; }
	private bool? OffsetsValue { get; set; }
	private bool? PayloadsValue { get; set; }
	private bool? PositionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private bool? TermStatisticsValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>The ID of the document.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>The index of the document.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>An artificial document (a document not present in the index) for which you want to retrieve term vectors.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Doc(object? doc)
	{
		DocValue = doc;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes the document count, sum of document frequencies, and sum of total term frequencies.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor FieldStatistics(bool? fieldStatistics = true)
	{
		FieldStatisticsValue = fieldStatistics;
		return Self;
	}

	/// <summary>
	/// <para>Comma-separated list or wildcard expressions of fields to include in the statistics.<br/>Used as the default list unless a specific field list is provided in the `completion_fields` or `fielddata_fields` parameters.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Filter terms based on their tf-idf scores.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Filter(Elastic.Clients.Elasticsearch.Core.TermVectors.Filter? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public MultiTermVectorsOperationDescriptor Filter(Core.TermVectors.FilterDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public MultiTermVectorsOperationDescriptor Filter(Action<Core.TermVectors.FilterDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term offsets.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Offsets(bool? offsets = true)
	{
		OffsetsValue = offsets;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term payloads.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Payloads(bool? payloads = true)
	{
		PayloadsValue = payloads;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the response includes term positions.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Positions(bool? positions = true)
	{
		PositionsValue = positions;
		return Self;
	}

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>If true, the response includes term frequency and document frequency.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor TermStatistics(bool? termStatistics = true)
	{
		TermStatisticsValue = termStatistics;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, returns the document version as part of a hit.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	/// <summary>
	/// <para>Specific version type.</para>
	/// </summary>
	public MultiTermVectorsOperationDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("_id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (DocValue is not null)
		{
			writer.WritePropertyName("doc");
			JsonSerializer.Serialize(writer, DocValue, options);
		}

		if (FieldStatisticsValue.HasValue)
		{
			writer.WritePropertyName("field_statistics");
			writer.WriteBooleanValue(FieldStatisticsValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Core.TermVectors.FilterDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (OffsetsValue.HasValue)
		{
			writer.WritePropertyName("offsets");
			writer.WriteBooleanValue(OffsetsValue.Value);
		}

		if (PayloadsValue.HasValue)
		{
			writer.WritePropertyName("payloads");
			writer.WriteBooleanValue(PayloadsValue.Value);
		}

		if (PositionsValue.HasValue)
		{
			writer.WritePropertyName("positions");
			writer.WriteBooleanValue(PositionsValue.Value);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (TermStatisticsValue.HasValue)
		{
			writer.WritePropertyName("term_statistics");
			writer.WriteBooleanValue(TermStatisticsValue.Value);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}