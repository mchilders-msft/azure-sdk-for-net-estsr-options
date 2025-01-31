// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsConnectorStatsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OrgsCount))
            {
                writer.WritePropertyName("orgsCount");
                writer.WriteNumberValue(OrgsCount.Value);
            }
            if (Optional.IsDefined(ProjectsCount))
            {
                writer.WritePropertyName("projectsCount");
                writer.WriteNumberValue(ProjectsCount.Value);
            }
            if (Optional.IsDefined(ReposCount))
            {
                writer.WritePropertyName("reposCount");
                writer.WriteNumberValue(ReposCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureDevOpsConnectorStatsProperties DeserializeAzureDevOpsConnectorStatsProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<long> orgsCount = default;
            Optional<long> projectsCount = default;
            Optional<long> reposCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orgsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    orgsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    projectsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reposCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reposCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new AzureDevOpsConnectorStatsProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(orgsCount), Optional.ToNullable(projectsCount), Optional.ToNullable(reposCount));
        }
    }
}
