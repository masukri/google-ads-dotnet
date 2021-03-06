// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/geo_target_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/geo_target_constant.proto</summary>
  public static partial class GeoTargetConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/geo_target_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeoTargetConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvZ2VvX3Rhcmdl",
            "dF9jb25zdGFudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVz",
            "b3VyY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9nZW9fdGFy",
            "Z2V0X2NvbnN0YW50X3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoeZ29v",
            "Z2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90",
            "YXRpb25zLnByb3RvIq0EChFHZW9UYXJnZXRDb25zdGFudBJJCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjLgQQP6QSwKKmdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9HZW9UYXJnZXRDb25zdGFudBIsCgJpZBgDIAEoCzIbLmdvb2dsZS5wcm90",
            "b2J1Zi5JbnQ2NFZhbHVlQgPgQQMSLwoEbmFtZRgEIAEoCzIcLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEjcKDGNvdW50cnlfY29kZRgFIAEo",
            "CzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEjYKC3Rhcmdl",
            "dF90eXBlGAYgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPg",
            "QQMSZwoGc3RhdHVzGAcgASgOMlIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "ZW51bXMuR2VvVGFyZ2V0Q29uc3RhbnRTdGF0dXNFbnVtLkdlb1RhcmdldENv",
            "bnN0YW50U3RhdHVzQgPgQQMSOQoOY2Fub25pY2FsX25hbWUYCCABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAzpZ6kFWCipnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vR2VvVGFyZ2V0Q29uc3RhbnQSKGdlb1Rhcmdl",
            "dENvbnN0YW50cy97Z2VvX3RhcmdldF9jb25zdGFudH1CgwIKJWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNvdXJjZXNCFkdlb1RhcmdldENvbnN0",
            "YW50UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291cmNlcztyZXNvdXJjZXOiAgNH",
            "QUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5SZXNvdXJjZXPKAiFHb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMlxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.GeoTargetConstant), global::Google.Ads.GoogleAds.V2.Resources.GeoTargetConstant.Parser, new[]{ "ResourceName", "Id", "Name", "CountryCode", "TargetType", "Status", "CanonicalName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A geo target constant.
  /// </summary>
  public sealed partial class GeoTargetConstant : pb::IMessage<GeoTargetConstant> {
    private static readonly pb::MessageParser<GeoTargetConstant> _parser = new pb::MessageParser<GeoTargetConstant>(() => new GeoTargetConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GeoTargetConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.GeoTargetConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstant(GeoTargetConstant other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      CountryCode = other.CountryCode;
      TargetType = other.TargetType;
      status_ = other.status_;
      CanonicalName = other.CanonicalName;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstant Clone() {
      return new GeoTargetConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the geo target constant.
    /// Geo target constant resource names have the form:
    ///
    /// `geoTargetConstants/{geo_target_constant_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the geo target constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// Output only. Geo target constant English name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_countryCode_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string countryCode_;
    /// <summary>
    /// Output only. The ISO-3166-1 alpha-2 country code that is associated with the target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = value;
      }
    }


    /// <summary>Field number for the "target_type" field.</summary>
    public const int TargetTypeFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_targetType_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string targetType_;
    /// <summary>
    /// Output only. Geo target constant target type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetType {
      get { return targetType_; }
      set {
        targetType_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus status_ = global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Unspecified;
    /// <summary>
    /// Output only. Geo target constant status.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "canonical_name" field.</summary>
    public const int CanonicalNameFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _single_canonicalName_codec = pb::FieldCodec.ForClassWrapper<string>(66);
    private string canonicalName_;
    /// <summary>
    /// Output only. The fully qualified English name, consisting of the target's name and that
    /// of its parent and country.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CanonicalName {
      get { return canonicalName_; }
      set {
        canonicalName_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GeoTargetConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GeoTargetConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (CountryCode != other.CountryCode) return false;
      if (TargetType != other.TargetType) return false;
      if (Status != other.Status) return false;
      if (CanonicalName != other.CanonicalName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (countryCode_ != null) hash ^= CountryCode.GetHashCode();
      if (targetType_ != null) hash ^= TargetType.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Unspecified) hash ^= Status.GetHashCode();
      if (canonicalName_ != null) hash ^= CanonicalName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (countryCode_ != null) {
        _single_countryCode_codec.WriteTagAndValue(output, CountryCode);
      }
      if (targetType_ != null) {
        _single_targetType_codec.WriteTagAndValue(output, TargetType);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Status);
      }
      if (canonicalName_ != null) {
        _single_canonicalName_codec.WriteTagAndValue(output, CanonicalName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (countryCode_ != null) {
        size += _single_countryCode_codec.CalculateSizeWithTag(CountryCode);
      }
      if (targetType_ != null) {
        size += _single_targetType_codec.CalculateSizeWithTag(TargetType);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (canonicalName_ != null) {
        size += _single_canonicalName_codec.CalculateSizeWithTag(CanonicalName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GeoTargetConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.countryCode_ != null) {
        if (countryCode_ == null || other.CountryCode != "") {
          CountryCode = other.CountryCode;
        }
      }
      if (other.targetType_ != null) {
        if (targetType_ == null || other.TargetType != "") {
          TargetType = other.TargetType;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.canonicalName_ != null) {
        if (canonicalName_ == null || other.CanonicalName != "") {
          CanonicalName = other.CanonicalName;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 42: {
            string value = _single_countryCode_codec.Read(input);
            if (countryCode_ == null || value != "") {
              CountryCode = value;
            }
            break;
          }
          case 50: {
            string value = _single_targetType_codec.Read(input);
            if (targetType_ == null || value != "") {
              TargetType = value;
            }
            break;
          }
          case 56: {
            Status = (global::Google.Ads.GoogleAds.V2.Enums.GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus) input.ReadEnum();
            break;
          }
          case 66: {
            string value = _single_canonicalName_codec.Read(input);
            if (canonicalName_ == null || value != "") {
              CanonicalName = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
