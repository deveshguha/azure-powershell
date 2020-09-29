namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.PowerShell;

    /// <summary>Defines the move resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(MoveResourceTypeConverter))]
    public partial class MoveResource
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MoveResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MoveResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MoveResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MoveResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettings) content.GetValueForProperty("ResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ResourceSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesSourceResourceSettings) content.GetValueForProperty("SourceResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesSourceResourceSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOn = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency[]) content.GetValueForProperty("DependsOn",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependencyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOnOverride = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride[]) content.GetValueForProperty("DependsOnOverride",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOnOverride, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependencyOverrideTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ExistingTargetId = (string) content.GetValueForProperty("ExistingTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ExistingTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesErrors) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesErrorsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).TargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingResourceType = (string) content.GetValueForProperty("ResourceSettingResourceType",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IJobStatus) content.GetValueForProperty("MoveStatusJobStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.JobStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMoveState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState?) content.GetValueForProperty("MoveStatusMoveState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMoveState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesMoveStatus) content.GetValueForProperty("MoveStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesMoveStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingTargetResourceName = (string) content.GetValueForProperty("ResourceSettingTargetResourceName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingTargetResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingResourceType = (string) content.GetValueForProperty("SourceResourceSettingResourceType",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingTargetResourceName = (string) content.GetValueForProperty("SourceResourceSettingTargetResourceName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingTargetResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusError = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceError) content.GetValueForProperty("MoveStatusError",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusError, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobName = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName?) content.GetValueForProperty("MoveStatusJobName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobName, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobProgress = (string) content.GetValueForProperty("MoveStatusJobProgress",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobProgress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTargetId = (string) content.GetValueForProperty("MoveStatusTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody) content.GetValueForProperty("MoveStatusErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorTarget = (string) content.GetValueForProperty("ErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody[]) content.GetValueForProperty("MoveStatusDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMessage = (string) content.GetValueForProperty("MoveStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusCode = (string) content.GetValueForProperty("MoveStatusCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTarget = (string) content.GetValueForProperty("MoveStatusTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTarget, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MoveResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IResourceSettings) content.GetValueForProperty("ResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.ResourceSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesSourceResourceSettings) content.GetValueForProperty("SourceResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesSourceResourceSettingsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOn = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency[]) content.GetValueForProperty("DependsOn",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependency>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependencyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOnOverride = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride[]) content.GetValueForProperty("DependsOnOverride",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).DependsOnOverride, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceDependencyOverride>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceDependencyOverrideTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ExistingTargetId = (string) content.GetValueForProperty("ExistingTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ExistingTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesErrors) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesErrorsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).TargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingResourceType = (string) content.GetValueForProperty("ResourceSettingResourceType",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IJobStatus) content.GetValueForProperty("MoveStatusJobStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.JobStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMoveState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState?) content.GetValueForProperty("MoveStatusMoveState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMoveState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourcePropertiesMoveStatus) content.GetValueForProperty("MoveStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourcePropertiesMoveStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingTargetResourceName = (string) content.GetValueForProperty("ResourceSettingTargetResourceName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ResourceSettingTargetResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingResourceType = (string) content.GetValueForProperty("SourceResourceSettingResourceType",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody) content.GetValueForProperty("ErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingTargetResourceName = (string) content.GetValueForProperty("SourceResourceSettingTargetResourceName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).SourceResourceSettingTargetResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusError = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceError) content.GetValueForProperty("MoveStatusError",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusError, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobName = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName?) content.GetValueForProperty("MoveStatusJobName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobName, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobProgress = (string) content.GetValueForProperty("MoveStatusJobProgress",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusJobProgress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTargetId = (string) content.GetValueForProperty("MoveStatusTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTargetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody[]) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusErrorProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody) content.GetValueForProperty("MoveStatusErrorProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusErrorProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorCode = (string) content.GetValueForProperty("ErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorTarget = (string) content.GetValueForProperty("ErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorTarget, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).ErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody[]) content.GetValueForProperty("MoveStatusDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMessage = (string) content.GetValueForProperty("MoveStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusCode = (string) content.GetValueForProperty("MoveStatusCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTarget = (string) content.GetValueForProperty("MoveStatusTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20191001Preview.IMoveResourceInternal)this).MoveStatusTarget, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Defines the move resource.
    [System.ComponentModel.TypeConverter(typeof(MoveResourceTypeConverter))]
    public partial interface IMoveResource

    {

    }
}