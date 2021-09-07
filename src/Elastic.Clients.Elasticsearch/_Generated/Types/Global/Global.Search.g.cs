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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Global.Search
{
	public partial class AggregationBreakdown
	{
		[JsonPropertyName("build_aggregation")]
		public long BuildAggregation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_aggregation_count")]
		public long BuildAggregationCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_leaf_collector")]
		public long BuildLeafCollector
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_leaf_collector_count")]
		public long BuildLeafCollectorCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("collect")]
		public long Collect
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("collect_count")]
		public long CollectCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initialize")]
		public long Initialize
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initialize_count")]
		public long InitializeCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("post_collection")]
		public long? PostCollection
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("post_collection_count")]
		public long? PostCollectionCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reduce")]
		public long Reduce
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reduce_count")]
		public long ReduceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AggregationProfile
	{
		[JsonPropertyName("breakdown")]
		public Elastic.Clients.Elasticsearch.Global.Search.AggregationBreakdown Breakdown
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.AggregationProfileDebug>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("debug")]
		public Elastic.Clients.Elasticsearch.Global.Search.AggregationProfileDebug? Debug
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AggregationProfileDebug
	{
	}

	public partial class Collector
	{
		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.Collector>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public string Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("reason")]
		public string Reason
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CompletionSuggestOption<TDocument>
	{
		[JsonPropertyName("collate_match")]
		public bool? CollateMatch
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("contexts")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.Context>>? Contexts
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_source")]
		public TDocument Source
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Elastic.Clients.Elasticsearch.DocType? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CompletionSuggester : Global.Search.SuggesterBase
	{
		[JsonPropertyName("contexts")]
		public Dictionary<string, OneOf<string, IReadOnlyCollection<string>, QueryDsl.GeoLocation, IReadOnlyCollection<Global.Search.SuggestContextQuery>>>? Contexts { get; set; }

		[JsonPropertyName("fuzzy")]
		public Elastic.Clients.Elasticsearch.Global.Search.SuggestFuzziness? Fuzzy { get; set; }

		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonPropertyName("regex")]
		public string? Regex { get; set; }

		[JsonPropertyName("skip_duplicates")]
		public bool? SkipDuplicates { get; set; }
	}

	public partial class DirectGenerator
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("max_edits")]
		public int? MaxEdits { get; set; }

		[JsonPropertyName("max_inspections")]
		public float? MaxInspections { get; set; }

		[JsonPropertyName("max_term_freq")]
		public float? MaxTermFreq { get; set; }

		[JsonPropertyName("min_doc_freq")]
		public float? MinDocFreq { get; set; }

		[JsonPropertyName("min_word_length")]
		public int? MinWordLength { get; set; }

		[JsonPropertyName("post_filter")]
		public string? PostFilter { get; set; }

		[JsonPropertyName("pre_filter")]
		public string? PreFilter { get; set; }

		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonPropertyName("suggest_mode")]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get; set; }
	}

	public partial class FieldAndFormat
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonPropertyName("include_unmapped")]
		public bool? IncludeUnmapped { get; set; }
	}

	public partial class FieldCollapse
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("inner_hits")]
		public Union<Elastic.Clients.Elasticsearch.Global.Search.InnerHits, IEnumerable<Elastic.Clients.Elasticsearch.Global.Search.InnerHits>>? InnerHits { get; set; }

		[JsonPropertyName("max_concurrent_group_searches")]
		public int? MaxConcurrentGroupSearches { get; set; }
	}

	public partial class GeoDistanceSort
	{
		[JsonPropertyName("distance_type")]
		public Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortMode? Mode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unit")]
		public Elastic.Clients.Elasticsearch.DistanceUnit? Unit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Highlight
	{
		[JsonPropertyName("boundary_chars")]
		public string? BoundaryChars { get; set; }

		[JsonPropertyName("boundary_max_scan")]
		public int? BoundaryMaxScan { get; set; }

		[JsonPropertyName("boundary_scanner")]
		public Elastic.Clients.Elasticsearch.Global.Search.BoundaryScanner? BoundaryScanner { get; set; }

		[JsonPropertyName("boundary_scanner_locale")]
		public string? BoundaryScannerLocale { get; set; }

		[JsonPropertyName("encoder")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterEncoder? Encoder { get; set; }

		[JsonPropertyName("fields")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Global.Search.HighlightField> Fields { get; set; }

		[JsonPropertyName("fragmenter")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterFragmenter? Fragmenter { get; set; }

		[JsonPropertyName("fragment_offset")]
		public int? FragmentOffset { get; set; }

		[JsonPropertyName("fragment_size")]
		public int? FragmentSize { get; set; }

		[JsonPropertyName("highlight_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? HighlightQuery { get; set; }

		[JsonPropertyName("max_analyzed_offset")]
		public Union<string, int>? MaxAnalyzedOffset { get; set; }

		[JsonPropertyName("max_fragment_length")]
		public int? MaxFragmentLength { get; set; }

		[JsonPropertyName("no_match_size")]
		public int? NoMatchSize { get; set; }

		[JsonPropertyName("number_of_fragments")]
		public int? NumberOfFragments { get; set; }

		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterOrder? Order { get; set; }

		[JsonPropertyName("post_tags")]
		public IEnumerable<string>? PostTags { get; set; }

		[JsonPropertyName("pre_tags")]
		public IEnumerable<string>? PreTags { get; set; }

		[JsonPropertyName("require_field_match")]
		public bool? RequireFieldMatch { get; set; }

		[JsonPropertyName("tags_schema")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterTagsSchema? TagsSchema { get; set; }

		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterType? Type { get; set; }
	}

	public partial class HighlightField
	{
		[JsonPropertyName("boundary_chars")]
		public string? BoundaryChars { get; set; }

		[JsonPropertyName("boundary_max_scan")]
		public int? BoundaryMaxScan { get; set; }

		[JsonPropertyName("boundary_scanner")]
		public Elastic.Clients.Elasticsearch.Global.Search.BoundaryScanner? BoundaryScanner { get; set; }

		[JsonPropertyName("boundary_scanner_locale")]
		public string? BoundaryScannerLocale { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonPropertyName("force_source")]
		public bool? ForceSource { get; set; }

		[JsonPropertyName("fragmenter")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterFragmenter? Fragmenter { get; set; }

		[JsonPropertyName("fragment_offset")]
		public int? FragmentOffset { get; set; }

		[JsonPropertyName("fragment_size")]
		public int? FragmentSize { get; set; }

		[JsonPropertyName("highlight_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? HighlightQuery { get; set; }

		[JsonPropertyName("matched_fields")]
		public Elastic.Clients.Elasticsearch.Fields? MatchedFields { get; set; }

		[JsonPropertyName("max_fragment_length")]
		public int? MaxFragmentLength { get; set; }

		[JsonPropertyName("no_match_size")]
		public int? NoMatchSize { get; set; }

		[JsonPropertyName("number_of_fragments")]
		public int? NumberOfFragments { get; set; }

		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterOrder? Order { get; set; }

		[JsonPropertyName("phrase_limit")]
		public int? PhraseLimit { get; set; }

		[JsonPropertyName("post_tags")]
		public IEnumerable<string>? PostTags { get; set; }

		[JsonPropertyName("pre_tags")]
		public IEnumerable<string>? PreTags { get; set; }

		[JsonPropertyName("require_field_match")]
		public bool? RequireFieldMatch { get; set; }

		[JsonPropertyName("tags_schema")]
		public Elastic.Clients.Elasticsearch.Global.Search.HighlighterTagsSchema? TagsSchema { get; set; }

		[JsonPropertyName("type")]
		public Union<Elastic.Clients.Elasticsearch.Global.Search.HighlighterType, string>? Type { get; set; }
	}

	public partial class Hit<TDocument>
	{
		[JsonPropertyName("_explanation")]
		public Elastic.Clients.Elasticsearch.Global.Explain.Explanation? Explanation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("highlight")]
		public Dictionary<string, IReadOnlyCollection<string>>? Highlight
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_ignored")]
		public IReadOnlyCollection<string>? Ignored
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("inner_hits")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Global.Search.InnerHitsResult>? InnerHits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("matched_queries")]
		public IReadOnlyCollection<string>? MatchedQueries
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nested")]
		public Elastic.Clients.Elasticsearch.Global.Search.NestedIdentity? Nested
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_node")]
		public string? Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_primary_term")]
		public long? PrimaryTerm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_routing")]
		public string? Routing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_score")]
		public double? Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_seq_no")]
		public Elastic.Clients.Elasticsearch.SequenceNumber? SeqNo
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shard")]
		public string? Shard
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortResults? Sort
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_source")]
		public TDocument? Source
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Elastic.Clients.Elasticsearch.DocType? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class HitsMetadata<T>
	{
		[JsonPropertyName("hits")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.Hit<T>> Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public Union<Elastic.Clients.Elasticsearch.Global.Search.TotalHits, long> Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InnerHits
	{
		[JsonPropertyName("collapse")]
		public Elastic.Clients.Elasticsearch.Global.Search.FieldCollapse? Collapse { get; set; }

		[JsonPropertyName("docvalue_fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Global.Search.FieldAndFormat>? DocvalueFields { get; set; }

		[JsonPropertyName("explain")]
		public bool? Explain { get; set; }

		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Global.Search.Highlight? Highlight { get; set; }

		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

		[JsonPropertyName("script_fields")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		[JsonPropertyName("seq_no_primary_term")]
		public bool? SeqNoPrimaryTerm { get; set; }

		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Global.Search.Sort? Sort { get; set; }

		[JsonPropertyName("_source")]
		public Union<bool, Elastic.Clients.Elasticsearch.Global.Search.SourceFilter>? Source { get; set; }

		[JsonPropertyName("stored_field")]
		public Elastic.Clients.Elasticsearch.Fields? StoredField { get; set; }

		[JsonPropertyName("track_scores")]
		public bool? TrackScores { get; set; }

		[JsonPropertyName("version")]
		public bool? Version { get; set; }
	}

	public partial class InnerHitsMetadata
	{
		[JsonPropertyName("hits")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.Hit<Dictionary<string, object>>> Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public Union<Elastic.Clients.Elasticsearch.Global.Search.TotalHits, long> Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InnerHitsResult
	{
		[JsonPropertyName("hits")]
		public Elastic.Clients.Elasticsearch.Global.Search.InnerHitsMetadata Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class LaplaceSmoothingModel
	{
		[JsonPropertyName("alpha")]
		public double Alpha { get; set; }
	}

	public partial class LinearInterpolationSmoothingModel
	{
		[JsonPropertyName("bigram_lambda")]
		public double BigramLambda { get; set; }

		[JsonPropertyName("trigram_lambda")]
		public double TrigramLambda { get; set; }

		[JsonPropertyName("unigram_lambda")]
		public double UnigramLambda { get; set; }
	}

	public partial class NestedIdentity
	{
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_nested")]
		public Elastic.Clients.Elasticsearch.Global.Search.NestedIdentity? Nested
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("offset")]
		public int Offset
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PhraseSuggestCollate
	{
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonPropertyName("prune")]
		public bool? Prune { get; set; }

		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.Global.Search.PhraseSuggestCollateQuery Query { get; set; }
	}

	public partial class PhraseSuggestCollateQuery
	{
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

		[JsonPropertyName("source")]
		public string? Source { get; set; }
	}

	public partial class PhraseSuggestHighlight
	{
		[JsonPropertyName("post_tag")]
		public string PostTag { get; set; }

		[JsonPropertyName("pre_tag")]
		public string PreTag { get; set; }
	}

	public partial class PhraseSuggestOption
	{
		[JsonPropertyName("highlighted")]
		public string Highlighted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PhraseSuggester : Global.Search.SuggesterBase
	{
		[JsonPropertyName("collate")]
		public Elastic.Clients.Elasticsearch.Global.Search.PhraseSuggestCollate? Collate { get; set; }

		[JsonPropertyName("confidence")]
		public double? Confidence { get; set; }

		[JsonPropertyName("direct_generator")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Global.Search.DirectGenerator>? DirectGenerator { get; set; }

		[JsonPropertyName("force_unigrams")]
		public bool? ForceUnigrams { get; set; }

		[JsonPropertyName("gram_size")]
		public int? GramSize { get; set; }

		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Global.Search.PhraseSuggestHighlight? Highlight { get; set; }

		[JsonPropertyName("max_errors")]
		public double? MaxErrors { get; set; }

		[JsonPropertyName("real_word_error_likelihood")]
		public double? RealWordErrorLikelihood { get; set; }

		[JsonPropertyName("separator")]
		public string? Separator { get; set; }

		[JsonPropertyName("shard_size")]
		public int? ShardSize { get; set; }

		[JsonPropertyName("smoothing")]
		public Elastic.Clients.Elasticsearch.Global.Search.SmoothingModelContainer? Smoothing { get; set; }

		[JsonPropertyName("text")]
		public string? Text { get; set; }

		[JsonPropertyName("token_limit")]
		public int? TokenLimit { get; set; }
	}

	public partial class PointInTimeReference
	{
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; set; }

		[JsonPropertyName("keep_alive")]
		public Elastic.Clients.Elasticsearch.Time? KeepAlive { get; set; }
	}

	public partial class Profile
	{
		[JsonPropertyName("shards")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.ShardProfile> Shards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class QueryBreakdown
	{
		[JsonPropertyName("advance")]
		public long Advance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("advance_count")]
		public long AdvanceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_scorer")]
		public long BuildScorer
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("build_scorer_count")]
		public long BuildScorerCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("compute_max_score")]
		public long ComputeMaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("compute_max_score_count")]
		public long ComputeMaxScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("create_weight")]
		public long CreateWeight
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("create_weight_count")]
		public long CreateWeightCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("match")]
		public long Match
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("match_count")]
		public long MatchCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("next_doc")]
		public long NextDoc
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("next_doc_count")]
		public long NextDocCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("score")]
		public long Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("score_count")]
		public long ScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("set_min_competitive_score")]
		public long SetMinCompetitiveScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("set_min_competitive_score_count")]
		public long SetMinCompetitiveScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shallow_advance")]
		public long ShallowAdvance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shallow_advance_count")]
		public long ShallowAdvanceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class QueryProfile
	{
		[JsonPropertyName("breakdown")]
		public Elastic.Clients.Elasticsearch.Global.Search.QueryBreakdown Breakdown
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.QueryProfile>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Rescore
	{
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.Global.Search.RescoreQuery Query { get; set; }

		[JsonPropertyName("window_size")]
		public int? WindowSize { get; set; }
	}

	public partial class RescoreQuery
	{
		[JsonPropertyName("rescore_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonPropertyName("query_weight")]
		public double? QueryWeight { get; set; }

		[JsonPropertyName("rescore_query_weight")]
		public double? RescoreQueryWeight { get; set; }

		[JsonPropertyName("score_mode")]
		public Elastic.Clients.Elasticsearch.Global.Search.ScoreMode? ScoreMode { get; set; }
	}

	public partial class ScoreSort
	{
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortMode? Mode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ScriptSort
	{
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Global.Search.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SearchProfile
	{
		[JsonPropertyName("collector")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.Collector> Collector
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("query")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.QueryProfile> Query
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rewrite_time")]
		public long RewriteTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardProfile
	{
		[JsonPropertyName("aggregations")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.AggregationProfile> Aggregations
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("searches")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.SearchProfile> Searches
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SmoothingModelContainer
	{
		[JsonPropertyName("laplace")]
		public Elastic.Clients.Elasticsearch.Global.Search.LaplaceSmoothingModel? Laplace { get; set; }

		[JsonPropertyName("linear_interpolation")]
		public Elastic.Clients.Elasticsearch.Global.Search.LinearInterpolationSmoothingModel? LinearInterpolation { get; set; }

		[JsonPropertyName("stupid_backoff")]
		public Elastic.Clients.Elasticsearch.Global.Search.StupidBackoffSmoothingModel? StupidBackoff { get; set; }
	}

	public partial class SortContainer
	{
		[JsonPropertyName("_doc")]
		public Elastic.Clients.Elasticsearch.Global.Search.ScoreSort? Doc
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_geo_distance")]
		public Elastic.Clients.Elasticsearch.Global.Search.GeoDistanceSort? GeoDistance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_score")]
		public Elastic.Clients.Elasticsearch.Global.Search.ScoreSort? Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_script")]
		public Elastic.Clients.Elasticsearch.Global.Search.ScriptSort? Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SourceFilter
	{
		[JsonPropertyName("exclude")]
		public Elastic.Clients.Elasticsearch.Fields? Exclude { get; set; }

		[JsonPropertyName("excludes")]
		public Elastic.Clients.Elasticsearch.Fields? Excludes { get; set; }

		[JsonPropertyName("include")]
		public Elastic.Clients.Elasticsearch.Fields? Include { get; set; }

		[JsonPropertyName("includes")]
		public Elastic.Clients.Elasticsearch.Fields? Includes { get; set; }
	}

	public partial class StupidBackoffSmoothingModel
	{
		[JsonPropertyName("discount")]
		public double Discount { get; set; }
	}

	public partial class Suggest<T>
	{
		[JsonPropertyName("length")]
		public int Length
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("offset")]
		public int Offset
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("options")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Global.Search.SuggestOption<T>> Options
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SuggestContainer
	{
		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.Global.Search.CompletionSuggester? Completion { get; set; }

		[JsonPropertyName("phrase")]
		public Elastic.Clients.Elasticsearch.Global.Search.PhraseSuggester? Phrase { get; set; }

		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonPropertyName("regex")]
		public string? Regex { get; set; }

		[JsonPropertyName("term")]
		public Elastic.Clients.Elasticsearch.Global.Search.TermSuggester? Term { get; set; }

		[JsonPropertyName("text")]
		public string? Text { get; set; }
	}

	public partial class SuggestContextQuery
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("context")]
		public Elastic.Clients.Elasticsearch.Global.Search.Context Context { get; set; }

		[JsonPropertyName("neighbours")]
		public Union<IEnumerable<Elastic.Clients.Elasticsearch.Distance>, IEnumerable<int>>? Neighbours { get; set; }

		[JsonPropertyName("precision")]
		public Union<Elastic.Clients.Elasticsearch.Distance, int>? Precision { get; set; }

		[JsonPropertyName("prefix")]
		public bool? Prefix { get; set; }
	}

	public partial class SuggestFuzziness
	{
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness Fuzziness { get; set; }

		[JsonPropertyName("min_length")]
		public int MinLength { get; set; }

		[JsonPropertyName("prefix_length")]
		public int PrefixLength { get; set; }

		[JsonPropertyName("transpositions")]
		public bool Transpositions { get; set; }

		[JsonPropertyName("unicode_aware")]
		public bool UnicodeAware { get; set; }
	}

	public partial class SuggesterBase
	{
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonPropertyName("size")]
		public int? Size { get; set; }
	}

	public partial class TermSuggestOption
	{
		[JsonPropertyName("freq")]
		public long? Freq
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TermSuggester : Global.Search.SuggesterBase
	{
		[JsonPropertyName("lowercase_terms")]
		public bool? LowercaseTerms { get; set; }

		[JsonPropertyName("max_edits")]
		public int? MaxEdits { get; set; }

		[JsonPropertyName("max_inspections")]
		public int? MaxInspections { get; set; }

		[JsonPropertyName("max_term_freq")]
		public float? MaxTermFreq { get; set; }

		[JsonPropertyName("min_doc_freq")]
		public float? MinDocFreq { get; set; }

		[JsonPropertyName("min_word_length")]
		public int? MinWordLength { get; set; }

		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonPropertyName("shard_size")]
		public int? ShardSize { get; set; }

		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Global.Search.SuggestSort? Sort { get; set; }

		[JsonPropertyName("string_distance")]
		public Elastic.Clients.Elasticsearch.Global.Search.StringDistance? StringDistance { get; set; }

		[JsonPropertyName("suggest_mode")]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get; set; }

		[JsonPropertyName("text")]
		public string? Text { get; set; }
	}

	public partial class TotalHits
	{
		[JsonPropertyName("relation")]
		public Elastic.Clients.Elasticsearch.Global.Search.TotalHitsRelation Relation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("value")]
		public long Value
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}