// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Elastic.Transport.Products.Elasticsearch;

namespace Elastic.Clients.Elasticsearch;

public static class ElasticsearchResponseBaseExtensions
{
	public static bool IsSuccess(this ElasticsearchResponseBase response) => response.ApiCall is not null && response.ApiCall.Success;
}