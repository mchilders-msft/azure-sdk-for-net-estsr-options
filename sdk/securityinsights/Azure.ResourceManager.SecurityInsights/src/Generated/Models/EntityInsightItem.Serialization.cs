// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityInsightItem
    {
        internal static EntityInsightItem DeserializeEntityInsightItem(JsonElement element)
        {
            Optional<string> queryId = default;
            Optional<EntityInsightItemQueryTimeInterval> queryTimeInterval = default;
            Optional<InsightsTableResult> tableQueryResults = default;
            Optional<IReadOnlyList<InsightsTableResult>> chartQueryResults = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryId"))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryTimeInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTimeInterval = EntityInsightItemQueryTimeInterval.DeserializeEntityInsightItemQueryTimeInterval(property.Value);
                    continue;
                }
                if (property.NameEquals("tableQueryResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tableQueryResults = InsightsTableResult.DeserializeInsightsTableResult(property.Value);
                    continue;
                }
                if (property.NameEquals("chartQueryResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InsightsTableResult> array = new List<InsightsTableResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InsightsTableResult.DeserializeInsightsTableResult(item));
                    }
                    chartQueryResults = array;
                    continue;
                }
            }
            return new EntityInsightItem(queryId.Value, queryTimeInterval.Value, tableQueryResults.Value, Optional.ToList(chartQueryResults));
        }
    }
}
