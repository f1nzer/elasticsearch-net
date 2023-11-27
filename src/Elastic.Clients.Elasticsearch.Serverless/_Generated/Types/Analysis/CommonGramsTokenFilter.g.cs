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

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class CommonGramsTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("common_words")]
	public ICollection<string>? CommonWords { get; set; }
	[JsonInclude, JsonPropertyName("common_words_path")]
	public string? CommonWordsPath { get; set; }
	[JsonInclude, JsonPropertyName("ignore_case")]
	public bool? IgnoreCase { get; set; }
	[JsonInclude, JsonPropertyName("query_mode")]
	public bool? QueryMode { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "common_grams";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class CommonGramsTokenFilterDescriptor : SerializableDescriptor<CommonGramsTokenFilterDescriptor>, IBuildableDescriptor<CommonGramsTokenFilter>
{
	internal CommonGramsTokenFilterDescriptor(Action<CommonGramsTokenFilterDescriptor> configure) => configure.Invoke(this);

	public CommonGramsTokenFilterDescriptor() : base()
	{
	}

	private ICollection<string>? CommonWordsValue { get; set; }
	private string? CommonWordsPathValue { get; set; }
	private bool? IgnoreCaseValue { get; set; }
	private bool? QueryModeValue { get; set; }
	private string? VersionValue { get; set; }

	public CommonGramsTokenFilterDescriptor CommonWords(ICollection<string>? commonWords)
	{
		CommonWordsValue = commonWords;
		return Self;
	}

	public CommonGramsTokenFilterDescriptor CommonWordsPath(string? commonWordsPath)
	{
		CommonWordsPathValue = commonWordsPath;
		return Self;
	}

	public CommonGramsTokenFilterDescriptor IgnoreCase(bool? ignoreCase = true)
	{
		IgnoreCaseValue = ignoreCase;
		return Self;
	}

	public CommonGramsTokenFilterDescriptor QueryMode(bool? queryMode = true)
	{
		QueryModeValue = queryMode;
		return Self;
	}

	public CommonGramsTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (CommonWordsValue is not null)
		{
			writer.WritePropertyName("common_words");
			JsonSerializer.Serialize(writer, CommonWordsValue, options);
		}

		if (!string.IsNullOrEmpty(CommonWordsPathValue))
		{
			writer.WritePropertyName("common_words_path");
			writer.WriteStringValue(CommonWordsPathValue);
		}

		if (IgnoreCaseValue.HasValue)
		{
			writer.WritePropertyName("ignore_case");
			writer.WriteBooleanValue(IgnoreCaseValue.Value);
		}

		if (QueryModeValue.HasValue)
		{
			writer.WritePropertyName("query_mode");
			writer.WriteBooleanValue(QueryModeValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("common_grams");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	CommonGramsTokenFilter IBuildableDescriptor<CommonGramsTokenFilter>.Build() => new()
	{
		CommonWords = CommonWordsValue,
		CommonWordsPath = CommonWordsPathValue,
		IgnoreCase = IgnoreCaseValue,
		QueryMode = QueryModeValue,
		Version = VersionValue
	};
}