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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Sql
{
	public class SqlNamespace : NamespacedClientProxy
	{
		internal SqlNamespace(ElasticClient client) : base(client)
		{
		}

		public ClearCursorResponse ClearCursor(IClearCursorRequest request) => DoRequest<IClearCursorRequest, ClearCursorResponse>(request, request.RequestParameters);
		public Task<ClearCursorResponse> ClearCursorAsync(IClearCursorRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IClearCursorRequest, ClearCursorResponse>(request, request.RequestParameters, cancellationToken);
		public ClearCursorResponse ClearCursor(Func<ClearCursorDescriptor, IClearCursorRequest> selector = null) => ClearCursor(selector.InvokeOrDefault(new ClearCursorDescriptor()));
		public Task<ClearCursorResponse> ClearCursorAsync(Func<ClearCursorDescriptor, IClearCursorRequest> selector = null, CancellationToken cancellationToken = default) => ClearCursorAsync(selector.InvokeOrDefault(new ClearCursorDescriptor()), cancellationToken);
		public QueryResponse Query(IQueryRequest request) => DoRequest<IQueryRequest, QueryResponse>(request, request.RequestParameters);
		public Task<QueryResponse> QueryAsync(IQueryRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IQueryRequest, QueryResponse>(request, request.RequestParameters, cancellationToken);
		public QueryResponse Query(Func<QueryDescriptor, IQueryRequest> selector = null) => Query(selector.InvokeOrDefault(new QueryDescriptor()));
		public Task<QueryResponse> QueryAsync(Func<QueryDescriptor, IQueryRequest> selector = null, CancellationToken cancellationToken = default) => QueryAsync(selector.InvokeOrDefault(new QueryDescriptor()), cancellationToken);
		public TranslateResponse Translate(ITranslateRequest request) => DoRequest<ITranslateRequest, TranslateResponse>(request, request.RequestParameters);
		public Task<TranslateResponse> TranslateAsync(ITranslateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<ITranslateRequest, TranslateResponse>(request, request.RequestParameters, cancellationToken);
		public TranslateResponse Translate(Func<TranslateDescriptor, ITranslateRequest> selector = null) => Translate(selector.InvokeOrDefault(new TranslateDescriptor()));
		public Task<TranslateResponse> TranslateAsync(Func<TranslateDescriptor, ITranslateRequest> selector = null, CancellationToken cancellationToken = default) => TranslateAsync(selector.InvokeOrDefault(new TranslateDescriptor()), cancellationToken);
	}
}