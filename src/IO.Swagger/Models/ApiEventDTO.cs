/*
 * Revenium Metering API
 *
 * Revenium Metering API
 *
 * OpenAPI spec version: 1.14.0-SNAPSHOT
 * Contact: info@revenium.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Revenium.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApiEventDTO : IEquatable<ApiEventDTO>
    { 
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>

        [DataMember(Name="requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum REQUESTEnum for REQUEST
            /// </summary>
            [EnumMember(Value = "REQUEST")]
            REQUESTEnum = 0,
            /// <summary>
            /// Enum RESPONSEEnum for RESPONSE
            /// </summary>
            [EnumMember(Value = "RESPONSE")]
            RESPONSEEnum = 1        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>

        [DataMember(Name="eventType", EmitDefaultValue = false)]
        public EventTypeEnum? EventType { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>

        [DataMember(Name="assetId", EmitDefaultValue = false)]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets ProductKey
        /// </summary>

        [DataMember(Name="productKey", EmitDefaultValue = false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>

        [DataMember(Name="application", EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>

        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets CurrentMillis
        /// </summary>

        [DataMember(Name="currentMillis", EmitDefaultValue = false)]
        public long? CurrentMillis { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>

        [DataMember(Name="uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedTime
        /// </summary>

        [DataMember(Name="elapsedTime", EmitDefaultValue = false)]
        public long? ElapsedTime { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>

        [DataMember(Name="metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets ResponseCode
        /// </summary>
        [Required]

        [DataMember(Name="responseCode")]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets RequestMessageSize
        /// </summary>

        [DataMember(Name="requestMessageSize", EmitDefaultValue = false)]
        public long? RequestMessageSize { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMessageSize
        /// </summary>

        [DataMember(Name="responseMessageSize", EmitDefaultValue = false)]
        public long? ResponseMessageSize { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>

        [DataMember(Name="contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets RemoteHost
        /// </summary>

        [DataMember(Name="remoteHost", EmitDefaultValue = false)]
        public string RemoteHost { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>

        [DataMember(Name="userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>

        [DataMember(Name="correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets BackendLatency
        /// </summary>

        [DataMember(Name="backendLatency", EmitDefaultValue = false)]
        public double? BackendLatency { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>

        [DataMember(Name="clientId", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>

        [DataMember(Name="source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiEventDTO {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  ProductKey: ").Append(ProductKey).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  CurrentMillis: ").Append(CurrentMillis).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  RequestMessageSize: ").Append(RequestMessageSize).Append("\n");
            sb.Append("  ResponseMessageSize: ").Append(ResponseMessageSize).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  RemoteHost: ").Append(RemoteHost).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  BackendLatency: ").Append(BackendLatency).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ApiEventDTO)obj);
        }

        /// <summary>
        /// Returns true if ApiEventDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiEventDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiEventDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) && 
                (
                    EventType == other.EventType ||
                    EventType != null &&
                    EventType.Equals(other.EventType)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    ProductKey == other.ProductKey ||
                    ProductKey != null &&
                    ProductKey.Equals(other.ProductKey)
                ) && 
                (
                    Application == other.Application ||
                    Application != null &&
                    Application.Equals(other.Application)
                ) && 
                (
                    Method == other.Method ||
                    Method != null &&
                    Method.Equals(other.Method)
                ) && 
                (
                    CurrentMillis == other.CurrentMillis ||
                    CurrentMillis != null &&
                    CurrentMillis.Equals(other.CurrentMillis)
                ) && 
                (
                    Uri == other.Uri ||
                    Uri != null &&
                    Uri.Equals(other.Uri)
                ) && 
                (
                    ElapsedTime == other.ElapsedTime ||
                    ElapsedTime != null &&
                    ElapsedTime.Equals(other.ElapsedTime)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
                ) && 
                (
                    ResponseCode == other.ResponseCode ||
                    ResponseCode != null &&
                    ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    RequestMessageSize == other.RequestMessageSize ||
                    RequestMessageSize != null &&
                    RequestMessageSize.Equals(other.RequestMessageSize)
                ) && 
                (
                    ResponseMessageSize == other.ResponseMessageSize ||
                    ResponseMessageSize != null &&
                    ResponseMessageSize.Equals(other.ResponseMessageSize)
                ) && 
                (
                    ContentType == other.ContentType ||
                    ContentType != null &&
                    ContentType.Equals(other.ContentType)
                ) && 
                (
                    RemoteHost == other.RemoteHost ||
                    RemoteHost != null &&
                    RemoteHost.Equals(other.RemoteHost)
                ) && 
                (
                    UserAgent == other.UserAgent ||
                    UserAgent != null &&
                    UserAgent.Equals(other.UserAgent)
                ) && 
                (
                    CorrelationId == other.CorrelationId ||
                    CorrelationId != null &&
                    CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    BackendLatency == other.BackendLatency ||
                    BackendLatency != null &&
                    BackendLatency.Equals(other.BackendLatency)
                ) && 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                    if (EventType != null)
                    hashCode = hashCode * 59 + EventType.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (ProductKey != null)
                    hashCode = hashCode * 59 + ProductKey.GetHashCode();
                    if (Application != null)
                    hashCode = hashCode * 59 + Application.GetHashCode();
                    if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                    if (CurrentMillis != null)
                    hashCode = hashCode * 59 + CurrentMillis.GetHashCode();
                    if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                    if (ElapsedTime != null)
                    hashCode = hashCode * 59 + ElapsedTime.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                    if (ResponseCode != null)
                    hashCode = hashCode * 59 + ResponseCode.GetHashCode();
                    if (RequestMessageSize != null)
                    hashCode = hashCode * 59 + RequestMessageSize.GetHashCode();
                    if (ResponseMessageSize != null)
                    hashCode = hashCode * 59 + ResponseMessageSize.GetHashCode();
                    if (ContentType != null)
                    hashCode = hashCode * 59 + ContentType.GetHashCode();
                    if (RemoteHost != null)
                    hashCode = hashCode * 59 + RemoteHost.GetHashCode();
                    if (UserAgent != null)
                    hashCode = hashCode * 59 + UserAgent.GetHashCode();
                    if (CorrelationId != null)
                    hashCode = hashCode * 59 + CorrelationId.GetHashCode();
                    if (BackendLatency != null)
                    hashCode = hashCode * 59 + BackendLatency.GetHashCode();
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApiEventDTO left, ApiEventDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApiEventDTO left, ApiEventDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
