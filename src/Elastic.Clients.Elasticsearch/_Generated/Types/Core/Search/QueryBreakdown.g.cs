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
namespace Elastic.Clients.Elasticsearch.Core.Search;
public sealed partial class QueryBreakdown
{
	[JsonInclude]
	[JsonPropertyName("advance")]
	public long Advance { get; init; }

	[JsonInclude]
	[JsonPropertyName("advance_count")]
	public long AdvanceCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("build_scorer")]
	public long BuildScorer { get; init; }

	[JsonInclude]
	[JsonPropertyName("build_scorer_count")]
	public long BuildScorerCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("compute_max_score")]
	public long ComputeMaxScore { get; init; }

	[JsonInclude]
	[JsonPropertyName("compute_max_score_count")]
	public long ComputeMaxScoreCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("create_weight")]
	public long CreateWeight { get; init; }

	[JsonInclude]
	[JsonPropertyName("create_weight_count")]
	public long CreateWeightCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("match")]
	public long Match { get; init; }

	[JsonInclude]
	[JsonPropertyName("match_count")]
	public long MatchCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("next_doc")]
	public long NextDoc { get; init; }

	[JsonInclude]
	[JsonPropertyName("next_doc_count")]
	public long NextDocCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("score")]
	public long Score { get; init; }

	[JsonInclude]
	[JsonPropertyName("score_count")]
	public long ScoreCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("set_min_competitive_score")]
	public long SetMinCompetitiveScore { get; init; }

	[JsonInclude]
	[JsonPropertyName("set_min_competitive_score_count")]
	public long SetMinCompetitiveScoreCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("shallow_advance")]
	public long ShallowAdvance { get; init; }

	[JsonInclude]
	[JsonPropertyName("shallow_advance_count")]
	public long ShallowAdvanceCount { get; init; }
}