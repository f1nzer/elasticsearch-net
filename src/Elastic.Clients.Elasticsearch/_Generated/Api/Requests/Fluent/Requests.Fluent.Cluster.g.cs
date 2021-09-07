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

using Elastic.Transport;
using System.Collections.Generic;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class AllocationExplainDescriptor : RequestDescriptorBase<AllocationExplainDescriptor, AllocationExplainRequestParameters, IAllocationExplainRequest>, IAllocationExplainRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/allocation/explain</summary>
        public AllocationExplainDescriptor() : base()
		{
		}

		string? IAllocationExplainRequest.CurrentNode { get; set; }

		Elastic.Clients.Elasticsearch.IndexName? IAllocationExplainRequest.Index { get; set; }

		bool? IAllocationExplainRequest.Primary { get; set; }

		int? IAllocationExplainRequest.Shard { get; set; }

		public AllocationExplainDescriptor IncludeDiskInfo(bool? includeDiskInfo = true) => Qs("include_disk_info", includeDiskInfo);
		public AllocationExplainDescriptor IncludeYesDecisions(bool? includeYesDecisions = true) => Qs("include_yes_decisions", includeYesDecisions);
		public AllocationExplainDescriptor CurrentNode(string? currentNode) => Assign(currentNode, (a, v) => a.CurrentNode = v);
		public AllocationExplainDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index) => Assign(index, (a, v) => a.Index = v);
		public AllocationExplainDescriptor Primary(bool? primary = true) => Assign(primary, (a, v) => a.Primary = v);
		public AllocationExplainDescriptor Shard(int? shard) => Assign(shard, (a, v) => a.Shard = v);
	}

	public partial class DeleteComponentTemplateDescriptor : RequestDescriptorBase<DeleteComponentTemplateDescriptor, DeleteComponentTemplateRequestParameters, IDeleteComponentTemplateRequest>, IDeleteComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_component_template/{name}</summary>
        public DeleteComponentTemplateDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public DeleteComponentTemplateDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public DeleteComponentTemplateDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	public partial class DeleteVotingConfigExclusionsDescriptor : RequestDescriptorBase<DeleteVotingConfigExclusionsDescriptor, DeleteVotingConfigExclusionsRequestParameters, IDeleteVotingConfigExclusionsRequest>, IDeleteVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/voting_config_exclusions</summary>
        public DeleteVotingConfigExclusionsDescriptor() : base()
		{
		}

		public DeleteVotingConfigExclusionsDescriptor WaitForRemoval(bool? waitForRemoval = true) => Qs("wait_for_removal", waitForRemoval);
	}

	public partial class ExistsComponentTemplateDescriptor : RequestDescriptorBase<ExistsComponentTemplateDescriptor, ExistsComponentTemplateRequestParameters, IExistsComponentTemplateRequest>, IExistsComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterExistsComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/_component_template/{name}</summary>
        public ExistsComponentTemplateDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		public ExistsComponentTemplateDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ExistsComponentTemplateDescriptor Local(bool? local = true) => Qs("local", local);
	}

	public partial class GetComponentTemplateDescriptor : RequestDescriptorBase<GetComponentTemplateDescriptor, GetComponentTemplateRequestParameters, IGetComponentTemplateRequest>, IGetComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_component_template</summary>
        public GetComponentTemplateDescriptor() : base()
		{
		}

		///<summary>/_component_template/{name}</summary>
        public GetComponentTemplateDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
		{
		}

		public GetComponentTemplateDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public GetComponentTemplateDescriptor Local(bool? local = true) => Qs("local", local);
		public GetComponentTemplateDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
	}

	public partial class GetSettingsDescriptor : RequestDescriptorBase<GetSettingsDescriptor, GetSettingsRequestParameters, IGetSettingsRequest>, IGetSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/settings</summary>
        public GetSettingsDescriptor() : base()
		{
		}

		public GetSettingsDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public GetSettingsDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
		public GetSettingsDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public GetSettingsDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	public partial class HealthDescriptor : RequestDescriptorBase<HealthDescriptor, HealthRequestParameters, IHealthRequest>, IHealthRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/health</summary>
        public HealthDescriptor() : base()
		{
		}

		///<summary>/_cluster/health/{index}</summary>
        public HealthDescriptor(Elastic.Clients.Elasticsearch.Indices? index) : base(r => r.Optional("index", index))
		{
		}

		public HealthDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public HealthDescriptor Level(Elastic.Clients.Elasticsearch.Level? level) => Qs("level", level);
		public HealthDescriptor Local(bool? local = true) => Qs("local", local);
		public HealthDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public HealthDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public HealthDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public HealthDescriptor WaitForEvents(Elastic.Clients.Elasticsearch.WaitForEvents? waitForEvents) => Qs("wait_for_events", waitForEvents);
		public HealthDescriptor WaitForNodes(string? waitForNodes) => Qs("wait_for_nodes", waitForNodes);
		public HealthDescriptor WaitForNoInitializingShards(bool? waitForNoInitializingShards = true) => Qs("wait_for_no_initializing_shards", waitForNoInitializingShards);
		public HealthDescriptor WaitForNoRelocatingShards(bool? waitForNoRelocatingShards = true) => Qs("wait_for_no_relocating_shards", waitForNoRelocatingShards);
		public HealthDescriptor WaitForStatus(Elastic.Clients.Elasticsearch.WaitForStatus? waitForStatus) => Qs("wait_for_status", waitForStatus);
	}

	public partial class PendingTasksDescriptor : RequestDescriptorBase<PendingTasksDescriptor, PendingTasksRequestParameters, IPendingTasksRequest>, IPendingTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/pending_tasks</summary>
        public PendingTasksDescriptor() : base()
		{
		}

		public PendingTasksDescriptor Local(bool? local = true) => Qs("local", local);
		public PendingTasksDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
	}

	public partial class PostVotingConfigExclusionsDescriptor : RequestDescriptorBase<PostVotingConfigExclusionsDescriptor, PostVotingConfigExclusionsRequestParameters, IPostVotingConfigExclusionsRequest>, IPostVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/voting_config_exclusions</summary>
        public PostVotingConfigExclusionsDescriptor() : base()
		{
		}

		public PostVotingConfigExclusionsDescriptor NodeNames(Elastic.Clients.Elasticsearch.Names? nodeNames) => Qs("node_names", nodeNames);
		public PostVotingConfigExclusionsDescriptor NodeIds(Elastic.Clients.Elasticsearch.Ids? nodeIds) => Qs("node_ids", nodeIds);
		public PostVotingConfigExclusionsDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	public partial class PutComponentTemplateDescriptor : RequestDescriptorBase<PutComponentTemplateDescriptor, PutComponentTemplateRequestParameters, IPutComponentTemplateRequest>, IPutComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_component_template/{name}</summary>
        public PutComponentTemplateDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		Elastic.Clients.Elasticsearch.IndexManagement.IndexState IPutComponentTemplateRequest.Template { get; set; }

		Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? IPutComponentTemplateRequest.Aliases { get; set; }

		Elastic.Clients.Elasticsearch.Mapping.TypeMapping? IPutComponentTemplateRequest.Mappings { get; set; }

		Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? IPutComponentTemplateRequest.Settings { get; set; }

		Elastic.Clients.Elasticsearch.VersionNumber? IPutComponentTemplateRequest.Version { get; set; }

		Elastic.Clients.Elasticsearch.Metadata? IPutComponentTemplateRequest.Meta { get; set; }

		public PutComponentTemplateDescriptor Create(bool? create = true) => Qs("create", create);
		public PutComponentTemplateDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public PutComponentTemplateDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexState template) => Assign(template, (a, v) => a.Template = v);
		public PutComponentTemplateDescriptor Aliases(Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? aliases) => Assign(aliases, (a, v) => a.Aliases = v);
		public PutComponentTemplateDescriptor Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings) => Assign(mappings, (a, v) => a.Mappings = v);
		public PutComponentTemplateDescriptor Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings) => Assign(settings, (a, v) => a.Settings = v);
		public PutComponentTemplateDescriptor Version(Elastic.Clients.Elasticsearch.VersionNumber? version) => Assign(version, (a, v) => a.Version = v);
		public PutComponentTemplateDescriptor Meta(Elastic.Clients.Elasticsearch.Metadata? meta) => Assign(meta, (a, v) => a.Meta = v);
	}

	public partial class PutSettingsDescriptor : RequestDescriptorBase<PutSettingsDescriptor, PutSettingsRequestParameters, IPutSettingsRequest>, IPutSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/settings</summary>
        public PutSettingsDescriptor() : base()
		{
		}

		Dictionary<string, object>? IPutSettingsRequest.Persistent { get; set; }

		Dictionary<string, object>? IPutSettingsRequest.Transient { get; set; }

		public PutSettingsDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public PutSettingsDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public PutSettingsDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public PutSettingsDescriptor Persistent(Dictionary<string, object>? persistent) => Assign(persistent, (a, v) => a.Persistent = v);
		public PutSettingsDescriptor Transient(Dictionary<string, object>? transient) => Assign(transient, (a, v) => a.Transient = v);
	}

	public partial class RemoteInfoDescriptor : RequestDescriptorBase<RemoteInfoDescriptor, RemoteInfoRequestParameters, IRemoteInfoRequest>, IRemoteInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_remote/info</summary>
        public RemoteInfoDescriptor() : base()
		{
		}
	}

	public partial class RerouteDescriptor : RequestDescriptorBase<RerouteDescriptor, RerouteRequestParameters, IRerouteRequest>, IRerouteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/reroute</summary>
        public RerouteDescriptor() : base()
		{
		}

		IEnumerable<Elastic.Clients.Elasticsearch.Cluster.Reroute.Command>? IRerouteRequest.Commands { get; set; }

		public RerouteDescriptor DryRun(bool? dryRun = true) => Qs("dry_run", dryRun);
		public RerouteDescriptor Explain(bool? explain = true) => Qs("explain", explain);
		public RerouteDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric) => Qs("metric", metric);
		public RerouteDescriptor RetryFailed(bool? retryFailed = true) => Qs("retry_failed", retryFailed);
		public RerouteDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public RerouteDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public RerouteDescriptor Commands(IEnumerable<Elastic.Clients.Elasticsearch.Cluster.Reroute.Command>? commands) => Assign(commands, (a, v) => a.Commands = v);
	}

	public partial class StateDescriptor : RequestDescriptorBase<StateDescriptor, StateRequestParameters, IStateRequest>, IStateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/state</summary>
        public StateDescriptor() : base()
		{
		}

		///<summary>/_cluster/state/{metric}</summary>
        public StateDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_cluster/state/{metric}/{index}</summary>
        public StateDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? index) : base(r => r.Optional("metric", metric).Optional("index", index))
		{
		}

		public StateDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public StateDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public StateDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public StateDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public StateDescriptor Local(bool? local = true) => Qs("local", local);
		public StateDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public StateDescriptor WaitForMetadataVersion(Elastic.Clients.Elasticsearch.VersionNumber? waitForMetadataVersion) => Qs("wait_for_metadata_version", waitForMetadataVersion);
		public StateDescriptor WaitForTimeout(Elastic.Clients.Elasticsearch.Time? waitForTimeout) => Qs("wait_for_timeout", waitForTimeout);
	}

	public partial class StatsDescriptor : RequestDescriptorBase<StatsDescriptor, StatsRequestParameters, IStatsRequest>, IStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/stats</summary>
        public StatsDescriptor() : base()
		{
		}

		///<summary>/_cluster/stats/nodes/{node_id}</summary>
        public StatsDescriptor(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		public StatsDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public StatsDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}
}