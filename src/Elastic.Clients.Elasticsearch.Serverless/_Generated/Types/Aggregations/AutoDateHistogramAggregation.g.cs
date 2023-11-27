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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

internal sealed class AutoDateHistogramAggregationConverter : JsonConverter<AutoDateHistogramAggregation>
{
	public override AutoDateHistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "auto_date_histogram")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new AutoDateHistogramAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("buckets"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Buckets = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("minimum_interval"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval?>(ref reader, options);
					if (value is not null)
					{
						agg.MinimumInterval = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<DateTimeOffset?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("offset"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Offset = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("params"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<IDictionary<string, object>?>(ref reader, options);
					if (value is not null)
					{
						agg.Params = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("time_zone"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.TimeZone = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
				{
					var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
					if (value is not null)
					{
						agg.Aggregations = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, AutoDateHistogramAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("auto_date_histogram");
		writer.WriteStartObject();
		if (value.Buckets.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(value.Buckets.Value);
		}

		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.MinimumInterval is not null)
		{
			writer.WritePropertyName("minimum_interval");
			JsonSerializer.Serialize(writer, value.MinimumInterval, options);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (!string.IsNullOrEmpty(value.Offset))
		{
			writer.WritePropertyName("offset");
			writer.WriteStringValue(value.Offset);
		}

		if (value.Params is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, value.Params, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		if (value.TimeZone is not null)
		{
			writer.WritePropertyName("time_zone");
			JsonSerializer.Serialize(writer, value.TimeZone, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		if (value.Aggregations is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, value.Aggregations, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(AutoDateHistogramAggregationConverter))]
public sealed partial class AutoDateHistogramAggregation : SearchAggregation
{
	public AutoDateHistogramAggregation(string name) => Name = name;

	internal AutoDateHistogramAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? Aggregations { get; set; }

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public int? Buckets { get; set; }

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Field? Field { get; set; }

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	public string? Format { get; set; }
	public IDictionary<string, object>? Meta { get; set; }

	/// <summary>
	/// <para>The minimum rounding interval.<br/>This can make the collection process more efficient, as the aggregation will not attempt to round at any interval lower than `minimum_interval`.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval? MinimumInterval { get; set; }

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public DateTimeOffset? Missing { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>Time zone specified as a ISO 8601 UTC offset.</para>
	/// </summary>
	public string? Offset { get; set; }
	public IDictionary<string, object>? Params { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Script? Script { get; set; }

	/// <summary>
	/// <para>Time zone ID.</para>
	/// </summary>
	public string? TimeZone { get; set; }
}

public sealed partial class AutoDateHistogramAggregationDescriptor<TDocument> : SerializableDescriptor<AutoDateHistogramAggregationDescriptor<TDocument>>
{
	internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AutoDateHistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }
	private int? BucketsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval? MinimumIntervalValue { get; set; }
	private DateTimeOffset? MissingValue { get; set; }
	private string? OffsetValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private string? TimeZoneValue { get; set; }

	public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument> descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor<TDocument>> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Buckets(int? buckets)
	{
		BucketsValue = buckets;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The minimum rounding interval.<br/>This can make the collection process more efficient, as the aggregation will not attempt to round at any interval lower than `minimum_interval`.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> MinimumInterval(Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval? minimumInterval)
	{
		MinimumIntervalValue = minimumInterval;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Missing(DateTimeOffset? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>Time zone specified as a ISO 8601 UTC offset.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> Offset(string? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Time zone ID.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor<TDocument> TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("auto_date_histogram");
		writer.WriteStartObject();
		if (BucketsValue.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(BucketsValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MinimumIntervalValue is not null)
		{
			writer.WritePropertyName("minimum_interval");
			JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (!string.IsNullOrEmpty(OffsetValue))
		{
			writer.WritePropertyName("offset");
			writer.WriteStringValue(OffsetValue);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (TimeZoneValue is not null)
		{
			writer.WritePropertyName("time_zone");
			JsonSerializer.Serialize(writer, TimeZoneValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor<TDocument>(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class AutoDateHistogramAggregationDescriptor : SerializableDescriptor<AutoDateHistogramAggregationDescriptor>
{
	internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor> configure) => configure.Invoke(this);

	public AutoDateHistogramAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? AggregationsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor AggregationsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> AggregationsDescriptorAction { get; set; }
	private int? BucketsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? FieldValue { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval? MinimumIntervalValue { get; set; }
	private DateTimeOffset? MissingValue { get; set; }
	private string? OffsetValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Script? ScriptValue { get; set; }
	private string? TimeZoneValue { get; set; }

	public AutoDateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDictionary? aggregations)
	{
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = null;
		AggregationsValue = aggregations;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor descriptor)
	{
		AggregationsValue = null;
		AggregationsDescriptorAction = null;
		AggregationsDescriptor = descriptor;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Serverless.Aggregations.AggregationDescriptor> configure)
	{
		AggregationsValue = null;
		AggregationsDescriptor = null;
		AggregationsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Buckets(int? buckets)
	{
		BucketsValue = buckets;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field on which to run the aggregation.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The date format used to format `key_as_string` in the response.<br/>If no `format` is specified, the first date format specified in the field mapping is used.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The minimum rounding interval.<br/>This can make the collection process more efficient, as the aggregation will not attempt to round at any interval lower than `minimum_interval`.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor MinimumInterval(Elastic.Clients.Elasticsearch.Serverless.Aggregations.MinimumInterval? minimumInterval)
	{
		MinimumIntervalValue = minimumInterval;
		return Self;
	}

	/// <summary>
	/// <para>The value to apply to documents that do not have a value.<br/>By default, documents without a value are ignored.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Missing(DateTimeOffset? missing)
	{
		MissingValue = missing;
		return Self;
	}

	/// <summary>
	/// <para>Time zone specified as a ISO 8601 UTC offset.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor Offset(string? offset)
	{
		OffsetValue = offset;
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public AutoDateHistogramAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Serverless.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	/// <summary>
	/// <para>Time zone ID.</para>
	/// </summary>
	public AutoDateHistogramAggregationDescriptor TimeZone(string? timeZone)
	{
		TimeZoneValue = timeZone;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("auto_date_histogram");
		writer.WriteStartObject();
		if (BucketsValue.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(BucketsValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MinimumIntervalValue is not null)
		{
			writer.WritePropertyName("minimum_interval");
			JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (!string.IsNullOrEmpty(OffsetValue))
		{
			writer.WritePropertyName("offset");
			writer.WriteStringValue(OffsetValue);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (TimeZoneValue is not null)
		{
			writer.WritePropertyName("time_zone");
			JsonSerializer.Serialize(writer, TimeZoneValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (AggregationsDescriptor is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
		}
		else if (AggregationsDescriptorAction is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, new AggregationDescriptor(AggregationsDescriptorAction), options);
		}
		else if (AggregationsValue is not null)
		{
			writer.WritePropertyName("aggregations");
			JsonSerializer.Serialize(writer, AggregationsValue, options);
		}

		writer.WriteEndObject();
	}
}