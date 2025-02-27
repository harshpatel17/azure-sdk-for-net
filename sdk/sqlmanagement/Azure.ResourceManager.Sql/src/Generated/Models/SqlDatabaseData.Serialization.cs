// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlDatabaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes"u8);
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(SampleName))
            {
                writer.WritePropertyName("sampleName"u8);
                writer.WriteStringValue(SampleName.Value.ToString());
            }
            if (Optional.IsDefined(ElasticPoolId))
            {
                writer.WritePropertyName("elasticPoolId"u8);
                writer.WriteStringValue(ElasticPoolId);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId"u8);
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(SourceDatabaseDeletedOn))
            {
                writer.WritePropertyName("sourceDatabaseDeletionDate"u8);
                writer.WriteStringValue(SourceDatabaseDeletedOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryServicesRecoveryPointId))
            {
                writer.WritePropertyName("recoveryServicesRecoveryPointId"u8);
                writer.WriteStringValue(RecoveryServicesRecoveryPointId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId"u8);
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId"u8);
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId"u8);
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation"u8);
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(ReadScale))
            {
                writer.WritePropertyName("readScale"u8);
                writer.WriteStringValue(ReadScale.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailabilityReplicaCount))
            {
                writer.WritePropertyName("highAvailabilityReplicaCount"u8);
                writer.WriteNumberValue(HighAvailabilityReplicaCount.Value);
            }
            if (Optional.IsDefined(SecondaryType))
            {
                writer.WritePropertyName("secondaryType"u8);
                writer.WriteStringValue(SecondaryType.Value.ToString());
            }
            if (Optional.IsDefined(AutoPauseDelay))
            {
                writer.WritePropertyName("autoPauseDelay"u8);
                writer.WriteNumberValue(AutoPauseDelay.Value);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(IsLedgerOn))
            {
                writer.WritePropertyName("isLedgerOn"u8);
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            if (Optional.IsDefined(FederatedClientId))
            {
                writer.WritePropertyName("federatedClientId"u8);
                writer.WriteStringValue(FederatedClientId.Value);
            }
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartObject();
                foreach (var item in Keys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EncryptionProtector))
            {
                writer.WritePropertyName("encryptionProtector"u8);
                writer.WriteStringValue(EncryptionProtector);
            }
            if (Optional.IsDefined(PreferredEnclaveType))
            {
                writer.WritePropertyName("preferredEnclaveType"u8);
                writer.WriteStringValue(PreferredEnclaveType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ManualCutover))
            {
                writer.WritePropertyName("manualCutover"u8);
                writer.WriteBooleanValue(ManualCutover.Value);
            }
            if (Optional.IsDefined(PerformCutover))
            {
                writer.WritePropertyName("performCutover"u8);
                writer.WriteBooleanValue(PerformCutover.Value);
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlDatabaseData DeserializeSqlDatabaseData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlSku> sku = default;
            Optional<string> kind = default;
            Optional<string> managedBy = default;
            Optional<DatabaseIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SqlDatabaseCreateMode> createMode = default;
            Optional<string> collation = default;
            Optional<long> maxSizeBytes = default;
            Optional<SampleSchemaName> sampleName = default;
            Optional<ResourceIdentifier> elasticPoolId = default;
            Optional<ResourceIdentifier> sourceDatabaseId = default;
            Optional<SqlDatabaseStatus> status = default;
            Optional<Guid> databaseId = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<string> currentServiceObjectiveName = default;
            Optional<string> requestedServiceObjectiveName = default;
            Optional<AzureLocation> defaultSecondaryLocation = default;
            Optional<ResourceIdentifier> failoverGroupId = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<DateTimeOffset> sourceDatabaseDeletionDate = default;
            Optional<ResourceIdentifier> recoveryServicesRecoveryPointId = default;
            Optional<ResourceIdentifier> longTermRetentionBackupResourceId = default;
            Optional<ResourceIdentifier> recoverableDatabaseId = default;
            Optional<ResourceIdentifier> restorableDroppedDatabaseId = default;
            Optional<CatalogCollationType> catalogCollation = default;
            Optional<bool> zoneRedundant = default;
            Optional<DatabaseLicenseType> licenseType = default;
            Optional<long> maxLogSizeBytes = default;
            Optional<DateTimeOffset> earliestRestoreDate = default;
            Optional<DatabaseReadScale> readScale = default;
            Optional<int> highAvailabilityReplicaCount = default;
            Optional<SecondaryType> secondaryType = default;
            Optional<SqlSku> currentSku = default;
            Optional<int> autoPauseDelay = default;
            Optional<SqlBackupStorageRedundancy> currentBackupStorageRedundancy = default;
            Optional<SqlBackupStorageRedundancy> requestedBackupStorageRedundancy = default;
            Optional<double> minCapacity = default;
            Optional<DateTimeOffset> pausedDate = default;
            Optional<DateTimeOffset> resumedDate = default;
            Optional<ResourceIdentifier> maintenanceConfigurationId = default;
            Optional<bool> isLedgerOn = default;
            Optional<bool> isInfraEncryptionEnabled = default;
            Optional<Guid> federatedClientId = default;
            Optional<IDictionary<string, SqlDatabaseKey>> keys = default;
            Optional<string> encryptionProtector = default;
            Optional<SqlAlwaysEncryptedEnclaveType> preferredEnclaveType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<bool> manualCutover = default;
            Optional<bool> performCutover = default;
            Optional<SqlAvailabilityZoneType> availabilityZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = DatabaseIdentity.DeserializeDatabaseIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new SqlDatabaseCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("collation"u8))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSizeBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sampleName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sampleName = new SampleSchemaName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elasticPoolId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SqlDatabaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("currentServiceObjectiveName"u8))
                        {
                            currentServiceObjectiveName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedServiceObjectiveName"u8))
                        {
                            requestedServiceObjectiveName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSecondaryLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultSecondaryLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("failoverGroupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverGroupId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseDeletionDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDatabaseDeletionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recoveryServicesRecoveryPointId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoveryServicesRecoveryPointId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("longTermRetentionBackupResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            longTermRetentionBackupResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverableDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorableDroppedDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorableDroppedDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("catalogCollation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            catalogCollation = new CatalogCollationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new DatabaseLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxLogSizeBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxLogSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("readScale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readScale = new DatabaseReadScale(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("highAvailabilityReplicaCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailabilityReplicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("secondaryType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryType = new SecondaryType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("currentSku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentSku = SqlSku.DeserializeSqlSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoPauseDelay"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoPauseDelay = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestedBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minCapacity = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("pausedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pausedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resumedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resumedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceConfigurationId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isLedgerOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLedgerOn = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isInfraEncryptionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isInfraEncryptionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("federatedClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            federatedClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("keys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, SqlDatabaseKey> dictionary = new Dictionary<string, SqlDatabaseKey>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, SqlDatabaseKey.DeserializeSqlDatabaseKey(property1.Value));
                            }
                            keys = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("encryptionProtector"u8))
                        {
                            encryptionProtector = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("preferredEnclaveType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredEnclaveType = new SqlAlwaysEncryptedEnclaveType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("manualCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            manualCutover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("performCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            performCutover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityZone = new SqlAvailabilityZoneType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlDatabaseData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, kind.Value, managedBy.Value, identity.Value, Optional.ToNullable(createMode), collation.Value, Optional.ToNullable(maxSizeBytes), Optional.ToNullable(sampleName), elasticPoolId.Value, sourceDatabaseId.Value, Optional.ToNullable(status), Optional.ToNullable(databaseId), Optional.ToNullable(creationDate), currentServiceObjectiveName.Value, requestedServiceObjectiveName.Value, Optional.ToNullable(defaultSecondaryLocation), failoverGroupId.Value, Optional.ToNullable(restorePointInTime), Optional.ToNullable(sourceDatabaseDeletionDate), recoveryServicesRecoveryPointId.Value, longTermRetentionBackupResourceId.Value, recoverableDatabaseId.Value, restorableDroppedDatabaseId.Value, Optional.ToNullable(catalogCollation), Optional.ToNullable(zoneRedundant), Optional.ToNullable(licenseType), Optional.ToNullable(maxLogSizeBytes), Optional.ToNullable(earliestRestoreDate), Optional.ToNullable(readScale), Optional.ToNullable(highAvailabilityReplicaCount), Optional.ToNullable(secondaryType), currentSku.Value, Optional.ToNullable(autoPauseDelay), Optional.ToNullable(currentBackupStorageRedundancy), Optional.ToNullable(requestedBackupStorageRedundancy), Optional.ToNullable(minCapacity), Optional.ToNullable(pausedDate), Optional.ToNullable(resumedDate), maintenanceConfigurationId.Value, Optional.ToNullable(isLedgerOn), Optional.ToNullable(isInfraEncryptionEnabled), Optional.ToNullable(federatedClientId), Optional.ToDictionary(keys), encryptionProtector.Value, Optional.ToNullable(preferredEnclaveType), sourceResourceId.Value, Optional.ToNullable(manualCutover), Optional.ToNullable(performCutover), Optional.ToNullable(availabilityZone));
        }
    }
}
