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

public sealed partial class KuromojiAnalyzer : IAnalyzer
{
	[JsonInclude, JsonPropertyName("mode")]
	public Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiTokenizationMode Mode { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "kuromoji";

	[JsonInclude, JsonPropertyName("user_dictionary")]
	public string? UserDictionary { get; set; }
}

public sealed partial class KuromojiAnalyzerDescriptor : SerializableDescriptor<KuromojiAnalyzerDescriptor>, IBuildableDescriptor<KuromojiAnalyzer>
{
	internal KuromojiAnalyzerDescriptor(Action<KuromojiAnalyzerDescriptor> configure) => configure.Invoke(this);

	public KuromojiAnalyzerDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiTokenizationMode ModeValue { get; set; }
	private string? UserDictionaryValue { get; set; }

	public KuromojiAnalyzerDescriptor Mode(Elastic.Clients.Elasticsearch.Serverless.Analysis.KuromojiTokenizationMode mode)
	{
		ModeValue = mode;
		return Self;
	}

	public KuromojiAnalyzerDescriptor UserDictionary(string? userDictionary)
	{
		UserDictionaryValue = userDictionary;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("mode");
		JsonSerializer.Serialize(writer, ModeValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("kuromoji");
		if (!string.IsNullOrEmpty(UserDictionaryValue))
		{
			writer.WritePropertyName("user_dictionary");
			writer.WriteStringValue(UserDictionaryValue);
		}

		writer.WriteEndObject();
	}

	KuromojiAnalyzer IBuildableDescriptor<KuromojiAnalyzer>.Build() => new()
	{
		Mode = ModeValue,
		UserDictionary = UserDictionaryValue
	};
}