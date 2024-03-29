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
    public partial class MeteringRequestDTO : IEquatable<MeteringRequestDTO>
    { 
        /// <summary>
        /// Gets or Sets Api
        /// </summary>

        [DataMember(Name="api", EmitDefaultValue = false)]
        public string Api { get; set; }

        /// <summary>
        /// The Product Key ID
        /// </summary>
        /// <value>The Product Key ID</value>

        [DataMember(Name="productKey", EmitDefaultValue = false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The Application ID
        /// </summary>
        /// <value>The Application ID</value>

        [DataMember(Name="application", EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// The HTTP method being invoked
        /// </summary>
        /// <value>The HTTP method being invoked</value>
        [Required]

        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// The HTTP URL being invoked
        /// </summary>
        /// <value>The HTTP URL being invoked</value>

        [DataMember(Name="url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Additional billing metadata (supports numeric values and comma-seperated key-value pairs)
        /// </summary>
        /// <value>Additional billing metadata (supports numeric values and comma-seperated key-value pairs)</value>

        [DataMember(Name="metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Backend API response time
        /// </summary>
        /// <value>Backend API response time</value>

        [DataMember(Name="backendLatency", EmitDefaultValue = false)]
        public double? BackendLatency { get; set; }

        /// <summary>
        /// Latency introduced by the API GW
        /// </summary>
        /// <value>Latency introduced by the API GW</value>

        [DataMember(Name="gatewayLatency", EmitDefaultValue = false)]
        public double? GatewayLatency { get; set; }

        /// <summary>
        /// Backend HTTP response code
        /// </summary>
        /// <value>Backend HTTP response code</value>
        [Required]

        [DataMember(Name="responseCode")]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Whether or not the backend timed out
        /// </summary>
        /// <value>Whether or not the backend timed out</value>

        [DataMember(Name="timedOut", EmitDefaultValue = false)]
        public bool? TimedOut { get; set; }

        /// <summary>
        /// The size of the API request in bytes
        /// </summary>
        /// <value>The size of the API request in bytes</value>

        [DataMember(Name="requestMessageSize", EmitDefaultValue = false)]
        public long? RequestMessageSize { get; set; }

        /// <summary>
        /// The size of the API response in bytes
        /// </summary>
        /// <value>The size of the API response in bytes</value>

        [DataMember(Name="responseMessageSize", EmitDefaultValue = false)]
        public long? ResponseMessageSize { get; set; }

        /// <summary>
        /// The comma seperated list of names of the headers in the request
        /// </summary>
        /// <value>The comma seperated list of names of the headers in the request</value>
        [Required]

        [DataMember(Name="requestHeaders")]
        public List<string> RequestHeaders { get; set; }

        /// <summary>
        /// The comma seperated list of names of the headers in the response
        /// </summary>
        /// <value>The comma seperated list of names of the headers in the response</value>
        [Required]

        [DataMember(Name="responseHeaders")]
        public List<string> ResponseHeaders { get; set; }

        /// <summary>
        /// The HTTP User Agent
        /// </summary>
        /// <value>The HTTP User Agent</value>

        [DataMember(Name="userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// The Remote User
        /// </summary>
        /// <value>The Remote User</value>

        [DataMember(Name="remoteUser", EmitDefaultValue = false)]
        public string RemoteUser { get; set; }

        /// <summary>
        /// The Remote Host
        /// </summary>
        /// <value>The Remote Host</value>

        [DataMember(Name="remoteHost", EmitDefaultValue = false)]
        public string RemoteHost { get; set; }

        /// <summary>
        /// The HTTP Protocol
        /// </summary>
        /// <value>The HTTP Protocol</value>

        [DataMember(Name="httpProtocol", EmitDefaultValue = false)]
        public string HttpProtocol { get; set; }

        /// <summary>
        /// The Content Type
        /// </summary>
        /// <value>The Content Type</value>

        [DataMember(Name="contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The Correlation ID
        /// </summary>
        /// <value>The Correlation ID</value>

        [DataMember(Name="correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// platformAPIKey
        /// </summary>
        /// <value>platformAPIKey</value>
        [Required]

        [DataMember(Name="platformAPIKey")]
        public string PlatformAPIKey { get; set; }

        /// <summary>
        /// Dynamic metering elements
        /// </summary>
        /// <value>Dynamic metering elements</value>
        [Required]

        [DataMember(Name="elements", EmitDefaultValue = false)]
        public List<ElementDTO> Elements { get; set; }

        /// <summary>
        /// the source of the event
        /// </summary>
        /// <value>the source of the event</value>

        [DataMember(Name="source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("MeteringRequestDTO:{\n");
            sb.Append("Api:").Append(Api).Append("\n");
            sb.Append("  ProductKey: ").Append(ProductKey).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  BackendLatency: ").Append(BackendLatency).Append("\n");
            sb.Append("  GatewayLatency: ").Append(GatewayLatency).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  TimedOut: ").Append(TimedOut).Append("\n");
            sb.Append("  RequestMessageSize: ").Append(RequestMessageSize).Append("\n");
            sb.Append("  ResponseMessageSize: ").Append(ResponseMessageSize).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  RemoteUser: ").Append(RemoteUser).Append("\n");
            sb.Append("  RemoteHost: ").Append(RemoteHost).Append("\n");
            sb.Append("  HttpProtocol: ").Append(HttpProtocol).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  PlatformAPIKey: ").Append(PlatformAPIKey).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MeteringRequestDTO)obj);
        }

        /// <summary>
        /// Returns true if MeteringRequestDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of MeteringRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeteringRequestDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Api == other.Api ||
                    Api != null &&
                    Api.Equals(other.Api)
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
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
                ) && 
                (
                    BackendLatency == other.BackendLatency ||
                    BackendLatency != null &&
                    BackendLatency.Equals(other.BackendLatency)
                ) && 
                (
                    GatewayLatency == other.GatewayLatency ||
                    GatewayLatency != null &&
                    GatewayLatency.Equals(other.GatewayLatency)
                ) && 
                (
                    ResponseCode == other.ResponseCode ||
                    ResponseCode != null &&
                    ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    TimedOut == other.TimedOut ||
                    TimedOut != null &&
                    TimedOut.Equals(other.TimedOut)
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
                    RequestHeaders == other.RequestHeaders ||
                    RequestHeaders != null &&
                    RequestHeaders.SequenceEqual(other.RequestHeaders)
                ) && 
                (
                    ResponseHeaders == other.ResponseHeaders ||
                    ResponseHeaders != null &&
                    ResponseHeaders.SequenceEqual(other.ResponseHeaders)
                ) && 
                (
                    UserAgent == other.UserAgent ||
                    UserAgent != null &&
                    UserAgent.Equals(other.UserAgent)
                ) && 
                (
                    RemoteUser == other.RemoteUser ||
                    RemoteUser != null &&
                    RemoteUser.Equals(other.RemoteUser)
                ) && 
                (
                    RemoteHost == other.RemoteHost ||
                    RemoteHost != null &&
                    RemoteHost.Equals(other.RemoteHost)
                ) && 
                (
                    HttpProtocol == other.HttpProtocol ||
                    HttpProtocol != null &&
                    HttpProtocol.Equals(other.HttpProtocol)
                ) && 
                (
                    ContentType == other.ContentType ||
                    ContentType != null &&
                    ContentType.Equals(other.ContentType)
                ) && 
                (
                    CorrelationId == other.CorrelationId ||
                    CorrelationId != null &&
                    CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    PlatformAPIKey == other.PlatformAPIKey ||
                    PlatformAPIKey != null &&
                    PlatformAPIKey.Equals(other.PlatformAPIKey)
                ) && 
                (
                    Elements == other.Elements ||
                    Elements != null &&
                    Elements.SequenceEqual(other.Elements)
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
                    if (Api != null)
                    hashCode = hashCode * 59 + Api.GetHashCode();
                    if (ProductKey != null)
                    hashCode = hashCode * 59 + ProductKey.GetHashCode();
                    if (Application != null)
                    hashCode = hashCode * 59 + Application.GetHashCode();
                    if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                    if (BackendLatency != null)
                    hashCode = hashCode * 59 + BackendLatency.GetHashCode();
                    if (GatewayLatency != null)
                    hashCode = hashCode * 59 + GatewayLatency.GetHashCode();
                    if (ResponseCode != null)
                    hashCode = hashCode * 59 + ResponseCode.GetHashCode();
                    if (TimedOut != null)
                    hashCode = hashCode * 59 + TimedOut.GetHashCode();
                    if (RequestMessageSize != null)
                    hashCode = hashCode * 59 + RequestMessageSize.GetHashCode();
                    if (ResponseMessageSize != null)
                    hashCode = hashCode * 59 + ResponseMessageSize.GetHashCode();
                    if (RequestHeaders != null)
                    hashCode = hashCode * 59 + RequestHeaders.GetHashCode();
                    if (ResponseHeaders != null)
                    hashCode = hashCode * 59 + ResponseHeaders.GetHashCode();
                    if (UserAgent != null)
                    hashCode = hashCode * 59 + UserAgent.GetHashCode();
                    if (RemoteUser != null)
                    hashCode = hashCode * 59 + RemoteUser.GetHashCode();
                    if (RemoteHost != null)
                    hashCode = hashCode * 59 + RemoteHost.GetHashCode();
                    if (HttpProtocol != null)
                    hashCode = hashCode * 59 + HttpProtocol.GetHashCode();
                    if (ContentType != null)
                    hashCode = hashCode * 59 + ContentType.GetHashCode();
                    if (CorrelationId != null)
                    hashCode = hashCode * 59 + CorrelationId.GetHashCode();
                    if (PlatformAPIKey != null)
                    hashCode = hashCode * 59 + PlatformAPIKey.GetHashCode();
                    if (Elements != null)
                    hashCode = hashCode * 59 + Elements.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MeteringRequestDTO left, MeteringRequestDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MeteringRequestDTO left, MeteringRequestDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
