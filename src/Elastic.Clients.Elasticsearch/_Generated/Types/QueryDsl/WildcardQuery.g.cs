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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

internal sealed partial class WildcardQueryConverter : JsonConverter<WildcardQuery>
{
	public override WildcardQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new WildcardQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "case_insensitive")
				{
					variant.CaseInsensitive = JsonSerializer.Deserialize<bool?>(ref reader, options);
					continue;
				}

				if (property == "rewrite")
				{
					variant.Rewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "value")
				{
					variant.Value = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "wildcard")
				{
					variant.Wildcard = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, WildcardQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize WildcardQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (options.TryGetClientSettings(out var settings))
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(value.Field));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			if (value.CaseInsensitive.HasValue)
			{
				writer.WritePropertyName("case_insensitive");
				writer.WriteBooleanValue(value.CaseInsensitive.Value);
			}

			if (value.Rewrite is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, value.Rewrite, options);
			}

			if (!string.IsNullOrEmpty(value.Value))
			{
				writer.WritePropertyName("value");
				writer.WriteStringValue(value.Value);
			}

			if (!string.IsNullOrEmpty(value.Wildcard))
			{
				writer.WritePropertyName("wildcard");
				writer.WriteStringValue(value.Wildcard);
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
			return;
		}

		throw new JsonException("Unable to retrieve client settings required to infer field.");
	}
}

[JsonConverter(typeof(WildcardQueryConverter))]
public sealed partial class WildcardQuery : SearchQuery
{
	public WildcardQuery(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	public string? QueryName { get; set; }
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Allows case insensitive matching of the pattern with the indexed field values when set to true. Default is false which means the case sensitivity of matching depends on the underlying field’s mapping.</para>
	/// </summary>
	public bool? CaseInsensitive { get; set; }

	/// <summary>
	/// <para>Method used to rewrite the query</para>
	/// </summary>
	public string? Rewrite { get; set; }

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when wildcard is not set.</para>
	/// </summary>
	public string? Value { get; set; }

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when value is not set.</para>
	/// </summary>
	public string? Wildcard { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	public static implicit operator Query(WildcardQuery wildcardQuery) => QueryDsl.Query.Wildcard(wildcardQuery);
}

public sealed partial class WildcardQueryDescriptor<TDocument> : SerializableDescriptor<WildcardQueryDescriptor<TDocument>>
{
	internal WildcardQueryDescriptor(Action<WildcardQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	internal WildcardQueryDescriptor() : base()
	{
	}

	public WildcardQueryDescriptor(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	public WildcardQueryDescriptor(Expression<Func<TDocument, object>> field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private bool? CaseInsensitiveValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? RewriteValue { get; set; }
	private string? ValueValue { get; set; }
	private string? WildcardValue { get; set; }

	public WildcardQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public WildcardQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Allows case insensitive matching of the pattern with the indexed field values when set to true. Default is false which means the case sensitivity of matching depends on the underlying field’s mapping.</para>
	/// </summary>
	public WildcardQueryDescriptor<TDocument> CaseInsensitive(bool? caseInsensitive = true)
	{
		CaseInsensitiveValue = caseInsensitive;
		return Self;
	}

	public WildcardQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public WildcardQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Method used to rewrite the query</para>
	/// </summary>
	public WildcardQueryDescriptor<TDocument> Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when wildcard is not set.</para>
	/// </summary>
	public WildcardQueryDescriptor<TDocument> Value(string? value)
	{
		ValueValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when value is not set.</para>
	/// </summary>
	public WildcardQueryDescriptor<TDocument> Wildcard(string? wildcard)
	{
		WildcardValue = wildcard;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (CaseInsensitiveValue.HasValue)
		{
			writer.WritePropertyName("case_insensitive");
			writer.WriteBooleanValue(CaseInsensitiveValue.Value);
		}

		if (RewriteValue is not null)
		{
			writer.WritePropertyName("rewrite");
			JsonSerializer.Serialize(writer, RewriteValue, options);
		}

		if (!string.IsNullOrEmpty(ValueValue))
		{
			writer.WritePropertyName("value");
			writer.WriteStringValue(ValueValue);
		}

		if (!string.IsNullOrEmpty(WildcardValue))
		{
			writer.WritePropertyName("wildcard");
			writer.WriteStringValue(WildcardValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class WildcardQueryDescriptor : SerializableDescriptor<WildcardQueryDescriptor>
{
	internal WildcardQueryDescriptor(Action<WildcardQueryDescriptor> configure) => configure.Invoke(this);

	internal WildcardQueryDescriptor() : base()
	{
	}

	public WildcardQueryDescriptor(Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		FieldValue = field;
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private bool? CaseInsensitiveValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? RewriteValue { get; set; }
	private string? ValueValue { get; set; }
	private string? WildcardValue { get; set; }

	public WildcardQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public WildcardQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Allows case insensitive matching of the pattern with the indexed field values when set to true. Default is false which means the case sensitivity of matching depends on the underlying field’s mapping.</para>
	/// </summary>
	public WildcardQueryDescriptor CaseInsensitive(bool? caseInsensitive = true)
	{
		CaseInsensitiveValue = caseInsensitive;
		return Self;
	}

	public WildcardQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public WildcardQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public WildcardQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Method used to rewrite the query</para>
	/// </summary>
	public WildcardQueryDescriptor Rewrite(string? rewrite)
	{
		RewriteValue = rewrite;
		return Self;
	}

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when wildcard is not set.</para>
	/// </summary>
	public WildcardQueryDescriptor Value(string? value)
	{
		ValueValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Wildcard pattern for terms you wish to find in the provided field. Required, when value is not set.</para>
	/// </summary>
	public WildcardQueryDescriptor Wildcard(string? wildcard)
	{
		WildcardValue = wildcard;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (CaseInsensitiveValue.HasValue)
		{
			writer.WritePropertyName("case_insensitive");
			writer.WriteBooleanValue(CaseInsensitiveValue.Value);
		}

		if (RewriteValue is not null)
		{
			writer.WritePropertyName("rewrite");
			JsonSerializer.Serialize(writer, RewriteValue, options);
		}

		if (!string.IsNullOrEmpty(ValueValue))
		{
			writer.WritePropertyName("value");
			writer.WriteStringValue(ValueValue);
		}

		if (!string.IsNullOrEmpty(WildcardValue))
		{
			writer.WritePropertyName("wildcard");
			writer.WriteStringValue(WildcardValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}