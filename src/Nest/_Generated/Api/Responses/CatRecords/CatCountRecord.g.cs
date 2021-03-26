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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatCountRecord
	{
		[JsonInclude, JsonPropertyName("count")]
		private string? _count = default;
		[JsonInclude, JsonPropertyName("dc")]
		private string? _dc = default;
		[JsonInclude, JsonPropertyName("docs.count")]
		private string? _docs_count = default;
		[JsonInclude, JsonPropertyName("docsCount")]
		private string? _docsCount = default;
		[JsonInclude, JsonPropertyName("epoch")]
		private EpochMillis? _epoch = default;
		[JsonInclude, JsonPropertyName("hhmmss")]
		private DateTimeOffset? _hhmmss = default;
		[JsonInclude, JsonPropertyName("hms")]
		private DateTimeOffset? _hms = default;
		[JsonInclude, JsonPropertyName("t")]
		private EpochMillis? _t = default;
		[JsonInclude, JsonPropertyName("time")]
		private EpochMillis? _time = default;
		[JsonInclude, JsonPropertyName("timestamp")]
		private DateTimeOffset? _timestamp = default;
		[JsonInclude, JsonPropertyName("ts")]
		private DateTimeOffset? _ts = default;
		public string? Count => _count ?? _docsCount ?? _dc ?? _docs_count;
		public EpochMillis? Epoch => _epoch ?? _t ?? _time;
		public DateTimeOffset? Timestamp => _timestamp ?? _hhmmss ?? _ts ?? _hms;
	}
}