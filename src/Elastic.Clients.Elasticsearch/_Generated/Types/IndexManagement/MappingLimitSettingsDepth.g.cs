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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class MappingLimitSettingsDepth
	{
		[JsonInclude]
		[JsonPropertyName("limit")]
		public int? Limit { get; set; }
	}

	public sealed partial class MappingLimitSettingsDepthDescriptor : SerializableDescriptorBase<MappingLimitSettingsDepthDescriptor>
	{
		internal MappingLimitSettingsDepthDescriptor(Action<MappingLimitSettingsDepthDescriptor> configure) => configure.Invoke(this);
		public MappingLimitSettingsDepthDescriptor() : base()
		{
		}

		private int? LimitValue { get; set; }

		public MappingLimitSettingsDepthDescriptor Limit(int? limit)
		{
			LimitValue = limit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (LimitValue.HasValue)
			{
				writer.WritePropertyName("limit");
				writer.WriteNumberValue(LimitValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}