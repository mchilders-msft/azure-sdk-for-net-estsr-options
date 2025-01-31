// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesPropertiesHciStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MocGroup))
            {
                writer.WritePropertyName("mocGroup");
                writer.WriteStringValue(MocGroup);
            }
            if (Optional.IsDefined(MocLocation))
            {
                writer.WritePropertyName("mocLocation");
                writer.WriteStringValue(MocLocation);
            }
            if (Optional.IsDefined(MocStorageContainer))
            {
                writer.WritePropertyName("mocStorageContainer");
                writer.WriteStringValue(MocStorageContainer);
            }
            writer.WriteEndObject();
        }

        internal static StorageSpacesPropertiesHciStorageProfile DeserializeStorageSpacesPropertiesHciStorageProfile(JsonElement element)
        {
            Optional<string> mocGroup = default;
            Optional<string> mocLocation = default;
            Optional<string> mocStorageContainer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mocGroup"))
                {
                    mocGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocLocation"))
                {
                    mocLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocStorageContainer"))
                {
                    mocStorageContainer = property.Value.GetString();
                    continue;
                }
            }
            return new StorageSpacesPropertiesHciStorageProfile(mocGroup.Value, mocLocation.Value, mocStorageContainer.Value);
        }
    }
}
