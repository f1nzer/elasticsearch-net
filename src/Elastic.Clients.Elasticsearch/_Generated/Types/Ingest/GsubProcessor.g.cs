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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest;
public sealed partial class GsubProcessor
{
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	[JsonInclude, JsonPropertyName("ignore_missing")]
	public bool? IgnoreMissing { get; set; }

	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	[JsonInclude, JsonPropertyName("pattern")]
	public string Pattern { get; set; }

	[JsonInclude, JsonPropertyName("replacement")]
	public string Replacement { get; set; }

	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	public static implicit operator Processor(GsubProcessor gsubProcessor) => Ingest.Processor.Gsub(gsubProcessor);
}

public sealed partial class GsubProcessorDescriptor<TDocument> : SerializableDescriptor<GsubProcessorDescriptor<TDocument>>
{
	internal GsubProcessorDescriptor(Action<GsubProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
	public GsubProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }

	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }

	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }

	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }

	private string? DescriptionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? IfValue { get; set; }

	private bool? IgnoreFailureValue { get; set; }

	private bool? IgnoreMissingValue { get; set; }

	private string PatternValue { get; set; }

	private string ReplacementValue { get; set; }

	private string? TagValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	public GsubProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Pattern(string pattern)
	{
		PatternValue = pattern;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Replacement(string replacement)
	{
		ReplacementValue = replacement;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public GsubProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		writer.WritePropertyName("pattern");
		writer.WriteStringValue(PatternValue);
		writer.WritePropertyName("replacement");
		writer.WriteStringValue(ReplacementValue);
		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GsubProcessorDescriptor : SerializableDescriptor<GsubProcessorDescriptor>
{
	internal GsubProcessorDescriptor(Action<GsubProcessorDescriptor> configure) => configure.Invoke(this);
	public GsubProcessorDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }

	private ProcessorDescriptor OnFailureDescriptor { get; set; }

	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }

	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }

	private string? DescriptionValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? IfValue { get; set; }

	private bool? IgnoreFailureValue { get; set; }

	private bool? IgnoreMissingValue { get; set; }

	private string PatternValue { get; set; }

	private string ReplacementValue { get; set; }

	private string? TagValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	public GsubProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public GsubProcessorDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public GsubProcessorDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public GsubProcessorDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	public GsubProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	public GsubProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GsubProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GsubProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GsubProcessorDescriptor If(string? ifValue)
	{
		IfValue = ifValue;
		return Self;
	}

	public GsubProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	public GsubProcessorDescriptor IgnoreMissing(bool? ignoreMissing = true)
	{
		IgnoreMissingValue = ignoreMissing;
		return Self;
	}

	public GsubProcessorDescriptor Pattern(string pattern)
	{
		PatternValue = pattern;
		return Self;
	}

	public GsubProcessorDescriptor Replacement(string replacement)
	{
		ReplacementValue = replacement;
		return Self;
	}

	public GsubProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	public GsubProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public GsubProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	public GsubProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (IgnoreMissingValue.HasValue)
		{
			writer.WritePropertyName("ignore_missing");
			writer.WriteBooleanValue(IgnoreMissingValue.Value);
		}

		writer.WritePropertyName("pattern");
		writer.WriteStringValue(PatternValue);
		writer.WritePropertyName("replacement");
		writer.WriteStringValue(ReplacementValue);
		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}